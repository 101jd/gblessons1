using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
    public class DataBase
    {
        private List<Worker> workers;
        private List<string>? workerName;
        private List<int>? age;
        private List<string>? depName;
        private List<int>? workersDepId;
        public DataBase(List<Worker> workers, List<Department> departments)
        {
            try
            {
            //if (workers != null)
            {
                workerName = initName(workers);
                age = initAge(workers);
                depName = initDepName(workers, departments);
                workersDepId = initWorkersDepId(workers);
                this.workers = workers;
            }
            }
            catch (NullReferenceException err)
            {
                System.Console.WriteLine("NULL");
                System.Console.WriteLine(err.Message);
            }
        }
        
        public List<int> initAge(List<Worker> workers)
        {
            try{
            foreach (Worker worker in workers)
            {
                if (worker.GetAge() == null)
                    age.Add(0);
                age.Add(worker.GetAge());
            }
            
            } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
        return age;
        }
        public List<string> initName(List<Worker> workers)
        {
            try{
            foreach (Worker worker in workers)
            {
                if (worker.GetName() == null)
                    workerName.Add(" ");
                workerName.Add(worker.GetName());
            }
            } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
            return workerName;
        }
        public List<int> initWorkersDepId(List<Worker> workers)
        {
            try{
            foreach (Worker worker in workers)
            {
                if (worker.GetDepId() == null)
                    workersDepId.Add(0);
                workersDepId.Add(worker.GetDepId());
            }
            } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
            return workersDepId;
        }
        public List<string> initDepName(List<Worker> workers, List<Department> departments)
        {
            try{
            foreach (Worker worker in workers)
            {
                if (GetDepName(worker, departments) == null)
                    depName.Add(" ");
                depName.Add(GetDepName(worker, departments));
            }
            } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
            return depName;
        }
        public string GetDepName(Worker worker, List<Department> departments)
        {
            string result = "unknown";
            foreach (Department dep in departments)
            {
                if (dep.GetID().Equals(worker.GetDepId()))
                    result = dep.GetName();
            }
            return result;
        }
    
        
public List<(string, int, string)> Report(List<Worker> workers)
{ 
    // имя, возраст, наименование департамента
    List<(string, int, string)> rep = new();
    try{
    for (int i = 0; i < workers.Count; i++)
        rep.Add((workerName[i], age[i], depName[i]));
    } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
    return rep;
}

public override string ToString()
{
    string result = "";
    try{
    foreach ((string, int, string) item in this.Report(workers)){
        result += item;
    }
    } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
    return result;
}
    }
}