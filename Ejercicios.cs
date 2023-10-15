using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios4Practicos_RLG
{
    internal class Ejercicios
    {
        public void array()
        {

            //a) Escriba una instrucción que declare y cree a t.
            int[,] t = new int [2, 3];
            //valores para diferenciar en punto e) y f).
            t[0, 0] = 1;
            t[0, 1] = 4;
            t[0, 2] = 0;
            t[1, 0] = 2;
            t[1, 1] = 4;
            t[1, 2] = 0;
            //b) ¿Cuántas filas tiene t?
            int totalFilas = 0;
            for (int fila=0;fila < t.GetLength(0) ; fila++)
            {
                totalFilas += 1;
            }
            Console.WriteLine($"Total de filas: {totalFilas}");
            //c) ¿Cuántas columnas tiene t?
            int totalColumnas = 0;
            for (int columna = 0; columna < t.GetLength(1); columna++)
            {
                totalColumnas += 1;
            }
            Console.WriteLine($"Total de columnas: {totalColumnas}");
            //d) ¿Cuántos elementos tiene t?
            int elemento = 0;
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    elemento += 1;
                }
            }
            Console.WriteLine("Total de elementos: "+elemento);
            //e) Escriba expresiones de acceso para todos los elementos en la fila 1 de t.
            int element;
            for (int fila = 1; fila < t.GetLength(0); fila++)
            {
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    element = t[fila,columna];
                    Console.WriteLine($"Fila {fila+1} elemento:"+ element);
                }
            }
            //f ) Escriba expresiones de acceso para todos los elementos en la columna 2 de t.
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                    element = t[fila, 2];
                    Console.WriteLine($"Columna 2 elemento:" + element);
            }
            //g) Escriba una sola instrucción que asigne cero al elemento de t en la fila 0 y la columna 1.
            t[0, 1] = 0;
            //h) Escriba una serie de instrucciones que inicialice cada elemento de t con cero.No utilice una instrucción de repetición.
            t[0,0] = 0;
            t[0,1] = 0;
            t[0,2] = 0;
            t[1,0] = 0;
            t[1,1] = 0;
            t[1,2] = 0;
            //i) Escriba una instrucción for anidada que inicialice cada elemento de t con cero.
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    t[fila, columna]=0;
                    Console.Write(t[fila,columna]+" ");
                }
                Console.WriteLine();
            }
            //j) Escriba una instrucción for anidada que reciba como entrada del usuario los valores de los elementos de t.
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                Console.Write($"Escriba los valores en la fila {fila+1} ");
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    Console.WriteLine($"Misma fila y columna {columna+1}");
                    t[fila, columna] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //k) Escriba una serie de instrucciones que determine e imprima el valor más pequeño en t.
            int valorMasPequeno = t[0, 0]; // Inicializa con el primer valor y hacer la condicion debido a que es un arreglo bidemensional
            //y este arregglo solo guardara un valor que seria el menor de todo el arreglo llendo uno por uno 
            //empezando desde el valor de la fila 0 y columna 0 y si se encuentra otro valor mas pequeño cambiara el valor por el de esa posicion
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    if (t[fila, columna] < valorMasPequeno)
                    {
                        valorMasPequeno = t[fila, columna];
                    }
                }
            }
            Console.WriteLine("El valor más pequeño en el arreglo es: " + valorMasPequeno);

            //l) Escriba una instrucción Console.WriteLine que muestre los elementos de la primera fila de t. No utilice repetición.
            Console.WriteLine($"{t[0,0]} | {t[0, 1]} | {t[0, 2]}");
            //m) Escriba una instrucción que totalice los elementos de la tercera columna de t.No utilice repetición.
            int totalElementosC3 = t.GetLength(0);
            Console.WriteLine("Total de elementos en columna 3: "+totalElementosC3);
            //n) Escriba una serie de instrucciones para imprimir el contenido de t en formato tabular.Enliste los índices de columna como encabezados a lo largo de la parte superior, y enliste los índices de fila a la izquierda de cada fila.
            Console.Write("      ");
            for (int columna = 0; columna < t.GetLength(1); columna++)
            {
                Console.Write("Columna " + columna + "  ");// vista de columnas
            }
            Console.WriteLine();

            //índices de fila
            for (int fila = 0; fila < t.GetLength(0); fila++)
            {
                Console.Write("Fila " + fila + ": ");
                for (int columna = 0; columna < t.GetLength(1); columna++)
                {
                    Console.Write("  "+t[fila, columna] + "         ");
                }
                Console.WriteLine(); 
            }


        }

    }
}
