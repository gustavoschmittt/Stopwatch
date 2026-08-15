
Menu();


static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = segundos => Ex: 10s = 10 segundos");
    Console.WriteLine("M = minutos => Ex: 10m = 10 minutos");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo quer contar: ");

    string data = Console.ReadLine().ToLower(); 
    if (data == "0")
    {
        Console.Clear();
        Console.WriteLine("--Encerrando Stopwacth--");
        Thread.Sleep(2000);
        Console.Clear();
        System.Environment.Exit(0);
    }

    char type = char.Parse(data.Substring(data.Length-1,1));
    int time = int.Parse(data.Substring( 0, data.Length -1));
    int multiplier = 1;
    
    if (type == 'm')
    {
        multiplier = 60;
    }
    if (time < 0)
    {
        Console.Clear();
        Console.WriteLine("Número não válido!");
        Thread.Sleep(2000);
        Console.Clear();
        System.Environment.Exit(0);
    }
    PreStart(time * multiplier);    


}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Read----");
    Thread.Sleep(1000);
    Console.WriteLine("Set----");
    Thread.Sleep(1000);
    Console.WriteLine("Go----");
    Thread.Sleep(1500);

    Start(time);
}

static void Start(int time) 
{
    for (int currentTime = 1; currentTime <= time; currentTime++)
    {
        Console.Clear();
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    }
       


    Console.Clear();
    Console.WriteLine("Stopwatch finalizado!");
    Thread.Sleep(1000);
    Menu();
}
