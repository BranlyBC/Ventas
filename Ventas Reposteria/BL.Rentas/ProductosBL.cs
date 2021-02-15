using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Dark chocolate Cupcake";
            producto1.Precio = 55;
            producto1.Existencia = 15;
            producto1.Activo = true;

            ListaProductos.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Sweet Vanilla Cupcake";
            producto2.Precio = 60;
            producto2.Existencia = 25;
            producto2.Activo = true;

            ListaProductos.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Banana pudding";
            producto3.Precio = 120;
            producto3.Existencia = 30;
            producto3.Activo = true;

            ListaProductos.Add(producto3);

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Coconut Cake";
            producto4.Precio = 250;
            producto4.Existencia = 10;
            producto4.Activo = true;

            ListaProductos.Add(producto4);

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "Chocolate Brownie";
            producto5.Precio = 75;
            producto5.Existencia = 20;
            producto5.Activo = true;

            ListaProductos.Add(producto5);

            var producto6 = new Producto();
            producto6.Id = 6;
            producto6.Descripcion = "Cheesecake";
            producto6.Precio = 150;
            producto6.Existencia = 15;
            producto6.Activo = true;

            ListaProductos.Add(producto6);

            var producto7 = new Producto();
            producto7.Id = 7;
            producto7.Descripcion = "Boston cream pie";
            producto7.Precio = 70;
            producto7.Existencia = 10;
            producto7.Activo = true;

            ListaProductos.Add(producto7);

            var producto8 = new Producto();
            producto8.Id = 8;
            producto8.Descripcion = "Peppermint Cupcake";
            producto8.Precio = 75;
            producto8.Existencia = 12;
            producto8.Activo = true;

            ListaProductos.Add(producto8);

            var producto9 = new Producto();
            producto9.Id = 9;
            producto9.Descripcion = "Green Lemon Cake";
            producto9.Precio = 85;
            producto9.Existencia = 12;
            producto9.Activo = true;

            ListaProductos.Add(producto9);

            var producto10 = new Producto();
            producto10.Id = 10;
            producto10.Descripcion = "Marshmallow taste";
            producto10.Precio = 90;
            producto10.Existencia = 10;
            producto10.Activo = true;

            ListaProductos.Add(producto10);

        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}