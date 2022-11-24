using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Spire.Doc;
using System.Collections.Specialized;

namespace WebApplication2.Pages
{
    public class FormModel : PageModel
    {
        private readonly ILogger<FormModel> _logger;
        public string message;

        public FormModel(ILogger<FormModel> logger)
        {
            message = "��������� ����� ����"; 

            _logger = logger;
        }

        public void OnGet()
        {
            Console.WriteLine("test");
        }

        [HttpPost]
        public void OnPost( string fio, string group, string faculty)
        {
            doc(fio, group, faculty);
        }
        public void doc(string fio, string group, string faculty)
        {
            Document document = new Document();
            document.LoadFromFile(@"C:\Users\89627\C#\��1\WebApplication2\WebApplication2\files");
            document.Replace("���", fio, false, true);
            document.Replace("���", group, false, true);
            document.Replace("���", faculty, false, true);

            document.SaveToFile("Replace.docx", FileFormat.Docx);
           
            System.Diagnostics.Process.Start("Replace.docx");
           
        


    }
}
}
