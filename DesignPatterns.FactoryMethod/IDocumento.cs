﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public interface IDocumento
    {
        void Abrir();
        void Guardar();
        void Cerrar();
    }
}
