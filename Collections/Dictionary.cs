using System;
using System.Collections.Generic;

namespace EmployeeDictionaryManagement
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
        private Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        public void AddEmployee(Employee emp)
        {
            if (!employees.ContainsKey(emp.Id))
            {
                employees[emp.Id] = emp;
                Console.WriteLine("✅ Employee added successfully!");
            }
            else
            {
                Console.WriteLine("⚠️ Employee ID already exists!");
            }
        }

        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("⚠️ No employees found.");
                return;
            }

            Console.WriteLine("\n📋 Employee Dictionary:");
            foreach (var emp in employees.Values)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Position: {emp.Position}");
            }
        }

        public void UpdateEmployee(int id, string newName, string newPosition)
        {
            if (employees.ContainsKey(id))
            {
                employees[id].Name = newName;
                employees[id].Position = newPosition;
                Console.WriteLine("✅ Employee updated successfully!");
            }
            else
            {
                Console.WriteLine("❌ Employee not found.");
            }
        }

        public void DeleteEmployee(int id)
        {
            if (employees.Remove(id))
            {
                Console.WriteLine("✅ Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("❌ Employee not found.");
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
                Console.WriteLine("\n🔹 Employee Dictionary Management");
                Console.WriteLine("1️⃣ Add Employee");
                Console.WriteLine("2️⃣ View Employees");
                Console.WriteLine("3️⃣ Update Employee");
                Console.WriteLine("4️⃣ Delete Employee");
                Console.WriteLine("5️⃣ Exit");
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
                        Console.Write("Enter Employee ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter New Position: ");
                        string newPosition = Console.ReadLine();
                        manager.UpdateEmployee(updateId, newName, newPosition);
                        break;
                    case 4:
                        Console.Write("Enter Employee ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        manager.DeleteEmployee(deleteId);
                        break;
                    case 5:
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
