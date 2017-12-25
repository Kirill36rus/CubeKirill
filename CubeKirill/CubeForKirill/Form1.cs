using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using UtilsForCube;

/**39. Еще один вариант двухмерного кубика Рубика. 
    Только в этом варианте циклически сдвигаются строки или столбцы поля 
    (примера готовой игры для пояснения, к сожалению, нет).
**/

namespace CubeKirill
{
    public partial class Form1 : Form
    {
        private CubeKirillLogic game1 = new CubeKirillLogic();
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateView()
        {
            switch (game1.State)
            {
                case GameState.PLAYING:
                    gameStateLabel.Text = "Игра идет ...";
                    gameStateLabel.ForeColor = Color.Black;
                    break;
                case GameState.WIN:
                    gameStateLabel.Text = "ПОБЕДА :)";
                    gameStateLabel.ForeColor = Color.DarkGreen;
                    break;

            }

            gameFieldDataGridView.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(gameFieldDataGridView, 60, true, false, false, false, false);
            gameFieldDataGridView.RowCount = 5;
            gameFieldDataGridView.ColumnCount = 5;
            gameFieldDataGridView.RowTemplate.MinimumHeight = 50;

            UpdateView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            game1.NewGame();
            UpdateView();
        }

        private void gameFieldDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            game1.Click(e.RowIndex, e.ColumnIndex);
            UpdateView();
        }

        private void gameFieldDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int v = game1[e.RowIndex, e.ColumnIndex];

            if (v == 1)
            {
                e.CellStyle.BackColor = Color.Red;
            }
            if (v == 2)
            {
                e.CellStyle.BackColor = Color.Yellow;
            }
            if (v == 3)
            {
                e.CellStyle.BackColor = Color.Green;
            }
            if (v == 4)
            {
                e.CellStyle.BackColor = Color.Blue;
            }

            UpdateView();
        }

        private void gameFieldDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            gameFieldDataGridView.ClearSelection();
        }
    }
}
