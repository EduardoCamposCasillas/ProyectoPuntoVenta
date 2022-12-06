using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.entidades
{
    internal class Cliente
    {
        private int idClientes;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private string calle;
        private string numeroCelular;

        public int IdClientes { get => idClientes; set => idClientes = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApellidoPaterno { get => apellidoPaterno; set => apellidoPaterno = value; }
        public string ApellidoMaterno { get => apellidoMaterno; set => apellidoMaterno = value; }
        public string Calle { get => calle; set => calle = value; }
        public string NumeroCelular { get => numeroCelular; set => numeroCelular = value; }
    }
}
