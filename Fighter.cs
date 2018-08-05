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
        public string Category
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

        public void Introduce() { }
        public void Status() { }
        public void WinFight() { }
        public void LoseFight() { }
        public void DrawFight() { }

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