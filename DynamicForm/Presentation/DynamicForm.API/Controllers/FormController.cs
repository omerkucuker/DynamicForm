using DynamicForm.Application.Abstractions.Services;
using DynamicForm.Application.DTOs;
using DynamicForm.Domain.Entities;
using DynamicForm.Persistence.Services;
using Microsoft.AspNetCore.Mvc;

namespace DynamicForm.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : Controller
    {
        readonly IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpGet]
        public List<Form> GetForms()
        {
            return _formService.GetForms();
        }

        [HttpPost]
        public async Task<bool> AddForm(FormDTO newForm)
        {
            return await _formService.AddForm(newForm);
        }
        
    }
}
