namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            var round = 0;
            var player = 0;
            var choose = 0;

            do
            {  
                Console.WriteLine("Gracz nr 1: X, Gracz nr 2: 0");
                game.Board();
                if (game.IsDraw())
                {
                    break; 
                }

                player = (round % 2) + 1;
                Console.WriteLine("Tura gracza {0}", player);
                bool validator = false;

                while (!validator)
                {
                    Console.Write("Wybierz pozycje (1 - 9): ");
                    choose = int.Parse(Console.ReadLine());

                    if(choose > 0 && choose < 10)
                    {
                        if (game.IsDuplicate(choose))
                        {
                            Console.Beep();
                            Console.WriteLine("Pole jest juz zajęte!");
                        }else
                        {                           
                            game.Move(round%2, choose);
                            validator = true;
                        }   
                    }else
                    {
                        Console.Beep();
                        Console.WriteLine("Wprowadź prawidłową wartość!");
                    }
                }

                Console.Clear();
                round++;

            } while (!game.IsWin());
            
            
            Console.Clear();
            if(game.IsDraw())
            {
                Console.WriteLine("REMIS!");
                game.Board();
                Console.ReadKey();
            }else
            {
                Console.WriteLine("Wygrał gracz nr {0}!", player);
                game.Board();
                Console.ReadKey();
            }
           
        }
    }
}