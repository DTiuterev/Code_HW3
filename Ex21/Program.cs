// Нахождение расстояния между двумя точками в 3D пространстве

Console.WriteLine("Введите координаты точек А (x1, y1, z1) и B (x2, y2, z2)");
 
Console.WriteLine("Точка А, введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Точка А, введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Точка А, введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Точка B, введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Точка B, введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Точка B, введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между точками А и В в 3D пространстве равно {distance}");

