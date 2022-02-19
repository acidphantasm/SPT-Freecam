using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace Terkoiz.Freecam
{
    [BepInPlugin("com.terkoiz.freecam", "Terkoiz.Freecam", "1.1.0")]
    public class FreecamPlugin : BaseUnityPlugin
    {
        private static GameObject HookObject;

        // Keyboard shortcut config entries
        private const string KeybindSectionName = "Keybinds";
        internal static ConfigEntry<KeyboardShortcut> ToggleFreecamMode;
        internal static ConfigEntry<KeyboardShortcut> TeleportToCamera;
        internal static ConfigEntry<KeyboardShortcut> ToggleUi;

        // Camera settings config entries
        private const string CameraSettingsSectionName = "CameraSettings";
        internal static ConfigEntry<float> CameraMoveSpeed;
        internal static ConfigEntry<float> CameraFastMoveSpeed;
        internal static ConfigEntry<float> CameraLookSensitivity;
        internal static ConfigEntry<float> CameraZoomSpeed;
        internal static ConfigEntry<float> CameraFastZoomSpeed;

        private void Awake()
        {
            Logger.LogError("Loading Freecam...");

            InitConfiguration();

            HookObject = new GameObject();
            HookObject.AddComponent<FreecamController>();
            Object.DontDestroyOnLoad(HookObject);
        }

        private void InitConfiguration()
        {
            ToggleFreecamMode = Config.Bind(
                KeybindSectionName,
                "ToggleCamera",
                new KeyboardShortcut(KeyCode.KeypadPlus),
                "The keyboard shortcut that toggles Freecam");

            TeleportToCamera = Config.Bind(
                KeybindSectionName,
                "TeleportToCamera",
                new KeyboardShortcut(KeyCode.KeypadEnter),
                "The keyboard shortcut that teleports the player to camera position");

            ToggleUi = Config.Bind(
                KeybindSectionName,
                "ToggleUi",
                new KeyboardShortcut(KeyCode.KeypadMultiply),
                "The keyboard shortcut that toggles the game UI");

            CameraMoveSpeed = Config.Bind(
                CameraSettingsSectionName,
                "CameraMoveSpeed",
                10f,
                new ConfigDescription(
                    "The speed at which the camera will move normally",
                    new AcceptableValueRange<float>(0.01f, 100f)));

            CameraFastMoveSpeed = Config.Bind(
                CameraSettingsSectionName,
                "CameraFastMoveSpeed",
                100f,
                new ConfigDescription(
                    "The speed at which the camera will move when the Shift key is held down",
                    new AcceptableValueRange<float>(0.01f, 1000f)));

            CameraLookSensitivity = Config.Bind(
                CameraSettingsSectionName,
                "CameraLookSensitivity",
                3f,
                new ConfigDescription(
                    "Camera free look mouse sensitivity",
                    new AcceptableValueRange<float>(0.1f, 10f)));

            CameraZoomSpeed = Config.Bind(
                CameraSettingsSectionName,
                "CameraMousewheelZoomSpeed",
                10f,
                new ConfigDescription(
                    "Amount to zoom the camera when using the mouse wheel",
                    new AcceptableValueRange<float>(0.01f, 100f)));

            CameraFastZoomSpeed = Config.Bind(
                CameraSettingsSectionName,
                "CameraMousewheelFastZoomSpeed",
                50f,
                new ConfigDescription(
                    "Amount to zoom the camera when using the mouse wheel while holding Shift",
                    new AcceptableValueRange<float>(0.01f, 1000f)));
        }
    }
}
