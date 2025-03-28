using System;
using System.Collections.Generic;

namespace EmployeeManagement
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
    }

    // EmployeeManager Class
    public class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        // Add Employee
        public void AddEmployee(Employee emp)
        {
            employees.Add(emp);
            Console.WriteLine("✅ Employee added successfully!");
        }

        // Display Employees
        public void DisplayEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("⚠️ No employees found.");
                return;
            }

            Console.WriteLine("\n📋 Employee List:");
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Position: {emp.Position}");
            }
        }

        // Update Employee
        public void UpdateEmployee(int id, string newName, string newPosition)
        {
            var emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                emp.Name = newName;
                emp.Position = newPosition;
                Console.WriteLine("✅ Employee updated successfully!");
            }
            else
            {
                Console.WriteLine("❌ Employee not found.");
            }
        }

        // Delete Employee
        public void DeleteEmployee(int id)
        {
            var emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("✅ Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("❌ Employee not found.");
            }
        }
    }

    // Program Class
    public class Program
    {
        
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            EmployeeManager manager = new EmployeeManager();
            while (true)
            {
                Console.WriteLine("\n🔹 Employee Management System");
                Console.WriteLine("1️ Add Employee");
                Console.WriteLine("2️ View Employees");
                Console.WriteLine("3️ Update Employee");
                Console.WriteLine("4️ Delete Employee");
                Console.WriteLine("5️ Exit");
                Console.Write("👉 Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
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
                        Console.WriteLine("⚠️ Invalid choice! Please enter a valid option.");
                        break;
                }
            }
        }
    }
}
