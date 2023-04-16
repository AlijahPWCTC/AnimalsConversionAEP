using System;


public class Teacher : Person, ITalkable{
  private int age {get; set;}

    public Teacher(int age, String name) {
        this.name = name;
        this.age = age;
    }

    public string talk() {
        return "Don't forget to do the assigned reading!";
    }
}