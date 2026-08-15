# AGENTS.md

## Project snapshot
- This repository is a small C# console app targeting .NET 10.
- The main logic lives in [Program.cs](Program.cs), with the project defined in [Stopwatch.csproj](Stopwatch.csproj).
- Keep changes focused and minimal; this project does not currently have a larger architecture or multiple modules.

## Working conventions
- Prefer simple, direct edits to the existing console flow rather than introducing new abstractions or frameworks.
- Validate the project with `dotnet build` from the workspace root before reporting completion.
- Use `dotnet run` only for a quick manual check of the user-facing timer behavior when needed.
- Preserve the app's current Portuguese messaging unless the user explicitly requests a wording or language change.
- Do not add dependencies, test projects, or new patterns unless the task clearly requires them.

## Inlay-focused guidance
- Treat this as a lightweight UI/console application: prefer concise, readable console output over elaborate formatting.
- If a change affects prompts, countdown output, or completion messages, keep the behavior consistent with the current style.
- Avoid broad refactors or unrelated cleanup when the user asks for a small inlay or console-display change.

## Safety guardrails
- Do not assume missing files or docs exist; this repo is intentionally small and self-contained.
- When editing the timer logic, keep the existing validation and user feedback flow intact unless the request specifically changes it.
- Favor surgical updates over structural rewrites.
