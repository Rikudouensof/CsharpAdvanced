using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanced
{
  class Program2
  {

    static void Main(string[] args)
    {

    }

    public static void Encrption()
    {

    }

    public static void Cryptogrphy()
    {
      var stringText = "text to be tested";
      var stringKey = "key";
      //byte array
      byte[] convertedText = System.Text.Encoding.UTF8.GetBytes(stringText);
      byte[] convertedKey = System.Text.Encoding.UTF8.GetBytes(stringKey);
      string restored = System.Text.Encoding.UTF8.GetString(convertedText);

      //hashing
      var hasher = new System.Security.Cryptography.HMACSHA512(convertedKey);
      var hasheed = hasher.ComputeHash(convertedText);
      string harsedstring = Convert.ToBase64String(hasheed);
    }
    public static void Linqs(string[] args)
    {

      List<DataList> datalist1 = new List<DataList>();
      List<DataList> datalist2 = new List<DataList>();
      var randomData = new Random();

      for (int i = 0; i < 2; i++)
      {

        datalist1.Add(new DataList()
        {
          Id = i,
          Data = randomData.Next(1, 20),
          Name = randomData.NextDouble() * 2


        }
        );

       

      }
      for (int i = 0; i < 2; i++)
      {

        datalist2.Add(new DataList()
        {
          Id = i,
          Data = randomData.Next(1, 20),
          Name = randomData.NextDouble() * 2


        }
        );



      }


      var result = datalist1.Where(x => x.Id.ToString() == "search parameter");

      Console.WriteLine("Min");
      Console.WriteLine(datalist1.Min(x => x.Name));
      Console.WriteLine("Max");
      Console.WriteLine(datalist1.Max(x => x.Name));
      Console.WriteLine("Average");
      Console.WriteLine(datalist1.Average(x => x.Name));
      Console.WriteLine("Order by Assending");
      foreach (var item in datalist1.OrderBy(x => x.Name).ToList())
      {
        Console.WriteLine(item.Name);
      }
     
      Console.WriteLine("Order by Dessending");
      foreach (var item in datalist1.OrderByDescending(x => x.Name).ToList())
      {
        Console.WriteLine(item.Name);
      }

      Console.WriteLine("Group by Name");
      foreach (var item in datalist1.GroupBy(x => x.Name).ToList())
      {
        Console.WriteLine(item.Key);
      }
      Console.WriteLine("Join data 1 woyj data 2");
      var union = datalist1.Union(datalist2);
      foreach (var item in union)
      {
        Console.WriteLine(item.Name);
      }
      Console.ReadKey();
    }
  }


  public class DataList
  {
    public int Id { get; set; }

    public double Name { get; set; }

    public int Data { get; set; }
  }
}
