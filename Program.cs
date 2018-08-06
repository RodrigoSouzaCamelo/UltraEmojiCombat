using System;

namespace UltraEmojiCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters = new Fighter[6];

            fighters[0] = new Fighter("Pretty Boy", "France", 31, 1.75f, 68.9f, 11, 2, 1);
            fighters[1] = new Fighter("Putscript", "Brazil", 29, 1.68f, 57.8f, 14, 2, 3);
            fighters[2] = new Fighter("Snapshadow", "USA", 35, 1.65f, 80.9f, 12, 2, 1);
            fighters[3] = new Fighter("Dead Code", "Australia", 29, 1.93f, 81.6f, 13, 0, 2);
            fighters[4] = new Fighter("UF0Cobol", "Brazil", 37, 1.70f, 119.3f, 5, 4, 3);
            fighters[5] = new Fighter("Nerdaart", "USA", 30, 1.81f, 105.7f, 12, 2, 4);
        }
    }
}
