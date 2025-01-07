namespace CodeAcademy.Entities
{
    public class Individual : Particpant
    {
        public string University { get; set; }

        public int YearOfGraduation { get; set; }

        public bool IsIntern { get; set; }

        public override string ToString()
        {
            return $"{Id}  ( {FName}, {LName} ) Graduted on ({YearOfGraduation}) From {University} " +
                $"({(IsIntern ? "Internship" : "")})";
        }
    }

}
