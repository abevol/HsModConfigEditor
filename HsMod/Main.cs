using BepInEx;
using System;
using UnityEngine;
using static HsMod.PluginConfig;

namespace HsMod
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public Plugin()
        {
            AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;
        }

        private static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex.Message);
            }

            Application.Quit();
        }

        private void Awake()
        {
            ConfigBind(base.Config);
        }
    }
}