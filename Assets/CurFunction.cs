using UnityEngine;
using System.Collections;
using System;

namespace Assets
{
    public class CurFunction : IFunction<float, float>
    {
        public float Calc(float value)
        {
            float t = value;
            return 10 - t + 2 * t * t - 6 * t * t * t;
        }
    }
}
