🌲 Text-Based Survival RPG
A robust, terminal-based survival simulation built with C# and .NET. This project demonstrates core Object-Oriented Programming (OOP) principles through a resource gathering and management gameplay loop.

🚀 Features
Dynamic Looting System: Explore the world to gather essential resources like Iron, Gold, Wood, and Stone.

Persistent Inventory: Implements a dictionary-based storage system that tracks and accumulates resources across multiple looting sessions.

Energy Management: Players must balance their energy levels; every action (looting) consumes energy, requiring strategic decision-making.

Combat for Survival: Encounter enemies to regain energy. High-risk, high-reward mechanics ensure gameplay tension.

Advanced OOP Architecture: Utilizes Class Inheritance, Static Members, and Collections (Dictionaries/Lists) for a clean and scalable codebase.

🛠 Technical Stack
Language: C#

Framework: .NET

Architecture: Object-Oriented Programming (OOP)

📂 Project Structure
Program.cs: The core Game Engine responsible for the main execution loop and user input.

Player.cs: Manages player statistics, including Health (HP), Energy, and Inventory state.

Create.cs: Handles the logic for resource generation and randomized loot distribution.

Class1.cs: Contains the base Item class and derived resource classes (Iron, Gold, etc.).

🎮 How to Play
Clone & Build: Open the solution in Visual Studio or VS Code and run the project.

Loot: Use the loot command to gather materials (costs energy).

Inventory: Check your collected resources using the inv command.

Fight: When low on energy, engage in combat to recover, but watch your HP!

📈 Roadmap
[ ] Implementation of a Crafting System (e.g., Stone Knife, campfire).

[ ] Advanced enemy AI and turn-based combat mechanics.

[ ] Persistent save states using JSON or File I/O.

[ ] Leveling system and skill trees.

Note: This project is under active development as a part of a deep dive into C# backend development.