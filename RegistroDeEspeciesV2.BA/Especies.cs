using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroDeEspeciesV2.BA;
using System.Xml.Serialization;
using System.IO;


namespace RegistroDeEspeciesV2.BA
{
    public class Especies
    {
        private List<Especie> ListaEspecies;

        public Especies()
        {
            ListaEspecies = new List<Especie>();
        }

        public void GuardarXML()
        { 
        
            XmlSerializer serializer = new XmlSerializer(typeof(List<Especie>));

            using (StreamWriter archivo = new StreamWriter("Especies.xml"))
            {
                serializer.Serialize(archivo, ListaEspecies);
            }

        }
 
        public void CargarXML()
        {
            if (File.Exists("Especies.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Especie>));
                using (StreamReader archivo = new StreamReader("Especies.xml"))
                {
                    ListaEspecies = (List<Especie>)serializer.Deserialize(archivo);
                }
            }
        }
        public void Registrar(Especie especie)
        {
            ListaEspecies.Add(especie);
        }

        

        public List<Especie> ObtenerEspecies()
        {
            return ListaEspecies;
        }


        public Especie BuscarPorID(string id)
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

        public bool Actualizar(Especie especieActualizada)
        {
            Especie especieExistente = BuscarPorID(especieActualizada.ID);

            if (especieExistente == null)
            {
                return false;
            }

            especieExistente.Nombre = especieActualizada.Nombre;
            especieExistente.Ejemplares = especieActualizada.Ejemplares;
            especieExistente.EstadoConservacion = especieActualizada.EstadoConservacion;
            return true;
        }

        
    }

}