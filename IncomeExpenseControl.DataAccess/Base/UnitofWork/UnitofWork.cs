using IncomeExpenseControl.Data.Context;
using IncomeExpenseControl.DataAccess.Abstract.Repositories;
using IncomeExpenseControl.DataAccess.Abstract.UnitofWork;
using IncomeExpenseControl.DataAccess.Base.Repositories;
using System;
using System.Data.Entity;


namespace IncomeExpenseControl.DataAccess.Base.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly IncomeExpenseControlDbContext _context;
        private bool disposed = false;
        public UnitofWork(IncomeExpenseControlDbContext context)
        {
            Database.SetInitializer<IncomeExpenseControlDbContext>(null);
            if (context == null)
                throw new ArgumentException("context is null");

            _context = context;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(_context);
        }

        DbContextTransaction transaction;
        public void BeginTransaction()
        {
            transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }


        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
