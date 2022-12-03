using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eduardo_Campos.entidades
{
    internal class Persona
    {
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string calle;
        private int numero;
        private string colonia;
        private string estado;
        private string numeroCelular;

        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Colonia { get => colonia; set => colonia = value; }
        public string Estado { get => estado; set => estado = value; }
        public string NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
    }
}
