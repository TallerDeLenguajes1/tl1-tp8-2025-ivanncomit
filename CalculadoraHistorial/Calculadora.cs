// See https://aka.ms/new-console-template for more information

using EspacioCalculadora;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public Calculadora(double dato = 0)
        {
            this.dato = dato;
        }

        public double Sumar(double termino)
        {
            dato = dato + termino;
            return (dato);
        }
        public double Restar(double termino)
        {
            dato = dato - termino;
            return (dato);
        }
        public double Multiplicar(double termino)
        {
            dato = dato * termino;
            return (dato);
        }
        public double Dividir(double termino)
        {
            dato = dato / termino;
            return (dato);
        }
        public void Limpiar()
        {
            Console.Clear();
        }

        public double Resultado
        {
            get => dato;
        }
    }

    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar  // Representa la acción de borrar el resultado actual o el historial 
    }



    public class Operacion
    {
        public Operacion(double nuevoIngresar, double anteriorIngresar, TipoOperacion operacionIngresar)
        {
            this.resultadoAnterior = anteriorIngresar;
            this.nuevoValor = nuevoIngresar;
            this.operacion = operacionIngresar;
        }

        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual 
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
        private TipoOperacion operacion;// El tipo de operación realizada 

        public TipoOperacion Toperacion
        {
            get => operacion;
        }
        public double Resultado
        {
            get
            {
                switch (operacion)
                {
                    case TipoOperacion.Suma:
                        return resultadoAnterior + nuevoValor;

                    case TipoOperacion.Resta:
                        return resultadoAnterior - nuevoValor;

                    case TipoOperacion.Multiplicacion:
                        return resultadoAnterior * nuevoValor;

                    case TipoOperacion.Division:
                        return nuevoValor != 0 ? resultadoAnterior / nuevoValor : throw new DivideByZeroException("No se puede dividir por cero.");

                    case TipoOperacion.Limpiar:
                        return 0;

                    default:
                        throw new InvalidOperationException("Operación no válida.");
                }
            }
        }
        // Propiedad pública para acceder al nuevo valor utilizado en la operación 
        public double NuevoValor
        {
            get => nuevoValor;
        }
    }
}




