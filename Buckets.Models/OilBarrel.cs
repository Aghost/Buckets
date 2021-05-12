using System;

namespace Buckets.Models
{
    public sealed class OilBarrel : LiquidContainer
    {
        private OilBarrel(int capacity, int current, string type = "OilBarrel") : base(capacity, current, type) { }

        public static OilBarrel CreateDefault(int current = 0)
        {
            return new OilBarrel(159, current);
        }
    }
}
