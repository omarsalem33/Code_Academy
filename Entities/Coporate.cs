using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CodeAcademy.Entities
{
    public class Coporate : Particpant
    {
        public string CompanyName { get; set; }
     
        public string JobTitle { get; set; }

        public override string ToString()
        {
            return $"{Id}  | {LName}, {FName} | ({JobTitle}) at {CompanyName}";
        }
    }
}
