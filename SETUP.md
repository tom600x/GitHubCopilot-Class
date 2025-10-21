# Quick Setup Guide

This guide helps instructors and students get the GitHub Copilot Labs running quickly.

## Prerequisites

- **Visual Studio Code** with GitHub Copilot extension enabled
- **.NET 8.0 SDK** installed
- **Git** for version control (optional)

## Instructor Setup

### 1. Verify Base Project

Navigate to the BaseProject folder and ensure it runs:

```bash
cd BaseProject
dotnet restore copiotdemo.csproj
dotnet build copilotdemo.csprojdotne
dotnet run
```

You should see:
- Application starts without errors
- Browser opens to localhost:5000 or similar
- Home page displays with Bootstrap styling

### 2. Student Environment Check

Ensure each student has:
- [ ] VS Code with GitHub Copilot extension active
- [ ] .NET 8.0 SDK (`dotnet --version` shows 8.x)
- [ ] Copilot enabled (green checkmark in VS Code status bar)

### 3. Lab Timing Validation

Each lab should take exactly 20 minutes:
- **Lab 1**: 20 minutes for inline completion exercises
- **Lab 2**: 20 minutes for Chat mode interactions  
- **Lab 3**: 20 minutes for Agent mode coordination

Total: **60 minutes** of hands-on Copilot training

## Student Setup

### Quick Start (5 minutes)

1. **Open VS Code** in the Labs folder
2. **Navigate to BaseProject**:
   ```bash
   cd BaseProject
   dotnet restore
   ```
3. **Verify Copilot is active** (green checkmark in status bar)
4. **Start with Lab 1**: Open `Lab-01-Inline-Completion/README.md`

### Troubleshooting

**Copilot not working?**
- Check extension is enabled
- Sign in to GitHub account
- Restart VS Code if needed

**Build errors?**
- Verify .NET 8.0 SDK installed
- Run `dotnet restore` in BaseProject folder
- Check project file syntax

**Can't see suggestions?**
- Type some comments and wait
- Try `Ctrl+Space` to trigger manually
- Check Copilot settings in VS Code

## Lab Structure

### BaseProject Contents
```
BaseProject/
├── CopilotDemo.csproj      # Complete project file
├── Program.cs              # Basic MVC setup
├── Controllers/
│   └── HomeController.cs   # Home and Error actions
├── Models/
│   └── ErrorViewModel.cs   # Error handling model
├── Views/
│   ├── _ViewStart.cshtml   # Layout configuration
│   ├── _ViewImports.cshtml # Global using statements
│   ├── Shared/
│   │   ├── _Layout.cshtml  # Bootstrap layout
│   │   └── Error.cshtml    # Error page
│   └── Home/
│       ├── Index.cshtml    # Homepage
│       └── Privacy.cshtml  # Privacy page
└── wwwroot/               # Static files (CSS, JS)
```

### What Students Will Build

Starting from the base project, students will add:

**Lab 1 - Inline Completion:**
- TaskItem model class
- TaskItem controller with CRUD actions
- Basic task item views
- Navigation updates

**Lab 2 - Chat Mode:**
- TaskItem service layer
- JSON storage implementation
- Advanced task item features
- Form validation

**Lab 3 - Agent Mode:**
- Unit testing infrastructure
- Performance optimizations
- Security enhancements
- Documentation generation

## Success Indicators

Students have succeeded when they can:
- **Accept Copilot suggestions** confidently (Lab 1)
- **Converse with Chat mode** to solve problems (Lab 2)
- **Coordinate with Agent mode** for complex tasks (Lab 3)

Each lab builds complete functionality, so students see immediate progress and working features.

## Instructor Tips

### Timing Management
- Start each lab with 20-minute timer
- Give 2-minute warning before end
- Allow brief overrun for completion

### Student Support
- Encourage experimentation with suggestions
- Show how to accept/reject Copilot recommendations
- Demonstrate Chat mode conversation techniques

### Common Issues
- Students may rush through exercises - encourage exploration
- Some may resist Copilot suggestions - show benefits
- Technical issues: have backup plans ready

## Post-Lab Assessment

Students should demonstrate:
1. **Comfort with inline completion** (accepting/modifying suggestions)
2. **Effective Chat conversations** (asking good questions)
3. **Agent coordination skills** (breaking down complex tasks)

The complete task management application serves as evidence of their Copilot mastery progression.