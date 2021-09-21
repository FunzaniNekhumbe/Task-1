using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
//Question 2.1//
{
    public abstract class Tile
    {
        public string X;
        public string Y;
        enum TileType {Hero, Enemy, Gold, Weapon };

        //Constructor//
        public Tile()
        {
            Console.WriteLine();
        }
    }

    class Obstacle : Tile
    {
       
    }

    class EmptyTile : Tile
    {

    }
}
