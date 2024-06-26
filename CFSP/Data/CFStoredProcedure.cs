using Microsoft.EntityFrameworkCore;

namespace CFSP.Data
{
    public static class CFStoredProcedure
    {
        private static List<string> storedProcedures = new List<string>()
            {
                "CREATE PROCEDURE SP_AllStudents AS Select * From Students"
            };

        public static void CreateSP(ApplicationDbContext context)
        {
            foreach (var sp in storedProcedures)
            {
                context.Database.ExecuteSqlRaw(sp);
            }
        }
    }
}
