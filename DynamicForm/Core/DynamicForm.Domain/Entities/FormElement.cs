using DynamicForm.Domain.Entities.Common;

namespace DynamicForm.Domain.Entities
{
    public class FormElement : BaseEntity
    {
        public int FormId { get; set; }
        public Form Form { get; set; }
        public int ElementId { get; set; }
        public Element Element { get; set; }
    }
}
