
while (true)
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if ((a + b) % 6 == 0)
    {
        Console.WriteLine("6ya bolunur");
        break;
    }
    Console.WriteLine("6ya bolunmur");
}
