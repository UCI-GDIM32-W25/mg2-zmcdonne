[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog

The plan I wrote in the MG2 breakdown activity connects to the code I wrote and was thankfully not too different. I imagined the code being divided into UI, coins, and penguin scripts. I changed this after seeing Professor Reid’s example with a game controller. The rest I followed for my outline.

For the UI, when a collision occurs, using the correct 2D collider was often an issue, so I learned the hard way about double-checking my colliders and will be preferring that in my next plan. I started by creating the ground how I imagined it, with a 2D box collider, ground tag and a sprite, and the player penguin with its sprite, a 2D capsule collider, and a Rigidbody, along with a player script that simply checked if the floor tag was equal to “Ground,” like we used last quarter. I had accidentally coded this to use the up key instead of the space key, so I made a last-minute change out of habit. For the UI, I used a similar strategy to the final project from last quarter, with a separate class for the UI that then gets called inside the gamecontroller for counting.

In terms of the process I didn’t have outlined beforehand, I went to LA tech support, and asked Elijah for a way to use Random.Range effectively, as I was confused about where to begin. He explained that back when he did the assigment he create a timer. So inside the gamecontroller my class randomizes the time using Random.Range, between instatiations of the Coin. In the coin script it calls destroy if the 2d collider of the coin collides with either player (or my "Death_collider") which then increments points by += 1. I put this logic into my GameController. I used a Death_collider with the tag destroyer inside the coin class with destroy, along with using Vector3 for movement * speed * Time.deltaTime, and used Instantiate(coinPrefab, position, Quaternion.identity); from last week so that the Coin prefab comes in a straight line from the right, randomly spaced.
Overall, I know next time I’m going to make a plan that thinks ahead a bit more and is a bit more specific, but I think this outline prepared me well enough and I didn’t stray too far.



## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
