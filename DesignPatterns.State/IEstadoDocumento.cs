﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public interface IEstadoDocumento
    {
        void Publicar(Documento documento, Usuario usuario);
    }
}
