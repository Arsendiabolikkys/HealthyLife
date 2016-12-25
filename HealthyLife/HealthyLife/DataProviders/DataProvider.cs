using HealthyLife.Business.Models;
using HealthyLife.NHibernate;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthyLife.DataProviders
{
    public class DataProvider<TEntity>
        where TEntity : class, IEntity
    {
        SessionHelper sessionHelper = new SessionHelper();

        private ISession CreateSession()
        {
            if (!sessionHelper.Current.IsOpen)
                return sessionHelper.OpenSession();
            return sessionHelper.Current;
        }

        protected T Execute<T>(Func<ISession, T> func, string errorMessage = null)
        {
            try
            {
                using (var session = CreateSession())
                {
                    return func(session);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void Execute(Action<ISession> action, string errorMessage = null)
        {
            try
            {
                using (var session = CreateSession())
                {
                    action(session);
                }
            }
            catch
            {
                throw;
            }
        }

        public TEntity GetById(int id)
        {
            return Execute(session =>
            {
                return session.Get<TEntity>(id);
            });
        }

        public void Create(TEntity model)
        {
            Execute(session =>
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(model);
                    transaction.Commit();
                }
            });
        }

        public void Update(TEntity model)
        {
            Execute(session =>
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(model);
                    transaction.Commit();
                }
            });
        }

        public void Delete(TEntity model)
        {
            Execute(session =>
            {
                session.Delete(model);
                session.Flush();
            });
        }

        public IList<TEntity> GetList()
        {
            return Execute(session =>
            {
                return session.QueryOver<TEntity>().List();
            });
        }
    }
}