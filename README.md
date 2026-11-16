# Flappy Bird Clone – C# Polymorphism

**A practical C# school project demonstrating polymorphism, inheritance, and method overriding through a simplified Flappy Bird-inspired game.**

![Language](./readme-img/language.svg)
![Framework](./readme-img/framework.svg)
![Platform](./readme-img/platform-windows.svg)

## Overview

This project is a simplified game inspired by Flappy Bird, developed in C# using Windows Forms as part of a school programming exercise.

The main objective was to practice object-oriented programming, especially **runtime polymorphism** using `virtual` and `override` methods.

The project is also included in my personal software development portfolio.

## Features

- **Bird Movement** – Control the bird using the spacebar.
- **Gravity** – The bird automatically moves downward.
- **Random Obstacles** – Pipes are generated with varying heights.
- **Collision Detection** – The game ends when the bird collides with an obstacle or leaves the playing field.
- **Game Timer** – Tracks survival time in seconds.
- **Restart System** – Restart the game after losing.

## Implementation

The application uses a shared `MoveableGameElement` base class.

- `Bird` – Implements gravity, jumping, and collision detection.
- `Pipe` – Generates obstacles and implements horizontal movement.
- `MoveableGameElement` – Provides shared functionality and a virtual `Move()` method.
- `FlappyBird` – Manages the game loop, controls, and events.

Derived classes override `Move()` to implement their own movement behavior, demonstrating **runtime polymorphism**.

## Technology Stack

| Category | Technology |
| --- | --- |
| Language | C# |
| Framework | .NET Windows Forms |
| Interface | Windows Forms |
| Main Concept | Runtime Polymorphism |
| Additional Concepts | Inheritance, Events, Method Overriding |

## Getting Started

1. Clone or download the repository.
2. Open the project in Visual Studio on Windows.
3. Build and run the application.
4. Press **Space** to control the bird.

## What I Learned

- Applying polymorphism with `virtual` and `override`.
- Using inheritance to share functionality.
- Implementing event-driven game logic.
- Managing movement and collision detection.
- Creating a simple graphical game using Windows Forms.

## Disclaimer

This project is an independent educational exercise inspired by Flappy Bird.

It is not affiliated with, sponsored by, or endorsed by the owners of Flappy Bird.

Flappy Bird is a trademark of its respective owner.

## License

No license has been specified. All rights to the original source code are reserved by default. Third-party assets, if any, remain subject to their respective owners' rights.
