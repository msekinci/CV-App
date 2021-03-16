using MSE.CVApp.Entities.Concrete.BaseClasses;
using MSE.CVApp.Entities.Interfaces;

namespace MSE.CVApp.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Interests")]
    public class Interest : BaseEntity2, IEntity
    {
    }
}
