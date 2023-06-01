using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrate;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        public List<Message> GetLast4Messages()
        {
            using var context = new Context();
            var values = context.Messages.OrderByDescending(x => x.MessageID).Take(4).ToList();
            return values;
        }
    }
}
