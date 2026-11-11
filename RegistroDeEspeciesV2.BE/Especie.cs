using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroDeEspeciesV2.BA
{
    public enum EstadoConservacion
    {
        DatosInsuficientes,
        PreocupacionMenor,
        CasiAmenazado,
        Vulnerable,
        EnPeligro,
        EnPeligroCritico,
        ExtintoEnEstadoSalvaje,
        Extinto,
    }
    
    public class Especie
    {
        public required string ID { get; set; }

        public required string Nombre { get; set; }

        public int Ejemplares { get; set; }

        public EstadoConservacion EstadoConservacion { get; set; }
       
        



    }
}
