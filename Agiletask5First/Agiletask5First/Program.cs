Console.WriteLine("ededi daxil edin");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[5];
arr[0] = 6;
arr[1] = 7;
arr[2] = 8;
arr[3] = 9;
arr[4] = 10;

bool numberexist = Array.Exists(arr, any => any == number);
if (numberexist)
{
    Console.WriteLine( number + " reqemi bu arrayin icinde movcuddur");
}
else
{
    {
        Console.WriteLine(number + " reqemi bu arrayin icinde movcud deyil");
    }
}
