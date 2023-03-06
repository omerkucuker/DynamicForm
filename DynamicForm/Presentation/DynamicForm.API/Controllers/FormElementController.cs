using DynamicForm.Application.Abstractions.Services;
using DynamicForm.Application.DTOs;
using DynamicForm.Domain.Entities;
using DynamicForm.Persistence.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicForm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormElementController : Controller
    {
        readonly IFormElementService _formElementService;

        public FormElementController(IFormElementService formElementService)
        {
            _formElementService = formElementService;
        }

        [HttpGet]
        public List<FormElement> GetFormElements()
        {
            return _formElementService.GetFormElements();
        }

        [HttpPost]
        public async Task<bool> AddFormElement(FormElementDTO newFormElement)
        {
            return await _formElementService.AddFormElement(newFormElement);
        }
    }
}
