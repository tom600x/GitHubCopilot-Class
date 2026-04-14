# GitHub Copilot Labs - VS 2026 + .NET 10

This repository is a hands-on class for teaching GitHub Copilot using a pre-built ASP.NET Core MVC app on .NET 10.

## Lab Overview

| Lab | Focus | Duration | Key Skills |
|-----|-------|----------|------------|
| [Lab 1](./Labs/Lab-01-Inline-Completion/) | Inline Completion | 15 minutes | Fast code completion, suggestion control, comment-driven development |
| [Lab 2](./Labs/Lab-02-Chat-Mode/) | Chat (Ask) | 15 minutes | Interactive problem-solving, architecture guidance, targeted code changes |
| [Lab 3](./Labs/Lab-03-Agent-Mode/) | Agent Mode | 15 minutes | Multi-step planning, repo-wide changes, verification workflows |

Total class time: 45 minutes.

## MCP Servers (Install First)

Install these MCP servers before checking prerequisites:

- Microsoft Learn MCP Server (`microsoftdocs/mcp`)
- Playwright MCP
- Chrome DevTools MCP

### VS Code

1. Install/enable GitHub Copilot and GitHub Copilot Chat extensions.
2. Open MCP server management in VS Code.
3. Add and enable:
    - `microsoftdocs/mcp`
    - Playwright MCP
    - Chrome DevTools MCP
4. Restart VS Code if prompted.

### Visual Studio 2026

1. Make sure GitHub Copilot Completions and GitHub Copilot Chat are installed and enabled VS on versions prior to 17.9.  For Visual Studio 17.10 or higher, GitHub Copilot Chat is built-in to Visual Studio, it need not be installed as an extension. This extension Copilot Chat is only compatible with Visual Studio versions 17.8 - 17.9
2. Open the MCP server/tooling configuration area.
3. Add and enable:
    - `microsoftdocs/mcp`
    - Playwright MCP
    - Chrome DevTools MCP
4. Restart Visual Studio if prompted.

## Requirements

- Visual Studio 2026 with GitHub Copilot and GitHub Copilot Chat enabled
- .NET 10 SDK installed
- GitHub account with Copilot access

## Copilot Prompt: Prerequisite Setup

Use this prompt in Copilot Chat before starting labs:

```text
Validate my environment for this repo and auto-install missing prerequisites where possible.

Requirements:
- MCP servers installed:
    - Microsoft Learn MCP Server (`microsoftdocs/mcp`)
    - Playwright MCP
    - Chrome DevTools MCP
- Visual Studio 2026 with GitHub Copilot and Copilot Chat
- .NET 10 SDK
- GitHub sign-in with Copilot access

Please:
1. Confirm the three MCP servers are installed and enabled first.
2. Check what is already installed (dotnet version, VS version if detectable, and common tooling).
3. List exactly what is missing.
4. Automatically install anything safe and quick to install from terminal.
5. Do NOT attempt to install Visual Studio 2026 from terminal (too large/slow). Only verify whether it is present.
6. At minimum, auto-install .NET 10 SDK if missing.
7. After setup, run quick validation commands and confirm I am ready.

For .NET SDK installation on Windows, prefer winget. If winget is unavailable, provide the exact manual install link and continue validation after I install it.
```

## Quick Start

```powershell
cd BaseProject
dotnet restore
dotnet run
```

Then complete labs in order:

1. Lab 1 - Inline Completion
2. Lab 2 - Chat (Ask)
3. Lab 3 - Agent Mode

## Technical Stack

- Framework: ASP.NET Core MVC on .NET 10
- UI: Bootstrap 5
- Storage: JSON file persistence (introduced in labs)
- Testing: xUnit (introduced in labs)
- Copilot: Inline, Chat (Ask), Agent

## Copilot Guidance Validation (Current)

The instructions in this repo are aligned to current GitHub Copilot workflows:

- Chat and Agent are accessed from Copilot Chat with a mode selector.
- Ask mode is best for explanation and guidance.
- For focused code changes, use Copilot Edits or next edit suggestions.
- Agent mode is best for multi-file, multi-step tasks with planning and execution.
- Keyboard shortcuts can vary by IDE profile; command names in docs are authoritative.

## Project Structure

```text
GitHubCopilot-Class/
├── BaseProject/
│   ├── CopilotDemo.csproj
│   ├── Program.cs
│   ├── Controllers/
│   ├── Models/
│   ├── Views/
│   └── wwwroot/
└── Labs/
    ├── Lab-01-Inline-Completion/
    ├── Lab-02-Chat-Mode/
    └── Lab-03-Agent-Mode/
```

## Learning Outcomes

By the end of the labs, students should be able to:

- Use inline suggestions efficiently and safely
- Use Chat effectively for architecture and implementation guidance
- Use Agent mode to execute complex tasks with checkpoints
- Evaluate generated code for correctness, security, and maintainability

## Next Step

Start with [Lab 1 - Inline Completion](./Labs/Lab-01-Inline-Completion/README.md).
