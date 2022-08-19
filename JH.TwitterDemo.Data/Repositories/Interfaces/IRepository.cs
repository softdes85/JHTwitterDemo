using JH.TwitterDemo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JH.TwitterDemo.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        T Get(string Id);
    }
}
