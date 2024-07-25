using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Computador
    {
        private readonly IProcesador _procesador;
        private readonly IMemoria _memoria;
        private readonly IAlmacenamiento _almacenamiento;

        public Computador(IProcesador procesador, IMemoria memoria, IAlmacenamiento almacenamiento)
        {
            _procesador = procesador;
            _memoria = memoria;
            _almacenamiento = almacenamiento;
        }

        public void Iniciar()
        {
            _memoria.Cargar();
            _procesador.Procesar();
            _almacenamiento.Guardar();
        }
    }
}
