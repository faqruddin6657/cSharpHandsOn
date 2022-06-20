using System;
using DBclassLibrary;
using DBclassLibrary.Entities;
using System.Collections;


class Program
{
    public static void Main()
    {
        // for employee class

        CRUDManager cRUDManager = new CRUDManager();
        // insertion
        //cRUDManager.Insert(new Employee() { Name = "shaikh azhar", Address = "hyderabad" });

        //Employee e1= cRUDManager.GetEmplpoyeeById(3);// getting employee by id
        //Console.WriteLine(e1.Name);

        //

        //deletion
        //   cRUDManager.Delete(2);
        //  
        //update
        //cRUDManager.Update(3, new Employee() { Name ="shaikh azher",Address = "telangana" });
        // List<Employee> elist=cRUDManager.GetAllEmployees();
        // foreach(Employee emp in elist)
        //  {
        //      Console.WriteLine(emp.Name);
        //  }


        //for employee education

        //  cRUDManager.InsertEmpEd(new EmployeeEducation() { CourseName = "ece", UniversityName = "gnitc", PassingYear = 2022, MarksPercentage = 8,});
        // EmployeeEducation ed=cRUDManager.GetEmplpoyeeEducationRecordsById(1); //getting records by id
        // Console.WriteLine(ed.CourseName);
        /*List<EmployeeEducation> edList= cRUDManager.GetAllEmployeeEdRecords();
        foreach(EmployeeEducation e in edList)
        {
            Console.WriteLine(e.UniversityName);
        }
        */
        // cRUDManager.DeleteEmployeeEd(2); //deleting educational record

        cRUDManager.UpdateEmployeeEd(1, new EmployeeEducation() { CourseName = "literature", UniversityName = "lovely", PassingYear = 2024, MarksPercentage = 89 });

        Console.WriteLine("executed");
    }
}
