using System.Runtime.InteropServices;
using EspacioTareas;

string[] Descripciones = {"Laburo", "Encargo", "Entregas", "Despacho", "Reposicion"};

Random x = new Random();

int indice, i, duracion, opcion, indiceElegido, cantEliminadas=0;
int randon  = x.Next(1, 10);

List<Tarea> TPendientes = new List<Tarea>();
List<Tarea> TRealizadas = new List<Tarea>();

for(i=1;i<randon+1;i++)
{
    indice = x.Next(0,4);
    duracion = x.Next(1,20);
    Tarea NuevaTarea = new Tarea(i, Descripciones[indice], duracion);
    TPendientes.Add(NuevaTarea);
}

Console.WriteLine("¿Desea mover una tarea de la lista 'Pendientes' a 'Realizadas'?");
Console.WriteLine("1 - SI | Cualq. Otro - NO");

string aux = Console.ReadLine();
int.TryParse(aux, out opcion);

while (opcion == 1)
{
    Console.WriteLine($"ID de la tarea a mover de {1} a {randon}: ");
    aux = Console.ReadLine();
    int.TryParse(aux, out indiceElegido);
    /* TPendientes.ForEach(p => p.TareaID == indiceElegido); comentario profe*/
    for (i=0;i<TPendientes.Count;i++)
    {
        if(TPendientes[i].TareaID==indiceElegido)
        {
            cantEliminadas++;
            TRealizadas.Add(TPendientes[i]);
            TPendientes.RemoveAt(indiceElegido-cantEliminadas);
        }
    }
    Console.WriteLine("Desea Continuar? 1 - SI | C/O - NO");
    aux = Console.ReadLine();
    int.TryParse(aux, out opcion);
}

Console.WriteLine("--------------LISTA - PENDIENTES ------------");

foreach (var p in TPendientes)
{
   Console.WriteLine($"Descripcion Tarea: {p.Descripcion} | ID: {p.TareaID} | Duracion: {p.Duracion}"); 
}

Console.WriteLine("--------------LISTA - REALIZADAS ------------");
foreach (var p in TRealizadas)
{
   Console.WriteLine($"Descripcion Tarea: {p.Descripcion} | ID: {p.TareaID} | Duracion: {p.Duracion}"); 
}