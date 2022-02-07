using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsUtkast1
{
    internal class Card
    {
        public string Tag;
        public int Value;



        public Card(string tag, int value)
        {
            Tag = tag;
            Value = value;
        }
    }
}
