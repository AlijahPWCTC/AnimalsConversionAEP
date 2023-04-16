using System.Reflection.PortableExecutable;
using System;


public class Dog : Pet, ITalkable{
  private Boolean friendly {get; set;}

  public Dog(Boolean friendly, string name) {
      this.name = name;
      this.friendly = friendly;
    }

    public Boolean isFriendly() {
      return friendly;
    }

  public string talk() {
        return "Bark";
    }

    public string toString() {
      return "Dog: " + "name=" + name + " friendly=" + friendly;
    }

}