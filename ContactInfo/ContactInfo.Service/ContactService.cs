using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInfo.Data.EFModels;
using ContactInfo.Data.Repositories;

namespace ContactInfo.Service
{
    public class ContactService : IContactService
    {
        IContactRepository iContactRepository;
        public ContactService(IContactRepository icontactRepository)
        {
            iContactRepository = icontactRepository;
        }
        public int Add(Contact contact)
        {
            iContactRepository.Add(contact);
            return contact.ContactId;
        }


        public List<Contact> List(int startIndex, int count, string sorting)
        {
            return iContactRepository.List(startIndex,count,sorting);
        }

        public int ActiveDeactive(int ContactId)
        {
            var contact = iContactRepository.GetById(ContactId);
            if (contact.Status == false)
                contact.Status = true;
            else
                contact.Status = false;
            iContactRepository.Update(contact);
            return contact.ContactId;
        }

        public int Delete(int ContactId)
        {
            var contact = iContactRepository.GetById(ContactId);

                contact.IsDelete = true;
            iContactRepository.Update(contact);
            return contact.ContactId;
        }

        public int Update(Contact contact)
        {
            iContactRepository.Update(contact);
            return contact.ContactId;
        }
    }
}
