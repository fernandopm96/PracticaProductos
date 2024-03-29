﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProductos
{
    // Clase Producto que representa en este caso vehículos. 
    public class Producto
    {
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public Tipo Tipo { get; set; }
        public Marca Marca { get; set; }
        public Bitmap Imagen { get; set; }

        public String RutaImagen { get; set; }
  
        public Producto(int cod, string nombre, double precio, string descripcion, int stock, Tipo tipo, Marca marca)
        {
            this.Cod = cod;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Stock = stock;
            this.Tipo = tipo;
            this.Marca = marca; 
        }
        // Devuelve el valor de una propiedad en base al nombre de la variable
        public string GetPropertyByName(string property)
        {
            string prop = null;
            switch (property)
            {
                case "Cod": prop = Cod.ToString(); break;
                case "Nombre": prop = Nombre; break;
                case "Precio": prop = Precio.ToString(); break;
                case "Descripcion": prop = Descripcion; break;
                case "Stock": prop = Stock.ToString(); break;
                case "Tipo": prop = Tipo.ToString(); break;
                case "Marca": prop = Marca.ToString(); break;
            }
            return prop;
        }

        public string ToString()
        {
            return "Código: " + Cod + " Nombre: " + Nombre + " Precio: " + Precio + " Descripción: " + Descripcion + 
                " Stock: " + Stock + " Marca: " + Marca + " Tipo: " + Tipo;
        }


    }
    // Tipo de vehículo
    public enum Tipo
    {
        Compacto,
        Deportivo,
        Berlina,
        Suv,
        Todoterreno,
        Monovolumen,
        Biplaza,
        Furgoneta
    }
    // Marcas de vehículo
    public enum Marca
    {
        Renault,
        Citroen,
        Peugeot,
        BMW,
        Audi,
        Mercedes,
        Porsche,
        Ferrari, 
        Ford,
        Volkswagen,
        Kia,
        Honda,
        Dacia
    }
    
}
