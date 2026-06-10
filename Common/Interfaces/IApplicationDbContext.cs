using JobTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobTracker.Application.Common.Interfaces
{
    public interface IApplicationDbContext 
    {
        DbSet<User> Users { get; set; }
        DbSet<JobApplication> JobApplications { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
