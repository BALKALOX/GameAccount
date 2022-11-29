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
                        Win(cross, zero);
                        break;
                    }
                    break;
                }
            }
        }
        public virtual void Check()
        {
            if(DiagonalCheck()) end = true; 
            for(int i = 0; i < 3; i++)
            {
                if (RowCheck(i) | ColumnCheck(i))
                {
                    end = true; 
                }
            }
        }
        public virtual bool DiagonalCheck()
        {
            for(int i = 0; i < 2; i++)
            {
                if (gameField[i, i] == gameField[i + 1, i + 1] & gameField[i, i] != ' ') continue;
                else return false;
            }
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
                if ((gameField[j, i] == gameField[j + 1, i]) & (gameField[i, j] != ' ')) continue;
                else return false;
            }
            return true;
        }
        public virtual void Step(GameAccount player)
        {
            if(stepCounter < 9)
            {
                Console.WriteLine(player.userName + ", select the position of a cell");
                int i = Convert.ToInt32(Console.ReadLine());
                int j = Convert.ToInt32(Console.ReadLine());
                if (gameField[i, j] == ' ')
                    gameField[i, j] = player.role;
                else { Console.WriteLine("The position is occupied"); Step(player); }
                Check();
            }
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
        public virtual void Win(GameAccount cross, GameAccount zero)
        {
            cross.GameWin(cross.currentRating, cross.gameCount);
            cross.GameWinPrint(cross.oponentName, cross.currentRating);
            zero.GameLoose(zero.currentRating, zero.gameCount);
            ListAdd(cross, zero);
        }
        public virtual void Loose(GameAccount cross, GameAccount zero)
        {
            cross.GameLoose(cross.currentRating, cross.gameCount);
            cross.GameLoosePrint(cross.oponentName, cross.currentRating);
            zero.GameWin(zero.currentRating, zero.gameCount);
            ListAdd(cross, zero);
        }
        public virtual void ListAdd(GameAccount cross, GameAccount zero)
        {
            cross.list.Add(cross.toString(cross.userName, cross.oponentName, cross.currentRating.ToString(), cross.gameCount.ToString()));
            zero.list.Add(zero.toString(zero.userName, zero.oponentName, zero.currentRating.ToString(), zero.gameCount.ToString()));
        }
    }
}