using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.BusinessLayer.Concrate
{
    public class MapInfoManager : IMapInfoService
    {
        private readonly IMapInfoDal _mapInfoDal;

        public MapInfoManager(IMapInfoDal mapInfoDal)
        {
            _mapInfoDal = mapInfoDal;
        }

        public void TDelete(MapInfo t)
        {
            throw new NotImplementedException();
        }

        public MapInfo TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MapInfo> TGetList()
        {
            return _mapInfoDal.GetList();
        }

        public void TInsert(MapInfo t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MapInfo t)
        {
            _mapInfoDal.Update(t);
        }
    }
}
