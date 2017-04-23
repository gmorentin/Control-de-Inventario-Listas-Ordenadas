using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROL_DE_INVENTARIO
{
    class Inventario
    {
        private Productos inicio;

        public void Agregar(Productos nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                Productos temp = inicio;
               
                    if (nuevo.codigo < temp.codigo)
                    {
                        temp.siguiente = nuevo;
                        temp = temp.siguiente;
                    }
                    else
                    {
                        temp.siguiente = nuevo;
                        temp = temp.siguiente;
                    }

            }
        }          

        public Productos Buscar(int codigo)
        {
            Productos produ = null;
            Productos temp = inicio;
            while (temp.siguiente != null)
            {
                if (temp.siguiente.codigo == codigo)
                {
                    produ = temp.siguiente;
                }
                temp = temp.siguiente;
            }
            return produ;
        }

        public void Borrar(int codigo)
        {
            Productos temp = inicio;
            while (temp.siguiente != null)
            {
                if (temp.siguiente.codigo == codigo)
                {
                    temp.siguiente = temp.siguiente.siguiente;
                    break;
                }
                temp = temp.siguiente;
            }
        }

        public string Reporte()
        {
            string datos = "";
            Productos t = inicio;
            while (t != null)
            {
                datos += t.ToString();
                t = t.siguiente;
            }
            return datos;
        }
    }
}
