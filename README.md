# 📊 Realtime Sensor Data Dashboard with Blazor & ASP.NET Core Web API

## 🧩 Overview

This project is a functional prototype of a realtime dashboard for displaying sensor data, built with **Blazor** (Server) and **ASP.NET Core Web API**. It demonstrates a basic communication flow between a frontend UI and a backend service, where simulated sensor values (e.g., temperature or pressure) are periodically fetched and displayed in a table.


---

## ⚙️ Features

- Blazor Server application as a dashboard UI  
- ASP.NET Core Web API to provide mock sensor data  
- Periodic polling of sensor values (e.g., every few seconds)  
- Tabular display of data including timestamps  

---

## 🖼️ Preview

| Timestamp           | Sensor Type | Value  |
|---------------------|-------------|--------|
| 2025-04-20 10:15:00 | Temperature | 23.5°C |
| 2025-04-20 10:15:05 | Temperature | 24.1°C |
| ...                 | ...         | ...    |

---

## 🏗️ Project Structure

- SensorDashboard/
  - SensorDashboard.Client/ *(Blazor Server Project)*
    - Pages/
      - Dashboard.razor *(UI for displaying sensor data)*
  - SensorDashboard.API/ *(ASP.NET Core Web API Project)*
    - Controllers/
      - SensorDataController.cs *(Returns simulated data)*
  - Shared/
    - Models/
      - SensorData.cs *(Shared model for data transfer)*

## 🚀 How to Run API

To run the application locally, make sure you have the **.NET SDK** installed (e.g., .NET 8.0+).

Navigate to the API project folder:

```bash
cd SensorDataApi
dotnet run
```
This will start the backend on a local port (e.g., https://localhost:5030/sensor), which provides the sensor data via an API endpoint.

## 🧱 Build and Run the Blazor App

To build and run the Blazor Server application, follow these steps:

### ✅ Prerequisites

- [.NET SDK 8.0 or higher](https://dotnet.microsoft.com/en-us/download)
- A terminal (e.g., PowerShell, Command Prompt, or terminal in VS Code)

---

### 🔨 Build the Blazor App

Navigate to the folder containing your Blazor project (`*.csproj`) and run:

```bash
dotnet build

dotnet run
```

This will start the UI on a local port (e.g., https://localhost:5190/sensor), which provides the UI for sensor data visualisation which communicates with the API that was built before in this readme file.

