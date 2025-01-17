[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
How would you describe this game world in objects?
- plant count UI: seed planted UI/seeds remaining UI
- players
- plants

What attributes and  actions do these objects have?
- Seed UI
  - Attributes: quantity, texts
  - actions: can be planted by the players, count goes up/down when player plants a seed
- Player object
  - Attributes: bunny sprite
  - Actions: move with fours directions, can plant seeds
  - *output: seed is planted as player¡¯s location, decreases seed count + increase seed count (shows up in the UI); player has to have seeds left in order to plant
- Plants object:
  - Attributes: position in the game world, plant sprite
  - Actions: appear

How do these objects act on or affect each other?
- The player can interact with seeds by planting them
- planting a seed can make a plant object appear
- The seed planted UI and seed remaining UI update everytime the seed is planted

The player object corresponds to player class in C#
the player has an attribute  - corresponds to the code part in C### Devlog

## Devlog

In developing the game, I followed notes discussed in class, which described the game with three main objects: Plant Count UI, Player, and Plants. Each object’s attributes and actions influenced how I structured my code: the ‘Start’, ‘Update’, and ‘PlantSeed’ methods in the Player and ‘UpdateSeeds’ method in PlantCountUI scripts.
  
The PlantCountUI class corresponds to the Plant Count UI object in unity, which manages the text display of seeds planted and seeds remaining. The UpdateSeeds method in this class updates the two UI elements dynamically. When the player plants a seed, the number shown in seeds remaining UI will decrease and the number shown in seeds planted UI will increase. In Unity, I set two text UI as game objects, which are linked to the _plantedText and _remainingText fields in the PlantCountUI script. This connection ensures that every time a seed is planted, the UI reflects the updated counts.

The Player class mainly implements the movement of the player (moving in four directions and press space to plant seeds). This movement is handled in the Update method by using Input.GetAxis to control WASD keys. The PlantSeed method in the Player class allows the player to plant seeds. It checks if the player has any seeds left before instantiating a Plant prefab at the player’s current position. After planting, the method calls PlantCountUI.UpdateSeeds to update the UI, ensuring that the text dynamically reflects the game state. The player is represented in the Unity Scene by the player Game Object, which has the bunny sprite as its visual representation. I linked the player object to player transform and plant object to plant prefab in player script to make sure the seed can be planted by player with four directions.

The Plant object is implemented as a prefab in Unity. The Plant prefab is instantiated by the PlantSeed method in Player script when a seed is planted. Its position follows the player’s current location, and its visual representation uses the grass sprite.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting the break-down to your code! Great job on this Devlog.

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
