using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using System.Reflection.Metadata.Ecma335;

public class Board
{
    public Tile[,] Tiles { get; set; }
    public int Size { get; set; }
    public int Moves { get; set; }
    public Board(int size)
    {
        Size = size;
        Tiles = new Tile[Size, Size];
        Moves = 0;
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Tiles[i, j] = new Tile();
            }
        }
    }

    public void placesign(int x, int y, int i)
    {
        Tiles[x, y].Occupied = i;
        Moves++;
    }

    public bool isfree(int x, int y)
    {
        if (x < 0 || x >= Size || y < 0 || y >= Size) return false;
        if (Tiles[x, y].Occupied != 0) return false;
        return true;
    }

    public bool isfinished(Player player)
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                if (Tiles[i, j].Occupied == player.Num)
                {
                    if (fivenext(player.Num, i, j)) return true;
                }
            }
        }
        return false;
    }

    bool fivenext(int n, int x, int y)
    {
        int inarow = 1;
        int movesfrom = 1;
        while (x - movesfrom >= 0)
        {
            if (inarow == 5) return true;
            if (Tiles[x - movesfrom, y].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        while (x + movesfrom < Size)
        {
            if (inarow >= 5) return true;
            if (Tiles[x + movesfrom, y].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        inarow = 1;
        while (y - movesfrom >= 0)
        {
            if (inarow >= 5) return true;
            if (Tiles[x, y - movesfrom].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        while (y + movesfrom < Size)
        {
            if (inarow >= 5) return true;
            if (Tiles[x, y + movesfrom].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        inarow = 1;
        while (x - movesfrom >= 0 && y - movesfrom >= 0)
        {
            if (inarow >= 5) return true;
            if (Tiles[x - movesfrom, y - movesfrom].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        while (x + movesfrom < Size && y + movesfrom < Size)
        {
            if (inarow >= 5) return true;
            if (Tiles[x + movesfrom, y + movesfrom].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        inarow = 1;
        while (x - movesfrom >= 0 && y + movesfrom >= 0)
        {
            if (inarow >= 5) return true;
            if (Tiles[x - movesfrom, y + movesfrom].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        while (x + movesfrom >= 0 && y - movesfrom >= 0)
        {
            if (inarow >= 5) return true;
            if (Tiles[x + movesfrom, y - movesfrom].Occupied == n)
            {
                movesfrom++;
                inarow++;
            }
            else
            {
                movesfrom = 1;
                break;
            }
        }
        return false;
    }

    public void show_board()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Console.Write($"[{Tiles[i, j].Occupied}]");
            }
            Console.Write("\n");
        }
    }
}