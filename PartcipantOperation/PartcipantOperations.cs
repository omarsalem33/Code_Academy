using CodeAcademy.Data;

namespace CodeAcademy.PartcipantOperation
{
    public class PartcipantOperations
    {
        public static int NumberOfParticpants(AppDbContext context)
        {
            using (var _context = context)
            {
                return  _context.Particpants.Count();
            }
        }
    }
}
