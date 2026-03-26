using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter9.DTO;

namespace WebAppStarter9.Pages.Students
{
    public class ViewStudentsModel : PageModel
    {
        public List<StudentReadOnlyDTO> StudentsReadOnlyDTOs { get; set; } = [];
        public IActionResult OnGet()
        {
            string? lastname = Request.Query["lastname"];

            var allStudents = GetAllStudents();

            StudentsReadOnlyDTOs = string.IsNullOrEmpty(lastname) 
                ? allStudents 
                : [.. allStudents.Where(s => s.Lastname == lastname)];

            return Page();
        }

        private List<StudentReadOnlyDTO> GetAllStudents()
        {
            return [
                new StudentReadOnlyDTO { Id = 1, Firstname = "John", Lastname = "Doe" },
                new StudentReadOnlyDTO { Id = 2, Firstname = "Mobby", Lastname = "Dick" },
                new StudentReadOnlyDTO { Id = 3, Firstname = "Alice", Lastname = "Cooper" },


                ];
        }

    }
}
