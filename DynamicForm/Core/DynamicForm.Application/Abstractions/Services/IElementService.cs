
using DynamicForm.Application.DTOs;
using DynamicForm.Domain.Entities;

namespace DynamicForm.Application.Abstractions.Services
{
    public interface IElementService
    {
        List<Element> GetElements();
        Task<bool> AddElement(ElementDTO newElement);
    }
}
