using DynamicForm.Application.Repositories;
using DynamicForm.Domain.Entities;
using DynamicForm.Persistence.Context;
using DynamicForm.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Persistence.Repositories
{
    public class FormWriteRepository : WriteRepository<Form>, IFormWriteRepository
    {
        public FormWriteRepository(DynamicFormsContext context) : base(context)
        {
        }
    }
}
