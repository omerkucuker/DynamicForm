using DynamicForm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Application.DTOs
{
    public class FormElementDTO
    {
        public Form FormId { get; set; }
        public Element ElementId { get; set; }
    }
}
