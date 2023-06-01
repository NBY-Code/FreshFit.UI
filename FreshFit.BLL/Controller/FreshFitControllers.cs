using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshFit.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace FreshFit.BLL.Controller
{
    public sealed class FreshFitControllers
    {
        private FreshFitContext _context = new FreshFitContext();

        private static FreshFitControllers _instance = null;
        public static FreshFitControllers Instance => _instance ?? (_instance = new FreshFitControllers());

        private FreshFitControllers()
        {

        }

        public ICollection<T> GetAllData<T>() where T : class
        {
            return _context.Set<T>().ToList();
        }

        public T GetDataByID<T>(int id) where T : class
        {
            return _context.Set<T>().Find(id);
        }

        public T GetDataByIDForComposite<T>(int id1, int id2) where T : class
        {
            return _context.Set<T>().Find(id1, id2);
        }

        public void AddData<T>(T data) where T : class
        {
            _context.Set<T>().Add(data);
            _context.SaveChanges();
        }

        public void UpdateData<T>(T cls) where T : class
        {
            _context.Entry(cls).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void UpdateDataByID<T>(int id) where T : class
        {
            UpdateData<T>(GetDataByID<T>(id));
        }

        public void UpdateDataByIDForComposite<T>(int id1, int id2) where T : class
        {
            UpdateData<T>(GetDataByIDForComposite<T>(id1, id2));
        }

        public void RemoveData<T>(T cls) where T : class
        {
            _context.Set<T>().Remove(cls);
            _context.SaveChanges();
        }

        public void RemoveDataByID<T>(int id) where T : class
        {
            RemoveData<T>(GetDataByID<T>(id));
        }

        public void RemoveDataByIDForComposite<T>(int id1, int id2) where T : class
        {
            RemoveData<T>(GetDataByIDForComposite<T>(id1, id2));
        }
        public void SaveAllChanges()
        {
            _context.SaveChanges(); 
        }
    }
}
