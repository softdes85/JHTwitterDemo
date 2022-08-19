using JH.TwitterDemo.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using JH.TwitterDemo.Data.Entities;

namespace JH.TwitterDemo.Data.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : IEntity
    {
        public List<T> Items { get; set; }
        public Repository()
        {
            Items = new List<T>();
        }
        public void Add(T entity)
        {
            Items.Add(entity);
        }

        public T Get(string Id)
        {
            return Items.Find(x => x.Id == Id);
        }
    }
}
