using DynamicForm.Application.Abstractions.Services;
using DynamicForm.Application.DTOs;
using DynamicForm.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DynamicForm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElementController : ControllerBase
    {
        readonly IElementService _elementService;

        public ElementController(IElementService elementService)
        {
            _elementService = elementService;
        }

        [HttpGet]
        public List<Element> GetElements()
        {
            return  _elementService.GetElements();
        }

        [HttpPost]
        public async Task<bool> AddElement(ElementDTO newElement)
        {
            return await _elementService.AddElement(newElement);
        }
    }
}
