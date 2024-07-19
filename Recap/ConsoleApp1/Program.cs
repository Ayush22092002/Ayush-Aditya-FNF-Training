
using ClassLibrary1.Models;
using ClassLibrary1.Data;
using ClassLibrary1.Services;
using static ClassLibrary1.Services.DataServices;
using System.Threading.Channels;
using Microsoft.Extensions.DependencyInjection;
namespace ConsoleApp1
{ 
    public class Program
    {
           private static IDataService service;
            static void Main(string[] args)
            {
             service = CreateServices().GetRequiredService<IDataService>();
           
            //testforinsertion();
            //testforReading();
            //testforUpdation();
            testfordeleting();
            }


        private static void testfordeleting()
        {
            try
            {
                service.DeleteStudent(4);
                Console.WriteLine("student delted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void testforUpdation()
        {
            try
            {
                var student = new Student
                {
                    ContactNo = 647883784,
                    StudentEmail = "prathamesh@gmail.com",
                    StudentName = "prathamesh",
                    StudentId = 3
                };
                service.UpdateStudent(student);
                Console.WriteLine("student updated ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void testforReading()
            {
                try
                {
                    var component = new StudentDataService(new StudentDbContext());
                    var records = component.GetAllStudents();
                    foreach (var record in records)
                    {
                        Console.WriteLine($"{record.StudentName} can be contacted at {record.ContactNo}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    if (ex.InnerException != null)
                        Console.WriteLine(ex.InnerException.Message);

                }
            }
            private static void testforinsertion()

            {
                try

                {

                    var student = new Student
                    {
                        ContactNo = 8271301722,
                        StudentEmail = "light@gmail.com",
                        StudentName = "Adi"
                    };

                    var context = new StudentDbContext();

                    var service = new StudentDataService(context);

                    service.AddNewStudent(student);

                    Console.WriteLine("Student added succesfully");

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex.Message);

                    Console.WriteLine(ex.StackTrace);

                }

            }

        private static ServiceProvider CreateServices()
        {
            var services = new ServiceCollection()
                .AddDbContext<StudentDbContext>()
                //.AddTransient<IDataService,StudentDataService>()
                .AddSingleton<IDataService, StudentDataService>()
                .BuildServiceProvider();
            return services;
        }

    }

    }


