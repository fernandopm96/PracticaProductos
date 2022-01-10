using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
    public class Producto
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public Tipo tipo { get; set; }
        public Marca marca { get; set; }
        public String foto { get; set; }
        public Producto(int cod, string nombre, double precio, string descripcion, int stock, Tipo tipo, Marca marca)
        {
            this.Cod = cod;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Stock = stock;
            this.tipo = tipo;
            this.marca = marca; 
        }

        

        public string ToString()
        {
            return "Código: " + Cod + " Nombre: " + Nombre + " Precio: " + Precio + " Descripción: " + Descripcion + 
                " Stock: " + Stock + " Marca: " + marca + " Tipo: " + tipo;
        }

        
    }
    public enum Tipo
    {
        Television,
        Lavadora,
        Microondas,
        Frigorifico,
        Secadora,
        Lavavajillas,
        Horno,
        AireAcondicionado,
        Estufa
    }
    public enum Marca
    {
        Balay,
        LG,
        Bosch,
        Siemens,
        Samsung,
        Zanussi,
        Fagor,
        Mitsubishi
    }
    
}
