# TestFlow Mentoring Journal

This is the learning-first project journal for TestFlow. Read it at the start of each mentoring session, then check the current repository state before deciding the next step. Add a dated entry after each session; keep the newest entry first.

## Mentoring principles

- Learning the technology is the priority; the application is a vehicle for practice, not a reason to over-engineer.
- Work in small steps. Explain the concept and purpose before each hands-on task, then review what happened before moving on.
- Prefer decisions that create useful practice in C#, .NET, Git, GitHub, SQL, REST APIs, and GitHub Actions.
- Do not mark work complete until it is confirmed by the developer or verified in the repository.
- Keep implementation and test data synthetic; never use real patient or personal information.
- For SQL exercises, prepare reusable synthetic seed data up front when practical so practice time focuses on schema design, queries, and application persistence rather than manual data entry.
- Playwright is intentionally out of scope for now because the planned user experience is a desktop application.
- Decide architecture and tools together when the learning milestone requires them; do not assume choices that have not been discussed.
- Mentor the developer; do not provide implementation code unless they ask for it. Prefer explaining concepts, giving a small task, and reviewing the developer's attempt.
- Present every learning stage using the nine-part structure below. Keep each stage small enough to complete and review before introducing the next one.
- Stop at the checkpoint and wait for the developer's implementation or answer before moving forward. Do not silently complete their assigned task for them.

## Required stage format

For every stage, cover these points in order:

1. **What we're building**: State the small feature, workflow, or learning outcome.
2. **Why we're building it**: Connect it to TestFlow and the developer's learning priorities.
3. **What concept you need to learn**: Explain the relevant idea in beginner-friendly terms.
4. **Small task for you**: Give one actionable task with a clear expected result; avoid dumping a full implementation.
5. **Hints if you get stuck**: Offer progressive clues that preserve the opportunity to solve it.
6. **Review of your implementation**: After the developer shares their work, review it for correctness, clarity, tests, and the concept being practiced.
7. **Improvement suggestions**: Suggest a small number of worthwhile next refinements without expanding scope unnecessarily.
8. **Git/GitHub task**: Include a related version-control task when appropriate, explaining the command or workflow before asking the developer to perform it.
9. **Checkpoint before moving forward**: Confirm what was learned and verified, identify anything unresolved, and wait for the developer before starting the next stage.

## Learning goals

- Build and test REST APIs with clear HTTP behavior.
- Practice SQL through schema design, queries, and application persistence.
- Understand GitHub Actions CI workflows that restore, build, and test the solution; approach deployment/CD after choosing a suitable target.
- Practice Git and GitHub workflows such as status, diff, commits, branches, push, pull, and pull requests.
- Become more comfortable using VS Code for navigation, editing, terminal work, debugging, and tests.
- Practice C# and .NET by incrementally building TestFlow.

## Agreed learning stack

- Editor: VS Code.
- Language and platform: C# and the .NET SDK. The existing solution currently targets .NET 9; revisit the target only when there is a learning or compatibility reason.
- Desktop UI: WPF with XAML, building on the developer's C# and WinAppDriver experience while practicing data binding, MVVM, commands, and dependency injection.
- Data access: The ASP.NET Core API owns Entity Framework Core and SQLite initially; use DB Browser for SQLite when a visual database inspection tool is useful. The WPF app does not access the database directly.
- API architecture: Build the API as a separate service consumed by the WPF client over HTTP. Keep API validation and persistence behind that boundary. GitHub Actions will build and test both applications; choose deployment and packaging approaches later.
- Source control and collaboration: Git and GitHub.
- CI/CD: GitHub Actions, beginning with build and test automation; choose a deployment target before practicing CD.
- Automated tests: xUnit, which the existing test project already uses.
- Project documentation: Markdown and a recruiter-facing GitHub README.
- AI assistance: GitHub Copilot if available, as a learning aid rather than a replacement for understanding or reviewing the work.
- Browser automation: Playwright remains deferred while the user experience is a desktop application.

## Flexible learning sequence

These are learning milestones, not a fixed schedule. Adjust the order and pace based on what the developer wants to practice and what the repository currently needs.

1. Understand the existing TestFlow solution, identify its intended users and workflow, and agree on a small first deliverable.
2. Practice the Git workflow on small, explainable changes and confirm the GitHub repository state.
3. Explore the C#/.NET solution structure and add focused tests around existing behavior.
4. Design and implement a small REST API feature, learning routes, validation, status codes, and API testing.
5. Add SQL-backed persistence for an agreed feature and practice schema changes and queries.
6. Build the desktop experience that uses the application functionality, choosing the UI approach together.
7. Add GitHub Actions CI for restore, build, and tests; learn workflow triggers, jobs, logs, and failure diagnosis.
8. Consider a CD/deployment exercise once the app and an appropriate deployment target are agreed.
9. Improve documentation and the repository presentation so the work and learning are clear to reviewers and recruiters.

## Session log

### 2026-10-09

- Focus: Set the learning priorities and establish this journal for TestFlow.
- Decisions: TestFlow is the project. Learning takes priority over perfecting the application. Practice areas are C#/.NET, Git and GitHub, SQL, REST APIs and API tests, GitHub Actions CI/CD, and VS Code. Playwright is deferred for the desktop-focused application.
- Stack direction: WPF with XAML and MVVM; a separate ASP.NET Core REST API consumed by WPF over HTTP; EF Core with SQLite owned only by the API; VS Code, Git/GitHub, GitHub Actions, xUnit, Markdown/README, and Copilot if available. The existing solution currently targets .NET 9. Deployment and desktop packaging remain future decisions.
- Repository context reviewed: The solution contains `TestFlow.Domain` and `TestFlow.Tests`, targeting .NET 9. Existing code includes employee, project, assignment, and test-suite domain types, a permission service, and xUnit tests for reviewer-level behavior.
- Completed this session: Created this mentoring journal. No application code or tests were changed.
- Next: Confirm the TestFlow user/problem and a small first deliverable, then begin with a small API endpoint before adding SQLite persistence and the WPF client integration.
- Commands run: None.

## Entry template

### YYYY-MM-DD

- Focus:
- Concepts practiced:
- Hands-on work and confirmed outcome:
- Decisions or blockers:
- Checks/tests and outcomes:
- Commands run:
- Next small step: