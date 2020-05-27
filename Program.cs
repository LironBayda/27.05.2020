using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace part2_q2
{
    class Program
    {
        const int BOARD_SIZE=3;
        static int[,] board=new int[BOARD_SIZE, BOARD_SIZE];
        static int WinX0(int[,] board)
        {
            
            if (!IsSizeRight(board))
                return -1;
            else if (!IsValuesRight(board))
                return -2;
            bool WinX = Win(1, board);
            bool WinO = Win(0, board);
            if (WinX && WinO)
                return -3;
            else if (WinX)
                return 1;
            else if(WinO)
                return 2;
            return 0;


        }

        private static bool IsSizeRight(int[,] board)
        {
            if(board.GetLength(0)==BOARD_SIZE && board.GetLength(1) == BOARD_SIZE)
                return true;
            return false;
        }

        private static bool Win(int v, int[,] board)
        {
            if(winRaw(v, board) || winCol(v, board) ||Windiag(v, board))
                return true;
            return false;
        }

        private static bool Windiag(int v, int[,] board)
        {
            int sumDiag1 = 0;
            int sumDiag2=0;
            int j = 3;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                sumDiag1 += board[i, i];
                sumDiag2 += board[i, --j];
            }

            return sumDiag1 == v * BOARD_SIZE || sumDiag2 == v * BOARD_SIZE;
        }

        private static bool winCol(int v,int[,] board)
        {
            int sum = 0;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    sum += board[j, i];

                }
                if (sum == BOARD_SIZE * v)
                    return true;
                 sum = 0;

            }

            return false;
        }

        private static bool winRaw(int v, int[,] board)
        {

            int sum = 0;
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    sum += board[i,j];

                }
                if (sum == BOARD_SIZE * v)
                    return true;
                 sum = 0;

            }


            return false;
        }

  

        private static bool IsValuesRight(int[,] board)
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                for (int j = 0; j < BOARD_SIZE; j++)
                {
                    if (board[i, j] != 0 && board[i, j] != 1)
                        return false;

                }
               

            }

            return true;
        }

        static void Main(string[] args)
        {
            int[,] sizeNotRigth= new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, };
            int[,] valuesNotRight = new int[,] { { 1, 2, 6 }, { 3, 4, 6 }, { 5, 6, 6 } };
            int[,] XAndOWins = new int[,] { { 0, 0, 0 }, { 1, 1, 1 }, { 1, 0, 1 } };
            int[,] Xwin = new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 1, 0, 1 } };
            int[,] Xwin1 = new int[,] { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 } };
            int[,] Xwin2 = new int[,] { { 1, 1, 0 }, { 0, 1, 1 }, { 1, 0, 1 } };
            int[,] Xwin3 = new int[,] { { 1, 0, 1 }, { 0, 1, 1 }, { 1, 0, 1 } };
            int[,] OWin = new int[,] { { 0, 0, 0 }, { 1, 0, 1 }, { 1, 0, 1 } };
            int[,] noBodyWin = new int[,] { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 0, 1 } }; ;

            print(sizeNotRigth);
            print(valuesNotRight);
            print(XAndOWins);
            print(Xwin);
            print(Xwin1);
            print(Xwin2);
            print(Xwin3);
            print(OWin);
            print(noBodyWin);
            Console.ReadLine();





        }

        private static void print(int[,] board)
        {
            switch(WinX0(board))
            {
                case -1:
                    Console.WriteLine("board Size is worng");
                    break;
                case -2:
                    Console.WriteLine("board values is worng");
                    break;
                case -3:
                    Console.WriteLine("X and O wons");
                    break;
                case 1:
                    Console.WriteLine("X won");
                    break;
                case 2:
                    Console.WriteLine("O won");
                    break;
                case 0:
                    Console.WriteLine("no body won");
                    break;
            }
        }
    }
}
