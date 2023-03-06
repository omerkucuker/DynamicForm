using AutoMapper;
using DynamicForm.Application.Abstractions.Services;
using DynamicForm.Application.DTOs;
using DynamicForm.Application.Repositories;
using DynamicForm.Domain.Entities;

namespace DynamicForm.Persistence.Services
{
    public class ElementService : IElementService
    {
        readonly IElementReadRepository _elementReadRepository;
        readonly IElementWriteRepository _elementWriteRepository;
        readonly IMapper _mapper;

        public ElementService(IElementWriteRepository elementWriteRepository, IElementReadRepository elementReadRepository, IMapper mapper)
        {
            _elementWriteRepository = elementWriteRepository;
            _elementReadRepository = elementReadRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddElement(ElementDTO newElement)
        {
            Element tempElement = _mapper.Map<Element>(newElement);
            bool result = await _elementWriteRepository.AddAsync(tempElement);
            if (result)
            {
                await _elementWriteRepository.SaveAsync();
            }
            return result;
        }

        public List<Element> GetElements()
        {
            List<Element> result = new List<Element>();
            result = _elementReadRepository.GetAll().ToList();

            return result;
        }
    }
}
