using DynamicForm.Application.DTOs;
using DynamicForm.Domain.Entities;

namespace DynamicForm.Application.Abstractions.Services
{
    public interface IFormService
    {
        List<Form> GetForms();
        Task<bool> AddForm(FormDTO newForm);
    }
}
