using System.Reflection.PortableExecutable;
using System;


public class Cat : Pet, ITalkable{
  private int mousesKilled {get; set;}

  public Cat(int mousesKilled, string name) {
      this.name = name;
      this.mousesKilled = mousesKilled;
    }

    public int getMousesKilled() {
      return mousesKilled;
    }

    public void addMouse() {
      mousesKilled++;
    }

  public string talk() {
      return "Meow";
    }

    public string toString() {
      return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
    }

}