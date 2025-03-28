using System;
using System.Collections.Generic;

namespace EmployeeQueueManagement
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(int id, string name, string position)
        {
            Id = id;
            Name = name;
            Position = position;
        }
    }

    public class EmployeeManager
    {
        private Queue<Employee> employees = new Queue<Employee>();

        public void AddEmployee(Employee emp)
        {
            employees.Enqueue(emp);
            Console.WriteLine("✅ Employee added successfully!");
        }

        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("⚠️ No employees found.");
                return;
            }

            Console.WriteLine("\n📋 Employee Queue:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Position: {emp.Position}");
            }
        }

        public void RemoveEmployee()
        {
            if (employees.Count > 0)
            {
                Employee removed = employees.Dequeue();
                Console.WriteLine($"✅ Employee {removed.Name} removed.");
            }
            else
            {
                Console.WriteLine("⚠️ No employees to remove.");
            }
        }
    }
}
