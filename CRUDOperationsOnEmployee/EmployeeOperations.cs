using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsOnEmployee
{
    public class EmployeeOperations
    {
        private List<Employee> emplist;

        public EmployeeOperations()
        {
            emplist = new List<Employee>()
            {
                new Employee(){Id=101,Name="Samruddhi",Salary=30000},
                 new Employee(){Id=102,Name="ketki",Salary=35000},
                  new Employee(){Id=103,Name="Aishwarya",Salary=40000},
            };
        }

        public List<Employee> ShowEmployee()
        {
            return emplist;
        }

        public Employee SearchEmployee(int id)
        {
            Employee emp=new Employee();
            foreach(Employee item in emplist)
            {
                if(item.Id == id)
                {

                    emp = item;
                    break;
                }
                
            }
            return emp;
        }

        public void AddEmployee(Employee e1)
        {
            emplist.Add(e1);

        }

        public void RemoveRecord(int id)
        {
            Employee e= new Employee();
            foreach(Employee item in emplist)
            {
                if(item.Id == id)
                {
                    emplist.Remove(item);
                    break;
                }
            }
        }

        public void UpdateRecord(Employee e)
        {
            
           foreach(Employee item in emplist)
            {
                if(item.Id == e.Id)
                {
                    item.Name = e.Name;
                    item.Salary = e.Salary;
                    break;
                }
            }
        }
    }
}





