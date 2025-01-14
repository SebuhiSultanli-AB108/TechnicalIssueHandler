using TechnicalIssueHandler.Core.Entities;
using TechnicalIssueHandler.Core.RepositoryInterfaces;
using TechnicalIssueHandler.DAL.Context;

namespace TechnicalIssueHandler.DAL.RepositoryImplements;

public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
{
    readonly AppDbContext _context;
    public EmployeeRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}