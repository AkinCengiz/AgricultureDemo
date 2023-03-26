using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Agriculture.Business.Abstract;
using Agriculture.DataAccess.Abstract;
using Agriculture.Entities.Abstract;

namespace Agriculture.Business.Concrete
{
    public class GenericManager<T,TEntityDal> : IGenericService<T> where T : class,IEntity, new() where TEntityDal : class,IGenericDal<T>,new()
    {
        private readonly TEntityDal _genericDal;

        public GenericManager(TEntityDal genericDal)
        {
            _genericDal = genericDal;
        }


        public void Add(T entity)
        {
            _genericDal.Add(entity);
        }

        public void Update(T entity)
        {
            _genericDal.Update(entity);
        }

        public void Delete(T entity)
        {
            _genericDal.Delete(entity);
        }

        public List<T> GetList()
        {
            return _genericDal.GetList();
        }

        public T GetById(Expression<Func<T, bool>> id)
        {
            return _genericDal.GetById(id);
        }
    }
}
