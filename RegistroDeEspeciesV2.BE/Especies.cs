using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroDeEspeciesV2.BA
{
    public class Especies
    {
        private List<Especie> ListaEspecies;

        public Especies()
        {
            ListaEspecies = new List<Especie>();
        }

        public void Registrar(Especie especie)
        { 
            ListaEspecies.Add(especie);
        }

        public List<Especie> ObtenerEspecies()
        {
            return ListaEspecies;
        }
    }

    public Especie 
        BuscarPorID(string id)
        {
            foreach (Especie especie in ListaEspecies)
            {
                if (especie.ID == id)
                {
                    return especie;
                }
            }
            return null;
        }







    }
