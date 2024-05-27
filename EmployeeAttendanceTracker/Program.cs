using EmployeeAttendanceTracker;

var db = new EmployeeADContext();

Console.WriteLine("Unexcused absences during the month of August");
Console.WriteLine(
    $"{"Absence Date",-40}" +
    $"{"Employee Name"}" +
    "");


db.Absences
    .Select(i => new
    {
        i.AbsDate,
        i.Employee.FirstName,
        i.Employee.LastName,
        i.Excused
    })
    .Where(i => i.AbsDate.Month == 8)
    .Where(i => i.Excused == "N")
    .ToList().ForEach(x =>
    {
        Console.WriteLine(
    $"{x.AbsDate,-40}" +
    $"{x.FirstName + " " + x.LastName}" +
    "");
    });

Console.WriteLine("\nFirst name, last name, and birthday of the employee dependents in the CL department");
Console.WriteLine(
    $"{"Dependent Birthday",-40}" +
    $"{"Dependent Name"}" +
    "");

db.Dependents
    .Select(i => new
    {
        i.Employee.DeptCode,
        i.DepName,
        i.Birthday,
        i.Employee.LastName,
    })
    .Where(i => i.DeptCode == "CL")
    .ToList().ForEach(x =>
    {
        Console.WriteLine(
    $"{x.Birthday,-40}" +
    $"{x.DepName + " " + x.LastName}" + 
    "");
    });