# PortfolioViewer

## 💡 Projektidee

Modulare Portfolio-Management-Plattform mit KI-gestützter Risikoanalyse

## 🧩 Beschreibung

PortfolioViewer ist eine modulare Plattform, mit der Nutzer ihre Finanzportfolios (Aktien, ETFs, Krypto, etc.) verwalten können. Die Plattform bietet KI-gestützte Risikoanalysen, Diversifikationsbewertungen und Optimierungsvorschläge. Nutzer können Portfolios importieren, simulieren und analysieren.

## 🔧 Tech Stack

| Komponente       | Technologie                                      |
| ---------------- | ------------------------------------------------ |
| Backend-API      | C# (.NET Web API)                                |
| Frontend         | Blazor, MAUI oder Angular                        |
| KI/Risikoanalyse | Python (Pandas, scikit-learn, XGBoost)           |
| Datenquellen     | Börsen-APIs (z. B. Yahoo Finance, Alpha Vantage) |
| Speicherung      | PostgreSQL oder MongoDB                          |

## 📈 Features

### MVP (Minimum Viable Product)

- Portfolio anlegen und verwalten
- Echtzeit-Datenintegration von Aktien und Kryptowährungen
- Grundlegende Kennzahlen (Sharpe Ratio, Volatilität, Beta etc.)
- Import über CSV/Excel oder API

### Erweiterbar/Skalierbar

- KI-Risikoprofil-Bewertung anhand vergangener Performance
- Optimierungsalgorithmen (z. B. Markowitz-Modell)
- Szenario-Simulation (z. B. Rezession, Zinsanstieg)
- Multi-User-System mit Rollen (Berater, Privatanleger, etc.)
- Mobile App via .NET MAUI oder API-Anbindung

## 🔁 Integration zwischen C# und Python

- Python-Skripte über eine REST-Schnittstelle aus C# aufrufen
- Python-Services via gRPC oder über Azure/AWS Lambda bereitstellen
- Nutzung von Python-Modulen für Datenanalyse in separatem Container (Docker)

## 💡 Warum ist es skalierbar?

- **Modularität:** Jeder Teil (Portfolio-Import, Analyse, Reporting) ist unabhängig ausbaubar
- **Mehrwertdienste:** Später können Premiumdienste, Abo-Modelle oder Finanzberatungen integriert werden
- **Skalierbare Infrastruktur:** Microservices und Cloud-Bereitstellung (z. B. über Azure App Services + Azure Functions)

## ✅ Bonus-Ideen

- Anomalie-Erkennung bei Transaktionen (Betrugsschutz)
- Social-Features: Nutzer vergleichen Portfolios anonym
- Steueroptimierung (Verlustverrechnung, Haltefristen)
- Chatbot-Beratung mit KI
