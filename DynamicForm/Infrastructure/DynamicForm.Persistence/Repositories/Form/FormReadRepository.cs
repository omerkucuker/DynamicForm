﻿using DynamicForm.Application.Repositories;
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
    public class FormReadRepository : ReadRepository<Form>, IFormReadRepository
    {
        public FormReadRepository(DynamicFormsContext context) : base(context)
        {
        }
    }
}
