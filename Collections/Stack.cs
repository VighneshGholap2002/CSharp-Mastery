using System;
using System.Collections.Generic;

namespace EmployeeStackManagement
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
        private Stack<Employee> employees = new Stack<Employee>();

        public void AddEmployee(Employee emp)
        {
            employees.Push(emp);
            Console.WriteLine("✅ Employee added successfully!");
        }

        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("⚠️ No employees found.");
                return;
            }

            Console.WriteLine("\n📋 Employee Stack:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Position: {emp.Position}");
            }
        }

        public void RemoveEmployee()
        {
            if (employees.Count > 0)
            {
                Employee removed = employees.Pop();
                Console.WriteLine($"✅ Employee {removed.Name} removed.");
            }
            else
            {
                Console.WriteLine("⚠️ No employees to remove.");
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            EmployeeManager manager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("\n🔹 Employee Stack Management");
                Console.WriteLine("1️⃣ Add Employee");
                Console.WriteLine("2️⃣ View Employees");
                Console.WriteLine("3️⃣ Remove Top Employee");
                Console.WriteLine("4️⃣ Exit");
                Console.Write("👉 Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Employee ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter Position: ");
                        string position = Console.ReadLine();
                        manager.AddEmployee(new Employee(id, name, position));
                        break;
                    case 2:
                        manager.DisplayEmployees();
                        break;
                    case 3:
                        manager.RemoveEmployee();
                        break;
                    case 4:
                        Console.WriteLine("🚀 Exiting Program. Thank You!");
                        return;
                    default:
                        Console.WriteLine("⚠️ Invalid choice!");
                        break;
                }
            }
        }
    }
}
