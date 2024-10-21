using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE_FACADE_PATTERN.Models
{
    public class Player
    {
        public string Name { get; }
        public MarkType Symbol { get; }

        public Player(string name, MarkType symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}
