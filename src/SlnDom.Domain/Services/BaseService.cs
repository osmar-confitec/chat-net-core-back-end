using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using CrossCutting;
using SlnDom.Domain.Interfaces;
using SlnDom.Domain.Models;
using SlnDom.Domain.Repository;


namespace SlnDom.Domain.Services
{

    public abstract class BaseServiceEntity<TEntity> : BaseService,
                          IBaseService<TEntity> where TEntity : EntityDataBase
    {
        public  IBaseRepository<TEntity> _iBaseRepository { get; protected set; }
        



        protected BaseServiceEntity(IBaseRepository<TEntity> iBaseRepository,
                                    
                                    LNotifications lNotifications)
                                    :base(lNotifications)

        {
            _iBaseRepository = iBaseRepository;
            
        }

        DateTime GetData()
        {

            //CultureInfo idioma = new CultureInfo("pt-BR");
            //return DateTime.Parse(DateTime.Now.ToString(), idioma);
            return DateTime.Now;

        }
            

        protected void GetErrorEntity<T>(T entity) where T : class
        {
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var validContext = new System.ComponentModel.DataAnnotations.ValidationContext(entity);
            if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(entity, validContext, results, true))
            {
                foreach (var errors in results)
                {
                    _lNotifications.Add(new Notification { Message = errors.ErrorMessage });
                }
            }

        }


        /**/

   

        protected void SetUpdateEntity<T>(T entity) where T : EntityDataBase
        {
            entity.Active = true;
            entity.DateUpdate = GetData();
            entity.UserUpdatedId = Guid.NewGuid();
            entity.UserAdUpdatedId = Guid.NewGuid().ToString();
        }

        protected void SetDeleteEntity<T>(T entity) where T : EntityDataBase
        {
            entity.Active = false;
            entity.DeleteDate = GetData();
            entity.UserDeletedId = Guid.NewGuid();
            entity.UserAdDeletedId = Guid.NewGuid().ToString();

        }

        protected void SetInsertEntity<T>(T entity) where T : EntityDataBase
        {

            entity.Active = true;
            entity.DateRegister = GetData();
            entity.UserInsertedId = Guid.NewGuid();
            entity.UserAdInsertedId = Guid.NewGuid().ToString();

        }

        public void Add(TEntity entidade)
        {
            _iBaseRepository.Add(entidade);
        }

        public void Update(TEntity entidade)
        {
            _iBaseRepository.Update(entidade);
        }

        public void Remove(TEntity entidade)
        {
            _iBaseRepository.Remove(entidade);
        }

        public async Task AddAsync(TEntity entidade)
        {
           await  _iBaseRepository.AddAsync(entidade);
        }

        public async Task AddAsync<T>(T entidade) where T : EntityDataBase
        {
            await _iBaseRepository.AddAsync(entidade);
        }

        public void Update<T>(T entity) where T : EntityDataBase
        {
             _iBaseRepository.Update(entity);
        }

        public void UpdateRange<T>(IEnumerable<T> entity) where T : EntityDataBase
        {
            _iBaseRepository.UpdateRange(entity);
        }
    }



    public abstract class BaseService:IDisposable
    {
        public LNotifications _lNotifications { get; protected set; }

        public BaseService(LNotifications lNotifications)
        {
            _lNotifications = lNotifications;
        }

        public void Dispose() => GC.SuppressFinalize(this);

    }
}
