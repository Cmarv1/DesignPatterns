﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    public interface IIterador
    {
        bool TieneSiguiente();
        object Siguiente();
    }
}
