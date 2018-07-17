using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInfo.Data.EFModels;

namespace ContactInfo.Data.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public int Delete(int ContactId)
        {
            throw new NotImplementedException();
        }

        public List<Contact> List(int startIndex, int count, string sorting)
        {
            throw new NotImplementedException();
        }
    }
}
