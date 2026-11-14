# Flappy Bird – Polymorphism

**A practical C# exercise for learning polymorphism, inheritance, and method overriding through a simple Flappy Bird game.**

![Language](https://img.shields.io/badge/language-C%23-512BD4)
![Framework](https://img.shields.io/badge/framework-.NET-512BD4)
![Platform](https://img.shields.io/badge/platform-Windows-blue)

## Overview

This project is a simplified Flappy Bird game developed in C# using Windows Forms.

The main objective was to practice object-oriented programming, especially **runtime polymorphism** using `virtual` and `override` methods.

The project is part of my personal software development portfolio.

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
|---|---|
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

## License

No license has been specified. All rights are reserved by default.