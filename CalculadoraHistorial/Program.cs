using EspacioCalculadora;
List<Operacion> Historial = new List<Operacion>();

Calculadora calculadora = new Calculadora(10);

Operacion calculo1 = new Operacion(5, calculadora.Resultado, TipoOperacion.Suma);
Operacion calculo2 = new Operacion(5, calculo1.Resultado, TipoOperacion.Suma);

Historial.Add(calculo1);
Historial.Add(calculo2);

foreach (var item in Historial)
{
    Console.WriteLine($"{item.Resultado}");
}   
