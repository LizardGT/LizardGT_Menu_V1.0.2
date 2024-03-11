using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.XR.Interaction.Toolkit;

namespace StupidTemplate.Mods
{
    internal class SpeedBoostMODS
    {

        public static void D_SpeedboostMOD() //-BOX
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 13f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 13f;//-things inside the box
        }

        public static void UN_Speedboost()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 9f;
        }

        public static void W_D_SpeedboostMOD()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 10f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 15f;
        }
    }
}
