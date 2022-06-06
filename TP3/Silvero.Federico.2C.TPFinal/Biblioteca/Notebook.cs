using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Notebook : Dispositivo
    {
        //CAMPOS
        private string idiomaTeclado;
        private short cantidadPuertosUsb;
        private bool tieneLectoraCd;

        //CONSTRUCTORES
        public Notebook(int id, Empresa marca, Software sistemaOperativo, string idiomaTeclado, short cantidadPuertosUsb, bool tieneLectoraCd)
            :base(id, marca, sistemaOperativo)
        {
            this.idiomaTeclado = idiomaTeclado;
            this.cantidadPuertosUsb = cantidadPuertosUsb;
            this.tieneLectoraCd = tieneLectoraCd;
        }
        public Notebook(int id, Empresa marca, Software sistemaOperativo)
            :this(id, marca, sistemaOperativo, "Español", 2, false)
        {
          
        }

        //PROPIEDADES
        public string IdiomaTeclado
        {
            get
            {
                return this.idiomaTeclado;
            }
            set
            {
                this.idiomaTeclado = value;
            }
        }
        public short CantidadPuertosUsb
        {
            get
            {
                return this.cantidadPuertosUsb;
            }
            set
            {
                this.cantidadPuertosUsb = value;
            }
        }
        public bool TieneLectoraCd
        {
            get
            {
                return this.tieneLectoraCd;
            }
            set
            {
                this.tieneLectoraCd = value;
            }
        }



     
        public override string Formatear()
        {
            string precio = String.Format("${0}", this.Valor);
            StringBuilder sb = new StringBuilder();
            if (this.Marca == Empresa.Apple)
            {
                sb.AppendFormat("{0,15}{1,34}{2,29}", this.Marca, this.SistemaOperativo, precio);
            }
            else if (this.Marca == Empresa.Microsoft)
            {
                sb.AppendFormat("{0,19}{1,29}{2,25}", this.Marca, this.SistemaOperativo, precio);
            }
            else
            {
               
                sb.AppendFormat("{0,17}{1,32}{2,18}", this.Marca, this.SistemaOperativo, precio);
            }
            return sb.ToString();
        }

    }
}
