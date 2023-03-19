using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Abstract;

namespace Agriculture.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(Expression<Func<T,bool>>filter);
        List<T> GetList(Expression<Func<T,bool>>filter = null);
    }
}
