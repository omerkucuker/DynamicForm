using DynamicForm.Domain.Entities.Common;

namespace DynamicForm.Domain.Entities
{
    public class Element : BaseEntity
    {
        public string Key { get; set; }
        public string? Value { get; set; }
        public string? Label { get; set; }
        public bool? Required { get; set; }
        public int? Order { get; set; }
        public ICollection<FormElement> FormElements { get; set; }

    }
}
