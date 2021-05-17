using System;

namespace Buckets.Models
{
    public sealed class RainBarrel : LiquidContainer
    {
        private RainBarrel(int capacity, int current, string type = "RainBarrel") : base(capacity, current, type) { }

        public static RainBarrel CreateDefault(int type = 1, int current = 0)
        {
            return type switch
            {
                0 => Create(80, current),
                1 => Create(100, current),
                2 => Create(120, current),
                _ => Create(100, current)
            };
        }

        private static RainBarrel Create(int capacity, int current)
        {
            return new RainBarrel(capacity, current);
        }
    }
}
