using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilsForCube
{
    public enum GameState
    {
        NOT_STARTED,
        PLAYING,
        WIN

    }
    public class CubeKirillLogic
    {
        private int[,] field { get; set; }

        public CubeKirillLogic()
        {
            field = new int[5, 5];
            FillField();
        }


        private Random rnd = new Random();

        private GameState state = GameState.NOT_STARTED;

        private void FillField()
        {
            for (int row = 1; row < 5; row++)
                for (int col = 1; col < 5; col++)
                {
                    if ((row == 1 || row == 2) && (col == 1 || col == 2))
                        field[row, col] = 1;
                    else
                    if ((row == 1 || row == 2) && (col == 3 || col == 4))
                        field[row, col] = 2;
                    else
                    if ((row == 3 || row == 4) && (col == 1 || col == 2))
                        field[row, col] = 3;
                    else
                        field[row, col] = 4;

                }
        }

        public void NewGame()
        {


            Sort();

            state = GameState.PLAYING;


        }
        public void Sort()
        {
            for (int i = 0; i < 10; i++)
            {
                int row = 0;
                int col = rnd.Next(1, 5);
                Click(row, col);
                int r = rnd.Next(1, 5);
                int c = 0;
                Click(r, c);
            }
            /* for (int j = 0; j < 10; j++)
             {
                 int col = 0;
                 int row = rnd.Next(1, 5);
                 Click(row, col);
             }
             */
        }
        public void Click(int row, int col)
        {
            if (row == 0 && col > 0) Rotate1(row, col);
            else if (col == 0 && row > 0) Rotate0(row, col);
        }
        private void Rotate1(int row, int col)
        {
            int k;

            k = field[row + 1, col];
            field[row + 1, col] = field[row + 4, col];
            field[row + 4, col] = field[row + 3, col];
            field[row + 3, col] = field[row + 2, col];
            field[row + 2, col] = k;
            WinGame();
        }
        private void Rotate0(int row, int col)
        {
            int k;

            k = field[row, col + 1];
            field[row, col + 1] = field[row, col + 4];
            field[row, col + 4] = field[row, col + 3];
            field[row, col + 3] = field[row, col + 2];
            field[row, col + 2] = k;
            WinGame();
        }


        private void WinGame()
        {
            if (field[1, 1] == field[1, 2] && field[1, 2] == field[2, 1] && field[2, 1] == field[2, 2] &&
                field[1, 3] == field[1, 4] && field[1, 4] == field[2, 3] && field[2, 3] == field[2, 4] &&
                field[3, 1] == field[3, 2] && field[3, 2] == field[4, 1] && field[4, 1] == field[4, 2] &&
                field[3, 3] == field[3, 4] && field[3, 4] == field[4, 3] && field[4, 3] == field[4, 4])
                state = GameState.WIN;


        }

        //индексация (можно  читать, но нельзя писать)
        public int this[int row, int col]
        {
            get
            {
                return field[row, col];
            }
        }
        public GameState State
        {
            get
            {
                return state;
            }
        }
    }
}
