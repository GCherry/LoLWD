using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoLWD.Shared.Models.Entities;


namespace LoLWD.Shared.Interfaces
{
    public interface IManager<T> where T : Entity
    {
        #region Methods

        T Add(T item);
        T DeleteById(int id);
        T EditById(T item, int id);
        List<T> GetAll();
        T GetOneById(int id);

        #endregion
    }
}
