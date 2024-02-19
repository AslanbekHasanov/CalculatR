// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------
homePage:
Console.Clear();
System.Console.WriteLine("Welcome to, my project");
System.Console.WriteLine("1.Geomtry Guru");
System.Console.WriteLine("2.Simple Calculatr");

System.Console.Write("Enter command(1 or 2): ");
int command = Convert.ToInt32(Console.ReadLine());

if(command == 1)
{
  Console.Clear();
  System.Console.WriteLine("===== Geomtry Guru =====");
  System.Console.WriteLine("1.Calculation of the surface area of a circle");
  System.Console.WriteLine("2.Calculate the perimeter of a rectangle");
  System.Console.WriteLine("3.Go to home page");
  System.Console.Write("Enter command: ");
  int commandOne = Convert.ToInt32(Console.ReadLine());

  if(commandOne == 1)
  {
    System.Console.Write("Enter circle radius: ");
    double radius = Convert.ToDouble(Console.ReadLine());

    System.Console.WriteLine($"Surface: {Math.PI * Math.Pow(radius, 2)}");

  }
  else if(commandOne == 2)
  {
    System.Console.Write("Enter the height of the rectangle: ");
    double height = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Enter the width of the rectangle: ");
    double width = Convert.ToInt32(Console.ReadLine());

    System.Console.WriteLine($"Perimeter: {2 * (width + height)}");


  }
  else if(commandOne == 3)
  {
    goto homePage;

  }
}
else if(command == 2)
{
  Console.Clear();
  System.Console.WriteLine("===== Simple Calculatr ===== \n");
  System.Console.WriteLine("1.Calculatr");
  System.Console.WriteLine("2.Tub number");
  System.Console.WriteLine("3.Go to home page");

  System.Console.Write("Enter command: ");
  int commandTwo = Convert.ToInt32(Console.ReadLine());

 if(commandTwo == 1)
 {
  Console.Clear();
  System.Console.WriteLine("==== Calculatr ====");
  System.Console.Write("\nEnter the values as follows(i: {2 * 3} o: {2 * 3 = 6}:  ");
  string[] @operator = Console.ReadLine().Split(' ');

  if(@operator[1].Contains('+'))
  {
    System.Console.WriteLine($"{@operator[0]} + {@operator[2]} = " +
                            $"{Convert.ToDouble(@operator[0]) + Convert.ToDouble(@operator[2])}");
  }

  else if(@operator[1].Contains('-'))
  {
    System.Console.WriteLine($"{@operator[0]} - {@operator[2]} = " +
                            $"{Convert.ToDouble(@operator[0]) - Convert.ToDouble(@operator[2])}");
  }

  else if(@operator[1].Contains('/'))
  {
    System.Console.WriteLine($"{@operator[0]} / {@operator[2]} = " +
                            $"{Convert.ToDouble(@operator[0]) / Convert.ToDouble(@operator[2])}");
  }

  else if(@operator[1].Contains('*'))
  {
    System.Console.WriteLine($"{@operator[0]} * {@operator[2]} = " +
                            $"{Convert.ToDouble(@operator[0]) * Convert.ToDouble(@operator[2])}");
  }

  else if(@operator[1].Contains('^'))
  {
    System.Console.WriteLine($"{@operator[0]} ^ {@operator[2]} = " +
                            $"{Math.Pow(Convert.ToDouble(@operator[0]),Convert.ToDouble(@operator[2]))}");
  }

 }
 else if(commandTwo == 2)
 {
  Console.Clear();
  System.Console.WriteLine("==== Tub number ====");

  System.Console.Write("\nEnter number:");
  int number = Convert.ToInt32(Console.ReadLine());
  bool isTub = true;
  if(number > 0 && number <= 2)
    System.Console.WriteLine("Tub");
  else
  {
    for(int itarator = 2; itarator < number; itarator++)
    {
      if(number % 2 == 0)
        isTub = false;
    }

    if(isTub == false)
      System.Console.WriteLine("Not Tub");
    else
      System.Console.WriteLine("Tub");


  }

 }
 else if(commandTwo == 3)
 {
  goto homePage;

 }

}
