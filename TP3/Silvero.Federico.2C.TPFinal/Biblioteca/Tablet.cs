using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Tablet : Dispositivo
    {
        //CAMPOS
        private bool incluyeLapiz;


        //CONSTRUCTORES
        public Tablet(int id, Empresa marca, Software sistemaOperativo, bool incluyeLapiz)
            :base(id, marca, sistemaOperativo)
        {
            this.incluyeLapiz = incluyeLapiz;
        }
        public Tablet(int id, Empresa marca, Software sistemaOperativo)
            :this(id, marca, sistemaOperativo, false)
        {

        }


        //PROPIEDADES
        public bool IncluyeLapiz
        {
            get
            {
                return this.incluyeLapiz;
            }
            set
            {
                this.incluyeLapiz = value;
            }
        }

        public override string Formatear()
        {
            string precio = String.Format("${0}", this.Valor);
            StringBuilder sb = new StringBuilder();
            if (this.Marca == Empresa.Apple)
            {
                sb.AppendFormat("{0,20}{1,35}{2,29}", this.Marca, this.SistemaOperativo, precio);
            }
            else if (this.Marca == Empresa.Microsoft)
            {
                sb.AppendFormat("{0,24}{1,29}{2,25}", this.Marca, this.SistemaOperativo, precio);
            }
            else
            {
                sb.AppendFormat("{0,22}{1,30}{2,27}", this.Marca, this.SistemaOperativo, precio);
            }
            return sb.ToString();
        }
    }
}
