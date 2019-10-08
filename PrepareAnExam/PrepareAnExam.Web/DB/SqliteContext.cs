using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PrepareAnExam.Web.DB.Tables;
using System.Reflection;
using System.Threading.Tasks;

namespace PrepareAnExam.Web.DB
{
    public class SqliteContext : DbContext, IDbContext
    {
        private readonly IConfiguration Configuration;
        public SqliteContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("DefaultConnection"), options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Created).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.Deleted).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Question>()
                .HasOne<Exam>(e => e.Exam)
                .WithMany(e => e.Questions)
                .HasForeignKey(e => e.ExamId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Question> Questions { get; set; }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
