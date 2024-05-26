int a = 56;
int b = 78;
int c = 25;
static int Boyukeded(int a, int b, int c)
{
    return Math.Max(Math.Max(a, b), c);
}
static int Kicikeded(int a, int b, int c)
{
    return Math.Min(Math.Max(a, b), c);
}
Console.WriteLine("boyuk eded: " + Boyukeded(a,b,c));
Console.WriteLine("kicik eded: " + Kicikeded(a, b, c));
