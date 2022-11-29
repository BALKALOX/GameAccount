namespace GameAccount
{
    public class Game5x5: StandartGame
    {
        public Game5x5()
        {
            this.gameField = new char[5, 5];
            this.end = false;
            this.stepCounter = 0;
        }
        public override void Play(GameAccount cross, GameAccount zero)
        {
            SetDefaultGameField();
            PrintGameField();
            while (end == false & stepCounter < 25)
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
                if (stepCounter == 24)
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
        public override void Check()
        {
            if (DiagonalCheck()) end = true;
            for (int i = 0; i < 5; i++)
            {
                if (RowCheck(i) | ColumnCheck(i))
                {
                    end = true;
                }
            }
        }
        public override bool DiagonalCheck()
        {
            for (int i = 0; i < 4; i++)
            {
                if (gameField[i, i] == gameField[i + 1, i + 1] & gameField[i, i] != ' ') continue;
                else return false;
            }
            int j = 4;
            for (int i = 0; i < 4; i++, j--)
            {
                if (gameField[i, j] == gameField[i + 1, j - 1] & gameField[i, i] != ' ') continue;
                else return false;
            }
            return true;
        }
        public override bool RowCheck(int i)
        {
            for (int j = 0; j <4; j++)
            {
                if ((gameField[i, j] == gameField[i, j + 1]) & (gameField[i, j] != ' ')) continue;
                else return false;
            }
            return true;
        }
        public override bool ColumnCheck(int i)
        {
            for (int j = 0; j < 4; j++)
            {
                if ((gameField[j, i] == gameField[j + 1, i]) & (gameField[i, j] != ' ')) continue;
                else return false;
            }
            return true;
        }
        public override void Step(GameAccount player)
        {
            if (stepCounter < 25)
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
            if (stepCounter == 25)
            {
                Console.WriteLine("Нічия!");
            }
        }
        public override void PrintGameField()
        {
            Console.WriteLine("_____________________");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0) Console.Write("| ");
                    Console.Write(gameField[i, j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("|___|___|___|___|___|");
            }
        }
        public override void SetDefaultGameField()
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    gameField[i, j] = ' ';
        }
    }
}