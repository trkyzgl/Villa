using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class DealManager : GenericManager<Deal>, IDealService
    {
        public DealManager(IGenericDal<Deal> genericDal) : base(genericDal)
        {
        }
    }
}
