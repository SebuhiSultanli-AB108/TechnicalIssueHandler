using AutoMapper;
using TechnicalIssueHandler.BL.ViewModels.DesigantionVMs;
using TechnicalIssueHandler.Core.Entities;
using TechnicalIssueHandler.Core.RepositoryInterfaces;

namespace TechnicalIssueHandler.BL.Services.DesignationServices;

public class DesignationService(IDesignationRepository _repository, IMapper _mapper) : IDesignationService
{
    public async Task CreateAsync(DesignationCreateVM vm)
    {
        await _repository.CreateAsync(_mapper.Map<Designation>(vm));
        _repository.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
        _repository.SaveChanges();
    }

    public IEnumerable<DesignationGetVM> GetAll()
        => _mapper.Map<IEnumerable<DesignationGetVM>>(_repository.GetAll());

    public async Task<DesignationGetVM> GetByIdAsync(Guid id)
        => _mapper.Map<DesignationGetVM>(await _repository.GetByIdAsync(id));
}