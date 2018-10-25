using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        string nombre;
        int carbohidratos;
        int proteinas;
        int grasas;
        int kcal; //Calorias

        public Comida(string nombre, int carbohidratos, int proteinas, int grasas)
        {
            this.nombre = nombre;
            this.carbohidratos = carbohidratos;
            this.proteinas = proteinas;
            this.grasas = grasas;
            kcal = 4 * carbohidratos + 4 * proteinas + 9 * grasas; // Método calorias
        }

        public override string ToString()
        {
            return $"{nombre}(carbohidratos: {carbohidratos}, proteinas: {proteinas}, grasas: {grasas}, calorias: {kcal})";
        }



    }
}
