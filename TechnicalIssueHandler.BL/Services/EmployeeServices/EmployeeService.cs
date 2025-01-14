using AutoMapper;
using TechnicalIssueHandler.BL.ViewModels.EmployeeVMs;
using TechnicalIssueHandler.Core.Entities;
using TechnicalIssueHandler.Core.RepositoryInterfaces;

namespace TechnicalIssueHandler.BL.Services.EmployeeServices;

public class EmployeeService(IEmployeeRepository _repository, IMapper _mapper) : IEmployeeService
{
    public async Task CreateAsync(EmployeeCreateVM vm)
    {
        await _repository.CreateAsync(_mapper.Map<Employee>(vm));
        _repository.SaveChanges();
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
        _repository.SaveChanges();
    }

    public IEnumerable<EmployeeGetVM> GetAll()
        => _mapper.Map<IEnumerable<EmployeeGetVM>>(_repository.GetAll());

    public async Task<EmployeeGetVM> GetByIdAsync(Guid id)
        => _mapper.Map<EmployeeGetVM>(await _repository.GetByIdAsync(id));

}