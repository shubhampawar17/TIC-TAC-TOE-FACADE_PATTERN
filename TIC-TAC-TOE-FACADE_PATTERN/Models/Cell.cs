using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE_FACADE_PATTERN.Models
{
    public class Cell
    {
        public MarkType Mark { get; private set; } = MarkType.EMPTY;

        public void MarkCell(MarkType symbol)
        {
            Mark = symbol;
        }

        public bool IsEmpty()
        {
            return Mark == MarkType.EMPTY;
        }
    }
}
