# GitHub Copilot Labs - Complete Learning Series

This lab series teaches GitHub Copilot through hands-on exercises using a pre-built ASP.NET Core 8.0 MVC application. Students will master the three core modes of GitHub Copilot while building a practical task management system.

## 🎯 Lab Overview

| Lab | Focus | Duration | Key Skills |
|-----|-------|----------|------------|
| [Lab 1](./Lab-01-Inline-Completion/) | Inline Completion | 20 minutes | Auto-completion, suggestion acceptance, comment-driven development |
| [Lab 2](./Lab-02-Chat-Mode/) | Chat Mode | 20 minutes | Interactive problem-solving, architecture guidance, code generation |
| [Lab 3](./Lab-03-Agent-Mode/) | Agent Mode | 20 minutes | Multi-step coordination, code analysis, testing infrastructure |

**Total Time**: 60 minutes  
**Prerequisites**: Visual Studio Code with GitHub Copilot extension enabled

## 🚀 Quick Start

1. **Setup Base Project**:
   ```bash
   cd BaseProject
   dotnet restore
   dotnet run
   ```

2. **Complete Labs in Order**:
   - Start with Lab 1 for foundational skills
   - Progress to Lab 2 for interactive features
   - Finish with Lab 3 for advanced coordination

## 📋 What You'll Build

By the end of these labs, you'll have a complete task management application with:

- **TaskItem Model & Storage**: JSON-based persistence system
- **CRUD Operations**: Create, read, update, delete tasks
- **Service Layer**: Clean architecture with business logic separation
- **Testing Infrastructure**: Unit tests with xUnit framework
- **Performance Optimization**: Efficient data handling and caching
- **Security Features**: Input validation and secure practices

## 🛠 Technical Stack

- **Framework**: ASP.NET Core 8.0 MVC
- **UI**: Bootstrap 5 with responsive design
- **Testing**: xUnit testing framework
- **Storage**: JSON file-based persistence
- **GitHub Copilot**: All three modes (Inline, Chat, Agent)

## 💡 Learning Approach

Each lab focuses on **one primary Copilot mode** to ensure mastery:

### Lab 1: Inline Completion Mastery
- Learn to work WITH Copilot's suggestions
- Master comment-driven development
- Build confidence with auto-completion

### Lab 2: Chat Mode Proficiency  
- Interactive problem-solving conversations
## 🎓 Instructor Notes

- **Timing**: Each lab is designed for exactly 20 minutes
- **Pre-built Base**: Students start with working foundation, no setup time
- **Progressive Complexity**: Skills build from lab to lab
- **Practical Focus**: Real-world task management scenario
- **Copilot Emphasis**: 100% focus on Copilot features, not ASP.NET complexity

## 📁 Project Structure

```
GitHubCopilot-Class/Labs/
├── README.md                    # This overview
├── BaseProject/                 # Pre-built MVC foundation
│   ├── CopilotDemo.csproj      # Project file with dependencies
│   ├── Program.cs              # Application startup
│   ├── Controllers/            # MVC controllers
│   ├── Models/                 # Data models
│   ├── Views/                  # Razor views
│   └── wwwroot/               # Static files
├── Lab-01-Inline-Completion/   # 20-minute inline completion lab
├── Lab-02-Chat-Mode/          # 20-minute chat mode lab
└── Lab-03-Agent-Mode/         # 20-minute agent mode lab
```

## 🏆 Success Metrics

Students will demonstrate mastery by:
- **Lab 1**: Building models and controllers using inline completion
- **Lab 2**: Implementing services and features via Chat conversations
- **Lab 3**: Coordinating complex multi-step tasks with Agent mode

Each lab builds upon the previous, creating a comprehensive learning experience that transforms students from Copilot beginners to confident practitioners.

---

**Ready to start?** Begin with [Lab 1 - Inline Completion](./Lab-01-Inline-Completion/) to master the fundamentals!
3. Suggest improvements for learning experience
4. Share feedback on lab effectiveness

---

**Ready to start your GitHub Copilot journey?** 🚀

### 👨‍💻 **Choose Your Path:**

**🎯 New to Copilot?** → [Start with Veteran Benefits Labs](Veteran-Benefits-Labs/)

**🏗️ Enterprise Developer?** → [Jump to Database Labs](Database-Labs-README.md)

**🤔 Not sure?** → Read both guides and pick what fits your timeline and goals

*Both lab tracks teach the same core GitHub Copilot features but with different complexity levels and setup requirements. You can always do both for the complete experience!*