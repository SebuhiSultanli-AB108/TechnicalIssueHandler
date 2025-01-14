using TechnicalIssueHandler.Core.Entities;
using TechnicalIssueHandler.Core.RepositoryInterfaces;
using TechnicalIssueHandler.DAL.Context;

namespace TechnicalIssueHandler.DAL.RepositoryImplements;

public class DesignationRepository : GenericRepository<Designation>, IDesignationRepository
{
    readonly AppDbContext _context;
    public DesignationRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }
}