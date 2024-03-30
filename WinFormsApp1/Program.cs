using System.Reflection.Metadata;
using System;
using System.Windows.Forms;
using System.Drawing;
using WinFormsApp1;
using System.Xml.Linq;
using System.Reflection;

public class Program
{
    private static List<Player> players_ = new List<Player>();
    private static int currentPlayerIndex = 0;
    static Board board = new Board(20);
    static Player winner = null;
    static Game game;
    public static void Main(string[] args)
    {
        Form1 form = new Form1();
        form.Show();
        Application.Run();
        game = new Game(TwoTextBoxes.names);
        game.Show();
        Application.Run();
    }

    public static void HandleCellClick(int rowIndex, int colIndex)
    {
        
        Player currentPlayer = game.players[currentPlayerIndex];
        string symbol = currentPlayer.Num == 1 ? "X" : "O";
        game.SetCellValue(rowIndex, colIndex, symbol);
        if (board.isfree(rowIndex, colIndex))
        {
            board.placesign(rowIndex, colIndex, currentPlayer.Num);
            if (board.Moves / 2 >= 4)
            {
                if (board.isfinished(currentPlayer))
                {
                    MessageBox.Show($"{currentPlayer.Name} wins!!!");
                    Application.Exit();
                }
            }
            currentPlayerIndex = (currentPlayerIndex + 1) % 2;
        }
        else
        {
            MessageBox.Show("This cell is already occupied!!!");
        }

    }
}


