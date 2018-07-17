using ContactInfo.Data.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo.Data.Repositories
{
    interface IContactRepository
    {
        List<Contact> List(int startIndex, int count, string sorting);
        int Delete(int ContactId);

    }
}
