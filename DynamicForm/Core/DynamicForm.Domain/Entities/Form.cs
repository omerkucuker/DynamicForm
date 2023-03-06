using DynamicForm.Domain.Entities.Common;

namespace DynamicForm.Domain.Entities
{
    public class Form : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<FormElement> FormElements { get; set; }

    }
}
