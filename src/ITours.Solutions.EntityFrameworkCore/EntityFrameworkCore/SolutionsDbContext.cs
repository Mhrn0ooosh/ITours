using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ITours.Solutions.Authorization.Roles;
using ITours.Solutions.Authorization.Users;
using ITours.Solutions.MultiTenancy;
using ITours.Solutions.StudentCourses;

namespace ITours.Solutions.EntityFrameworkCore
{
    public class SolutionsDbContext : AbpZeroDbContext<Tenant, Role, User, SolutionsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public SolutionsDbContext(DbContextOptions<SolutionsDbContext> options)
            : base(options)
        {
        }
    }
}
