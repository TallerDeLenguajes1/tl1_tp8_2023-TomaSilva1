using System;
using tareas;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();

int cantPend = random.Next(1, 3);

List<ToDo> tareaPendiente = new List<ToDo>();
List<ToDo> tareaRealizada = new List<ToDo>();

for (int i = 0; i < cantPend; i++)
{
    Console.WriteLine("--------Cargar tareas--------");
    Console.WriteLine("Ingrese la descripcion de la tarea: ");
    
}
