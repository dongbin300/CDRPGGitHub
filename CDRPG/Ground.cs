using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRPG
{
    public class Ground
    {
        int size = 10;
        int turn;
        int turnLimit;
        int[][] isEnemy;

        Enemy[] enemy;

        public Ground()
        {
            isEnemy = new int[size][];
            for (int i = 0; i < size; i++)
            {
                isEnemy[i] = new int[size];
            }
        }

        public void NewLevel()
        {
            turn = 0;
            turnLimit = 10;
            Random random = new Random();
            enemy = new Enemy[50];
            for (int i = 0; i < enemy.Length; i++)
            {
                int x = random.Next(size);
                int y = random.Next(size);
                if (isEnemy[y][x] != 0)
                {
                    i--;
                    continue;
                }
                enemy[i] = new Enemy(new Enemy.Position(x, y), 100, Card.Tiers.Bronze, Card.Properties.None, Card.Species.Human);
                isEnemy[y][x] = 1;
            }
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    str += isEnemy[i][j] == 0 ? "□" : "■";
                }
                str += "\n";
            }
            return str;
        }
    }
}
