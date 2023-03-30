﻿namespace BookProjet.Data
{
    public class PositionOptions
    {
        public bool EnableHighAccuracy { get; set; } = false;
        public int Timeout { get; set; }
        public int MaximumAge { get; set; } = 0;
    }
}
