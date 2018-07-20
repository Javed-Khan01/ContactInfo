using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInfo.Data.EFModels;

namespace ContactInfo.Data.Repositories
{
    public class ContactRepository : RepositoryBase<Contact>,IContactRepository
    {
        public ContactRepository(IDbFactory dbFactory)
           : base(dbFactory) { }
        public int Delete(int ContactId)
        {
            throw new NotImplementedException();
        }

        public List<Contact> List(int startIndex, int count, string sorting)
        {
            IQueryable<Contact> query;

            query=context.Contacts.Where(m=>m.IsDelete==false);
            query = query.OrderBy(c => c.ContactId);
            if (string.IsNullOrEmpty(sorting) || sorting.Equals("FirstName ASC"))
            {
                query = query.OrderBy(c => c.FirstName);
            }
            else if (sorting.Equals("FirstName DESC"))
            {
                query = query.OrderByDescending(c => c.FirstName);
            }
            else if (string.IsNullOrEmpty(sorting) || sorting.Equals("LastName ASC"))
            {
                query = query.OrderBy(c => c.LastName);
            }
            else if (sorting.Equals("LastName DESC"))
            {
                query = query.OrderByDescending(c => c.LastName);
            }
            
            return count > 0
                       ? query.Skip(startIndex).Take(count).ToList() //Paging
                       : query.ToList(); //No paging
        }
    }
}
