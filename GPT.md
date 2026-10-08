# TestFlow Project Handoff

This file preserves the project context so a future AI mentor can continue one step at a time. Update it when a meaningful project decision or milestone changes.

## Mentoring approach

- Guide the developer step by step and explain the purpose of commands before asking them to run anything.
- Give one focused action at a time, then wait for its result before moving on.
- Prefer clear, beginner-friendly explanations without assuming prior Git or software-development experience.
- Do not invent product requirements, technology choices, or repository state. Ask when a decision is genuinely needed.
- Never ask the developer to share passwords, access tokens, or other secrets. Redact credentials from any output they share.

## Project status

- Project/repository name: `TestFlow`.
- The local Git repository was reported to be on branch `main`.
- A GitHub remote named `origin` was added. An initial placeholder URL using `yourname` was corrected to the actual repository URL, and the developer reported that `git remote -v` then looked correct.
- No push result has been provided yet. Do not assume the first push succeeded.
- The workspace currently contains `TestFlow.sln`; application requirements, architecture, and implementation have not yet been discussed here.

## Next step: first push

Continue from the last confirmed point in the conversation. Ask the developer to run this command from the `TestFlow` repository directory:

```powershell
git push -u origin main
```

Explain that it publishes the local `main` branch to GitHub and configures it to track `origin/main`. Ask them to paste the terminal output, but remind them to remove any credentials or sensitive information. Do not ask them to push again until the result is understood.

After a successful push, have them verify that the solution files appear in the GitHub `TestFlow` repository. Then begin project discovery: ask what the application should do and who will use it before proposing an implementation or technology stack.

## Continuity notes

When resuming, check this file and the repository's current state rather than treating old notes as live facts. Record confirmed outcomes and decisions here; keep secrets and personal or sensitive data out of this document.