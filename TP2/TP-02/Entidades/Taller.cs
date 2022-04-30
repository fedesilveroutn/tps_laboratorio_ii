using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        public enum ETipo
        {
            Ciclomotor, Sedan, SUV, Todos
        }

        private int espacioDisponible;
        private List<Vehiculo> vehiculos;
        

        #region "Constructores"
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) 
            : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public new string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            if (!(t is null || t.vehiculos is null) )
            {
                sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", t.vehiculos.Count, t.espacioDisponible);
                sb.AppendLine("");
                foreach (Vehiculo v in t.vehiculos)
                {
                    switch (tipo)
                    {
                        case ETipo.Ciclomotor:
                            if (v.GetType().Name == "Ciclomotor")
                            {
                                sb.AppendLine(v.Mostrar());
                            } 
                            break;

                        case ETipo.Sedan:
                            if (v.GetType().Name == "Sedan")
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;

                        case ETipo.SUV:
                            if (v.GetType().Name == "Suv")
                            {
                                sb.AppendLine(v.Mostrar());
                            }
                            break;

                        default:
                            sb.AppendLine(v.Mostrar());
                            break;
                    }
                }
            }
            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            if( !(t is null || vehiculo is null) )
            {
                if (t.vehiculos.Contains(vehiculo) == false && t.vehiculos.Count + 1 <= t.espacioDisponible)
                {
                    t.vehiculos.Add(vehiculo);
                }
            }
            return t;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            if (!(t.vehiculos is null) && t.vehiculos.Count > 0 )
            {
                if (t.vehiculos.Contains(vehiculo) == true)
                {
                    t.vehiculos.Remove(vehiculo);
                }
            }
            return t;
        }
        #endregion
    }
}
