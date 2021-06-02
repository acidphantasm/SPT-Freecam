# Freecam

An SPT-AKI modules mod that allows you to detach the camera and fly around freely in Escape From Tarkov.

### Controls

For now, the keybinds are non-configurable (unless you change it in code and build from source).
- Keypad Plus - toggle free camera mode
- Keypad Enter - teleport player to camera position
- Keypad Multiply - toggle UI

### How to install

1. Download the latest release here: [link](https://dev.sp-tarkov.com/Terkoiz/Freecam/releases) -OR- build from source (instructions below)
2. Simply drop the folder `Terkoiz-Freecam` into your SPT-AKI `user/mods/` directory.

### Known issues

1. Your weapon doesn't turn invisible when you enter freecam mode
2. When teleporting to camera position, the camera rotation gets copied exactly, potentially causing the player model to tilt
3. Game version UI element is not hidden when toggling UI
4. None of the camera settings (speed, senstivity, etc.) are user-configurable
5. When flying to distant parts of the map in freecam mode, LODs are not triggered (these seem to follow the player)

### How to build from source

1. Download/clone this repository
2. Download/clone the `SPT-AKI/Modules` repository: [link](https://dev.sp-tarkov.com/SPT-AKI/Modules)
3. Move the contents of the `project` folder over to the SPT-AKI Modules `project` folder
4. Add the `Terkoiz.Freecam` project to the SPT-AKI Modules solution
5. Build modules - `Terkoiz.Freecam.dll` should appear under `Build/EscapeFromTarkov_Data/Managed` in the SPT-AKI Modules directory
6. Copy the .dll into the `mod/Terkoiz-Freecam` folder and rename to `modules.dll`
7. That's it, you have a working release of this mod! Follow the `How to install` instructions on how to get the mod into your game