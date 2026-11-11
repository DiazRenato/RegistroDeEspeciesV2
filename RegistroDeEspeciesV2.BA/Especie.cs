using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeEspeciesV2.BA
    {
        public enum EstadoConservacion
        {
            _,
            Datos_Insuficientes,
            Preocupacion_Menor,
            Casi_Amenazado,
            Vulnerable,
            En_Peligro,
            En_Peligro_Critico,
            Extinto_En_Estado_Salvaje,
            Extinto,
        }

    public class Especie
        {
            public string ID { get; set; }

        public string Nombre { get; set; }

            public int Ejemplares { get; set; }

            public EstadoConservacion EstadoConservacion { get; set; }

        }
    }
