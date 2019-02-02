﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
   public class FoodAsterisk:Food
    {
        private const char symbol = '*';
        private const int points = 1;

        public FoodAsterisk(Wall wall) : base(wall, points, symbol) { }

    }
}