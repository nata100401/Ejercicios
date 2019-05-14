using System;
using System.Linq;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***EJERCICIOS***");
            Proyecto proyec = new Proyecto();
            proyec.proyectos = proyec.AgragarProyecto2();
            var proy = proyec.proyectos;
            Console.ReadLine();


            Console.WriteLine("**Obtener todos los proyectos cuya duración sea superior a 6 y inferior a 12**");
            var supinf = proy.Where(x => x.Duracion > 6 && x.Duracion < 12).ToList();
            proyec.Mostrar(supinf);

           // Console.WriteLine("**Obtener todos los proyectos que empiecen por (B)**");
           // var proyectosb = from p in proy
           //                  where (p.Nombre.StartsWith("B"))
           //                  select p;
           // proyec.Mostrar(proyectosb.ToList());


           // Console.WriteLine("**Obtener todos los proyectos cuyo codigo sea multiplo de 7**");
           // var proyectosmult = proy.Where(x => x.Codigo % 7 == 0).ToList();
           // proyec.Mostrar(proyectosmult);
           // Console.ReadLine();

           // Proyecto pro = new Proyecto();
           // Console.WriteLine("**Agrupar los proyectos que tengan una duracion inferior a 6 y 10 y mayor a 10**");
           // proyec.AgragarProyecto2();
           // var proyectolis = pro.proyectos;
           // var Superior = proyectolis.GroupBy(x =>
           //{
           //    if(x.Duracion <= 6)

           //{
           //        return "Duracion inferior a 6";
           //    }

           //else if (x.Duracion >= 7 && x.Duracion < 11)
           //    {
           //        return "Duracion entre 7 y 10";
           //    }
           //    else
           //    {
           //        return "Salio";
           //    }
           //});
           // foreach (var Proyectosbase in Superior) 
           //  {
           //     Console.WriteLine("Grupo de proyectos" + Proyectosbase.Key + "Hay" + Proyectosbase.Count());
           //     foreach (var item in Proyectosbase) 
           //  {
           //         Console.WriteLine($"Nombre del proyecto: {item.Nombre}");
           //         Console.WriteLine($"Codigo: {item.Codigo}");
           //         Console.WriteLine($"Codigo: {item.Duracion}");
           //     }
           // }
           // Console.ReadLine();

           // Proyecto proys = new Proyecto();
           // Console.WriteLine("**Obtener el promedio de la duracion de todos los proyectos**");
           // proyec.AgragarProyecto2();
           // var proyectos = pro.proyectos;
           // var Promedio = proyectolis.Average(x => x.Codigo);
           // Console.WriteLine($"Su promedio es: {Promedio}");
           // Console.ReadLine();

           // Proyecto proys = new Proyecto();
           // Console.WriteLine("**Obtener el nombre del proyecto conmas duracion**");
           // pro.AgragarProyecto2();
           // var Proyecto = pro.proyectos;
           // var dato = proyectolis.Max(y => y.Duracion);
           // var mayor = proyectolis.Where(x => x.Duracion == dato).Select(x => x.Nombre).FirstOrDefault();
           // Console.WriteLine($"el nombre del proyecto con maxima duracion es : {mayor}");
           // Console.ReadLine();

           // Proyecto proys = new Proyecto();
           // Console.WriteLine("**Seleccionar el nombre y el area del proyecto con duracion mayor a 6**");
           // pro.AgragarProyecto2();
           // var Proyecto = pro.proyectos;
           // var NombreArea = proyectolis.Where(x => x.Duracion > 6).Select(x =>
           //  new Proyecto()
           //  {
           //      Nombre = x.Nombre,
           //      Area = x.Area
           //  }
           // ).ToList();
           // pro.ShowList(NombreArea);
           // Console.ReadLine();

           // Proyecto proys = new Proyecto();
           // Console.WriteLine("**Verificar si existe un proyecto con duracion mayor a 24**");
           // pro.AgragarProyecto2();
           // var Proyecto = pro.proyectos;
           // var guardar = proyectolis.Any(x => x.Duracion > 24);
           // Console.WriteLine($"{guardar}");
           // Console.ReadLine();


           // Proyecto proys = new Proyecto();
           // Console.WriteLine("** **");
           // pro.AgragarProyecto2();
           // var Proyecto = pro.proyectos;
           // var sum = proyectolis.Where(x => x.Codigo > 20).Sum(x => x.Duracion);
           // Console.WriteLine($"{sum}");
           // Console.ReadLine();
        }
    }
}