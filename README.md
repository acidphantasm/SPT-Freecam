# Freecam

A BepInEx plugin for SPT-AKI that allows you to detach the camera and fly around freely in Escape From Tarkov.

### Controls

The default controls are as follows:
- Keypad Plus - toggle free camera mode
- Keypad Enter - teleport player to camera position
- Keypad Multiply - toggle UI

If you need to change them, press F12 in-game and expand the `Freecam #.#.#` section and configure your keybinds there.
Alternatively, you can find the `com.terkoiz.freecam.cfg` file in your `BepInEx/config/` folder after you've started up the game at least once with Freecam installed, and change the keybinds there.


### How to install

1. Download the latest release here: [link](https://dev.sp-tarkov.com/Terkoiz/Freecam/releases) -OR- build from source (instructions below)
2. Simply extract the zip file contents into your root SPT-AKI folder (where EscapeFromTarkov.exe is).
3. Your `BepInEx/plugins` folder should now contain a `Terkoiz.Freecam.dll` file inside.

### Known issues

1. When teleporting to camera position, the camera rotation gets copied exactly, potentially causing the player model to tilt
2. Game version UI element is not hidden when toggling UI
3. When flying to distant parts of the map in freecam mode, LODs are not triggered (these seem to follow the player)

### How to build from source

1. Download/clone this repository
2. Open your current SPT directory and copy all files from `\EscapeFromTarkov_Data\Managed` into this solution's `\References\EFT_Managed` folder.
3. Rebuild the project in the Release configuration.
4. Grab the `Terkoiz.Freecam.dll` file from the `bin/Release` folder and use it wherever. Refer to the "How to install" section if you need help here.