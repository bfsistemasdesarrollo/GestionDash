# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

GestionDash is a full-stack business management dashboard. The backend is ASP.NET Core Web API (.NET 10) and the frontend is React 19 + Vite. They share the same Visual Studio solution (`GestionDash.slnx`).

## Commands

### Backend (from `GestionDash.Server/`)
```
dotnet run          # Start API on https://localhost:7012
dotnet build        # Build only
```

### Frontend (from `gestiondash.client/`)
```
npm run dev         # Start Vite dev server on https://localhost:50990
npm run build       # Production build
npm run lint        # ESLint
```

### Run full stack
Open `GestionDash.slnx` in Visual Studio and press F5. Both projects launch simultaneously — the backend starts first, then the Vite proxy is started automatically via `SpaProxyLaunchCommand`.

## Architecture

### Request Flow (development)
The Vite dev server (`localhost:50990`) proxies all `/api/*` requests to the ASP.NET Core backend (`localhost:7012`). In production, the backend hosts the React SPA directly via `MapStaticAssets()` and `MapFallbackToFile("/index.html")`.

### Authentication
- **Backend**: `POST /api/auth/login` receives `{ usuMail, usuCla }`, hashes the password with MD5, and returns a JWT on success. JWT config (key, issuer, audience, expiry 8h) lives in `appsettings.json`.
- **Frontend**: `AuthContext` (`src/context/AuthContext.jsx`) stores the JWT and user object in `localStorage` under keys `gd_token` and `gd_user`. All pages behind `ProtectedRoute` redirect to `/login` when no token is present.

### Database
- SQL Server, database `BFGestionDemo`. Connection string in `appsettings.json` (defaults to Windows trusted connection on `localhost`).
- `AppDbContext` (`Data/AppDbContext.cs`) was **scaffold-generated from an existing database** — it is ~3300 lines and maps 80+ tables. Do not assume code-first migrations exist; the schema is database-first.
- Every table has a `trg_*_Delete` trigger registered via `tb.HasTrigger(...)` in `OnModelCreating`.
- Entity naming convention: table names are uppercase (e.g., `ARTICULOS`), C# model names are PascalCase (e.g., `Articulo`), and column/property names use a prefix abbreviation (e.g., `ArtNro`, `CliNom`).

### Backend Layout
- `Controllers/` — API controllers, one per resource. Inject `AppDbContext` directly (no repository layer).
- `Models/` — EF Core entity classes, one per DB table.
- `DTOs/` — Request/response shapes (`LoginRequest`, `LoginResponse`).
- `Data/AppDbContext.cs` — Single large EF context with all entity configurations.
- `Program.cs` — Service registration (EF, JWT bearer, OpenAPI) and middleware pipeline.

### Frontend Layout
- `src/context/AuthContext.jsx` — Auth state (`token`, `user`, `login`, `logout`, `isAuthenticated`) shared via React Context.
- `src/components/ProtectedRoute.jsx` — Wraps routes that require authentication.
- `src/pages/` — Page-level components (`LoginPage`, `DashboardPage`), each with a co-located CSS file.
- `src/App.jsx` — Router: `/login` → `LoginPage`, `/` → `DashboardPage` (protected), everything else redirects to `/`.
