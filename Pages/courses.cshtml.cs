using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Student.Pages
{
    public class CourseDetailsModel : PageModel
    {
        public List<University>? University { get; set; }

        public CourseDetailsModel()
        {
            University = new List<University>();
        }

        public void OnGet()
        {
            string filePath = Path.Combine("Pages", "courses.json");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                // Console.WriteLine(json);
                JsonSerializerOptions options = new JsonSerializerOptions();
                // options.MaxJsonLength = 10 * 1024 * 1024;
                University = JsonSerializer.Deserialize<List<University>>(json, options);
                Console.WriteLine(JsonSerializer.Serialize(University, new JsonSerializerOptions { WriteIndented = true }));

            }
        }
    }

    public class University
    {
        public string? name { get; set; }
        public string? country { get; set; }
    }
}
