using System;
using Buckets.Models;
using static System.Console;

namespace Buckets
{
    class Program
    {
        static void Main(string[] args)
        {
            Bucket bucket = Bucket.CreateDefault();
            bucket.GetStats();
            bucket.Fill(18);
            bucket.GetStats();
            bucket.Empty();
            bucket.GetStats();
            //test123();
        }

        static void test123() {
            Bucket bucket = Bucket.CreateDefault(12);
            bucket.Fill(18);
            bucket.Empty();

            RainBarrel rainbarrel = RainBarrel.CreateDefault();
            rainbarrel.Fill(101);

            RainBarrel rainbarrel2 = RainBarrel.CreateDefault(2);
            rainbarrel2.Fill(33);

            OilBarrel oilbarrel = OilBarrel.CreateDefault(20);
            oilbarrel.Fill(33);

            oilbarrel.Fill(32, bucket);
        }
    }
}
