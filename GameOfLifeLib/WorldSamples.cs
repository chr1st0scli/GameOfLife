using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLifeLib
{
    /// <summary>
    /// Sets the world to some of well known patterns.
    /// The world should be first initialized.
    /// If the world is not big enough for a pattern, an IndexOutOfRangeException is thrown.
    /// </summary>
    public static class WorldSamples
    {
        public static void StillLife()
        {
            var arr = new[] 
            {
                (3, 6), (3, 7), (4, 6), (4, 7), (5, 2), (5, 3), (6, 1), (6, 4), (6, 11), (7, 2), (7, 3), (7, 10),
                (7, 12), (8, 10), (8, 13), (9, 6), (9, 7), (9, 11), (9, 12), (10, 1), (10, 2), (10, 6), (10, 8),
                (11, 1), (11, 2), (11, 7), (12, 14), (13, 13), (13, 15), (14, 3), (14, 4), (14, 9), (14, 14),
                (14, 15), (15, 2), (15, 5), (15, 8), (15, 10), (16, 3), (16, 5), (16, 8), (16, 10), (17, 4), (17, 9)
            };
            FillWorld(arr);
        }

        public static void Blinker()
        {
            var arr = new[] { (1, 2), (2, 2), (3, 2) };
            FillWorld(arr);
        }

        public static void KoksGalaxy()
        {
            var arr = new[]
            {
                (5, 4), (5, 5), (5, 6), (5, 7), (5, 8), (5, 9), (5, 11), (5, 12), (6, 4), (6, 5), (6, 6), (6, 7),
                (6, 8), (6, 9), (6, 11), (6, 12), (7, 11), (7, 12), (8, 4), (8, 5), (8, 11), (8, 12), (9, 4),
                (9, 5), (9, 11), (9, 12), (10, 4), (10, 5), (10, 11), (10, 12), (11, 4), (11, 5), (12, 4), (12, 5),
                (12, 7), (12, 8), (12, 9), (12, 10), (12, 11), (12, 12), (13, 4), (13, 5), (13, 7), (13, 8), (13, 9),
                (13, 10), (13, 11), (13, 12)
            };
            FillWorld(arr);
        }

        public static void Glider()
        {
            var arr = new[] { (1, 3), (2, 1), (2, 3), (3, 2), (3, 3) };
            FillWorld(arr);
        }

        public static void LightweightSpaceship()
        {
            var arr = new[] { (1, 4), (1, 6), (2, 3), (3, 3), (4, 3), (4, 6), (5, 3), (5, 4), (5, 5) };
            FillWorld(arr);
        }

        public static void SmallExploder()
        {
            var arr = new[] { (11, 8), (11, 9), (12, 7), (12, 8), (12, 10), (13, 8), (13, 9) };
            FillWorld(arr);
        }

        public static void Exploder()
        {
            var arr = new[] { (11, 7), (11, 8), (11, 9), (11, 10), (11, 11), (13, 7), (13, 11), (15, 7), (15, 8), (15, 9), (15, 10), (15, 11) };
            FillWorld(arr);
        }

        public static void TenCellRow()
        {
            var arr = new[] { (11, 9), (12, 9), (13, 9), (14, 9), (15, 9), (16, 9), (17, 9), (18, 9), (19, 9), (20, 9) };
            FillWorld(arr);
        }

        public static void GosperGliderGun()
        {
            var arr = new[]
            {
                (3, 6), (3, 7), (4, 6), (4, 7), (11, 7), (11, 8), (12, 6), (12, 8), (13, 6), (13, 7), (19, 8),
                (19, 9), (19, 10), (20, 8), (21, 9), (25, 5), (25, 6), (26, 4), (26, 6), (27, 4), (27, 5), (27, 16),
                (27, 17), (28, 16), (28, 18), (29, 16), (37, 4), (37, 5), (38, 4), (38, 5), (38, 11), (38, 12),
                (38, 13), (39, 11), (40, 12)
            };
            FillWorld(arr);
        }

        static void FillWorld((int, int)[] arr)
        {
            World w = World.GetWorld();
            foreach (var el in arr)
                w[el.Item1, el.Item2] = true;
        }
    }
}
