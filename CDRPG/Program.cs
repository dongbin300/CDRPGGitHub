using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            // 카드 정보를 초기화
            Card c = new Card();
            c.AddCard();

            // 캐릭터를 초기화
            Character crt = new Character();

            crt.ObtainCard(new Card().GetCard(1));

            // 전장을 초기화
            Ground g = new Ground();
            g.NewLevel();
            Console.WriteLine(g.ToString());
        }
    }
}
