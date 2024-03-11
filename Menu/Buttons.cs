using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Disconect", method =() => Disconnect.DisconnectFromLobby(), toolTip = "Disconects you from the lobby"},
                new ButtonInfo { buttonText = "Speedboost [D]", method =() => SpeedBoostMODS.D_SpeedboostMOD(), toolTip = "Gives you a detected Speedboost"},
                new ButtonInfo { buttonText = "Lower speedboost [UN]", method =() => SpeedBoostMODS.UN_Speedboost(), toolTip = "Gives you a undetected Speedboost"},
                new ButtonInfo { buttonText = "Wierd Speedbost [KD]", method =() => SpeedBoostMODS.W_D_SpeedboostMOD(), toolTip = "Gives you a wierd speedboost"},
                new ButtonInfo { buttonText = "Reset Turn Speed [UN]", method =() => EXPI.resetturnspeed(), toolTip = "resets your snap/smooth turn"},
                new ButtonInfo { buttonText = "Fast Turn Speed [UN]", method =() => EXPI.FastTurnSpeed(), toolTip = "Gives you a fast turn speed"},
                new ButtonInfo { buttonText = "Quit GTAG [MD]", method =() => Disconnect.QUITGTAG(), toolTip = "Quit Gorilla tag"},
                new ButtonInfo { buttonText = "Car Monkey [D]", method =() => Cool.CarMonke(), toolTip = "Car!"},
                new ButtonInfo { buttonText = "Invis Monkey [D]", method =() => Cool.InvisMonke(), toolTip = "Go invisible!"},
                new ButtonInfo { buttonText = "Fly [D]", method =() => Movement.Fly(), toolTip = "Fly!"},
                new ButtonInfo { buttonText = "Left Hand Fly [D]", method =() => Movement.LeftFly(), toolTip = "Fly With your left hand!"},
                new ButtonInfo { buttonText = "Trigger Fly [D]", method =() => Movement.TriggerFly(), toolTip = "Fly With your Right Trigger hand!"},
                new ButtonInfo { buttonText = "Tp Gun [D]", method =() => Movement.TpGun(), toolTip = "Teleport Gun"},
                new ButtonInfo { buttonText = "Platforms [D]", method =() => Movement.Platforms(), toolTip = "Platforms"},
                new ButtonInfo { buttonText = "Ghost Monkey [UN]", method =() => Movement.GhostMonke(), toolTip = "Be a ghost"},
                new ButtonInfo { buttonText = "No Clip [UN&D]", method =() => Movement.NoClip(), toolTip = "go trugh objects"},
                new ButtonInfo { buttonText = "Tracers [UN]", method =() => EXPI.Tracersmod(), toolTip = "know where every ones at"},
                new ButtonInfo { buttonText = "Force Tag Freeze[]", method =() => Cool.ForceTagFreeze(), toolTip = "Tag freeze"},
                new ButtonInfo { buttonText = "No tag Freeze[]", method =() => Cool.NoTagFreeze(), toolTip = "No tag freeze"},
                new ButtonInfo { buttonText = "Reverse Gravity[]", method =() => Cool.ReverseGravity(), toolTip = "reverse gravity"},
                new ButtonInfo { buttonText = "Low Gravity", method =() => Cool.LowGravity(), toolTip = "Low gravity"},
                new ButtonInfo { buttonText = "Zero Gravity", method =() => Cool.ZeroGravity(), toolTip = "Zero gravity"},
                new ButtonInfo { buttonText = "Flip Character", method =() => Cool.FlipCharacter(), toolTip = "Flips your monke"},
                new ButtonInfo { buttonText = "High Gravity", method =() => Cool.HighGravity(), toolTip = "High Gravity"},
                new ButtonInfo { buttonText = "UnFlip Character", method =() => Cool.UnflipCharacter(), toolTip = "Unflips your monkey"},
                new ButtonInfo { buttonText = "Bug Gun", method =() => HEHEHE.BugGun(), toolTip = "Spawns a Bug"},
            },

            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
                new ButtonInfo { buttonText = "Projectile", method =() => SettingsMods.ProjectileSettings(), isTogglable = false, toolTip = "Opens the projectile settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },

            new ButtonInfo[] { // Projectile Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
            },
        };
    }
}
