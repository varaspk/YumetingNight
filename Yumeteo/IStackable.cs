using System;
using System.Collections.Generic;
using System.Text;

namespace Yumeteo
{
    // Interfaz para items stackables en ItemStackTiles
    public interface IStackable
    {
        int StackLimit { get; }
    }
}
