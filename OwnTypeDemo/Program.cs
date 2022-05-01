

using Microsoft.EntityFrameworkCore;
using OwnTypeDemo.Db;
using OwnTypeDemo.Db.Entity;

var hooby = new Hobby("qwe",2);
var hooby2 = new Hobby("qw2e", 2);
Console.WriteLine(hooby2.EqualOperator(hooby));
//var context = new ApplicationDbcontext();
//SeedEmployess(context);
//var selectedEmployee = context.Employees.FirstOrDefault(e => e.Id == 12);
//var selectedEmployeeWithOwnTypeThatHasRefToEntityObj = context.Employees.Include(h=>h.Hobbies).ThenInclude(t=>t.HobbyType).FirstOrDefault(e => e.Id == 12);
//selectedEmployee.Hobbies.RemoveAll(e => e.Name.Contains("1"));
//selectedEmployee.FirstName = "Ahmedd";
//selectedEmployee.AddressTow = new Address("S3_2", "C3_2");

//await context.SaveChangesAsync();
//Console.WriteLine("Hello, World!");


void SeedEmployess(ApplicationDbcontext context)
{
    context.Employees.AddRange(
        new List<Employee> {
        new Employee
        {
        FirstName = "Emad",
        LastName = "Sayed",
        SSN = "123",
        AddressOne = new Address ("S1","C1"),
        AddressTow = new Address ("S1_2","C1_2"),
        Hobbies = new List<Hobby>{new Hobby ("Emad H1",1),new Hobby ("Emad H2",2)}
        },
                new Employee
        {
        FirstName = "Ahmed",
        LastName = "Sayed",
        SSN = "122",
        AddressOne = new Address ("S2","C2"),
        AddressTow = new Address ("S2_2","C2_2"),
        Hobbies = new List<Hobby>{new Hobby ("Ahmed H1",1),new Hobby ("Ahmed H2",2) }
        },
        });
    context.SaveChanges();
}