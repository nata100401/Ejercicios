using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Proyecto
    {
        public List<Proyecto> proyectos = new List<Proyecto>();
        //Propiedades
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        //Metodos
        public List<Proyecto> AgregarProyecto()
        {
            Console.WriteLine($"Escriba Y para ingresar");
            var res = Console.ReadLine();
            while (res == "Y")
            {
                Console.WriteLine($"Escriba el nombre del proyecto");
                var nom = Console.ReadLine();
                Console.WriteLine($"Escriba el codigo del proyecto");
                var cod = Console.ReadLine();
                var miProyecto = new Proyecto()
                {
                    Nombre = nom,
                    Codigo = int.Parse(cod)
                };
                proyectos.Add(miProyecto);
                Console.WriteLine($"Escriba Y para ingresar");
                res = Console.ReadLine();

            }
            return proyectos;
        }
        public List<Proyecto> AgragarProyecto2()
        {

            var proys = new List<Proyecto>()
            {
                 new Proyecto
                {
                    Nombre = "Bancaria",
                    Codigo = 23,
                    Area ="Comercio",
                    Duracion=12

                },
                  new Proyecto
                {
                    Nombre = "Desarrollo",
                    Codigo = 35,
                    Area ="Comercio",
                    Duracion=3

                },
                    new Proyecto
                {
                    Nombre = "Ambiental ",
                    Codigo = 4,
                    Area ="Comercio",
                    Duracion=2

                },
            };
            proyectos = proys;
            return proyectos;
        }
        public void Mostrar(List<Proyecto> proyec)
        {

            Console.WriteLine($"*Lista de proyectos**");
            foreach (var item in proyec)
            {
                Console.WriteLine($"Nombre: {item.Nombre}");
                Console.WriteLine($"Duracion: {item.Duracion}");
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Area: {item.Area}");
            }

        }


    }

}