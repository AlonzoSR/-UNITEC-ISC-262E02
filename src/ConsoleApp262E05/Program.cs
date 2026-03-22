using System.Diagnostics;
double lado_a = 5;
double lado_b = 7;  
double altura = 10;
double perimetro = Rectangulo262E02.Perimetro(lado_a, lado_b);
double area = Rectangulo262E02.Area(lado_a, lado_b);
double volumen = Rectangulo262E02.Volumen(area, altura);

Console.WriteLine($"El perimetro de un rectangulo de lado {lado_a}cm y de lado {lado_b}cm es {perimetro}cm");
Console.WriteLine($"El area de un rectangulo de lado {lado_a}cm y de lado {lado_b}cm es {area}cm2");
Console.WriteLine($"El volumen de un rectangulo con un area de la base {area}cm2 y {altura}cm de altura es {volumen}cm3");