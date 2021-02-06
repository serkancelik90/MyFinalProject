using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint (generic kısıt)
    //class: referans tip olabilir demek
    //herhangi bi class yazamaması için IEntity olmasını belirtmek gerek.Ya da IEntity olan bir class olabilir.
    //new diyerek newlenebilir olmalı demiş oluyoruz. böylece soyut nesneyi yazamıyoruz
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
