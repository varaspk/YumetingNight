using System;
using System.Collections.Generic;
using System.Text;

namespace Yumeteo
{
    // Definicion para tamaño de estructura
    public class StructureSize
    {
        private uint xSize;
        private uint ySize;

        public bool checkCollisionByOffset(uint xOffset, uint yOffset)
        {
            if (xOffset <= xSize || yOffset <= ySize)
                return true;
            else
                return false;
        }
    }
}
