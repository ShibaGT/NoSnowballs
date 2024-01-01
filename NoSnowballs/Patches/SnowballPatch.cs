using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoSnowballs.Patches
{
    /// <summary>
    /// This is an example patch, made to demonstrate how to use Harmony. You should remove it if it is not used.
    /// </summary>
    [HarmonyPatch(typeof(SnowballMaker))]
    [HarmonyPatch("LateUpdate", MethodType.Normal)]
    internal class SnowballPatch
    {
        private static bool Postfix()
        {
            return false;
        }
    }
}
