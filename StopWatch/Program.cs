Menu();

static void Menu()
{
  while (true)
  {
    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1 - STOPWATCH");
    Console.WriteLine("2 - TIMER");
    Console.WriteLine("3 - EXIT");

    if (!short.TryParse(Console.ReadLine(), out short option) || option < 1 || option > 3)
    {
      Console.WriteLine("ERROR! Please, select a valid option.");
      Thread.Sleep(2000);
      continue;
    }

    switch (option)
    {
      case 1: SubMenu(option); break;
      case 2: SubMenu(option); break;
      case 3: Exit(); break;
    }
  }
}

static void SubMenu(int option)
{
  while (true)
  {
    Console.Clear();
    Console.WriteLine("B - BACK");
    Console.WriteLine("E - EXIT");
    Console.Write("How long to count? ");

    string data = Console.ReadLine().ToLower();
    if (data == "b") return;
    if (data == "e") Exit();

    bool number = int.TryParse(data, out int time);

    if (!number || time <= 0)
    {
      Console.WriteLine("ERROR! Please, enter a valid number.");
      Thread.Sleep(2000);
      continue;
    }

    Console.Write("SECONDS OR MINUTES? Type S or M: ");
    string typeInput = Console.ReadLine().ToLower();

    if (typeInput != "s" && typeInput != "m")
    {
      Console.WriteLine("ERROR! Please, enter S for seconds or M for minutes.");
      Thread.Sleep(3000);
      continue;
    }

    char type = char.Parse(typeInput);
    int multiplier = type == 'm' ? 60 : 1;

    switch (option)
    {
      case 1: Stopwatch(time, multiplier); break;
      case 2: Timer(time, multiplier); break;
    }
    break;
  }
}

static void Stopwatch(int time, int multiplier)
{
  int currentTime = 0;
  while (currentTime < time * multiplier)
  {
    Console.Clear();
    currentTime++;
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
  Finished();
}

static void Timer(int time, int multiplier)
{
  for (int currentTime = time * multiplier; currentTime > 0; currentTime--)
  {
    Console.Clear();
    Console.WriteLine(currentTime);
    Thread.Sleep(1000);
  }
  Finished();
}

static void Finished()
{
  Console.Beep();
  Console.WriteLine("FINISHED!");
  Thread.Sleep(3000);
}

static void Exit()
{
  Console.WriteLine("\nThank you for using the Stopwatch Timer App.\nSee you next time!");
  Environment.Exit(0);
}