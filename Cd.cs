using System;
using System.Collections.Generic;

class Cd
{
  public string Title;
  public string Artist;
  public int Price;
}

public class Program
{
  public static void Main()
  {
    Cd first = new Cd();
    first.Title = "Danger";
    first.Artist = "BTS";
    first.Price = 7;

    Cd second = new Cd();
    second.Title = "Exodus";
    second.Artist = "Exo";
    second.Price = 7;

    List<Cd> cdList = new List<Cd> { first, second };

    foreach(Cd eachCd in cdList)
    {
      Console.WriteLine(eachCd.Title);
      Console.WriteLine(eachCd.Artist);
      Console.WriteLine(eachCd.Price);
    }
  }
}
