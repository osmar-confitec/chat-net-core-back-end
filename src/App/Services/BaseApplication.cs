using App.Interfaces;
using CrossCutting;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services
{
    public abstract class BaseApplication : IBaseApplication
    {

        protected BaseApplication(IUnitOfWork _unitOfWork,
                              LNotifications _LNotifications)
        {

            if (LNotifications == null)
                LNotifications = new LNotifications();

            UnitOfWork = _unitOfWork;

            LNotifications = _LNotifications;
        }

        public void ValidAnnotation<T>(T obj) where T : class
        {
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var validContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            if (!System.ComponentModel.DataAnnotations.Validator.TryValidateObject(obj, validContext, results, true))
            {

                foreach (var errors in results)
                {
                    LNotifications.Add(new Notification { Message = errors.ErrorMessage });
                }
            }

        }

        public IUnitOfWork UnitOfWork { get; protected set; }

        public LNotifications LNotifications { get; protected set; }

        public void Dispose() => GC.SuppressFinalize(this);

    }
}
