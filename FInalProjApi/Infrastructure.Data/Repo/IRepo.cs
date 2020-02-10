using System;
using System.Collections;
using System.Collections.Generic;

namespace Infrastructure.Data.Repo
{
    public interface IRepo<T>
    {
        public void add(T obj);
        public T get(int id);
        public void update(T obj);
        public void delete(int id);
        public List<T> getList();
    }
}