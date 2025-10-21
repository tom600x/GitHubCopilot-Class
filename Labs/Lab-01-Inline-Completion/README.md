# Lab 1: Inline Completion Mastery

**Duration**: 20 minutes  
**Focus**: Master GitHub Copilot's inline code completion features  
**Outcome**: Build a complete task management feature using only inline suggestions

## Learning Objectives

By the end of this lab, you will:
- Master triggering and accepting Copilot inline suggestions
- Use comments to guide Copilot's code generation
- Experience Copilot's context awareness within existing projects
- Build a complete MVC feature with minimal typing

## Prerequisites

- [ ] Visual Studio Code or Visual Studio 2022 with GitHub Copilot enabled
- [ ] Open the provided CopilotDemo base project
- [ ] Basic understanding of ASP.NET Core MVC

## Step 1: Setup the Project

### 1.1 Open Base Project

1. **Open** the `BaseProject` folder in your IDE
2. **Restore packages** if prompted
3. **Build** the project to ensure everything works
4. **Run** the application to see the base homepage

### 1.2 Explore Existing Structure

Take 2 minutes to explore:
- `Controllers/HomeController.cs` - Basic controller
- `Models/ErrorViewModel.cs` - Simple model
- `Views/Home/Index.cshtml` - Homepage view
- `Program.cs` - Basic web app configuration

## Step 2: Create TaskItem Model with Inline Completion

### 2.1 Start with a Comment

1. **Navigate** to `Models` folder
2. **Create** new file: `TaskItem.cs`
3. **Type this comment** and wait for Copilot:

```csharp
// TaskItem model class for CopilotDemo.Models namespace with properties: int Id, string Title (required), string Description (optional), DateTime DueDate (optional), bool IsCompleted, DateTime CreatedDate
```

**🤖 Copilot Exercise 1**: Accept the suggestion and observe how Copilot builds the entire model.

### 2.2 Add Data Annotations

4. **Add this comment** above the properties:

```csharp
// Add Required, Display, and DataType validation attributes for proper form validation and display names
```

**🤖 Copilot Exercise 2**: Let Copilot suggest data annotations for form validation.

### 2.3 Expected Result

Your model should look similar to:

```csharp
using System.ComponentModel.DataAnnotations;

namespace CopilotDemo.Models
{
    // Model for a simple task item with id, title, description, due date, and completion status
    public class TaskItem
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Task Title")]
        public string Title { get; set; } = string.Empty;
        
        [Display(Name = "Description")]
        public string? Description { get; set; }
        
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }
        
        [Display(Name = "Completed")]
        public bool IsCompleted { get; set; }
        
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
```

## Step 3: Create TaskItemController with Inline Magic

### 3.1 Controller Generation

1. **Create** new file: `Controllers/TaskItemController.cs`
2. **Type this comment** and let Copilot build the entire controller:

```csharp
// TaskItemController with full CRUD operations for managing task items including Index, Details, Create, Edit, Delete actions with proper HTTP verbs and view returns
using Microsoft.AspNetCore.Mvc;
using CopilotDemo.Models;

namespace CopilotDemo.Controllers
{
    public class TaskItemController : Controller
    {
```

**🤖 Copilot Exercise 3**: Let Copilot generate the entire controller structure. Accept suggestions piece by piece.

### 3.2 Add In-Memory Data Store

3. **Add this comment** inside the controller class:

```csharp
// Static List<TaskItem> to store task items in memory with sample data for demo purposes
```

**🤖 Copilot Exercise 4**: Let Copilot suggest the static list and sample data.

### 3.3 Implement Actions One by One

4. **For each action, start with a comment**:

```csharp
// GET: TaskItem/Index - Display all task items
```

```csharp
// GET: TaskItem/Details/5 - Show details of a specific task item
```

```csharp
// GET: TaskItem/Create - Show create task item form
```

```csharp
// POST: TaskItem/Create - Handle task item creation with model validation
```

```csharp
// GET: TaskItem/Edit/5 - Show edit task item form
```

```csharp
// POST: TaskItem/Edit/5 - Handle task item update with model validation
```

```csharp
// GET: TaskItem/Delete/5 - Show delete confirmation
```

```csharp
// POST: TaskItem/Delete/5 - Handle task item deletion
```

**🤖 Copilot Exercise 5**: For each comment, let Copilot suggest the complete action method.

## Step 4: Generate Views with Inline Assistance

### 4.1 Create Views Folder

1. **Create** `Views/TaskItem` folder
2. **For each view, start with an HTML comment**

### 4.2 Index View

**Create** `Views/TaskItem/Index.cshtml`:

```html
@* Bootstrap table view displaying all task items with columns for Title, Description, Due Date, Status, and action links for Details/Edit/Delete *@
@model List<CopilotDemo.Models.TaskItem>

@{
    ViewData["Title"] = "Task Items";
}
```

**🤖 Copilot Exercise 6**: Let Copilot generate the complete table layout.

### 4.3 Create View

**Create** `Views/TaskItem/Create.cshtml`:

```html
@* Bootstrap form for creating a new task item with proper form controls, validation summary, and submit/cancel buttons *@
@model CopilotDemo.Models.TaskItem

@{
    ViewData["Title"] = "Create Task Item";
}
```

**🤖 Copilot Exercise 7**: Let Copilot generate the form with proper tag helpers.

### 4.4 Edit View

**Create** `Views/TaskItem/Edit.cshtml`:

```html
@* Bootstrap edit form for updating an existing task item with hidden ID field, form controls, validation, and submit/cancel buttons *@
@model CopilotDemo.Models.TaskItem

@{
    ViewData["Title"] = "Edit Task Item";
}
```

**🤖 Copilot Exercise 8**: Let Copilot suggest the edit form with hidden ID field and validation scripts section.

### 4.5 Delete View

**Create** `Views/TaskItem/Delete.cshtml`:

```html
@* Bootstrap delete confirmation view showing task item details and confirmation form with Delete/Cancel buttons *@
@model CopilotDemo.Models.TaskItem

@{
    ViewData["Title"] = "Delete Task Item";
}
```

**🤖 Copilot Exercise 9**: Let Copilot suggest the delete confirmation view with task details and confirmation form.

### 4.6 Understanding Validation Scripts

When Copilot generates your Create and Edit views, you may see a reference to `@section Scripts`. This is for client-side validation:

```html
@section Scripts {
    @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
}
```

**💡 Note**: The `_ValidationScriptsPartial.cshtml` file is already included in your base project to support form validation.

## Step 5: Add Navigation with Inline Help

### 5.1 Update Layout Navigation

1. **Open** `Views/Shared/_Layout.cshtml`
2. **Find** the navbar section with `<ul class="navbar-nav flex-grow-1">`
3. **Add this comment** before the closing `</ul>`:

```html
<!-- Add Bootstrap nav-item and nav-link for Task Items controller Index action -->
```

**🤖 Copilot Exercise 10**: Let Copilot suggest the navigation list item.

## Step 6: Test Your Copilot-Generated Feature

### 6.1 Build and Run

1. **Build** the project (Ctrl+Shift+B)
2. **Run** the application (F5)
3. **Navigate** to Task Items
4. **Test** creating, editing, and viewing task items

### 6.2 Observe Copilot's Intelligence

Notice how Copilot:
- Understood MVC patterns from existing code
- Generated consistent naming conventions
- Added proper validation and Bootstrap styling
- Created logical relationships between actions and views

## Step 7: Enhance with More Inline Features

### 7.1 Add Search Functionality

**Add this comment** in TaskItemController:

```csharp
// GET: TaskItem/Search - Action to search task items by title or description with string searchTerm parameter
```

**🤖 Copilot Exercise 11**: Let Copilot generate a search action.

### 7.2 Add Task Statistics

**Add this comment** in TaskItemController:

```csharp
// Private method to get task item completion statistics returning total count, completed count, and pending count
```

**🤖 Copilot Exercise 12**: Let Copilot create a statistics method.

## Copilot Learning Points

**During this lab, you experienced:**

✅ **Context Awareness**: Copilot understood existing project structure  
✅ **Pattern Recognition**: Generated consistent MVC patterns  
✅ **Code Completion**: Completed complex multi-line suggestions  
✅ **Comment-Driven Development**: Used comments to guide generation  
✅ **Framework Knowledge**: Applied ASP.NET Core best practices  

## Key Inline Completion Techniques:

1. **Descriptive Comments**: Use detailed comments to guide suggestions
2. **Method Signatures**: Start with return type and name for method generation
3. **Context Building**: Work within existing files for better suggestions
4. **Progressive Acceptance**: Accept suggestions piece by piece for control
5. **Pattern Following**: Copilot learns from existing code patterns

## Common Inline Shortcuts:

- **Tab**: Accept entire suggestion
- **Ctrl+→**: Accept next word
- **Esc**: Dismiss suggestion
- **Alt+]**: Next suggestion
- **Alt+[**: Previous suggestion

## What You've Built:

🎉 **Complete Task Management System** using only inline completion:
- ✅ Full CRUD operations (Create, Read, Update, Delete)
- ✅ Data validation with annotations
- ✅ Bootstrap-styled responsive views
- ✅ In-memory data storage
- ✅ Navigation integration
- ✅ Search and statistics features

**🎯 Key Takeaway**: You built a complete feature with minimal typing by mastering Copilot's inline completion suggestions!

---

**Great job! Ready for Lab 2 where you'll learn Chat mode?** 
➡️ [Continue to Lab 2: Chat Mode](../Lab-02-Chat-Mode/README.md)