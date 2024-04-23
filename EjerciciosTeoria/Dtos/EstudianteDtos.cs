using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTeoria.Dtos
{
    internal class EstudianteDtos
    {

        long id;

        string nombre = "aaaaa";

        string apellido = "aaaaa";

        int edad = 11111;

        string grado = "aaaaa";

        public long Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Grado { get => grado; set => grado = value; }

        public EstudianteDtos(long id, string nombre, string apellido, int edad, string grado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.grado = grado;
        }

        public EstudianteDtos() { }


    }
}
