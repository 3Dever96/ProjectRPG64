# Project RPG 64

## Description

A roguelike collectathon with RPG elements, character customization, and permadeath.  Players can play solo or online with friends.

### Roguelike Collectathon
* Players start in an open hub where they can prepare for quests, choose the area they wish to explore, or interact with other players.
* Upon leaving the hub, the players can choose to scout a new level (randomly generated biome, cave, or dungeon) or revisit a previously generated level.
* Each level has five objectives that players can complete to gain magic crystals.  These crystals can be traded for rare cosmetics, experience points, or converted into skill points.
  * Navigation Challenge: Reach the highest peak or deepest pit using platforming/ skills.
  * Resource Sacrifice: Give up some gold to reveal the crystal.
  * King of the Hill: Stand in a designated "Capture Zone" for a cumulative 60 seconds.
  * Stealth Infiltration: Reach a chest without being spotted by invincible sentries.
  * Escort Mission: Protect a slow-moving npc as it travels to a shrine.
  * The Gauntlet: Navigate a treacherous path of physical traps.
  * Horde Survival: Survive waves of enemies for 2 minutes.
  * Time Trial: Activate a gate and reach the goal before the timer hits zero.
  * Fetch Quest: Find a specific item in the level and return it to a local NPC.
  * Puzzle: Find and activate hidden switches in the correct order/ time.
  * Item Collection: A scavenger hunt scattered across the terrain.
  * Boss Battle: Find the boss arena and defeat the level's unique guardian.
* After completing an objective, the players are returned to the hub.

### RPG Elements
* The player's character is 1 of 12 classes.
  * Knight
    * Plate Armor
    * Shield
    * Sword/ Great Sword/ Lance/ Hammer/ Axe
  * Paladin
    * Plate Armor/ Templar Armor
    * Shield
    * Sword/ Hammer/ Axe
  * Cleric
    * Templar Armor
    * Shield
    * Hammer/ Staff
  * Wizard
    * Templar Armor/ Arcane Armor
    * Hammer/ Staff/ Dagger
  * Sorcerer
    * Arcane Armor
    * Hammer/ Staff/ Dagger
  * Bard
    * Arcane Armor/ Shadow Armor
    * Staff/ Dagger/ Bow
  * Thief
    * Shadow Armor
    * Staff/ Dagger
  * Assassin
    * Shadow Armor/ Agile Armor
    * Dagger/ Bow/ Sword
  * Ranger
    * Agile Armor
    * Dagger/ Bow/ Sword
  * Mercenary
    * Agile Armor/ Savage Armor
    * Dagger/ Bow/ Sword/ Great Sword
  * Barbarian
    * Savage Armor
    * Great Sword/ Hammer/ Axe
  * Champion
    * Savage Armor/ Plate Armor
    * Great Sword/ Sword/ Hammer/ Axe/ Lance

* Instead of each class having its own unique skill tree, the players can give their character skills from a univeral skill tree.
  * This allows for interesting builds like a Barbarian that can use magic skills.
  * Skills that "contradict" the character's class will cost more skill points to learn.  I.e., since the Barbarian isn't a natural magic user, the player will have to spend more skill points to make that build.
 
* Classes fall into three basic categories.  Note: there are some overlap.
  * Fighters: Knight, Paladin, Mercenary, Barbarian, and Champion
  * Mages: Paladin, Cleric, Wizard, Sorcerer, and Bard
  * Rogues: Bard, Thief, Assassin, Ranger, and Mercenary

* While all classes receive EXP from defeating enemies, the categories receive EXP bonuses from different achievements.
  * Fighters receive a bonus from combo chain attacks.  There's also a bonus for boss defeats.
  * Mages receive a bonus from defeating enemies using magic skills.  There's also a bonus for solving puzzles.
  * Rogues receive a bonus from using sneak attacks to one hit kill enemies.  There's also a bonus for finding treasures.

### Character Customization and Permadeath
* Players are able to create their own unique character.
  * The player can alter the physical appearance of the character at any time.
  * Upon creation, the player chooses the class the character utilizes.
 
* In the event that the character dies:
  * A new character must be created.
  * All skill points used to build the deceased character are lost permanently.
  * The cosmetic features and class of the deceased character are unavailable to give to the new character, forcing the player to try out a new build.
 
### Network Features
* Upon booting up the game, the player automatically begins hosting a lobby.  The lobby is set to the player's default lobby state (public, solo, or friends only).
* Players can choose to change their lobby's online presence, allowing any other players to join them or only their friends.
* Players can also search for other pubic lobbies or search directly for a friend's lobby to join.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Requirements

**Unity Hub**
**Unity Editor Version:** '6000.3.6f1' (or minimum recommended patch version)
**Target Platform:** 'Windows' (Requires the Windows Build Support module installed via Unity Hub)

### Installation

1. **Clone the repository:** 
'''bash
git clone https://github.com/3Dever96/ProjectRPG64.git
'''

2. **Open in Unity**
* Open **Unity Hub**.
* Click **"Add Project from Disk"**.
* Navigate to the cloned directory and select the root folder.
* Ensure the correct Unity Editor Version ('6000.3.6f1') is selected in the Hub and open the project.

3. **Run the Project:**
* Once the Editor loads, navigate to the primary scene file (usually in 'Assets/Scenes/').
* Press the **Play** button in the Unity Editor to begin.


## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create.  Any contributions you make are **greatly appreciated**.

* Please adhere to the **https://leotgo.github.io/unity-coding-standards/** before submitting code.

1. Fork the Project
2. Create your Feature Branch ('git checkout -b Feature/AmazingFeature')
3. Commit your Changes ('git commit -m 'Add some AmazaingFeature'')
4. Push to the Branch ('git push origin Feature/AmazingFeature')
5. Open a Pull Request

## License

This project is licensed under the MIT License- see the LICENSE file for details.

## Acknowledgments
