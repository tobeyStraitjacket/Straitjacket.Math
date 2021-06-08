using UnityEngine;

namespace Straitjacket
{
    public static class Math
    {
        public static float RoundToNearest(this float num, float factor) => factor * Mathf.Round(num / factor);
        public static double RoundToNearest(this double num, double factor) => factor * System.Math.Round(num / factor);

        public static float FloorToNearest(this float num, float factor) => factor * Mathf.Floor(num / factor);
        public static double FloorToNearest(this double num, double factor) => factor * System.Math.Floor(num / factor);
    }
}
