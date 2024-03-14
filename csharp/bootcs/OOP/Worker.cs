using OOP;

namespace OOP
{
  public class Worker
  {
    private int id;
    private int depId;
    private int age;
    private string fullName;
    private int salary;

    public Worker(int id, int depId, int age, string fullName, int salary)
    {
      this.id = id;
      this.depId = depId;
      this.age = age;
      this.fullName = fullName;
      this.salary = salary;
    }

    public override string ToString()
    {
      return $"id: {this.id}  Full name: {this.fullName}  age: {this.age}  salary: {this.salary}  dep id: {this.depId}";
    }

    public int GetId(){
      return id;
    }

    public int GetDepId(){
      return depId;
    }

    public int GetAge(){
      return age;
    }
    public string GetName(){
      return fullName;
    }

    public int GetSalary() {
      return salary;
    }

  }
}