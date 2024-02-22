using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHihabernite
{
    public class NHEntityRepositoryBase<TEntity>:IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private NHihabernateHelper _nHibernateHelper;
        private object entity;

        public NHEntityRepositoryBase(NHihabernateHelper nHibernateHelper)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
                return entity;
            }
        }

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
