Menu();

static void Menu()
{
  Console.Clear();
  while (true)
  {
    Console.WriteLine("Enter the desired operation:");
    Console.WriteLine("1 - ADD");
    Console.WriteLine("2 - SUBTRACT");
    Console.WriteLine("3 - MULTIPLY");
    Console.WriteLine("4 - DIVIDE");
    Console.WriteLine("5 - EXIT");

    short option = GetShortInput();
    if (option < 1 || option > 5)
    {
      Console.WriteLine("INVALID OPTION!");
      continue;
    }

    if (option == 5) Exit();

    Console.Clear();
    Console.Write("FIRST VALUE: ");
    float value1 = GetFloatInput();

    Console.Write("SECOND VALUE: ");
    float value2 = GetFloatInput();

    switch (option)
    {
      case 1: Add(value1, value2); break;
      case 2: Subtract(value1, value2); break;
      case 3: Multiply(value1, value2); break;
      case 4: Divide(value1, value2); break;
    }
    Console.WriteLine();
  }
}

static short GetShortInput()
{
  return short.TryParse(Console.ReadLine(), out short result) ? result : (short)-1;
}

static float GetFloatInput()
{
  return float.TryParse(Console.ReadLine(), out float result) ? result : -1;
}

static void Add(float value1, float value2)
{
  Console.WriteLine($"The result of the addition is: {value1 + value2:F2}");
}

static void Subtract(float value1, float value2)
{
  Console.WriteLine($"The result of the subtraction is: {value1 - value2:F2}");
}

static void Multiply(float value1, float value2)
{
  Console.WriteLine($"The result of the multiplication is: {value1 * value2:F2}");
}

static void Divide(float value1, float value2)
{
  Console.WriteLine(value2 == 0 ? "Error! Cannot divide by zero." : $"The result of the division is: {value1 / value2:F2}");
}

static void Exit()
{
  Console.WriteLine("Thank you for using the calculator.\nSee you next time!");
  Environment.Exit(0);
}
