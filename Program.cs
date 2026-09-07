
Menu();


static void Menu()
{   bool successTime = false;
    bool successType = false;

    do
    {
        Console.Clear();
        Console.WriteLine("S = segundos => Ex: 10s = 10 segundos");
        Console.WriteLine("M = minutos => Ex: 10m = 10 minutos");
        Console.WriteLine("H = horas => Ex: 2h = 2 horas");
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
        if (data.Length == 0)
        {
            Console.Clear();
            Console.WriteLine("Digite um tempo válido, por exemplo: 10s, 10m ou 10h");
            Thread.Sleep(1500);
            successType = false;
            continue;
        }

        successType = char.TryParse(data.Substring(data.Length-1,1), out char type);
        successTime = int.TryParse(data.Substring( 0, data.Length -1), out int time);
        int multiplier = 1;
        successType = type == 's' || type == 'm'|| type == 'h';
        if (successType)
        {
            if (type == 's')
                multiplier = 1;
            if (type == 'm')
            {
                multiplier = 60;
            }
            if (type == 'h')
            {
                multiplier = 3600;
            }
            if (time < 0)
            {
                Console.Clear();
                Console.WriteLine("Número não válido!");
                Thread.Sleep(2000);
                successTime = false;
            }
            if (successTime && successType)
                PreStart(time * multiplier);
        }  
    }
    while(successTime == false || successType == false);
}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready----");
    Thread.Sleep(1000);
    Console.WriteLine("Set----");
    Thread.Sleep(1000);
    Console.WriteLine("Go----");
    Thread.Sleep(1500);

    Start(time);
}

static void Start(int time) 
{
    int currentTime = 0;

    do
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
    } while(currentTime < time);
       


    Console.Clear();
    Console.WriteLine("Stopwatch finalizado!");
    Thread.Sleep(1000);
    Menu();
}
