# Quick Setup Guide

This guide helps instructors and students run the GitHub Copilot labs on Visual Studio 2026 with .NET 10.

## Prerequisites

- Visual Studio 2026 with GitHub Copilot and GitHub Copilot Chat
- .NET 10 SDK installed
- Git (optional)

## Instructor Setup

### 1. Verify Base Project

```powershell
cd BaseProject
dotnet restore CopilotDemo.csproj
dotnet build CopilotDemo.csproj
dotnet run --project CopilotDemo.csproj
```

Expected result:

- Application starts without build errors
- Browser opens to localhost
- Home page renders correctly

### 2. Student Environment Check

Confirm each student has:

- VS 2026 signed in to GitHub
- Copilot enabled in the IDE
- .NET 10 available (`dotnet --version` reports 10.x)

### 3. Lab Timing

- Lab 1: 15 minutes (Inline)
- Lab 2: 15 minutes (Chat Ask)
- Lab 3: 15 minutes (Agent)

## Student Setup (5 minutes)

1. Open this repository in Visual Studio 2026.
2. Open a terminal at repository root.
3. Run:

```powershell
cd BaseProject
dotnet restore
dotnet run
```

4. Start [Lab 1](./Labs/Lab-01-Inline-Completion/README.md).

## Copilot UI Notes (Current)

- Use Copilot Chat and switch modes with the mode selector.
- Mode mapping:
  - Ask: explanation, ideation, debugging guidance
  - Copilot Edits / next edit suggestions: focused code edits
  - Agent: multi-step tasks across files
- If a documented shortcut differs, use the command palette command name.

## Troubleshooting

Copilot is unavailable:

- Verify sign-in to GitHub in Visual Studio
- Verify Copilot subscription/access
- Reload IDE window

Build errors:

- Run `dotnet --info` and confirm .NET 10 SDK is installed
- Run `dotnet restore` from `BaseProject`
- Rebuild solution

Chat/Agent commands not visible:

- Ensure GitHub Copilot Chat component is installed/enabled
- Update Visual Studio to latest 2026 build

## Instructor Checklist

- Base app launches successfully
- Students can open Copilot Chat
- Students can switch Ask/Agent modes and locate Copilot Edits
- Students complete labs in sequence
