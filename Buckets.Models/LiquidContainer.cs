using System;

namespace Buckets.Models
{
    public abstract class LiquidContainer
    {
        public readonly int Capacity;
        public int Current;
        public string Type;

        protected LiquidContainer(int capacity, int current, string type = "Container") {
            if (current < 0) {
                throw new ArgumentOutOfRangeException("current", "current below 0");
            }

            if (current > capacity) {
                throw new ArgumentOutOfRangeException("current", "current above max");
            }

            Capacity = capacity;
            Current = current;
            Type = type;
        }

        public bool Fill(int amount) {
            if ((amount + Current) > Capacity) {
                Console.WriteLine($"{Type} overflown! {Current} + {amount} > {Capacity} by this much: {(amount + Current) % Capacity} (cur:{Current}/cap:{Capacity})");

                if (OverflowAction(amount + Current - Capacity) == true) {
                    Current = Capacity;
                    Console.WriteLine($"ifif: added {amount} to {Type}, capacity at {Current}/{Capacity}");
                } else {
                    Console.WriteLine("cancelled...");
                    return false;
                }
            } else {
                Current += amount;
                Console.WriteLine($"ifelse: added {amount} to {Type}, capacity at {Current}/{Capacity}");
            }

            return true;
        }

        public void Fill(int amount, LiquidContainer container) {
            if ((Current - amount) < 1) {
                Console.WriteLine($"Not enough left({amount}) in {Type}({Current}) to fill {container.Type}({container.Current})");
            } else {
                if (container.Fill(amount)) {
                    Console.WriteLine($"{amount} added to {Type}{Current}");
                    Current -= amount;
                }
            }
        }

        private bool OverflowAction(int amount) {
            Console.WriteLine($"overflow action, amount: {amount}, what do you want to do?(proceed/cancel)");
            return Console.ReadLine() switch {
                "proceed" => true,
                "cancel" => false,
                _ => false 
            };
        }

        public void Empty() {
            Current = 0;
        }

        public void GetStats() {
            Console.WriteLine($"type: {Type}, current: {Current}, cap: {Capacity}");
        }
    }
}
