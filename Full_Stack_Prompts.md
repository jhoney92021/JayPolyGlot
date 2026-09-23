# Full Stack & Architecture Prompts

### Quick Links
* [Home](./README.md)
* [Basic Algo Prompts](./BasicAlgorithmPromts.md)
* [Windows Environment Setup](./C/WINDOWS_SETUP.md)
* [Linux Environment Setup](./CSharp/LINUX_SETUP.md)

---

## Overview

Unlike basic algorithm prompts (which focus on single-function logic like loops and array manipulations), **Full Stack Prompts** focus on system architecture, domain modeling, state management, and the clean **Separation of Concerns** between Backend (BE) business logic/persistence and Frontend (FE) presentation layers.

---

## 🐾 Prompt 1: Tomodachi (Virtual Pet State Machine & Full Stack Application)

### 📌 Level 1: Core Domain & State Machine (Basic)

**Goal**: Model a Virtual Pet ("Tomodachi") domain entity with state meters, action routines, and time-based decay.

#### Domain Requirements:
1. **Pet Attributes / Meters**:
   - `Name` (string)
   - `Hunger` (0 to 100, where 100 is starving, 0 is full)
   - `Happiness` (0 to 100, where 100 is ecstatic, 0 is depressed)
   - `Energy` (0 to 100, where 100 is fully rested, 0 is exhausted)
   - `IsSleeping` (boolean)
   - `HealthStatus` (Alive, Sick, Dead)

2. **Core Actions**:
   - `Feed()`: Decreases `Hunger` by 25, slightly increases `Happiness` (+5). Fails if pet is sleeping.
   - `Play()`: Increases `Happiness` (+20), increases `Hunger` (+10), decreases `Energy` (-15). Fails if `Energy` < 15 or pet is sleeping.
   - `Sleep()`: Toggles `IsSleeping = true`.
   - `WakeUp()`: Toggles `IsSleeping = false`.
   - `Tick()`: Simulates the passage of time (1 cycle).
     - If sleeping: `Energy` restores (+20 per tick). `Hunger` increases slowly (+5). Wake up automatically when `Energy == 100`.
     - If awake: `Hunger` increases (+10), `Happiness` decays (-5), `Energy` decreases (-5).
     - If `Hunger == 100` or `Happiness == 0` for 3 consecutive ticks, pet becomes `Sick`. If untreated, pet dies.

---

### 🚀 Level 2: Full-Stack Architecture & Separation of Concerns (Advanced)

**Goal**: Separate the pet logic into a robust **Backend (BE)** REST API / Domain Service and a decoupled **Frontend (FE)** Presentation Layer.

```
+----------------------------------------------------------------+
|                        FRONTEND (FE)                           |
|  - UI Rendering (Stat Bars, Pet Animation/Mood)                |
|  - Action Buttons (Feed, Play, Sleep)                          |
|  - Polling or WebSocket Listener for State Updates             |
+-------------------------------+--------------------------------+
                                | HTTP REST API / DTOs
                                v
+----------------------------------------------------------------+
|                        BACKEND (BE)                            |
|  - API Controller / Endpoints (POST /api/pet/feed, etc.)       |
|  - Domain Invariants & Rules (Cannot play while sleeping)      |
|  - Background Worker / Timer (Tick loop for stat decay)        |
|  - Persistence Layer (Database / File Storage for Pet State)   |
+----------------------------------------------------------------+
```

#### Backend (BE) Responsibilities:
1. **Domain Encapsulation**: Keep pet state validation strictly inside the backend domain layer. The API must reject invalid transitions (e.g., trying to play while sleeping returns `400 Bad Request`).
2. **Background Decay Loop**: Implement an asynchronous background worker (`IHostedService` in .NET, Celery/asyncio in Python, background thread in C/C++) that runs `Tick()` every $N$ seconds.
3. **Persistence**: Save pet state to a database (SQLite/PostgreSQL) or JSON storage on every action or tick so state persists across restarts.
4. **DTO Contracts**: Expose clean Read DTOs (e.g., `PetStatusResponse`) and Action Commands (e.g., `FeedPetCommand`).

#### Frontend (FE) Responsibilities:
1. **Presentation Only**: Render pet status bars, current mood (Happy, Sad, Sleeping, Sick, Dead), and action controls.
2. **Decoupled API Client**: Dispatch HTTP requests (`POST /api/pet/feed`) to trigger actions without embedding business rules in UI components.
3. **Real-time / Polling**: Poll backend status endpoint or listen to WebSocket updates to reflect background tick updates live.

---

## 📊 Multi-Language & Stack Implementation Matrix

Below is how different language stacks implement this separation of concerns:

| Language / Stack | Backend (BE) Architecture | Persistence | Background Tick Loop | Frontend (FE) Presentation |
| :--- | :--- | :--- | :--- | :--- |
| **C# / .NET** | ASP.NET Core Web API Controller | EF Core + SQLite / SQL Server | `BackgroundService` / `IHostedService` | React, Blazor WASM, or Razor Pages |
| **C (Embedded/CLI)** | Domain Structs (`pet_t`) & C11 module functions | File I/O (`fread`/`fwrite` to binary/json) | POSIX `alarm()` / `nanosleep()` or thread | Terminal ANSI render / Ncurses UI |
| **TypeScript / Node** | Express.js / NestJS Controller | Prisma / TypeORM + SQLite | `setInterval()` background worker | React / Next.js / Vue |
| **Python** | FastAPI / Flask endpoints | SQLAlchemy + SQLite | `asyncio` task or Celery scheduler | React / HTML + Tailwind |

---

## 🔗 Implementation Solutions

*(Solutions for this prompt across languages will be linked here as they are added)*

- **C#**: [Tomodachi README](./CSharp/Tomodachi/README.md) | [Domain Model (Pet.cs)](./CSharp/Tomodachi/Pet.cs) | [xUnit Tests](./CSharp/Tomodachi.Tests/TomodachiTests.cs)
- **C**: [Tomodachi CLI State Machine](./C/Tomodachi/README.md) *(Coming Soon)*
