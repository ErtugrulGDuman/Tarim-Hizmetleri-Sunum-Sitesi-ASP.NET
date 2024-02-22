using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHihabernite
{
    internal abstract class NHihabernateHelper : IDisposable
    {
        public virtual ISessionFactory SessionFactory
        {
            get { return _sessionFactory??(_sessionFactory=InitalizeFactory()); }
        }

        protected abstract ISessionFactory InitalizeFactory();

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();    
        }

        static ISessionFactory _sessionFactory;
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
