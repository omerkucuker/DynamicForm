using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicForm.Domain.Entities;

namespace DynamicForm.Application.Features.FormElement
{
    public class FormElementAddRequestModel
    {
        public Form FormId { get; set; }
        public Element ElementId { get; set; }
    }
}
