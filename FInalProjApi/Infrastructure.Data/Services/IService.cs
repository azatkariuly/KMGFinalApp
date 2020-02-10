using System.Collections.Generic;

namespace Infrastructure.Data.Services
{
    public interface IService<T>
    {
        public List<T> GetAll();
        public T Get(int id);
        public void Add(T obj);
        public void Delete(int id);
        public void Update(T obj);
    }
}