using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ListaComida
    {
        public List<Comida> comidas = new List<Comida>();

        public ListaComida()
        {
            comidas = new List<Comida>();
        }

        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
        public void Eliminar(Comida comida)
        {
            comidas.Remove(comida);
        }
    }
}
}
