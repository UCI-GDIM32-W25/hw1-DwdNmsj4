[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

## Put your notes from the W1L2 (Thurs, Jan 9) in-class activity 
How would you describe this game world in objects?
-plant count UI: seed planted UI/seeds remaining UI
-players
-plants

What attributes and  actions do these objects have?
-Seed UI
Attributes: quantity, texts
actions: can be planted by the players, count goes up/down when player plants a seed

-Player object
Attributes: bunny sprite
Actions: move with fours directions, can plant seeds
*output: seed is planted as player¡¯s location, decreases seed count + increase seed count (shows up in the UI); player has to have seeds left in order to plant

-Plants object:
Attributes: position in the game world, plant sprite
Actions: appear

How do these objects act on or affect each other?
-The player can interact with seeds by planting them
-planting a seed can make a plant object appear
-The seed planted UI and seed remaining UI update everytime the seed is planted

The player object corresponds to player class in C#
the player has an attribute  - corresponds to the code part in C### Devlog

## Devlog


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
