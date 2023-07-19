using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Student.Pages
{
    public class JsonModel : PageModel
    {
        public List<Course>? Courses { get; set; }

        public JsonModel()
        {
            Courses = new List<Course>();
        }
        public async Task OnGet()
        {
            // URL to retrieve the JSON data
            string url = "https://www.liverpool.ac.uk/app-data/study-abroad/courses.json";

            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(url);

                JsonSerializerOptions options = new JsonSerializerOptions();

                // Deserialize the JSON response into a list of Course objects
                Courses = JsonSerializer.Deserialize<List<Course>>(json, options);
            }
        }

        // Class representing a single course
        public class Course
        {
            public string? course { get; set; }
            public List<University>? universities { get; set; }
            public string? link { get; set; } 
        }

        // Class representing a university
        public class University
        {
            public string? name { get; set; } 
            public string? country { get; set; } 
        }
    }
}
