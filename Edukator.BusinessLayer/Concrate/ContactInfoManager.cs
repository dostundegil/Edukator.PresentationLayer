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
    public class ContactInfoManager : IContactInfoService
    {
        private readonly IContactInfoDal _contactInfoDal;

        public ContactInfoManager(IContactInfoDal contactInfoDal)
        {
            _contactInfoDal = contactInfoDal;
        }

        public void TDelete(ContactInfo t)
        {
            throw new NotImplementedException();
        }

        public ContactInfo TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactInfo> TGetList()
        {
            return _contactInfoDal.GetList();
        }

        public void TInsert(ContactInfo t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactInfo t)
        {
            _contactInfoDal.Update(t);
        }
    }
}
