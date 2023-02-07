
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; // true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1,4);
    //Console.WriteLine($"Cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess. Ente ra number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false;
    } else
    {
        Console.WriteLine("Oops, try again!");
            
    }
}
Console.WriteLine("Have a nice day!");