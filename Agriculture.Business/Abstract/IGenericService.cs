using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Entities.Abstract;

namespace Agriculture.Business.Abstract
{
    public interface IGenericService<T> where T : class,IEntity,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetList();
        T GetById(Expression<Func<T, bool>> id);
    }
}
