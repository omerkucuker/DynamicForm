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
    public class FormService : IFormService
    {
        readonly IFormReadRepository _formReadRepository;
        readonly IFormWriteRepository _formWriteRepository;
        readonly IMapper _mapper;

        public FormService(IFormWriteRepository formWriteRepository, IFormReadRepository formReadRepository, IMapper mapper)
        {
            _formReadRepository = formReadRepository;
            _formWriteRepository = formWriteRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddForm(FormDTO newForm)
        {
            Form tempForm = _mapper.Map<Form>(newForm);
            bool result = await _formWriteRepository.AddAsync(tempForm);
            if (result)
            {
                await _formWriteRepository.SaveAsync();
            }
            return result;
        }

        public List<Form> GetForms()
        {
            List<Form> result = new List<Form>();
            result = _formReadRepository.GetAll().ToList();

            return result;
        }
    }
}
