using System.Collections.Generic;
using System.Data;

namespace MyUnitOfWork
{
    public abstract class OurDbBaseClass<TEntity>
    {
        protected IEnumerable<TEntity> ToList(IDbCommand command)
        {
            using (var reader = command.ExecuteReader())
            {
                List<TEntity> items = new List<TEntity>();
                
                while (reader.Read())
                {
                    var item = CreateEntity();

                    Map(reader, item);

                    items.Add(item);
                }

                return items;
            }
        }

        protected abstract void Map(IDataRecord record, TEntity entity);

        protected abstract TEntity CreateEntity();
    }
}
