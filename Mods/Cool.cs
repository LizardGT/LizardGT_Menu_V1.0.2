using System;
using System.Collections.Generic;
using System.Text;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;
using UnityEngine;
using Photon.Pun;
using StupidTemplate.Menu;
using BepInEx;
using UnityEngine.InputSystem;
using System.Reflection;

namespace StupidTemplate.Mods
{
    internal class Cool
    {
        public static void CarMonke()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat >= 0.3f)
            {
                GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                if (ControllerInputPoller.instance.rightGrab)
                {
                    GorillaLocomotion.Player.Instance.transform.position -= GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 20f;
                }
            }
        }

        public static void InvisMonke()
        {
            if (ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = -180f;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset.x = 0f;
            }
        }

  

        public static void ForceTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = true;
        }

        public static void NoTagFreeze()
        {
            GorillaLocomotion.Player.Instance.disableMovement = false;
        }

        public static void LowGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (6.66f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void ZeroGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (9.81f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void HighGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.down * (Time.deltaTime * (6.66f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void ReverseGravity()
        {
            GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.AddForce(Vector3.up * (Time.deltaTime * (19.62f / Time.deltaTime)), ForceMode.Acceleration);
        }

        public static void FlipCharacter()
        {
            GorillaLocomotion.Player.Instance.transform.rotation = Quaternion.Euler(180f, 0f, 0f);
        }

        public static void UnflipCharacter()
        {
            GorillaLocomotion.Player.Instance.transform.rotation = Quaternion.identity;
        }
    }
}
