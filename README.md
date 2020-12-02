# NpcProtector

Synthesis Patcher to flag named Skyrim NPCs as protected

## Inspiration

This patcher was inspired by [Protect your People - PyP - Better NPC Protection SE](https://www.nexusmods.com/skyrimspecialedition/mods/10297) it flags the same NPCs as protected as the Legacy version of this mod, I might add Cutting Room Floor NPCs in the future, but I don't use that mod myself.

## How it works

The patcher has a simple list of EditorIDs of all named NPCs that should be flagged as protected.
During patching, it goes through all NPCs and checks if they are in the list and if they are not already flagged as essential or protected, then it copies the record and adds the protected flag to the NPC.

## Expansion

If you want to add NPCs, you have to add them to the source code at the moment, in the future, I hope to extract them to a separate file that users can easily modify, that is if I can be bothered since I am lazy.
