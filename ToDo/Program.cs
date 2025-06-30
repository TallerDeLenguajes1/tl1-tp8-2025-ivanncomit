using System.Runtime.InteropServices;
using EspacioTareas;

string[] Descripciones = { "Laburo", "Encargo", "Entregas", "Despacho", "Reposicion" };

Random x = new Random();

int indice, i, duracion, opcion, opcion1=1, indiceElegido, cantEliminadas = 0, opcionPrincipal;
int randon = x.Next(1, 10);
string descbuscar, aux;

List<Tarea> TPendientes = new List<Tarea>();
List<Tarea> TRealizadas = new List<Tarea>();

for (i = 1; i < randon + 1; i++)
{
    indice = x.Next(0, 4);
    duracion = x.Next(1, 20);
    Tarea NuevaTarea = new Tarea(i, Descripciones[indice], duracion);
    TPendientes.Add(NuevaTarea);
}

    System.Console.WriteLine("MOVER TAREAS P->R - 1 \nMOSTRAR LISTAS - 2\nBUSCAR POR DESC - 3\nSALIR - c/o");
    aux = Console.ReadLine();
    int.TryParse(aux, out opcionPrincipal);

do
{

    if (opcionPrincipal == 1)
    {
        opcion = 1;
        while (opcion == 1)
        {
            Console.WriteLine($"ID de la tarea a mover de {1} a {randon - cantEliminadas}: ");
            aux = Console.ReadLine();
            int.TryParse(aux, out indiceElegido);
            /* TPendientes.ForEach(p => p.TareaID == indiceElegido); comentario profe*/
            for (i = 0; i < TPendientes.Count; i++)
            {
                if (TPendientes[i].TareaID == indiceElegido)
                {
                    cantEliminadas++;
                    TRealizadas.Add(TPendientes[i]);
                    TPendientes.RemoveAt(i);
                }
            }
            Console.WriteLine("Desea Continuar? 1 - SI | C/O - NO");
            aux = Console.ReadLine();
            int.TryParse(aux, out opcion);
        }

    }

    if (opcionPrincipal == 2)
    {
        Mostrar(TPendientes, TRealizadas);
    }

    if (opcionPrincipal == 3)
    {
        do
        {
            System.Console.WriteLine("ingrese una descripcion para buscar en la lista de pendientes:");
            descbuscar = Console.ReadLine();
            Busqueda(TPendientes, descbuscar);
            System.Console.WriteLine("Desea buscar por otra descripcion? 1 - SI | c/o - NO");
            aux = Console.ReadLine();
            int.TryParse(aux, out opcion1);
        } while (opcion1 == 1);
    }

    System.Console.WriteLine("Desea Continuar? Presionar 1 | 2 | 3\nMOVER TAREAS P->R - 1 \nMOSTRAR LISTAS - 2\nBUSCAR POR DESC - 3\nSALIR - c/o");
    aux = Console.ReadLine();
    int.TryParse(aux, out opcionPrincipal);
} while (opcionPrincipal >= 1 && opcionPrincipal <= 3);







void Mostrar(List<Tarea> pendientes, List<Tarea> realizadas)
{
    Console.WriteLine("--------------LISTA - PENDIENTES ------------");

    foreach (var p in pendientes)
    {
        Console.WriteLine($"Descripcion Tarea: {p.Descripcion} | ID: {p.TareaID} | Duracion: {p.Duracion}");
    }

    Console.WriteLine("--------------LISTA - REALIZADAS ------------");
    foreach (var p in realizadas)
    {
        Console.WriteLine($"Descripcion Tarea: {p.Descripcion} | ID: {p.TareaID} | Duracion: {p.Duracion}");
    }
}

void Busqueda (List<Tarea> ListaBuscar, string DescripcionBuscar)
{
    foreach(var tareas in ListaBuscar){
        if (tareas.Descripcion == DescripcionBuscar)
        {
            System.Console.WriteLine($"Tarea: {tareas.Descripcion} | Duracion: {tareas.Duracion} | ID: {tareas.TareaID}");
        }
    }
}