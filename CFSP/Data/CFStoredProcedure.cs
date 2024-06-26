using Microsoft.EntityFrameworkCore;

namespace CFSP.Data
{
    public class CFStoredProcedure
    {
        private readonly ApplicationDbContext _context;
        private List<string> storedProcedures = new List<string>();
        public CFStoredProcedure(ApplicationDbContext context)
        {
            _context = context;
            storedProcedures.Add("CREATE PROCEDURE SP_AllStudents AS Select * From Students");
        }


        public void CreateSP()
        {
            foreach (var sp in storedProcedures)
            {
                _context.Database.ExecuteSqlRaw(sp);
            }
        }
    }
}
