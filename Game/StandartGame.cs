using System.ComponentModel;

namespace GameAccount
{
    public class StandartGame : BaseGame
    {
        protected char[,] gameField { get; set; }
        protected bool end { get; set; }
        protected int stepCounter { get; set; }
        public StandartGame()
        {
            this.gameField = new char[3,3];
            this.end = false;  
            this.stepCounter = 0;
        }
        public override void Play(GameAccount cross, GameAccount zero)
        {
            SetDefaultGameField();
            PrintGameField();
            while (end == false & stepCounter < 9)
            {
                Step(cross);
                PrintGameField();
                if (end == true)
                {  
                    Win(cross, zero);
                    break; 
                }   
                Step(zero);
                PrintGameField();
                if (end == true) Win(zero, cross); 
                if (stepCounter == 8)
                {
                    Step(cross);
                    PrintGameField();
                    if (end == true)
                    {
                        Win( zero, cross);
                        break;
                    }
                    break;
                }
            }
        }
        public virtual void Check()
        {
            if(MainDiagonalCheck() | DiagonalCheck()) end = true; 
            for(int i = 0; i < 3; i++)
            {
                if (RowCheck(i) | ColumnCheck(i))
                {
                    end = true; 
                }
            }
        }
        public virtual bool MainDiagonalCheck()
        {
            for(int i = 0; i < 2; i++)
            {
                if (gameField[i, i] == gameField[i + 1, i + 1] & gameField[i, i] != ' ') continue;
                else return false;
            }
            return true;
        }
        public virtual bool DiagonalCheck()
        {
            int j =2;
            for (int i = 0; i < 2; i++,j--)
            {
                if (gameField[i, j] == gameField[i + 1, j - 1] & gameField[i, i] != ' ') continue;
                else return false;
            }
            return true;
        }
        public virtual bool RowCheck(int i)
        {
            for(int j=0;j<2;j++)
            {
                if ((gameField[i, j] == gameField[i, j + 1]) & (gameField[i, j] != ' ')) continue;
                else return false;
            }
            return true;
        }
        public virtual bool ColumnCheck(int i)
        {
            for(int j=0;j<2;j++)
            {
                if ((gameField[j, i] == gameField[j + 1, i]) & (gameField[j, i] != ' ')) continue;
                else return false;
            }
            return true;
        }
        public virtual void Step(GameAccount player)
        {
            Console.WriteLine(player.userName + ", select the position of a cell");
            int i = Convert.ToInt32(Console.ReadLine());
            if ((i >2) | (i < 0)) 
            {
                Console.WriteLine("Uncorrect index of cell");
                Step(player); 
            }
            int j = Convert.ToInt32(Console.ReadLine());
            if ((j > 2) | (j < 0))
            {
                Console.WriteLine("Uncorrect index of cell");
                Step(player);
            }
            if (gameField[i, j] == ' ')
                gameField[i, j] = player.role;
            else { Console.WriteLine("The position is occupied"); Step(player); }
            Check();
            this.stepCounter++;
            if(stepCounter == 9)
            {
                Console.WriteLine("Нічия!");
            }

        }
        public virtual void PrintGameField()
        {
            Console.WriteLine("_____________");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (j == 0) Console.Write("| ");
                    Console.Write(gameField[i,j]+" | ");
                }
                Console.WriteLine();
                Console.WriteLine("|___|___|___|");
            }
        }
        public virtual void SetDefaultGameField()
        {
            for(int i = 0; i < 3; i++)
                for(int j = 0; j < 3; j++)
                    gameField[i,j] = ' ';
        }
        public virtual void Win(GameAccount player1, GameAccount player2)
        {
            player1.GameWin(player1.currentRating, player1.gameCount);
            player1.GameWinPrint(player1.oponentName, player1.currentRating);
            player2.GameLoose(player2.currentRating, player2.gameCount);
            ListAdd(player1, player2);
        }
        public virtual void Loose(GameAccount player1, GameAccount player2)
        {
            player1.GameLoose(player1.currentRating, player1.gameCount);
            player1.GameLoosePrint(player1.oponentName, player1.currentRating);
            player2.GameWin(player2.currentRating, player2.gameCount);
            ListAdd(player1, player2);
        }
        public virtual void ListAdd(GameAccount cross, GameAccount zero)
        {
            cross.list.Add(cross.toString(cross.userName, cross.oponentName, cross.currentRating.ToString(), cross.gameCount.ToString()));
            zero.list.Add(zero.toString(zero.userName, zero.oponentName, zero.currentRating.ToString(), zero.gameCount.ToString()));
        }
    }
}