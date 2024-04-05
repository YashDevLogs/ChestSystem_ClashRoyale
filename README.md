# Chest System - Clash Royale

## Introduction
This project implements a chest system inspired by the Clash Royale game. It allows players to unlock chests containing rewards such as coins and gems.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Design Patterns](#Design Patterns)
- [Programming Principles](#Programming Principles)
- [Installation](#installation)
- [Usage](#usage)

## Features
- Random generation of chests with different types and rewards.
- Timer-based unlocking mechanism for chests.
- Instant unlocking option using gems.
- User interface for displaying chests, rewards, and in-game resources.
- Singleton-based services for managing resources and UI.


## Design Patterns:
- Singleton Pattern: Implemented in `GenericMonoSingleton` and its subclasses (`ChestService`, `ResourceService`, `UIService`). Ensures that only one instance of these classes exists throughout the application.
- State Pattern: Not implemented directly in the provided code, but the `ChestState` enum indicates the potential use of the state pattern to manage the different states of a chest (Locked, Unlocking, Unlocked, Collected).

## Programming Principles:
- Separation of Concerns (SoC): Each class (`ChestModel`, `ChestController`, `ChestView`, `ChestService`, `ResourceService`, `UIService`, `Slot`, `SlotController`, `Chest_SO`, `ChestConfiguration`) has a specific responsibility, adhering to the principle of separation of concerns.
- Single Responsibility Principle (SRP): Each class has a single responsibility. For example, `ChestModel` manages chest data, `ChestController` handles chest logic, `ChestView` manages chest UI, and so on.
- Open/Closed Principle (OCP): The code is designed to be open for extension but closed for modification. For example, new chest types or configurations can be added without modifying existing code, thanks to the use of scriptable objects like `Chest_SO` and `ChestConfiguration`.
- Dependency Injection (DI): Dependency injection is used in the `ChestController` constructor to inject dependencies (`ChestModel` and `ChestView`). This promotes loose coupling and facilitates unit testing.
- Encapsulation: Properties and methods in classes are encapsulated to control access and protect data integrity. For example, properties in `ChestModel` are encapsulated to provide read-only access.
- Iterator (IEnumerator): Used in the `StartTimer` method of `ChestController` to implement a timer for unlocking chests.
- Factory Method Pattern: Not directly implemented, but the `GetChest` method in `ChestService` can be considered a factory method that creates instances of `ChestController` based on the provided `Chest_SO`.
- Observer Pattern: The UI updates (such as updating gem and coin counts) in `UIService` can be considered an implementation of the observer pattern, where the UI components observe changes in the game state.

## Installation
To use this project, follow these steps:

1. Clone the repository to your local machine.
2. Open the project in Unity.
3. Ensure that you have all the necessary dependencies and packages installed.
4. Run the project in the Unity Editor or build it for your desired platform.

## Usage
### Chest Configuration
Customize chest types, rewards, and unlock times by editing the `Chest_SO` and `ChestConfiguration` scriptable objects.

### Gameplay
Spawn chests in slots using the `SlotController` and interact with them through the `ChestView` UI.

### UI Interaction
Toggle various UI panels and handle user input through the `UIService`.

