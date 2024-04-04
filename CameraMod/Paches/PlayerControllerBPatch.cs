using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMod.Paches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]

        static void modifyspeedmovementPatch(ref float ___climbSpeed, ref float ___sprintMeter, ref float ___sprintMultiplier)
        {
            ___climbSpeed = 10f;
            ___sprintMeter = 1f;
            ___sprintMultiplier = 3f;

        }

    }
}
