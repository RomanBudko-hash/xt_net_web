﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2._1.GAME
{
    public class Player : Persons
    {
        public Player(int Speed, int PointOfBeingX, int PointOfBeingY) 
        : base(Speed, PointOfBeingX, PointOfBeingY) { }

        public int GetHealth()
        {
            return health += 25;
        }
    }
}
