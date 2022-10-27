/*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
casas decimais conforme exemplos.
Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159 */

using System.Globalization;

double area, r, pi = 3.14159;

Console.WriteLine("Informe o valor do raio:");
r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = r * r * pi;

Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));