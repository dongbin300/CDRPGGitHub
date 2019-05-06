using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRPG
{
    public class Enemy
    {
        public struct Position
        {
            public int X;
            public int Y;

            public Position(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        Position position = new Position();
        int hp;
        int hpMax;
        Card.Tiers tier;
        Card.Properties property;
        Card.Species species;

        public Enemy(Position position, int hpMax, Card.Tiers tier, Card.Properties property, Card.Species species)
        {
            this.position = position;
            this.hpMax = hpMax;
            hp = this.hpMax;
            this.tier = tier;
            this.property = property;
            this.species = species;
        }
    }
}
