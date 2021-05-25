using UnityEngine;

namespace Straitjacket
{
    public static class Math
    {
        public static float RoundToNearest(float x, float y) => y * Mathf.Round(x / y);
        public static double RoundToNearest(double x, double y) => y * System.Math.Round(x / y);

        public static float FloorToNearest(float x, float y) => y * Mathf.Floor(x / y);
        public static double FloorToNearest(double x, double y) => y * System.Math.Floor(x / y);
    }
}
