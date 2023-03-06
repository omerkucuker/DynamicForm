using AutoMapper;
using DynamicForm.Application.Abstractions.Services;
using DynamicForm.Application.DTOs;
using DynamicForm.Application.Repositories;
using DynamicForm.Domain.Entities;
using DynamicForm.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Persistence.Services
{
    public class FormElementService : IFormElementService
    {
        readonly IFormElementReadRepository _formElementReadRepository;
        readonly IFormElementWriteRepository _formElementWriteRepository;
        readonly IMapper _mapper;

        public FormElementService(IFormElementWriteRepository formElementWriteRepository, IFormElementReadRepository formElementReadRepository, IMapper mapper)
        {
            _formElementReadRepository = formElementReadRepository;
            _formElementWriteRepository = formElementWriteRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddFormElement(FormElementDTO newFormElement)
        {
            FormElement tempFormElement = _mapper.Map<FormElement>(newFormElement);
            bool result = await _formElementWriteRepository.AddAsync(tempFormElement);
            if (result)
            {
                await _formElementWriteRepository.SaveAsync();
            }
            return result;
        }

        public List<FormElement> GetFormElements()
        {
            List<FormElement> result = new List<FormElement>();
            result = _formElementReadRepository.GetAll().ToList();

            return result;
        }

        public List<FormElement> GetFormElementsByFormId(int formId)
        {
            List<FormElement> result = new List<FormElement>();
            result = _formElementReadRepository.GetWhere(x => x.FormId == formId).ToList();
            return result;
        }
    }
}
