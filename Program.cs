using System;
using System.IO;


    
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
    
        string[] contenido = Directory.GetFiles(ruta);

        using (StreamWriter cargar = new StreamWriter("index.csv"))
        {
            cargar.WriteLine("Indice, Nombre, Extension");
        

            for (int i = 0; i < contenido.Length; i++)
            {
                string nombre = Path.GetFileNameWithoutExtension(contenido[i]);
                string extension = Path.GetExtension(contenido[i]);
                int cont = i+1;
                cargar.WriteLine(cont+","+nombre+","+extension);
            }
        }
