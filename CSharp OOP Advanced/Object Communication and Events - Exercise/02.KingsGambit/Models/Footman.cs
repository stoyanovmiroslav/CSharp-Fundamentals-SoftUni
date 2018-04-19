﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02.KingsGambit
{
    public class Footman : Soldier
    {
        public Footman(string name) 
            : base(name)
        {
        }

        public override void KindUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}