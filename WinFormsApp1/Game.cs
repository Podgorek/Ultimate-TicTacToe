using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Game : Form
    {
        private Board board;
        public List<Player> players = new List<Player>();

        public Game(List<string> names)
        {
            InitializeComponent();
            board = new Board(20);
            for(int i = 1; i < names.Count + 1; i++)
            {
                players.Add(new Player(names[i-1], i));
            }
        }

        public delegate void CellClickEventHandler(int rowIndex, int colIndex);
        public event CellClickEventHandler CellClicked;

        public void SetCellValue(int rowIndex, int colIndex, string value)
        {
            dataGridView1.Rows[rowIndex].Cells[colIndex].Value = value;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.RowIndex;
            int y = e.ColumnIndex;
            if (x < 0 || y < 0)
            {
                MessageBox.Show("U clicked in a wrong place!!!");
            }
            else
            {
                Program.HandleCellClick(x, y);
            }
        }

    }
}
