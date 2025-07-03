Chp1: ASP.NET and ASP.NET Core
Here’s a clear and concise comparison between ASP.NET (classic) and ASP.NET Core:

Feature			ASP.NET (Framework)							ASP.NET Core
Platform		Windows-only								Cross-platform (Windows, Linux, macOS)
Performance		Slower due to older architecture			Much faster and lightweight
Hosting			Requires IIS								Can be hosted on IIS, Kestrel, Nginx, Apache, or self-hosted
Modularity		Monolithic framework (less flexible)		Fully modular via NuGet packages
Versioning		Tied to .NET Framework versions				Independent and side-by-side versioning possible
Dependency		Limited, third-party only					Built-in and first-class support
Injection (DI)
Configuration	web.config XML-based						Uses flexible appsettings.json, environment variables, etc.
Web API & MVC	Separate frameworks							Unified into a single framework
Razor Pages		Not available								Supported (simpler for page-focused apps)
Real-time apps 	Older version, limited features				Rewritten and improved in ASP.NET Core
(SignalR)
Development		Slower build and deployment					Faster due to lightweight and better tooling
Open Source		Partially									Fully open source and community-driven

Summary
ASP.NET Core is the modern, high-performance, cross-platform successor to ASP.NET.

Chp2: MVC Pattern in DotNet Core
Model - Business Entities
View - User Interaction (FrontEnd)
Controller - BackEnd Logic

View Interacts with Controller which communicates with Model to return Data to Display on the frontend.

Chp3: Directory Structure

Dependencies: Contains all NuGet packages your project depends on.

Properties: Holds project-specific settings like launchSettings.json used for debugging and environment configs.

root: The base directory of your ASP.NET Core project containing all core files and folders.

Controller: Contains C# classes that handle incoming HTTP requests and return responses (usually views or data).

Models: Defines the data structures and business logic used by your application.

Views: Contains .cshtml Razor files used to render HTML content sent to the browser.

appsettings.json: Stores configuration settings like connection strings and app-specific values in JSON format.

Program.cs: The entry point of the application that configures services and builds the HTTP request pipeline.








