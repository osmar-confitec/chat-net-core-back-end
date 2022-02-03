using CrossCutting;
using SlnDom.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Interfaces
{
   public interface IBaseApplication : IDisposable
    {
        public IUnitOfWork UnitOfWork { get; }
        public LNotifications LNotifications { get; }
    }
}
