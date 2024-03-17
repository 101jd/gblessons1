using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
    public class DataBase
    {
        public List<Worker> workers;
        public List<Department> departments;
        public DataBase()
        {
            workers = new List<Worker>();
            departments = new List<Department>();
            
        }
        public void AppendDepartments (Department department){
            departments.Add(department);
            
        }
        public void AppendWorkers (Worker worker){
            workers.Add(worker);
            
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
    
        
public List<(string, int, string)> Report()
{ 
    // имя, возраст, наименование департамента
    List<(string, int, string)> rep = new();
    try{
    for (int i = 0; i < workers.Count; i++)
        rep.Add((workers[i].GetName(), workers[i].GetAge(), GetDepName(workers[i], departments)));
    } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
    return rep;
}

public string Print()
{
    string result = "";
    try{
        result = string.Join("\n", this.Report());
    } catch (NullReferenceException err){
            System.Console.WriteLine(err.Message);
        }
        return result;
}
    }
}