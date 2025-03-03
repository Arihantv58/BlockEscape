# BlockGame

BlockGame is a Unity-based project designed to offer a robust and engaging gaming experience by leveraging efficient collision detection, seamless level transitions, and a user-friendly exit mechanism. Built with modularity in mind, BlockGame serves as an excellent foundation for developers looking to extend or customize core gameplay mechanics.

## Table of Contents
1. [Overview](#overview)
2. [Game Mechanics](#game-mechanics)
3. [Scripts Explanation](#scripts-explanation)
4. [Installation & Setup](#installation--setup)
5. [Development Guidelines](#development-guidelines)
6. [Contributing](#contributing)
7. [License](#license)
8. [Acknowledgements](#acknowledgements)

## Overview
BlockGame is engineered to create an interactive and immersive gameplay experience in Unity. With a focus on precision and scalability, the project uses dedicated scripts to manage collision events, level completions, and graceful exits. This architecture not only improves maintainability but also enables future expansion without compromising performance.

## Game Mechanics
BlockGame is built around three key mechanics:
- **Collision Management:**  
  Prevents the player from proceeding when a collision with an obstacle is detected.
- **Level Transitioning:**  
  Detects when the player reaches the level’s end and triggers the appropriate state change.
- **Application Termination:**  
  Provides a controlled method to exit the game seamlessly.

These mechanics ensure that gameplay is both challenging and reliable, while offering clear points for debugging and enhancements.

## Scripts Explanation

### collisionScript.cs
- **Purpose:**  
  This script is responsible for handling collision events in the game. It checks for collisions with objects tagged as "Obstacle" and, when detected, it disables player movement and logs the event.
- **Functionality:**  
  - **OnCollisionEnter:**  
    When a collision is detected, it verifies if the collider's tag is "Obstacle." If true, it disables the movement component attached to the player and calls the GameManager's `EndGame()` method to handle game termination.  
    *(Refer to the code in collisionScript.cs for full implementation details.)* :contentReference[oaicite:0]{index=0}
- **Usage:**  
  Attach this script to the player object to ensure that collisions with obstacles are properly managed, thereby enforcing gameplay rules.

### Credits.cs
- **Purpose:**  
  Implements the exit functionality for the game, allowing players to quit gracefully.
- **Functionality:**  
  - **Quit:**  
    Logs a quit event and calls `Application.Quit()`, ensuring that the game exits cleanly.  
    *(For more details, see Credits.cs.)* :contentReference[oaicite:1]{index=1}
- **Usage:**  
  This script is ideal for linking with UI elements (such as a "Quit" button) to facilitate user-initiated termination of the game.

### EndTrigger.cs
- **Purpose:**  
  Manages the completion of a level by detecting when the player enters the designated end zone.
- **Functionality:**  
  - **OnTriggerEnter:**  
    Once triggered, the script calls `CompleteLevel()` on the GameManager, indicating that the level has been successfully completed.  
    *(Examine EndTrigger.cs for additional context.)* :contentReference[oaicite:2]{index=2}
- **Usage:**  
  Attach this script to the end-of-level trigger zone within your Unity scene to automate level transitions.

## Installation & Setup
Follow these steps to get BlockGame running on your local machine:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Arihantv58/BlockEscape.git
