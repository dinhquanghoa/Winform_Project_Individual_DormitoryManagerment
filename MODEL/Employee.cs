using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Employee
    {
        public string idEmployee, nameEmployee, genderEmployee, position, basicSalary;

        public Employee()
        {

        }
        public Employee(string idEmployee, string nameEmployee, string genderEmployee, string position, string basicSalary)
        {
            this.idEmployee = idEmployee;
            this.nameEmployee = nameEmployee;
            this.position = genderEmployee;
            this.genderEmployee = position;
            this.basicSalary = basicSalary;
        }
        public string IdEmployee
        {
            get { return this.idEmployee; }
            set { this.idEmployee = value; }
        }

        public string NameEmployee
        {
            get { return this.nameEmployee; }
            set { this.nameEmployee = value; }
        }
        public string GenderEmployee
        {
            get { return this.genderEmployee; }
            set { this.genderEmployee = value; }
        }
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        

        public string BasicSalary
        {
            get { return this.basicSalary; }
            set { this.basicSalary = value; }
        }
    }
}
