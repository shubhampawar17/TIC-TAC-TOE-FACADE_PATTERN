using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE_FACADE_PATTERN.Models
{
    public class ResultAnalyzer
    {
        public static bool CheckWin(Board board, char symbol)
        {
            return board.CheckWin(symbol);
        }

        public static bool CheckDraw(int movesCount)
        {
            return movesCount >= 9;
        }
    }
}
