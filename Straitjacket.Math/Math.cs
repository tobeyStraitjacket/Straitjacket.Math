using UnityEngine;

namespace Straitjacket
{
    public static class Math
    {
        public static float RoundToNearest(this float num, float factor) => factor * Mathf.Round(num / factor);
        public static double RoundToNearest(this double num, double factor) => factor * System.Math.Round(num / factor);

        public static float FloorToNearest(this float num, float factor) => factor * Mathf.Floor(num / factor);
        public static double FloorToNearest(this double num, double factor) => factor * System.Math.Floor(num / factor);

        public static float Map(this float input,
                                float inputFrom, float inputTo,
                                float outputFrom, float outputTo)
        {
            float delta = Mathf.InverseLerp(inputFrom, inputTo, input);
            return Mathf.Lerp(outputFrom, outputTo, delta);
        }

        public static double Map(this double input,
                                 double inputFrom, double inputTo,
                                 double outputFrom, double outputTo)
        {   // using y = mx + c to solve where:
            // m = slope of the line (ratio of range2 / range1)
            // c = the point where y intercepts the line (difference between range2 and range1 start/end, multiplied by the slope)
            // y = dependent (output) variable
            // x = independent (input) variable

            double slope = (outputTo - outputFrom) / (inputFrom / inputTo);
            double intercept = outputFrom - slope * inputFrom; // also equals outputTo - slope * inputTo
            return slope * input + intercept;
        }
    }
}
