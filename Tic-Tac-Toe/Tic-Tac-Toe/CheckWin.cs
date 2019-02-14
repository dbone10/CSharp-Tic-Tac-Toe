using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public class CheckWin
    {
        public static int CheckWinner()
        {
            #region Horizontal Winning Condition
            if (Program.arr[1] == Program.arr[2] && Program.arr[2] == Program.arr[3])
            {
                return 1;
            }
            else if (Program.arr[4] == Program.arr[5] && Program.arr[5] == Program.arr[6])
            {
                return 1;
            }
            else if (Program.arr[7] == Program.arr[8] && Program.arr[8] == Program.arr[9])
            {
                return 1;
            }
            #endregion

            #region Vertical Winning Condition
            if (Program.arr[1] == Program.arr[4] && Program.arr[4] == Program.arr[7])
            {
                return 1;
            }
            else if (Program.arr[2] == Program.arr[5] && Program.arr[5] == Program.arr[8])
            {
                return 1;
            }
            else if (Program.arr[3] == Program.arr[6] && Program.arr[6] == Program.arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            if (Program.arr[1] == Program.arr[5] && Program.arr[5] == Program.arr[9])
            {
                return 1;
            }
            else if (Program.arr[3] == Program.arr[5] && Program.arr[5] == Program.arr[7])
            {
                return 1;
            }
            #endregion

            #region Check For Draw
            else if (Program.arr[1]!='1' && Program.arr[2]!='2' && Program.arr[3]!='3' && Program.arr[4]!='4' && Program.arr[5]!='5' && Program.arr[6]!='6' && Program.arr[7]!='7' && Program.arr[8]!='8' && Program.arr[9]!='9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }
    }
}
