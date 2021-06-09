using UnityEngine;

namespace Straitjacket
{
    public static class Math
    {
        /// <summary>
        /// Rounds a given <paramref name="num"/> to the nearest <paramref name="factor"/>.
        /// </summary>
        /// <remarks>
        /// <para>Formula: y = f[x/f] where:</para>
        /// <para>
        /// f = the rounding factor (<paramref name="factor"/>)<br/>
        /// y = dependent variable (<see langword="return"/>)<br/>
        /// x = independent variable (<paramref name="num"/>)
        /// </para>
        /// <para>[] indicates rounding the expression to the nearest whole number, using <see cref="Mathf.Round"/>.</para>
        /// </remarks>
        /// <param name="num">The number to be rounded.</param>
        /// <param name="factor">The rounding factor.</param>
        /// <returns><paramref name="num"/> rounded to the nearest <paramref name="factor"/>.</returns>
        /// <example>
        /// <code>
        /// float x = 1.1345f;
        /// float f = 0.2f;
        /// float y = x.RoundToNearest(f);
        /// System.Console.WriteLine(y); // outputs "1.2"
        /// </code>
        /// </example>
        /// <seealso cref="FloorToNearest(float, float)"/>
        /// <seealso cref="RoundToNearest(double, double)"/>
        public static float RoundToNearest(this float num, float factor) => factor * Mathf.Round(num / factor);

        /// <summary>
        /// Rounds a given <paramref name="num"/> to the nearest <paramref name="factor"/>.
        /// </summary>
        /// <remarks>
        /// <para>Formula: y = f[x/f] where:</para>
        /// <para>
        /// f = the rounding factor (<paramref name="factor"/>)<br/>
        /// y = dependent variable (<see langword="return"/>)<br/>
        /// x = independent variable (<paramref name="num"/>)
        /// </para>
        /// <para>[] indicates rounding the expression to the nearest whole number, using <see cref="System.Math.Round(double)"/>.</para>
        /// </remarks>
        /// <param name="num">The number to be rounded.</param>
        /// <param name="factor">The rounding factor.</param>
        /// <returns><paramref name="num"/> rounded to the nearest <paramref name="factor"/>.</returns>
        /// <example>
        /// <code>
        /// double x = 1.1345;
        /// double f = 0.2;
        /// double y = x.RoundToNearest(f);
        /// System.Console.WriteLine(y); // outputs "1.2"
        /// </code>
        /// </example>
        /// <seealso cref="FloorToNearest(double, double)"/>
        /// <seealso cref="RoundToNearest(float, float)"/>
        public static double RoundToNearest(this double num, double factor) => factor * System.Math.Round(num / factor);

        /// <summary>
        /// Floors a given <paramref name="num"/> to the nearest <paramref name="factor"/>.
        /// </summary>
        /// <remarks>
        /// <para>Formula: y = f⌊(x/f)⌋ where:</para>
        /// <para>
        /// f = the rounding factor (<paramref name="factor"/>)<br/>
        /// y = dependent variable (<see langword="return"/>)<br/>
        /// x = independent variable (<paramref name="num"/>)
        /// </para>
        /// <para>⌊⌋ indicates flooring the expression to a whole number, using <see cref="Mathf.Floor"/>.</para>
        /// </remarks>
        /// <param name="num">The number to be floored.</param>
        /// <param name="factor">The flooring factor.</param>
        /// <returns><paramref name="num"/> floored to the nearest <paramref name="factor"/>.</returns>
        /// <example>
        /// <code>
        /// float x = 1.1345f;
        /// float f = 0.2f;
        /// float y = x.FloorToNearest(f);
        /// System.Console.WriteLine(y); // outputs "1.1"
        /// </code>
        /// </example>
        /// <seealso cref="RoundToNearest(float, float)"/>
        /// <seealso cref="FloorToNearest(double, double)"/>
        public static float FloorToNearest(this float num, float factor) => factor * Mathf.Floor(num / factor);

        /// <summary>
        /// Floors a given <paramref name="num"/> to the nearest <paramref name="factor"/>.
        /// </summary>
        /// <remarks>
        /// <para>Formula: y = f⌊(x/f)⌋ where:</para>
        /// <para>
        /// f = the rounding factor (<paramref name="factor"/>)<br/>
        /// y = dependent variable (<see langword="return"/>)<br/>
        /// x = independent variable (<paramref name="num"/>)
        /// </para>
        /// <para>⌊⌋ indicates flooring the expression to a whole number, using <see cref="System.Math.Floor(double)"/>.</para>
        /// </remarks>
        /// <param name="num">The number to be floored.</param>
        /// <param name="factor">The flooring factor.</param>
        /// <returns><paramref name="num"/> floored to the nearest <paramref name="factor"/>.</returns>
        /// <example>
        /// <code>
        /// float x = 1.1345f;
        /// float f = 0.2f;
        /// float y = x.FloorToNearest(f);
        /// System.Console.WriteLine(y); // outputs "1.1"
        /// </code>
        /// </example>
        /// <seealso cref="RoundToNearest(double, double)"/>
        /// <seealso cref="FloorToNearest(float, float)"/>
        public static double FloorToNearest(this double num, double factor) => factor * System.Math.Floor(num / factor);

        /// <summary>
        /// Maps a given <paramref name="input"/> from the range [<paramref name="inputFrom"/>, <paramref name="inputTo"/>]
        /// to the range [<paramref name="outputFrom"/>, <paramref name="outputTo"/>].
        /// </summary>
        /// <remarks>
        /// <para>
        /// Uses <see cref="Mathf.InverseLerp(float, float, float)"/> to calculate the delta t,
        /// and <see cref="Mathf.Lerp(float, float, float)"/> to calculate the mapped output variable with the delta t.
        /// </para>
        /// </remarks>
        /// <param name="input">The number to be mapped to the new range.</param>
        /// <param name="inputFrom">The start of the inclusive range to map from.</param>
        /// <param name="inputTo">The end of the inclusive range to map from.</param>
        /// <param name="outputFrom">The start of the inclusive range to map to.</param>
        /// <param name="outputTo">The end of the inclusive range to map to.</param>
        /// <returns>
        /// <paramref name="input"/> mapped from the range
        /// [<paramref name="inputFrom"/>, <paramref name="inputTo"/>] to the range
        /// [<paramref name="outputFrom"/>, <paramref name="outputTo"/>].
        /// </returns>
        /// <seealso cref="Map(double, double, double, double, double)"/>
        public static float Map(this float input,
                                float inputFrom, float inputTo,
                                float outputFrom, float outputTo)
        {   // just use Unity's built-in functions, potentially more optimised (probably not though)
            float delta = Mathf.InverseLerp(inputFrom, inputTo, input);
            return Mathf.Lerp(outputFrom, outputTo, delta);
        }

        /// <summary>
        /// Maps a given <paramref name="input"/> from the range [<paramref name="inputFrom"/>, <paramref name="inputTo"/>]
        /// to the range [<paramref name="outputFrom"/>, <paramref name="outputTo"/>].
        /// </summary>
        /// <remarks>
        /// <para>Formula: y = mx + c where:</para>
        /// <para>
        /// m = slope of the line (ratio of range2 / range1)<br/>
        /// c = the point where y intercepts the line (difference between range 2 and range 1 start/end, multiplied by the slope)<br/>
        /// y = dependent (output) variable<br/>
        /// x = independent (input) variable
        /// </para>
        /// </remarks>
        /// <param name="input">The number to be mapped to the new range.</param>
        /// <param name="inputFrom">The start of the inclusive range to map from.</param>
        /// <param name="inputTo">The end of the inclusive range to map from.</param>
        /// <param name="outputFrom">The start of the inclusive range to map to.</param>
        /// <param name="outputTo">The end of the inclusive range to map to.</param>
        /// <returns>
        /// <paramref name="input"/> mapped from the range
        /// [<paramref name="inputFrom"/>, <paramref name="inputTo"/>] to the range
        /// [<paramref name="outputFrom"/>, <paramref name="outputTo"/>].
        /// </returns>
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
