using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class VideoManager : GenericManager<Video>, IVideoService
    {
        public VideoManager(IGenericDal<Video> genericDal) : base(genericDal)
        {
        }
    }
}
