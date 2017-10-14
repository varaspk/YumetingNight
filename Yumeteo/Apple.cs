using System;
using System.Collections.Generic;
using System.Text;

namespace Yumeteo
{
    // Definicion item consumible apple
    public class Apple : Consumable , IStackable
    {
        #region CONSTANTES_BALANCEO
        public static int FOOD_VALUE = 10;
        public static int STACKLIMIT = 200;
#endregion

        public int StackLimit {
            get
            {
                return STACKLIMIT;
            }
        }

        public Apple() : base(FOOD_VALUE)
        {

        }


        // Hazle algo al consumidor no?
        public override bool Consume(Pawn consumer)
        {
            if (consumer.Food + FOOD_VALUE <= consumer.Food)
            {
                consumer.Food += FOOD_VALUE;
                //PawnManager llama a itemStackTile.pickUp().Consume() y si devuelve true llama a itemStackTile.remove();
                return true;
            }
            return false;
        }
    }
}
