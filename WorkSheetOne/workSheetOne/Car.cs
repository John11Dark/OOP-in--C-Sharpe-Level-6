public class Car
{
  // Attributes
  public string Color { get; set; }
  public string Manufacturer { get; set; }
  public string TypeOfFuel { get; set; }
  public double Liters { get; set; }
  public double OdometerReading { get; set; }

  // Behaviors
  public void FillTank(double monetaryAmount)
  {
    if (string.IsNullOrEmpty(TypeOfFuel))
    {
      Console.WriteLine("Error: Please enter car details before refueling.");
      return;
    }

    double litres = 0;
    if (TypeOfFuel.ToLower() == "diesel")
    {
      litres = monetaryAmount * 0.71;
    }
    else if (TypeOfFuel.ToLower() == "petrol")
    {
      litres = monetaryAmount * 0.65;
    }

    Liters += litres;
  }

  public string CarDetails(string typeOfFuel, double odometerReading, string color)
  {
    if (typeOfFuel.ToLower() != "petrol" && typeOfFuel.ToLower() != "diesel")
    {
      return "The inputted type of fuel is incorrect";
    }

    TypeOfFuel = typeOfFuel;
    OdometerReading = odometerReading;
    Color = color;

    return "";
  }

  public void RePaint(string newColor)
  {
    Color = newColor;
  }


  public void Drive(string destination)
  {
    if (string.IsNullOrEmpty(destination))
    {
      Console.WriteLine("Error: Destination cannot be empty.");
      return;
    }

    Console.WriteLine($"The car has started driving towards {destination}.");
    // Assuming 10 km per liter
    double distance = 10 * Liters;
    OdometerReading += distance;
    Liters = 0;
  }
}
