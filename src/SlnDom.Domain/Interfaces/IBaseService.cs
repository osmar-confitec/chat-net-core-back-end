using CrossCutting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SlnDom.Domain.Models;
using SlnDom.Domain.Repository;


namespace SlnDom.Domain.Interfaces
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : EntityDataBase
    {
        public IBaseRepository<TEntity> _iBaseRepository { get; }

        
        public LNotifications _lNotifications { get; }

        void Add(TEntity entidade);

        Task AddAsync(TEntity entidade);

        void UpdateRange<T>(IEnumerable<T> entity) where T : EntityDataBase;

        Task AddAsync<T>(T entidade) where T : EntityDataBase;

        void Update<T>(T entity) where T : EntityDataBase;

        void Update(TEntity customer);

        void Remove(TEntity customer);


    }
}
