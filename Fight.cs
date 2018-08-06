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

        public void MarkFight(Fighter fighterOne, Fighter fighterTwo)
        {
            if (fighterOne.Category.Equals(fighterTwo.Category))
            {
                this.approved = true;
                this.challenged = fighterOne;
                this.challenger = fighterTwo;
            }
            else
            {
                this.approved = false;
                this.challenged = null;
                this.challenger = null;
            }
        }

        public void ToFight()
        {
            if (this.approved)
            {
                Console.WriteLine("### Challenged ###");
                this.challenged.Introduce();
                Console.WriteLine("### Challenger ###");
                this.challenger.Introduce();

                Random random = new Random();
                int winner = random.Next(0,3);
                switch(winner){
                    case 0:
                        Console.WriteLine("Drew!");
                        this.challenged.DrawFight();
                        this.challenger.DrawFight();
                    break;
                    
                    case 1:
                        Console.WriteLine(this.challenged + "'s victory");
                        this.challenged.WinFight();
                        this.challenger.LoseFight();
                    break;

                    case 2:
                        Console.WriteLine(this.challenger + "'s victory");
                        this.challenged.LoseFight();
                        this.challenger.WinFight();
                    break;
                }
            }
            else
            {
                Console.WriteLine("The fight can't happen");
            }
        }
    }
}