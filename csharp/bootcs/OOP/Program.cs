using OOP;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker(1, 2, 23, "Мариванна", 1000);
            Worker worker2 = new Worker(2, 1, 64, "Ольсанна", 10000);
            Worker worker3 = new Worker(3, 3, 18, "Петрович", 51000);
            Worker worker4 = new Worker(4, 1, 33, "Сергеич", 64000);
            Worker worker5 = new Worker(5, 4, 128, "Михалыч", 10);
            Department department1 = new Department(1, "IT");
            Department department2 = new Department(2, "Sales");
            Department department3 = new Department(3, "Accounting");

            List<Department>? departments = new();
            departments.Add(department1);
            departments.Add(department2);
            departments.Add(department3);

            List<Worker>? workers = new();
            workers.Add(worker1);
            workers.Add(worker2);
            workers.Add(worker3);
            workers.Add(worker4);
            workers.Add(worker5);

            DataBase db = new DataBase(workers, departments);

            System.Console.WriteLine(worker1.ToString());
            System.Console.WriteLine("====");
            System.Console.WriteLine(department1.ToString());
            //try {
            System.Console.WriteLine(db.ToString());//} catch (NullReferenceException err){
                //System.Console.WriteLine("NULL");
                //System.Console.WriteLine(err.Message);
            //}
            
        }
    }
}