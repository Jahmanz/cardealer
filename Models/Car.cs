namespace CarDealer.Models
{
  public class Car
  {
    private string _makeModel;
    private int _price;
    private int _miles;

    public Car(string makeModel, int miles, int price)
    {
      _makeModel = makeModel;
      _price = price;
      _miles = miles;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public string GetMakeModel()
    {
      return _makeModel;
    }

    public int GetMiles()
    {
      return _miles;
    }
  }
}

// public class Program
// {
//   public static void Main()
//   {
//     Car porsche = new Car();
//     porsche.MakeModel = "2014 Porsche 911";
//     porsche.Price = 114991;
//     porsche.Miles = 7864;
//
//     Car ford = new Car();
//     ford.MakeModel = "2011 Ford F450";
//     ford.Price = 55995;
//     ford.Miles = 14241;
//
//     Car lexus = new Car();
//     lexus.MakeModel = "2013 Lexus RX 350";
//     lexus.Price = 44700;
//     lexus.Miles = 20000;
//
//     Car mercedes = new Car();
//     mercedes.MakeModel = "Mercedes Benz CLS550";
//     mercedes.Price = 39900;
//     mercedes.Miles = 37979;

//     List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };
//     foreach(Car automobile in Cars)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//
//     Console.WriteLine("Enter maximum price: ");
//     string stringMaxPrice = Console.ReadLine();
//     int maxPrice = int.Parse(stringMaxPrice);
//
//     List<Car> CarsMatchingSearch = new List<Car>();
//
//     foreach (Car automobile in Cars)
//     {
//       if (automobile.Price < maxPrice)
//       {
//         CarsMatchingSearch.Add(automobile);
//       }
//     }
//
//     foreach(Car automobile in CarsMatchingSearch)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//   }
// }














//       {
//       private string _recipient;
//       private string _sender;
//
//       public string GetRecipient()
//       {
//         return _recipient;
//       }
//
//       public void SetRecipient(string newRecipient)
//       {
//         _recipient = newRecipient;
//       }
//
//       public string GetSender()
//       {
//         return _sender;
//       }
//
//       public void SetSender(string newSender)
//       {
//         _sender = newSender;
//       }
//       }
// }