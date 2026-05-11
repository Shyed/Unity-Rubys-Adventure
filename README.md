# Ruby's Adventure

**Ruby's Adventure** is a 2D Unity-based platformer game where players control a character named Ruby who navigates a world filled with hazards, collectibles, enemies, and interactive objects. The project was originally developed as part of an educational Unity game development experience and demonstrates core gameplay systems using Unity and C#.

This project showcases foundational game development and software engineering concepts including player movement, collision systems, health management, enemy AI behavior, object interaction, and scene management.

---

## Educational Developer Notes

This repository contains heavily documented scripts and beginner-friendly developer notes for educational and portfolio purposes.

Comments were intentionally expanded to:
- explain gameplay systems
- reinforce Unity and C# concepts
- document programming logic
- improve readability and maintainability
- support long-term learning and review

Because of this, the scripts are more heavily commented than a typical production game project.

## Gameplay Features

- 2D character movement and interaction system
- Health and damage mechanics
- Enemy AI movement and collision behavior
- Damage zones and healing collectibles
- Object pickup and interaction systems
- Scene-based level loading
- Physics-based movement using Rigidbody2D
- Modular gameplay scripting architecture

---

## Technologies Used

- Unity Engine
- C#
- Visual Studio
- Unity 2D Physics System

---

## Project Structure

```text
Assets/
├── Art/             # Sprites and visual assets
├── Audio/           # Music and sound effects
├── Demo/            # Demo or prototype content
├── Prefabs/         # Reusable game objects
├── Scenes/          # Unity scenes (MainScene, SampleScene)
├── Scripts/         # Main gameplay C# scripts
```

---

## Script Location

All gameplay and logic scripts are located under:

```text
Assets/Scripts/
```

Example scripts include:

- `RubyController.cs`
- `EnemyController.cs`
- `HealthCollectible.cs`
- `DamageZone.cs`
- `PickUpAndHold.cs`
- `TimedSelfDestruct.cs`

---

## Core Systems Implemented

### Player Controller System
- Physics-based movement using Rigidbody2D
- Health and invincibility system
- Keyboard input handling
- Collision and interaction logic

### Enemy System
- Timed directional movement AI
- Player collision damage
- Physics-based movement behavior

### Health & Collectible System
- Healing item pickups
- Environmental damage zones
- Dynamic health management

### Interaction System
- Trigger-based interactions
- Object pickup and hold mechanics
- Scene object communication

---

## Software Engineering Concepts Demonstrated

- Object-Oriented Programming (OOP)
- Component-based architecture
- State management
- Event-driven systems
- Collision detection
- Physics systems
- Modular scripting
- Defensive programming
- Scene management

---

## Project Purpose

This project was created to strengthen understanding of Unity game development and C# programming fundamentals while building hands-on experience with gameplay systems, physics interactions, and modular game architecture.

---

## Assets & Licensing

This project may contain educational or open-source Unity assets used for learning purposes. Please verify asset licensing before commercial reuse.
