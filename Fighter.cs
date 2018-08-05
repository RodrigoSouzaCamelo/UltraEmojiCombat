using System;

namespace UltraEmojiCombat
{
    public class Fighter
    {
        private string name;
        private string nationality;
        private int age;
        private float height;
        private float weight;
        private string category;
        private int victories;
        private int defeats;
        private int draws;

        public string Name { get => name; set => name = value; }
        public string Nationality { get => nationality; set => nationality = value; }
        public int Age { get => age; set => age = value; }
        public float Height { get => height; set => height = value; }
        public float Weight { get => weight; set => weight = value; }
        private string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (this.weight < 52.2)
                    this.category = "Invalid";

                else if (this.weight <= 70.3)
                    this.category = "Light Weight";

                else if (this.weight <= 83.9)
                    this.category = "Middle Weight";

                else if (this.weight <= 120.2)
                    this.category = "Heavy Weight";

                else
                    this.category = "Invalid";
            }
        }
        public int Victories { get => victories; set => victories = value; }
        public int Defeats { get => defeats; set => defeats = value; }
        public int Draws { get => draws; set => draws = value; }

        public void Introduce()
        {
            Console.WriteLine("It's time! Introducing the fighter " + this.Name);
            Console.WriteLine("Direct from " + this.Nationality);
            Console.WriteLine("With " + this.Age + " years old and " + this.Height + " cm tall");
            Console.WriteLine("Weighing" + this.Weight + "kg");
            Console.WriteLine(this.Victories + " victories");
            Console.WriteLine(this.Defeats + " defeats and");
            Console.WriteLine(this.Draws + " draws");
        }
        public void Status()
        {
            Console.WriteLine(this.Name + " is " + this.Category);
            Console.WriteLine("won " + this.Victories + " times");
            Console.WriteLine("lose " + this.Defeats + " times");
            Console.WriteLine("drew " + this.Draws + " times");
        }
        public void WinFight() => this.Victories++;
        public void LoseFight() => this.Defeats++;
        public void DrawFight() => this.Draws++;

        public Fighter(string name, string nationality, int age, float height,
                                float weight, int victories, int defeats, int draws)
        {
            this.Name = name;
            this.Nationality = nationality;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.Victories = victories;
            this.Defeats = defeats;
            this.Draws = draws;
        }
    }
}