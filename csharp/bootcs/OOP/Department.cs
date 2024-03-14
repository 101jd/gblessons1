using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOP;

namespace OOP
{
    public class Department
    {
        private int id;
        private string name;

        public Department(int id, string name){
            this.id = id;
            this.name = name;
        }

        public override string ToString(){
            return $"ID: {id} Department name: {name}";
        }

        public int GetID (){
            return id;
        }

        public string GetName(){
            return name;
        }
    }
}