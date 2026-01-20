[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
The plan I wrote in the MG2 breakdown activity connects to the code I wrote was thankfully not to diffrent, I imagined the code being divided into UI, coins, and penguin scripts. I changed this after seeing Professor Reid’s example with a game controller. The rest I followed for my outline.
For the UI when a collision occurs, using the correct 2D collider was often an issue. I started by creating the ground how I imagined it, with a 2D box collider and a sprite, and the player penguin with its sprite, a 2D capsule collider, and a Rigidbody, along with a script that simply checked if the floor tag was equal to “Ground,” like we used last quarter. I had accidentally coded this to use the up key instead of the space key, so I made a last-minute change out of habit. For the UI, I used a similar strategy to the final project from last quarter, with a separate class for the UI that then gets called.
I went to LA office hours and asked Elijah for a way to use Random.Range effectively, as I was confused about where to begin. He explained that I should: create a timer, randomize the time using Random.Range, destroy the collider if it collides with something, and increment points with points += 1;. I put this logic into my GameController.
Coins come in a straight line from the right, randomly spaced. I used way too much documentation.



## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
