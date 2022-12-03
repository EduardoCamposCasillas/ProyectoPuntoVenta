using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        private int idProveedor;
        private string Documento;
        private string RazonSocial;
        private string Correo;
        private string Telefono;
        private bool Estado;
        private string FechaRegistro;

        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Documento1 { get => Documento; set => Documento = value; }
        public string RazonSocial1 { get => RazonSocial; set => RazonSocial = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public bool Estado1 { get => Estado; set => Estado = value; }
        public string FechaRegistro1 { get => FechaRegistro; set => FechaRegistro = value; }
    }
}
