﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars
{
    class Program
    {
        static void Main(string[] args)
        {
            StarWars starWars = new StarWars();
            starWars.LoadDb();
        }
    }
}
