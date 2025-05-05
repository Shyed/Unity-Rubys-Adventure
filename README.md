# Ruby's Adventure

**Ruby's Adventure** is a 2D Unity-based platformer game where players control a character named Ruby who navigates a world of hazards, collectibles, and enemies. The project serves as an educational introduction to Unity's 2D game development environment and includes core gameplay mechanics such as movement, health collection, enemy AI, and scene management.

## Gameplay Features

- 2D character control with movement and interactions
- Damage zones and health collectibles
- Basic enemy AI and behavior
- Object interactions (pick up and hold)
- Scene-based level loading (`MainScene`, `SampleScene`)
- Modular scripts for character, enemy, and environment mechanics

## Project Structure

```
Assets/
├── Art/             # Sprites and visuals
├── Audio/           # Game audio files
├── Demo/            # Possibly test scenes or UI demos
├── Prefabs/         # Reusable game objects
├── Scenes/          # Unity scene files (MainScene, SampleScene)
├── Scripts/         # All C# game logic (e.g. RubyController.cs, EnemyController.cs)
```

## Scripts Included

- `RubyController.cs`: Main character logic (movement, animation, interaction)
- `EnemyController.cs`: Enemy movement and damage logic
- `HealthCollectible.cs`: Heals the player when collected
- `DamageZone.cs`: Applies damage to player when entered
- `PickUpAndHold.cs`: Handles object pickup mechanics
- `TimedSelfDestruct.cs`: For timed destruction of objects (e.g. projectiles)

## Requirements

- **Unity Version:** 2019.4 or higher recommended
- **Platform:** PC / Mac / Linux Standalone

## Getting Started

1. Clone this repository.
2. Open the project in Unity Hub.
3. Open the `MainScene` from the `Scenes` folder.
4. Press Play to begin testing the game.

## Assets & Licensing

This project may include open-source or educational Unity assets. Always verify licensing before reuse.
