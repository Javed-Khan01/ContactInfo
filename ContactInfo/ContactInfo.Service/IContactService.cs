using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInfo.Data.EFModels;
namespace ContactInfo.Service
{
   public interface IContactService
    {
        int Add(Contact contact);
        int Update(Contact contact);
        int ActiveDeactive(int ContactId);
        List<Contact> List(int startIndex, int count, string sorting);
        int Delete(int ContactId);
    }
}
