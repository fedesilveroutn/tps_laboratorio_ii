using System;
using System.Text;
using System.Collections.Generic;

namespace Biblioteca
{
    public abstract class Dispositivo
    {
        public enum Empresa
        {
            Apple, Microsoft, Samsung
        }
        public enum Software
        {
            Android, IOS, MacOs, Windows, iPadOs
        }

        //CAMPOS
        protected int id;
        protected Empresa marca;
        protected Software sistemaOperativo;
        protected float valor;


        //CONSTRUCTORES
        public Dispositivo(int id, Empresa marca, Software sistemaOperativo)
        {
            this.id = id;
            this.marca = marca;
            this.sistemaOperativo = sistemaOperativo;
            this.valor = 0.00f;
        }
       
        //PROPIEDADES
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public Empresa Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }
        public Software SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }
        public float Valor
        {
            get
            {
                return this.valor;
            }
            set
            {
                if(value > 0)
                {
                    this.valor = value;
                }
            }
        }


        //METODOS
        public static Empresa AsignarMarca(string marca)
        {
            Empresa empresa;

            if(marca == "Apple")
            {
                empresa = Empresa.Apple;
            }
            else if(marca == "Microsoft")
            {
                empresa = Empresa.Microsoft;
            }
            else
            {
                empresa = Empresa.Samsung;
            }
            return empresa;
        }
        

        public static Software AsignarSistemaOperativo(string marca, string tipoProducto)
        {
            Software sistemaOperativo;

            //Si la marca es "Apple" le asigno el sistema operativo que le corresponde segun el tipo de producto
            if (marca == "Apple")
            {
                if (tipoProducto == "Notebook")
                {
                    sistemaOperativo = Dispositivo.Software.MacOs;
                }
                else if (tipoProducto == "Smartphone")
                {
                    sistemaOperativo = Dispositivo.Software.IOS;
                }
                else
                {
                    sistemaOperativo = Dispositivo.Software.iPadOs;
                }
            }
            //Si la marca es "Microsoft" todos los productos tendrán Windows como sistema operativo
            else if (marca == "Microsoft")
            {
                sistemaOperativo = Dispositivo.Software.Windows;
            }
            //Si la marca es "Samsung" todos los productos tendrán Android como sistema operativo
            else
            {
                sistemaOperativo = Dispositivo.Software.Android;
            }
            return sistemaOperativo;
        }
      
        
        public static Dispositivo CrearDispositivo(string tipoProductoElegido, int id, Dispositivo.Empresa marca, Dispositivo.Software sistemaOperativo)
        {
            Dispositivo dispositivo;

            if (tipoProductoElegido == "Notebook")
            {
                dispositivo = new Notebook(id, marca, sistemaOperativo);
            }
            else if (tipoProductoElegido == "Smartphone")
            {
                dispositivo = new Smartphone(id, marca, sistemaOperativo);
            }
            else
            {
                dispositivo = new Tablet(id, marca, sistemaOperativo);
            }
            return dispositivo;            
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0,-25}{1,-25}", this.Id, this.GetType().Name);
            sb.Append(Formatear());
            return sb.ToString();
        }

        public abstract string Formatear();


    }
}
