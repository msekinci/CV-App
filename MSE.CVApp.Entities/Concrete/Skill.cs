using MSE.CVApp.Entities.Concrete.BaseClasses;
using MSE.CVApp.Entities.Interfaces;

namespace MSE.CVApp.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Skills")]
    public class Skill : BaseEntity2, IEntity
    {
        public string ImageUrl { get; set; }
    }
}
