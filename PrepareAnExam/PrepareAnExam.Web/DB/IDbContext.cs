using Microsoft.EntityFrameworkCore;
using PrepareAnExam.Web.DB.Tables;
using System.Threading.Tasks;

namespace PrepareAnExam.Web.DB
{
    public interface IDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Exam> Exams { get; set; }
        DbSet<Question> Questions { get; set; }

        Task<int> SaveChangesAsync();
    }
}
