using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRPG
{
    public class Card
    {
        public enum Types { Character, Weapon }
        public enum Properties { None, Water, Fire, Light, Dark, Electricity }
        public enum Species { Human, Machine, Reptile }
        public enum Tiers { Bronze, Silver, Gold, Rainbow }

        int no;
        string code;
        string name;
        int turn;
        int power;
        int range;
        Types type;
        Properties property;
        Species species;
        Tiers tier;
        string effect;

        Card[] cards = new Card[1000];

        public Card()
        {

        }
        public Card(int no, string code, string name, int turn, int power, int range, Types type, Properties property, Species species, Tiers tier, string effect)
        {
            this.no = no;
            this.code = code;
            this.name = name;
            this.turn = turn;
            this.power = power;
            this.range = range;
            this.type = type;
            this.property = property;
            this.species = species;
            this.tier = tier;
            this.effect = effect;
        }

        public void AddCard()
        {
            cards[0] = new Card(1, "CC0010001", "인간", 3, 300, 1, Card.Types.Character, Card.Properties.None, Card.Species.Human, Card.Tiers.Bronze, "");
        }

        public override string ToString()
        {
            return code + "\n" + name + "\n" + turn + "\n" + power + "\n" + type + "\n" + property + "\n" + species + "\n" + tier;
        }

        public Card GetCard(int cardNo)
        {
            return cards[cardNo - 1];
        }
    }
}
