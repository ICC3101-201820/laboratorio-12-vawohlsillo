using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Lab12
{
    class Controlador
    {
        public Form1 form1;
        ListaComida comidas;
        public Controlador()
        {
            comidas = new ListaComida();
        }
        
    public void OnAgregarcomida(string nombre,int carbohidratos, int proteinas, int grasas)
        {
            Comida comida = new Comida(nombre, carbohidratos, proteinas, grasas);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
    public void OffQuitarComida(string nombre, int carbo, int prt, int grs)
        {
            Comida comida = new Comida(nombre, carbo,prt, grs);
            comidas.Eliminar(comida);
            form1.QuitarComida(comida);
        }
    }

}
