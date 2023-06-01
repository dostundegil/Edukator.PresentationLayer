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
    public class AboutGridManager : IAboutGridService
    {
        private readonly IAboutGridDal _aboutGridDal;

        public AboutGridManager(IAboutGridDal aboutGridDal)
        {
            _aboutGridDal = aboutGridDal;
        }

        public void TDelete(AboutGrid t)
        {
            _aboutGridDal.Delete(t);
        }

        public AboutGrid TGetById(int id)
        {
            return _aboutGridDal.GetById(id);
        }

        public List<AboutGrid> TGetList()
        {
            return _aboutGridDal.GetList();
        }

        public void TInsert(AboutGrid t)
        {
            _aboutGridDal.Insert(t);
        }

        public void TUpdate(AboutGrid t)
        {
            _aboutGridDal.Update(t);
        }
    }
}
