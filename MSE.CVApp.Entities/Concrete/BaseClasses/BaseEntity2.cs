using Dapper.Contrib.Extensions;

namespace MSE.CVApp.Entities.Concrete.BaseClasses
{
    public class BaseEntity2
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
