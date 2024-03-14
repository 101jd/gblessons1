using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
    public class DataBase
    {
        private string workerName;
        private int age;
        private string depName;
        private int workersDepId;
        public DataBase(Worker worker, List<Department> departments){
            this.workerName = worker.GetName();
            this.age = worker.GetAge();
            this.depName = GetDepName(worker, departments);
            this.workersDepId = worker.GetDepId();
        }
        public string GetDepName(Worker worker, List<Department> departments){
            string result = "unknown";
            foreach (Department dep in departments){
                if (dep.GetID().Equals(worker.GetDepId()))
                    result = dep.GetName();
            }
            return result;
        }
        public List<(string, int, string)> Report (){ // имя, возраст, наименование департамента
            List <(string, int, string)> rep = new();
            rep.Add((workerName, age, depName));
            return rep;
        }

        public override string ToString(){
            string result = "";
            foreach ((string, int, string) item in this.Report()){
                result += item;
            }
            return result;
        }
    }
}