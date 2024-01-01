using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace NoSnowballs.Patches
{
    [HarmonyPatch(typeof(SnowballThrowable), "EnableSnowballLocal")]
    internal class SnowballPatch : MonoBehaviour
    {
        public static bool Prefix(SnowballThrowable __instance)
        {
            Debug.Log("Blocked Snowball");
            return false;
        }
    }
}
