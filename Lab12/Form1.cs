using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
namespace Lab12
{
    public delegate void AgregarComidaDelegate(string nombre, int carbohidratos, int proteinas, int grasas);
    public delegate void QuitarComidaDelegate(string nombre, int carbohidratos, int proteinas, int grasas);
    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;
        public event QuitarComidaDelegate OffQuitarComida;
        public Form1()
        {
            InitializeComponent();
        }
        public void AgregarComida(Comida comida)
        {

            ChLBxAlimentos.Items.Add(comida);
        }
        public void QuitarComida(Comida comida)
        {
            ChLBxAlimentos.CheckedItems.OfType<string>().ToList().ForEach(ChLBxAlimentos.Items.Remove);
        }
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // botón Eliminar
        {
            OffQuitarComida.Invoke(tBxComida.Text, Convert.ToInt32(tBxCarbo.Text), Convert.ToInt32(tBxProt.Text), Convert.ToInt32(tBxGras.Text));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                OnAgregarComida.Invoke(tBxComida.Text, Convert.ToInt32(tBxCarbo.Text), Convert.ToInt32(tBxProt.Text), Convert.ToInt32(tBxGras.Text));
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
