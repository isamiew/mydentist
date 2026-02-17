# MyDentist 🦷

**Minimalist, High-Performance Dental Clinic Management Platform.**
Built with the latest Microsoft technologies, featuring a professional UI/UX and robust architecture.

---

## 🚀 Tech Stack

-   **.NET 10 (Preview)**: Utilizing the latest performance improvements and language features.
-   **C# 14**: Modern, expressive, and type-safe backend logic.
-   **Blazor Server**: Interactive, real-time web UI without JavaScript frameworks.
-   **Tailwind CSS v4**: Utility-first, high-performance styling engine.
-   **Docker**: Containerized deployment support.

## 🎯 Project Goal

To provide a seamless, multi-language platform for dental clinics that connects patients with doctors efficiently. The system manages appointments, patient records, and doctor schedules in a unified, secure interface.

## 🏗 Architecture

The solution follows a clean, modular structure designed for scalability:

```
src/
├── MyDentist.Core/             # 🧠 Domain Logic & Entities (Pure C#)
│   └── (Interfaces, Models)
│
└── MyDentist.Web/              # 🌐 UI & Presentation Layer (Blazor)
    ├── App/                    # Application Entry Points
    ├── Layouts/                # Global Layouts (Main, Doctor, Patient)
    ├── Portals/                # Feature Modules (Isolated areas)
    │   ├── Doctor/             # Doctor-specific components
    │   ├── Patient/            # Patient-specific components
    │   └── Public/             # Public landing pages
    ├── Shared/                 # Reusable Components & Localization
    └── wwwroot/                # Static Assets (CSS, JS, Images)
```

## 🌍 Key Features

-   **Multi-Language**: Full support for **Uzbek (Default)**, Russian, and English with instant switching.
-   **Premium UI**: Custom animated components and smooth transitions.
-   **Portal System**: Separate, optimized interfaces for Doctors, Patients, and Public visitors.

## ▶️ Getting Started

1.  **Prerequisites**: Install .NET 10 SDK.
2.  **Run the project**:
    ```bash
    dotnet run --project src/MyDentist.Web/MyDentist.Web.csproj
    ```
3.  **Access**: Open `http://localhost:5000` in your browser.
