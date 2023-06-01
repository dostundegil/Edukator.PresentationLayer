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
    public class MailSubscribeManager : IMailSubscribeService
    {
        private readonly IMailSubscribeDal _mailSubscribeDal;

        public MailSubscribeManager(IMailSubscribeDal mailSubscribeDal)
        {
            _mailSubscribeDal = mailSubscribeDal;
        }

        public void TDelete(MailSubscribe t)
        {
            _mailSubscribeDal.Delete(t);
        }

        public MailSubscribe TGetById(int id)
        {
          return  _mailSubscribeDal.GetById(id);
        }

        public List<MailSubscribe> TGetList()
        {
            return _mailSubscribeDal.GetList();
        }

        public void TInsert(MailSubscribe t)
        {
            _mailSubscribeDal.Insert(t);
        }

        public void TUpdate(MailSubscribe t)
        {
            _mailSubscribeDal.Update(t);
        }
    }
}
