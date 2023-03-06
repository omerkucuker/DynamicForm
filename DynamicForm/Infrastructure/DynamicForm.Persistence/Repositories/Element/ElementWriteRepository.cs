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
    public class ElementWriteRepository : WriteRepository<Element>, IElementWriteRepository
    {
        public ElementWriteRepository(DynamicFormsContext context) : base(context)
        {
        }
    }
}
