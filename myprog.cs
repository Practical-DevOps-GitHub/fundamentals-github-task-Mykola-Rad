using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Obstacle> Obstacles { get; set; }
        public List<Fruit> Fruits { get; set; }
        public List<Debuff> Debuffs { get; set; }
        public List<Bonus> Bonuses { get; set; }

        public Map(int width, int height, List<Obstacle> obstacles)
        {
            Width = width;
            Height = height;
            Obstacles = obstacles;
            Fruits = new List<Fruit>();
            Debuffs = new List<Debuff>();
            Bonuses = new List<Bonus>();
        }

        public void GenerateFruits(int count)
        {
            List<FruitType> fruitTypes = new List<FruitType>{
                FruitType.Grape,
                FruitType.Orange,
                FruitType.Apple,
                FruitType.Banana,
                FruitType.Watermelon
            };
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(0, Width);
                int y = random.Next(0, Height);
                int randomIndex = random.Next(Enum.GetValues(typeof(FruitType)).Length);

                FruitType fruitType = fruitTypes[randomIndex];

                Fruits.Add(new Fruit(x, y, fruitType));
            }
        }

        public void GenerateDebuffs(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(0, Width);
                int y = random.Next(0, Height);
                DebuffType debuffType = (DebuffType)random.Next(Enum.GetValues(typeof(DebuffType)).Length);

                Debuffs.Add(new Debuff(x, y, debuffType));
            }
        }

        public void GenerateBonuses(int count)
        {
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(0, Width);
                int y = random.Next(0, Height);
                BonusType bonusType = (BonusType)random.Next(Enum.GetValues(typeof(BonusType)).Length);

                Bonuses.Add(new Bonus(x, y, bonusType));
            }
        }
    }
}
