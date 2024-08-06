﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command
{
    public interface IOperacion
    {
        void Ejecutar();
        void Deshacer();
    }
}
