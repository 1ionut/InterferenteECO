using System;
using System.Collections.Generic;
using System.Drawing;

namespace Inteferente_ECO
{
    static class Context
    {
        public static string ResourcesPath = "./Resources/";
        public static int CellSizeX;
        public static int CellSizeY;

        public static Entity[,] Entities;
        public static Color[,] ColorPath;
        public static int TotalCollectibleCount = 0;

        public static string Direction = string.Empty;
        public static int RobotLine;
        public static int RobotColumn;

        public static int DeflectorIncrement = 0;
        public static bool PlacingDeflector = false;
        public static int PlacementLine = 0;
        public static int PlacementColumn = 0;

        public static Dictionary<string, int> Collectibles = new Dictionary<string, int>()
        {
            {"Sticla" , 0},
            {"Plastic" , 0},
            {"Hartie" , 0}
        };

        public static readonly HashSet<string> MarineLifeNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "Meduza1",
            "Meduza2",
            "Meduza3",
            "Meduza4"
        };

        public static readonly Dictionary<string, (int dRow, int dCol)> DirectionVectors = new Dictionary<string, (int, int)>
        {
            { "Up",    (-1, 0) },
            { "Down",  ( 1, 0) },
            { "Left",  ( 0,-1) },
            { "Right", ( 0, 1) },
        };

        public static readonly Dictionary<(string Direction, int Action), string> DeflectorRedirects = new Dictionary<(string, int), string>
        {
            { ("Up", 0), "Right" },
            { ("Up", 1), "Left" },
            { ("Down", 2), "Left" },
            { ("Down", 3), "Right" },
            { ("Left", 0), "Down" },
            { ("Left", 3), "Up" },
            { ("Right", 1), "Down" },
            { ("Right", 2), "Up" },
        };

        public static void ResetState()
        {
            Entities = null;
            ColorPath = null;
            TotalCollectibleCount = 0;
            Direction = string.Empty;

            Collectibles["Sticla"] = 0;
            Collectibles["Plastic"] = 0;
            Collectibles["Hartie"] = 0;

            PlacingDeflector = false;
            DeflectorIncrement = 0;
        }
    }
}