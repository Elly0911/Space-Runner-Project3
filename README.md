# Space Runner

**Space Runner** is a 2D endless runner game developed in Unity using C#. The player controls a spaceship, dodges incoming asteroids, and tries to achieve the highest score possible.

## Overview

The game features three different spaceships, randomly spawning asteroids, keyboard and touch controls, scoring and high-score tracking, sound effects, background music, and a pause system.

The player moves the spaceship up and down while the game continuously scrolls forward. The longer the player survives, the higher their score. Hitting an asteroid ends the run.

## Features

* **Three Spaceships** - Choose between three different ship designs.
* **Endless Gameplay** - Asteroids continuously spawn as the player progresses.
* **Multiple Asteroid Types** - Two different asteroid designs add variety to gameplay.
* **Keyboard & Touch Controls** - Supports arrow-key controls and on-screen buttons.
* **Score & High Score** - Scores increase while playing, with the highest score saved between sessions.
* **Pause System** - Pause, resume, restart, or return to the home screen.
* **Audio** - Includes background music, button sounds, and collision sound effects.
* **Animated UI** - Includes animated titles and menu screens.

## How to Play

1. Start the game from the home screen.
2. Select a spaceship.
3. Press **Play** to begin.
4. Move the spaceship **up and down** to avoid asteroids.
5. Survive as long as possible to increase your score.
6. Try to beat your saved high score.
7. If you crash, restart the game or return to the main menu.

## Technology

* **Unity**
* **C#**
* **Unity PlayerPrefs** for saving player preferences and high scores

## Project Structure

The project is divided into separate scripts that handle different parts of the game, including:

* **CharacterManager** - Manages the available spaceships and the selected ship.
* **Player** - Handles player movement and gameplay-related logic.
* **Event** - Handles scene transitions and game events.
* **CameraMovement & LoopingBackground** - Create the scrolling environment.
* **Obstacle Spawner** - Generates asteroids at random positions.
* **Audio & Button Scripts** - Handle sound effects, music, and button interactions.

## Getting Started

1. Clone or download the repository.
2. Open the project in Unity.
3. Open the home scene.
4. Press **Play** to run the game.

## Project Information

Developed as a group project for the **PBDV301** university module.
