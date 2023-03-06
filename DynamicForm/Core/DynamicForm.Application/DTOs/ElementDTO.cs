using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicForm.Application.DTOs
{
    public class ElementDTO
    {
        public string Key { get; set; }
        public string? Value { get; set; }
        public string? Label { get; set; }
        public bool? Required { get; set; }
        public int? Order { get; set; }
    }
}
