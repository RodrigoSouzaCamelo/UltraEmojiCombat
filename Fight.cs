using System;

namespace UltraEmojiCombat
{
    public class Fight
    {
        private Fighter challenged;
        private Fighter challenger;
        private int rounds;
        private bool approved;

        public Fighter Challenged { get => challenged; set => challenged = value; }
        public Fighter Challenger { get => challenger; set => challenger = value; }
        public int Rounds { get => rounds; set => rounds = value; }
        public bool Approved { get => approved; set => approved = value; }
    }
}