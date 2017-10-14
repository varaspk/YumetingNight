using System;
using System.Collections.Generic;
using System.Text;

namespace Yumeteo
{
    // Clase Pawn Base
    public abstract class Pawn
    {
        private int foodPoints;
        private int maxFoodPoints;

        public int MaxFood
        {
            get { return maxFoodPoints; }
            private set { foodPoints = value; }
        }


        public int Food
        {
            get { return foodPoints; }
            set { foodPoints = value; }
        }

        public Pawn(int maxfoodpoints)
        {
            MaxFood = maxfoodpoints;
        }

    }
}
