# StarAlliesRandomizer
A randomizer tool for Kirby Star Allies.

## Features
* Patching the game's Step.bin Mint binary with custom code
* Numeric and text RNG seeds
* Randomizing Copy Abilities
  * Randomizing each individual Enemy, Mid-Boss, Boss, inhale-able Enemy objects, and Recoil/Drop Stars
    * Recoil/Drop Stars adopt the correct color corresponding to their Copy Ability
  * Giving Kirby a random Copy Ability whenever he eats anything
  * Giving Kirby Mix whenever he eats anything
  * Including Dream Friends in the randomization is included as an option, but is not recommended due to Gooey and Daroach crashing the game instantly if copied through Inhale.
  * Copy Ability Element randomization can also be enabled.
* Randomizing Helpers
* Randomizing Attack damage

## Planned Features
* Kirby color randomization
* Randomizing the rest of the inhale-able Enermy objects
* Attack element, launch angle, knockback, and multi-hit frames
* Level layout, tileset, background, and order randomization

## Usage
1. Dump the version 4.0.0 RomFS of Kirby Star Allies. Yuzu or the [nxdumptool](https://github.com/DarkMatterCore/nxdumptool/releases/tag/v1.1.14) homebrew application are the easiest ways to do so.
2. Launch the program and either click the elipses (...) button to select the RomFS folder or enter the path manually. This folder must contain `gfx`, `map`, and `mint`.
This directory is saved in `Config.xml` when the program exits and is automatically loaded when the program opens.
3. Mess with the program's options and click the `Randomize` button at the bottom of the program. This will take a small bit of time to complete.
When this has completed, the files are outputted to `OutFiles\seed_<seed>`, already formatted for use with LayeredFS with Atmosphère, Yuzu, or Ryujinx.

Seeds can be full numbers from 0 to 4,294,967,295, hexadecimal numbers from 0 to FFFFFFF or text strings such as "Super_Mario 64".

For information about the randomizer options, hover over one for a brief description.
