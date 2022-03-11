using System.Globalization;
using Testes;

double p = 0;
Triangulo x, y;

x=new Triangulo();
y=new Triangulo();  



Console.WriteLine("Entre com as medidas do triangulo X");
x.A = double.Parse(Console.ReadLine());
x.B = double.Parse(Console.ReadLine());
x.C = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com as medidas do triangulo Y");
y.A= double.Parse(Console.ReadLine());
y.B= double.Parse(Console.ReadLine());
y.C= double.Parse(Console.ReadLine());

p = (x.A + x.B + x.C) / 2;

areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

p = (yA + yB + yC) / 2;

areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

Console.WriteLine($"A area do triangulo X é {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
Console.WriteLine($"A area do triangulo Y é {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
if (areaX > areaY)
{
    Console.Write("Maior area X");
}
else
{
    Console.Write("Maior area Y");
}