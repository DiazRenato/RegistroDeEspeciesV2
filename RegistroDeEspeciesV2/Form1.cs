using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroDeEspeciesV2.BA;


namespace RegistroDeEspeciesV2
{
    public partial class Form1 : Form
    {
        private Especies RegistroEspecies;


        public Form1 ()
        {
            InitializeComponent();

            RegistroEspecies = new Especies();

            Estadotxt.DataSource = ListaEspeciesdg.DataSource = RegistroEspecies.ObtenerEspecies();

            Estadotxt.DataSource = Enum.GetValues(typeof(EstadoConservacion)); 
            //entrega todos los valores del enum EstadoConservacion 
            
            RegistroEspecies.CargarXML();
            MostrarEspecie();

        }
        private void MostrarEspecie()
        {
            ListaEspeciesdg.DataSource = null;

            if (RegistroEspecies.ObtenerEspecies().Count > 0)
            {
                ListaEspeciesdg.DataSource = RegistroEspecies.ObtenerEspecies();
            }
        }

        private void Registrarbtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text == "" || Nombretxt.Text == "" || Ejemplarestxt.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Ejemplarestxt.Text, out int ejemplares)) 
            {
                MessageBox.Show("Por favor, ingrese un número válido de ejemplares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Si no se puede convertir a entero, muestra un mensaje de error y sale del método.

            if (RegistroEspecies.BuscarPorID(IDtxt.Text) != null)
            {
                MessageBox.Show("Ya existe una especie con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //si existe ya un ID existente , muestra un mensaje de error y sale del método.

            Especie nuevaEspecie = new Especie
            {
                ID = IDtxt.Text,
                Nombre = Nombretxt.Text,
                Ejemplares = ejemplares,
                EstadoConservacion = (EstadoConservacion)Estadotxt.SelectedItem
            };

            RegistroEspecies.Registrar(nuevaEspecie);   
            MostrarEspecie();

            RegistroEspecies.GuardarXML();
            MostrarEspecie();

            MessageBox.Show("Especie registrada con éxito.");
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Especie especieEncontrada = RegistroEspecies.BuscarPorID(IDtxt.Text);
            if (especieEncontrada == null)
            {
                MessageBox.Show("No se encontró una especie con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nombretxt.Text = especieEncontrada.Nombre;
            Ejemplarestxt.Text = especieEncontrada.Ejemplares.ToString();
            Estadotxt.SelectedItem = especieEncontrada.EstadoConservacion;
        }

        private void Actualizarbtn_Click(object sender, EventArgs e)
        {
            if (IDtxt.Text == "" || Nombretxt.Text == "" || Ejemplarestxt.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(Ejemplarestxt.Text, out int ejemplares))
            {
                MessageBox.Show("Por favor, ingrese un número válido de ejemplares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Especie especieActualizada = new Especie
            {
                ID = IDtxt.Text,
                Nombre = Nombretxt.Text,
                Ejemplares = ejemplares,
                EstadoConservacion = (EstadoConservacion)Estadotxt.SelectedItem
            };

            if (RegistroEspecies.Actualizar(especieActualizada))
            {
                RegistroEspecies.GuardarXML();
                MessageBox.Show("Especie actualizada con éxito.");
                MostrarEspecie();
            }
            else
            {
                MessageBox.Show("No se encontró una especie con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

        private void Limpiarbtn_Click(object sender, EventArgs e)
        {

            IDtxt.Clear();
            Nombretxt.Clear();
            Ejemplarestxt.Clear();
            Estadotxt.SelectedIndex = 0; // Resetea el ComboBox al primer elemento

            IDtxt.Focus();
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {
            IDtxt.TabIndex = 0;
            Nombretxt.TabIndex = 1;
            Ejemplarestxt.TabIndex = 2;
            Estadotxt.TabIndex = 3;
        }



    }
}
