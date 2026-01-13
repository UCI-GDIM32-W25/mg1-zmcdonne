[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog
Zoya McDonnell, she/her


For the MG1, I broke it down into steps, which I commented directly into the code and then incremented on. 

My plan wasn’t that different from Professor Reid’s example. In the Start method, I made sure the game started correctly, with the seeds left being 5 and NumSeedsPlanted being 0.

For the private void Update method, I created the WASD controller. It was a bit different than planned because I forgot that 2D movement uses horizontal and vertical axes. When doing that for the first time, I got some help from Taylor on the formatting.
Thereafter, I followed my plan of coding so that if the space key was pressed and there were more than 0 seeds left, the player would plant a seed while also calling the PlantCountUI.

At the very end, I filled in the PlantSeed method using Instantiate, making sure it used what I called the SpritePrefab. It instantiates where the player is standing using _playerTransform.position. Willow explained to me the importance of why Quaternion.identity is used for the rotation of GameObjects.

In terms of my plan changing, I originally thought to increment only in the UI method called UpdateSeeds. However, I ended up just using the UI code called PlantCountUI for the text change, and in the Player class I called the method.


## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
