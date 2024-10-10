using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }

    public class Department
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
    }

    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000.3m,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000.1m,
                IsManager = true,
                DepartmentId = 3
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000.2m,
                IsManager = false,
                DepartmentId = 1
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Stevens",
                AnnualSalary = 30000.2m,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance"
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology"
            };
            departments.Add(department);

            return departments;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // int[] A = { 1,2,3};
            // int[] B = {1, 2, 5, 9, 9};

            // int i= Compute(A);

            // //int i=solution(B, 1);

            //Console.WriteLine(i);

            // int j = 9;

            List<Employee> employeeList = Data.GetEmployees();
            List<Department> departmentList = Data.GetDepartments();

#region MyRegion
		 
	

            //********************************
            //Correct: Get Dept name for each empl
            //var empDept = from emp in employeeList
            //              join dept in departmentList
            //              on emp.DepartmentId equals dept.Id
            //              select new
            //              {
            //                  emp.FirstName,
            //                  dept.LongName
            //              };

            //foreach(var emp in empDept)
            //{
            //    Console.WriteLine($" {emp.FirstName, -20} {emp.LongName}");
            //}

            //********************************
            //Correct: Get all depts left outer
            //var empDept = from dept in departmentList
            //              join emp in employeeList
            //              on  dept.Id equals emp.DepartmentId
            //              into employeeGroup
            //              select new
            //              {
            //                  Employees = employeeGroup,
            //                  DeptName= dept.LongName
            //              };


            //foreach (var emp in empDept)
            //{
            //    Console.WriteLine($" Department Name : {emp.DeptName,-20}");

            //    foreach (var e in emp.Employees)
            //      Console.WriteLine($"{e.FirstName}");

            //}

            //********************************

            ////Method Syntax to order by Dept Id, Salarys
            //var allEmps = employeeList.Join(
            //    departmentList, 
            //    e => e.DepartmentId, 
            //    d => d.Id,
            //    (e, d) => new {
            //        e.FirstName,
            //        d.Id,
            //        e.AnnualSalary
            //    })
            //    .OrderBy(o=>o.Id)
            //    .ThenBy(o=>o.AnnualSalary);

            //foreach (var emp in allEmps)
            //    Console.WriteLine($"Name:{emp.FirstName, -10} Dept:{emp.Id,-10} Sal:{emp.AnnualSalary,-10}");

            //********************************
            //var grpDepId = from emp in employeeList
            //               join dept in departmentList
            //               on emp.DepartmentId equals dept.Id
            //               group dept by dept.Id;   //query syntax must end with select or group operator

            //var allEmps = employeeList.OrderBy(e => e.AnnualSalary);

            //var allEmps = from emp in employeeList
            //              where emp.AnnualSalary > 30001
            //              orderby emp.AnnualSalary
            //              select emp;

            //foreach (var emp in allEmps)
            //    Console.WriteLine($"Name:{emp.FirstName,-10} Dept:{emp.Id,-10} Sal:{emp.AnnualSalary,-10}");



            #endregion
            //var techAvgSal = employeeList.Where(e => e.DepartmentId == 3).Average(e => e.AnnualSalary);

            //Console.WriteLine($"Avg Sal of Tech Dept is :{techAvgSal,-10}");

            string s = "pope";
            System.Text.StringBuilder s1=new StringBuilder();
            s.Reverse();

            for (int i = s.Length - 1; i >= 0; i--)
                s1.Append(s[i]);


                Console.WriteLine(s1.ToString()==s?"Yes":"No");

            Console.ReadLine();

        }

        public static int Compute(int[] AA)
        {

            //int[] intArray = new int[5] { 8, 10, 2, 6, 3 };

            int[] A = { 1, 3, 2, 1 };
            int[] B = { 4, 2, 5, 3, 2 };

            Array.Sort(A);
            Array.Sort(B);

            for (int iCtrA = 0; iCtrA < A.Length; iCtrA++)
            {
                if (B.Any(n=>n==A[iCtrA]))
                    return A[iCtrA];

                //for (int iCtrB = 0; iCtrB < A.Length; iCtrB++)
                //{
                //    if (A[iCtrA] == B[iCtrB])
                //        return A[iCtrA];
                //}
            }

            return -1;
        }


//        select sensor_id, event_type, value
//from events
//group by sensor_id, event_type
//order by time desc



        public static int solution(int[] A, int X)
        {
            int N = A.Length;
            if (N == 0)
            {
                return (-1);
            }
            int l = 0;
            int r = N - 1;
            while (l < r)
            {
                int m = (l + r);//
                if (A[m] > X)
                {
                    r = m - 1;
                }
                else
                {
                    l = m;
                }
            }
            if (A[l] == X)
            {
                return l;
            }
            return -1;
        }

        //public static int solution(int[] A, int X)
        //{

        //    //int[] B = {1, 2, 5, 9, 9};
        //    int N = A.Length;
        //    if (N == 0)
        //    {
        //        return (-1);
        //    }
        //    int l = 0;
        //    int r = N - 1;

        //    //while (l < r)
        //    while (l < N)
        //    {
        //        //int m = (l + r) / 2;
        //        int m = (l + r) / (l+1);

        //        //int m = l;
        //        if (A[m] > X)
        //        {
        //            r = m - 1;
        //            //l = m - 1;
        //        }
        //        else
        //        {
        //            l = m;
        //            //m = ++l;
                    
        //        }
        //    }
        //    if (A[l] == X)
        //    {
        //        return l;
        //    }
        //    return -1;
        //}

        public static int solutionB(int[] A, int X)
        {

            //int[] B = {1, 2, 5, 9, 9};
            int N = A.Length;
            if (N == 0)
            {
                return (-1);
            }
            int l = 0;
            int r = N - 1;

            //while (l < r)
            while (l < N)
            {
                //int m = (l + r) / 2;
                int m = (l + r) / (l + 1);

                //int m = l;
                if (A[m] > X)
                {
                    r = m - 1;
                    //l = m - 1;
                }
                else
                {
                    l = m;
                    //m = ++l;

                }
            }
            if (A[l] == X)
            {
                return l;
            }
            return -1;
        }
    }
}
