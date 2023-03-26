using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class TicTacToe
    {
        char[] board = {'1', '2', '3' ,'4', '5', '6', '7', '8', '9'};
        public TicTacToe() { }
        public void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }
        public void Move(int player, int coordinate)
        {
            if (player == 0)
            {
                board[coordinate - 1] = 'X';
            }else if(player == 1)
            {
                board[coordinate - 1] = 'O';
            }
        }
        public bool IsWin()
        {
            if (board[0] == board[1] && board[1] == board[2] ||
                board[3] == board[4] && board[4] == board[5] ||
                board[6] == board[7] && board[7] == board[8] ||
                board[0] == board[3] && board[3] == board[6] ||
                board[1] == board[4] && board[4] == board[7] ||
                board[2] == board[5] && board[5] == board[8] ||
                board[0] == board[4] && board[4] == board[8] ||
                board[2] == board[4] && board[4] == board[6])
            {
                return true;
            }
            else
            {
                return false;
            } 

        }
        public bool IsDraw()
        {
            if (board[0] != '1' &&
                board[1] != '2' &&
                board[2] != '3' &&
                board[3] != '4' &&
                board[4] != '5' &&
                board[5] != '6' &&
                board[6] != '7' &&
                board[7] != '8' &&
                board[8] != '9')
            {
                return true;
            }
            else return false;
        }
        public bool IsDuplicate(int coordinate)
        {
            if (board[coordinate - 1].Equals('X') || board[coordinate - 1].Equals('O'))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
