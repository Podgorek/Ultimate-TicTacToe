using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Player
{
    public string Name { get; set; }
    public int Num { get; set; }

    public Player(string n, int m)
    {
        Num = m;
        Name = n;
    }
}

