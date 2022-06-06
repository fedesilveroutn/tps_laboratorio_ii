using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        //CAMPOS
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected int telefono;
        protected string email;

        //CONSTRUCTORES
        public Persona(string nombre, string apellido, int dni, int telefono, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
            this.email = email;
        }

        //PROPIEDADES
        public string NombreCompleto
        {
            get
            {
                return $"{this.nombre} {this.apellido}";
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Telefono
        {
            get
            {
                return this.telefono;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
        }

        //METODOS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"--------------------------------------------------------------------------------");
            sb.AppendLine($"-Nombre completo : {this.NombreCompleto}");
            sb.AppendLine($"-DNI : {this.Dni}");
            sb.AppendLine($"-Telefono : {this.Telefono}");
            sb.Append($"-Email : {this.Email}");
            return sb.ToString();
        }
    }
}
