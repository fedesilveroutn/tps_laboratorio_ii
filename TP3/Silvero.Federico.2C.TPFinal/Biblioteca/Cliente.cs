using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        public enum TipoTarjeta
        {
            Debito, Credito
        }

        //CAMPOS
        private TipoTarjeta tipoTarjeta;
        private long numeroTarjeta;
        private short codigoDeSeguridad;
        private Dispositivo dispositivo;
        

        //CONSTRUCTORES
        public Cliente(string nombre, string apellido, int dni, int telefono, string email)
            :base(nombre, apellido, dni, telefono, email)
        {
            this.numeroTarjeta = 0;
            this.codigoDeSeguridad = 0;
            this.tipoTarjeta = TipoTarjeta.Debito;
            this.dispositivo = null;
            
        }

        //PROPIEDADES
        
        public Dispositivo Dispositivo
        {
            get
            {
                return this.dispositivo;
            }
            set
            {
                this.dispositivo = value;
            }
        }


        public TipoTarjeta Tarjeta
        {
            get
            {
                return this.tipoTarjeta;
            }
            set
            {
                this.tipoTarjeta = value;
            }
        }


        public long NumeroTarjeta
        {
            get
            {
                return this.numeroTarjeta;
            }
            set
            {
                this.numeroTarjeta = value;
            }
        }
       
        public short CodigoDeSeguridad
        {
            get
            {
                return this.codigoDeSeguridad;
            }
            set
            {
                this.codigoDeSeguridad = value;
            }
        }

        //METODOS
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());      
            sb.AppendLine($"-Tipo de tarjeta : {this.Tarjeta}");
            if(this.NumeroTarjeta != 0)
            {
                sb.AppendLine($"-Número de tarjeta : {this.NumeroTarjeta}");
            }
            if(this.Dispositivo != null)
            {
                sb.AppendLine($"-Dispositivo comprado :{Environment.NewLine}");
                sb.AppendLine($"{this.Dispositivo}");
            }          
            return sb.ToString();
        }


        public void AsignarTipoDeTarjeta(string tarjeta)
        {
            if(tarjeta == "Debito")
            {
                this.Tarjeta = TipoTarjeta.Debito;
            }
            else
            {
                this.Tarjeta = TipoTarjeta.Credito;
            }
        }
    }
}
