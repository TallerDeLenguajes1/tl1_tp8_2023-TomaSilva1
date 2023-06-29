using System;
using System.IO;

class indexados
{
    static void main()
    {
        Console.WriteLine("Ingrese el path de una carpeta en particular");
        string ruta = Console.ReadLine();

        if (Directory.Exists(ruta))
        {
            string[] archivos = Directory.GetFiles(ruta);

            foreach (var item in archivos)
            {
                Console.WriteLine(item);
            }
        }else{
            Console.WriteLine("La carpeta que ingreso no existe.");
        }
    }
}