// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[] InputArray(string text)
{
    System.Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
}

void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] Coords(double[] k, double[] b)
{
    double[] dotXY = new double[2];
    dotXY[0] = (b[1] - b[0]) / (k[0] - k[1]);
    dotXY[1] = k[0] * dotXY[0] + b[0];
    return dotXY;
}

double[] coordK = InputArray("Input K ");
double[] coordB = InputArray("Input B ");
PrintArray(Coords(coordK, coordB));