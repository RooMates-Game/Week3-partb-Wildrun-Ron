# Week 3 - Part B - WildRun!

**Why did the penguin cross the road? To get to the other side!**  
Can you cross the road safely?

Welcome to **WildRun**, a simple 2D game where you control a character trying to cross a road filled with speeding cars. The goal is to avoid collisions and make it safely to the other side.

This game demonstrates basic game development concepts like movement, collision detection, rigid body physics, and scene management.

## Table of Contents
- [Overview](#overview)
- [How to Play](#how-to-play)
- [Scripts](#scripts)
  - [CarMover](#carmover)
  - [CarSpawner](#carspawner)
  - [GoToNextLevel](#gotonextlevel)
  - [Mover](#mover)
  - [RestrictVerticalMovement](#restrictverticalmovement)

---

## Overview

In **WildRun**, the player controls a character that moves upward across a road filled with cars driving horizontally. The objective is to cross the road safely and reach the other side without being hit by a car.

### Key Features:
- Spawning of various cars with different speeds.
- Game Over and Win scenes.
- Interactive background that adds to the overall experience.

---

## How to Play
- Load the game.
- Use the arrow keys to move in four directions.
- Avoid colliding with the cars.
- Cross the road safely to win.

---

## Scripts

### **CarMover.cs**
This script controls the movement of cars across the screen. Cars move from west to east, or in the opposite direction, depending on the lane. The movement behavior is based on the **SmoothMover** concept from the first lecture.

**Responsibilities**:
- Moves cars at different speeds depending on the lane.
- Adjusts the direction based on the lane.

---

### **CarSpawner.cs**
This script is responsible for spawning cars at random intervals and in random lanes. It’s designed to be reusable for different lanes or cars and can be easily customized.

**Responsibilities**:
- Spawns cars at random positions and intervals.
- Ensures cars appear in a challenging yet fair manner for the player.

---

### **GoToNextLevel.cs**
This script manages the transition between different scenes, such as **GameOver** or **Win**. It handles the scene-switching logic when the game state changes.

**Responsibilities**:
- Transitions the game to either the Game Over or Win scene.
- Manages scene changes based on game events (e.g., player collision or successfully crossing the road).

---

### **Mover.cs**
This script handles the player's movement. The player can move in four directions using the arrow keys. The movement distance can be adjusted via the Unity inspector, allowing flexibility for the developer.

**Responsibilities**:
- Allows the player to move up, down, left, and right using the arrow keys.
- Provides easy adjustments to movement speed or distance via the Unity inspector.

---

### **RestrictVerticalMovement.cs**
This script ensures that the player cannot move outside the vertical boundaries of the camera's view. It prevents the player from going off-screen vertically.

**Responsibilities**:
- Restricts the player’s vertical movement to within the camera's viewport.
- Ensures the character stays within the scene's visible area.

---

## Enjoy Playing!
Have fun playing **WildRun**, and remember: Always look both ways before crossing the road! 🎮
