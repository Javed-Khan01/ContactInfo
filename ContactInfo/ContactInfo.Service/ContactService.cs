using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInfo.Data.EFModels;

namespace ContactInfo.Service
{
    public class ContactService : IContactService
    {
        public ContactService()
        {

        }
        public int Add(Contact contact)
        {
            throw new NotImplementedException();
        }

        public int Delete(int ContactId)
        {
            throw new NotImplementedException();
        }

        public List<Contact> List(int startIndex, int count, string sorting)
        {
            throw new NotImplementedException();
        }

        public int Update(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}
