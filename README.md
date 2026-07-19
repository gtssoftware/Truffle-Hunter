this game is made by GTS, COOLKIT, and CBASS

This game is intended to be the first steam game from GTS that would use a proprietary engine. most of this game is experimental.

so the engine itself, popcorn uses package files, like what you would see in Spore from EA. but these package files are different though ; they contain unencrypted, compressed data seperated by metadata. 
and the package files are read in alphabetical order, and usually you want the core engine parts read first. so with the compiled data, it would be ordered something like this :
assets/
a_engine1.package
a_engine2.package
b_scripts1.package
b_scripts2.package
c_binkscenes.package
c_sprites.package
c_sound.package

with the package files, they contain hundreds of different files, archived into one. you can think of it as a renamed zip file almost. 
when the executable runs, it basically turns all these files into a temporary filesystem. at runtime the executable uses C++, but the general game code is Lua.
Story:
In the land of Gleegon, lived the Oodas, bipedal sentient creatures with no arms. 
they were ruled by Jubba and Lubba, who lived in the very top of the Gleegon Citadel. 
these creatures only ate truffles. and they worshipped a sapphire truffle that allowed them to connect with the gods. 
one day pirate Oodas conquered the main island of Gleegon. they took over the tower and gaurded every floor with enslaved creatures. 
they stole the truffle supply, and took their sapphire truffle. as jubba you must climb every floor of the tower and fight off every beast, where at the very top you will duel with the captain, Zubba, over the truffle supply.
