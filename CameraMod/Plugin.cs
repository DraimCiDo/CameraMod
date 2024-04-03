using BepInEx;
using BepInEx.Logging;
using CameraMod.Paches;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class CameraModBase : BaseUnityPlugin
    {
        private const string modGUID = "DraimGooSe.CameraMod";
        private const string modName = "Camera Mod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static CameraModBase Instance;

        internal ManualLogSource mls; // Логирование

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Мод CameraMod успешно запущен.");
            
            harmony.PatchAll(typeof(CameraModBase));
            harmony.PatchAll(typeof(PlayerControllerBPatch));
        }
    }
}
