using System;
using System.Collections;

namespace EmployeeArrayListManagement
{
    // Employee Class
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

        public override string ToString()
        {
            return $"🆔 ID: {Id}, 👤 Name: {Name}, 💼 Position: {Position}";
        }
    }

    // Employee Manager Class for CRUD operations
    public class EmployeeManager
    {
        private ArrayList employees = new ArrayList();

        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine("✅ Employee added successfully!");
        }

        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("⚠️ No employees found.");
                return;
            }

            Console.WriteLine("\n📋 Employee List:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        public void UpdateEmployee(int id, string newName, string newPosition)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    emp.Name = newName;
                    emp.Position = newPosition;
                    Console.WriteLine("✅ Employee updated successfully!");
                    return;
                }
            }
            Console.WriteLine("❌ Employee not found.");
        }

        public void DeleteEmployee(int id)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Employee emp = (Employee)employees[i];
                if (emp.Id == id)
                {
                    employees.RemoveAt(i);
                    Console.WriteLine("✅ Employee deleted successfully!");
                    return;
                }
            }
            Console.WriteLine("❌ Employee not found.");
        }
    }

    // Program Class with Menu-driven system
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Enables emoji support

            EmployeeManager manager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("\n🔹 Employee ArrayList Management");
                Console.WriteLine("1️⃣ Add Employee");
                Console.WriteLine("2️⃣ View Employees");
                Console.WriteLine("3️⃣ Update Employee");
                Console.WriteLine("4️⃣ Delete Employee");
                Console.WriteLine("5️⃣ Exit");
                Console.Write("👉 Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("⚠️ Invalid input! Please enter a number.");
                    continue;
                }

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
                        Console.Write("Enter Employee ID to Update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter New Position: ");
                        string newPosition = Console.ReadLine();
                        manager.UpdateEmployee(updateId, newName, newPosition);
                        break;

                    case 4:
                        Console.Write("Enter Employee ID to Delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        manager.DeleteEmployee(deleteId);
                        break;

                    case 5:
                        Console.WriteLine("🚀 Exiting program. Have a great day!");
                        return;

                    default:
                        Console.WriteLine("⚠️ Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }
}
