using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Smartphone : Dispositivo
    {
        public enum Conector
        {
            UsbC, MicroUsb, Lightning
        }

        //CAMPOS
        private short resolucionCamara;
        private bool tieneCincoG;
        private Conector conector;

        //CONSTRUCTORES
        public Smartphone(int id, Empresa marca, Software sistemaOperativo, short resolucionCamara, bool tieneCincoG, Conector conector)
            :base(id, marca, sistemaOperativo)
        {
            this.resolucionCamara = resolucionCamara;
            this.tieneCincoG = tieneCincoG;
            this.conector = conector;
        }
        
        public Smartphone(int id, Empresa marca, Software sistemaOperativo)
            :this(id, marca, sistemaOperativo, 32, false, Conector.UsbC)
        {

        }

        //PROPIEDADES
        public short ResolucionCamara
        {
            get
            {
                return this.resolucionCamara;
            }
            set
            {
                this.resolucionCamara = value;
            }
        }
        public bool TieneCincoG
        {
            get
            {
                return this.tieneCincoG;
            }
            set
            {
                this.tieneCincoG = value;
            }
        }
        public Conector TipoConector
        {
            get
            {
                return this.conector;
            }
            set
            {
                this.conector = value;
            }
        }

        public override string Formatear()
        {
            string precio = String.Format("${0}", this.Valor);
            StringBuilder sb = new StringBuilder();
            if (this.Marca == Empresa.Apple)
            {
                sb.AppendFormat("{0,13}{1,32}{2,35}", this.Marca, this.SistemaOperativo, precio);
            }
            else if (this.Marca == Empresa.Samsung)
            {
                sb.AppendFormat("{0,15}{1,30}{2,27}", this.Marca, this.SistemaOperativo, precio);
            }
            else
            {
                sb.AppendFormat("{0,16}{1,30}{2,25}", this.Marca, this.SistemaOperativo, precio);
            }
            return sb.ToString();
        }
    }
}
