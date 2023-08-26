using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFTStart4NET.Desafio
{
    public class Triângulo
    {
        public void resultado()
        {
            double a, b, c, perimetro, area;
            string[] valor = Console.ReadLine().Split();
            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);

            if (a + b > c && b + c > a && a + c > b)
            {
                // verifica se os valores formam um triângulo
                perimetro = a + b + c;
                Console.WriteLine($"Perimetro = {perimetro:F1}");
            }
            else
            {
                // se não forma um triângulo, calcula a área do trapézio
                area = ((a + b) * c) / 2.0;
                Console.WriteLine($"Area = {area:F1}");
            }

        }
    }
}

/*
 * 
 * Desafio
Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo (soma de todos os lados) e apresente a mensagem:

Perimetro = XX.X

Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem:

Area = XX.X

Fórmula da área de um trapézio: AREA = ((A + B) x C) / 2

Entrada
A entrada contém três valores reais.

Saída
O resultado deve ser apresentado com uma casa decimal.

 
Exemplo de Entrada	Exemplo de Saída
6.0 4.0 2.0

Area = 10.0

6.0 4.0 2.1

Perimetro = 12.1
 * 
 */
