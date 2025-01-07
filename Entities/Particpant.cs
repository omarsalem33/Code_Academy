namespace CodeAcademy.Entities
{
    public class Particpant
    {
        public int Id { get; set; }

        public string FName { get; set; }
        
        public string LName { get; set; }

        public ICollection<Section> Sections { get; set; } = new List<Section>();

        public override string ToString() =>   $"Id: {(Id)}\t Name : {FName} {LName} ";
        
    }
}
