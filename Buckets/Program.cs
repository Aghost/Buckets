using System;
using Buckets.Models;
using static Buckets.Models.Bucket;
using static System.Console;

namespace Buckets
{
    class Program
    {
        static void Main(string[] args)
        {
            Bucket bucket = Bucket.CreateDefault(12);
            bucket.GetStats();
            bucket.Fill(18);
            bucket.GetStats();
            bucket.Empty();
            bucket.GetStats();

            RainBarrel rainbarrel = RainBarrel.CreateDefault();
            rainbarrel.GetStats();
            rainbarrel.Fill(101);
            rainbarrel.GetStats();

            RainBarrel rainbarrel2 = RainBarrel.CreateDefault(2);
            rainbarrel2.GetStats();
            rainbarrel2.Fill(33);
            rainbarrel2.GetStats();

            OilBarrel oilbarrel = OilBarrel.CreateDefault(20);
            oilbarrel.GetStats();
            oilbarrel.Fill(33);
            oilbarrel.GetStats();

            oilbarrel.Fill(32, bucket);
        }
    }
}
