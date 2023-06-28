using System;
using tareas;
using System.IO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Random random = new Random();

int cantPend = random.Next(1,4);

List<ToDo> tareaPendiente = new List<ToDo>();
List<ToDo> tareaRealizada = new List<ToDo>();

for (int i = 0; i < cantPend; i++)
{
    Console.WriteLine("--------Cargar tareas--------");
    Console.WriteLine("Ingrese la descripcion de la tarea: ");
    string aux1 = Console.ReadLine();
    Console.WriteLine("Ingrese la duracion: ");
    int aux2 = int.Parse(Console.ReadLine());
    ToDo tarea = new ToDo
    {
        TareaId = i+1,
        Descripcion = aux1,
        Duracion = aux2
    };
    tareaPendiente.Add(tarea);
}


int stop =1;

while(stop != 0){
    Console.WriteLine("-------Interfaz-------");
    Console.WriteLine("(1) Para mostrar tareas pendientes");
    Console.WriteLine("(2) Para mostrar tareas realizadas");
    Console.WriteLine("(3) Mover una tarea a realizadas");
    Console.WriteLine("(4) Buscar una tarea por descripcion");
    Console.WriteLine("(0) Salir ");
    stop = int.Parse(Console.ReadLine());

    switch (stop)
    {
        case 1:
            foreach (ToDo tarea in tareaPendiente)
            {
            Console.WriteLine("----Tareas Pendientes----");
            Console.WriteLine("Id de la tarea: "+tarea.TareaId);
            Console.WriteLine("Descripcion de la tarea: "+tarea.Descripcion);
            Console.WriteLine("Duracion de la tarea: "+tarea.Duracion);
            }
        break;
        case 2:
            foreach (ToDo tarea in tareaRealizada)
        {
            Console.WriteLine("----Tareas Realizadas----");
            Console.WriteLine("Id de la tarea: "+tarea.TareaId);
            Console.WriteLine("Descripcion de la tarea: "+tarea.Descripcion);
            Console.WriteLine("Duracion de la tarea: "+tarea.Duracion);
        }
        break;
        case 3:
            Console.WriteLine("Ingrese el id de la tarea que quiere poner como realizada: ");
            int id = int.Parse(Console.ReadLine());

            for (int j = 0; j < tareaPendiente.Count; j++)
            {
                if (id == tareaPendiente[j].TareaId)
                {
                    ToDo seleccion = tareaPendiente[j];
                    tareaRealizada.Add(seleccion);
                    tareaPendiente.Remove(seleccion);
                }
            }
        break;
        case 4:
            Console.WriteLine("Ingrese la descripcion del trabajo que quiere buscar: ");
            string aux = Console.ReadLine();
            //cadena1.Equals(cadena2) Otra forma de hacerlo.
            foreach (ToDo item in tareaPendiente)
            {
                if (aux == item.Descripcion)
                {
                    Console.WriteLine("---Tarea en Pendientes---");
                    Console.WriteLine("Id de la tarea: "+item.TareaId);
                    Console.WriteLine("Descripcion de la tarea: "+item.Descripcion);
                    Console.WriteLine("Duracion de la tarea: "+item.Duracion);
                }
            }
            foreach (ToDo item in tareaRealizada)
            {
                if (aux == item.Descripcion)
                {
                    Console.WriteLine("---Tarea en Realizadas---");
                    Console.WriteLine("Id de la tarea: "+item.TareaId);
                    Console.WriteLine("Descripcion de la tarea: "+item.Descripcion);
                    Console.WriteLine("Duracion de la tarea: "+item.Duracion);
                }
            }
        break;
       
    }

}

int contMin = 0;

foreach (ToDo horas in tareaRealizada)
{
    contMin += horas.Duracion;
}

Console.WriteLine("Total de minutos trabajados en tareas realizadas: "+contMin);

string ruta = "horasTrabajo.txt";

using (StreamWriter sumario = new StreamWriter(ruta)){
    sumario.WriteLine("Total de minutos trabajados: "+contMin);
}
