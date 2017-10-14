using System;
using System.Collections.Generic;
using System.Text;

namespace Yumeteo
{
    // Definicion de objeto consumible por pawns
    public abstract class Consumable : Item
    {
        private int foodValue;

        public Consumable(int foodvalue)
        {
            foodValue = foodvalue;
        }

        public abstract bool Consume(Pawn consumer);
    }
}
