using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLlantasForm.Classes
{
    class Inventario
    {
        List<llanta> llantas;

        public Inventario()
        {
            llantas = new List<llanta>();
        }

        public void addtoinv(string marca, string modelo, float costo, rin rin, dibujo dibujo, velocidad velocidad)
        {
            llanta llanta = new llanta(marca, modelo, costo, rin, dibujo, velocidad);
            llantas.Add(llanta);
        }

        public void search()
        {

        }
    }
}
