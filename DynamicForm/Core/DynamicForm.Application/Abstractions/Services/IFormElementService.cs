using DynamicForm.Application.DTOs;
using DynamicForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Application.Abstractions.Services
{
    public interface IFormElementService
    {
        List<FormElement> GetFormElements();
        Task<bool> AddFormElement(FormElementDTO newFormElement);
        List<FormElement> GetFormElementsByFormId(int formId);
    }
}
