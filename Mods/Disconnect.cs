using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.Device;

namespace StupidTemplate.Mods
{
    internal class Disconnect
    {
        public static void DisconnectFromLobby()
        {
            PhotonNetwork.Disconnect();
        }

        public static void QUITGTAG()
        {
           Application.Quit();
        }
    }
}
