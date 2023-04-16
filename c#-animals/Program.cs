using System;
using System.Collections;
using System.IO;
using System.Text;

public class Animals  {
  public static void Main()  {

    StreamWriter sw = new StreamWriter("C:\\Users\\amazo\\OneDrive - Waukesha County Technical College\\Mobile App\\c#-animals\\animals.txt");
    

    ArrayList zoo = new ArrayList();
    CreateAnimal(zoo);
    CreateAnimal(zoo);
    CreateAnimal(zoo);

    foreach(ITalkable thing in zoo){
      PrintOut(thing, sw);
    }
    sw.Close();
    
    StreamReader sr = new StreamReader("C:\\Users\\amazo\\OneDrive - Waukesha County Technical College\\Mobile App\\c#-animals\\animals.txt");

    string? line = sr.ReadLine();

    while (line != null) {
      Console.WriteLine(line);
      line = sr.ReadLine();
    }
    sr.Close();
    

  }
  public static void PrintOut(ITalkable p, StreamWriter sw) {
      Console.WriteLine(p.getName() + " says " + p.talk());
      sw.WriteLine(p.getName() + " | " + p.talk());
    }
  
  public static void CreateAnimal(ArrayList list){
    Console.WriteLine("What type of animal would you like to create 1. Dog 2. Cat\nPlease enter a number.");
    int type = 0;
    string? name = "";
    string? temp= "";
    Boolean friendly = true;
    int mousesKilled = -1;

    int i=0;
    while(i<1){
      try{
        type = int.Parse(Console.ReadLine());
      }
      catch (Exception e){
        Console.WriteLine("Error "+e);
      }
      if(type == 1 || type == 2){
        break;
      }
      else{
        Console.WriteLine("Please Try Again\nWhat type of animal would you like to create 1. Dog 2. Cat\nPlease enter a number.");
      }
    }
    

    if(type==1){
      Console.WriteLine("What is the dog's name?");
      while(i<1){
        try{
          name = Console.ReadLine();
        }
        catch (Exception e){
          Console.WriteLine("Error "+e);
        }
        if(name == "" || name == null){
          Console.WriteLine("What is the dog's name?");
        }
        else{
          break;
        }
      }

      Console.WriteLine("Is the dog friendly? Y/N");
      while(i<1){
        try{
          temp = Console.ReadLine();
        }
        catch (Exception e){
          Console.WriteLine("Error "+e);
        }
        if(string.Equals("Y", temp, StringComparison.CurrentCultureIgnoreCase)==true|| string.Equals("N", temp, StringComparison.CurrentCultureIgnoreCase)==true){
          break;
        }
        else{
          Console.WriteLine("Is the dog friendly? Y/N");
        }
      }
      if(string.Equals("Y", temp, StringComparison.CurrentCultureIgnoreCase)==true){
        friendly=true;
      }
      else if(string.Equals("N", temp, StringComparison.CurrentCultureIgnoreCase)==true){
        friendly=false;
      }
      list.Add(new Dog(friendly, name));
    }


    else if (type==2){
      while(i<1){
        Console.WriteLine("What is the cat's name?");
        try{
          name = Console.ReadLine();
        }
        catch (Exception e){
          Console.WriteLine("Error "+e);
        }
        if(name == "" || name == null){
          Console.WriteLine("What is the cat's name?");
        }
        else{
          break;
        }
      }

      Console.WriteLine("How many mice has the cat killed?\nPlease enter a number.");
      while(i<1){
        try{
          mousesKilled = int.Parse(Console.ReadLine());
        }
        catch (Exception e){
          Console.WriteLine("Error "+e);
        }
        if(mousesKilled>=0){
          break;
        }
        else{
          Console.WriteLine("How many mice has the cat killed?\nPlease enter a number.");
        }
      }
      
      list.Add(new Cat(mousesKilled, name));
    }
  
  }
}

