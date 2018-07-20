using ContactInfo.Data.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ContactInfo.Data.Repositories
{
    public class DbFactory : Disposable, IDbFactory
    {
        ContactInfoEFModel dbContext;
        public ContactInfoEFModel Init()
        {
            return dbContext ?? (dbContext = new ContactInfoEFModel());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
