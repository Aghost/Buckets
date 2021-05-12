using System;

namespace Buckets.Models
{
    public sealed class Bucket : LiquidContainer
    {
        private static int Max_Capacity = 12;
        private static readonly int Min_Capacity = 10;

        private Bucket(int capacity, int current, string type= "bucket") : base(capacity, current, type) { }

        // Default bucket should have a capacity of 12
        public static Bucket CreateDefault(int current = 0)
        {
            return Create(Max_Capacity, current);
        }

        private static Bucket Create(int capacity, int current)
        {
            if (capacity < Min_Capacity)
            {
                throw new ArgumentOutOfRangeException("max", $"bucket minimum: {Min_Capacity}");
            }

            return new Bucket(capacity, current);
        }
    }
}
