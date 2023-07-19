using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IO;

namespace Student.Pages
{
    public class StudentsModel : PageModel
    {
        public List<Student> Students { get; set; }

        public StudentsModel()
        {
            Students = new List<Student>(); 
        }

        // This method is executed when the page is requested with HTTP GET method
        public void OnGet()
        {
            // Path to the CSV file containing student data
            string csvFilePath = "Pages/students-and-subjects.csv";

            // Read students from the CSV file
            Students = ReadStudentsFromCsv(csvFilePath);
        }

        // Helper method to read students from a CSV file
        private List<Student> ReadStudentsFromCsv(string filePath)
        {
            var students = new List<Student>();

            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line is not null) 
                    {
                        var values = line.Split(',');

                        // Create a new student object and populate its properties from the CSV values
                        var student = new Student
                        {
                            Id = int.Parse(values[0]),
                            FirstName = values[1],
                            Surname = values[2],
                            Title = values[3],
                            Email = values[4]
                        };

                        students.Add(student);
                    }
                }
            }

            return students;
        }
    }

    public class Student
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? Surname { get; set; }
        public string? Title { get; set; }
        public string? Email { get; set; }
    }
}
