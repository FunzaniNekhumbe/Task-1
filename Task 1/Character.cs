using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
//Question 2.2//
{
    public abstract class Character : Tile
    {
        public int HP;
        public int MaxHP;
        public int Damage;
        int[] TileArray;
        enum Movement { NoMovemnt, Up, Down, Left, Right };

        public Character()
        {

        }

        public virtual void Attack()
        {

        }

        
    }

    //Question 2.6//
    class Hero : Character
    {

    }
}
