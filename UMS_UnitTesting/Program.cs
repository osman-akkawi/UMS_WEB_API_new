
using UMS_DAL.Models;
using UMS_DAL.Repositories.Faculties;

var context = new UmsContext();
FacultyRepository facultyRepository= new FacultyRepository(context);

var Faculties = facultyRepository.GetAll();

foreach (var faculty in Faculties)
{
    Console.WriteLine("Name: " + faculty.FacultyName + ", Dean: " + faculty.DeanName);
}

