using MSE.CVApp.Entities.Concrete.BaseClasses;
using MSE.CVApp.Entities.Interfaces;

namespace MSE.CVApp.Entities.Concrete
{
    [Dapper.Contrib.Extensions.Table("Certifications")]
    public class Certification : BaseEntity2, IEntity
    {
    }
}
