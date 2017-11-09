using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaLlantasForm;

namespace PracticaLlantasForm.Classes
{
    class llanta
    {
        string Marca;
        string modelo;
        float costo;
        rin rin;
        dibujo dibujo;
        velocidad velocidad;

        public llanta(string marca, string modelo, float costo, rin Rin, dibujo Dibujo, velocidad Velocidad)
        {
            this.Marca = marca;
            this.modelo = modelo;
            this.costo = costo;
            this.rin = Rin;
            this.dibujo = Dibujo;
            this.velocidad = Velocidad;

        }

        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public float Costo { get => costo; set => costo = value; }
        public rin Rin { get => rin; set => rin = value; }
        public dibujo Dibujo { get => dibujo; set => dibujo = value; }
        public velocidad Velocidad { get => velocidad; set => velocidad = value; }
    }
}
