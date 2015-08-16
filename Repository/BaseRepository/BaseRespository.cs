﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Interfaces.Repository;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.IdentityModels;

namespace Repository.BaseRepository
{
    public abstract class BaseRepository<TDomainClass> : IBaseRepository<TDomainClass, int>
       where TDomainClass : class
    {
        #region Private

        private readonly IUnityContainer container;
        #endregion
        #region Protected

        /// <summary>
        /// Primary database set
        /// </summary>
        protected abstract IDbSet<TDomainClass> DbSet { get; }
        public  BaseDbContext db;


        /// <summary>
        /// Entities
        /// </summary>
        //protected IApplicationEntities Entities
        //{
        //    get
        //    {
        //        return container.Resolve<IApplicationEntities>();
        //    }
        //}
        #endregion
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        protected BaseRepository(IUnityContainer container)
        {

            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
            //if (db == null)
            //{
                string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                db = new BaseDbContext(connectionString, container);
                
            //}
        }
        #endregion
        #region Public

        /// <summary>
        /// Get all
        /// </summary>
        public virtual IQueryable<TDomainClass> GetAll(TDomainClass instance)
        {
            return DbSet.Find(instance) as IQueryable<TDomainClass>;
        }

        /// <summary>
        /// Create object instance
        /// </summary>
        /// <returns>object instance</returns>
        public virtual TDomainClass Create()
        {
            TDomainClass result = container.Resolve<TDomainClass>();
            return result;
        }

        /// <summary>
        /// Find entry by key
        /// </summary>
        public virtual IQueryable<TDomainClass> Find(TDomainClass instance)
        {
            return DbSet.Find(instance) as IQueryable<TDomainClass>;
        }

        public TDomainClass Find(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<TDomainClass> GetAll()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        /// <summary>
        /// Delete an entry
        /// </summary>
        public virtual void Delete(TDomainClass instance)
        {
            DbSet.Remove(instance);

        }

        /// <summary>
        /// Add an entry
        /// </summary>
        public virtual void Add(TDomainClass instance)
        {
            DbSet.Add(instance);
        }
        /// <summary>
        /// Add an entry
        /// </summary>
        public virtual void Update(TDomainClass instance)
        {
            DbSet.AddOrUpdate(instance);
        }

        #endregion
    }
    //public abstract class BaseRepository<TDomainClass> : IBaseRepository<TDomainClass, int>
    //    where TDomainClass : class
    //{
    //    #region Private

    //    private readonly IUnityContainer container;
    //    #endregion
    //    #region Protected

    //    /// <summary>
    //    /// Primary database set
    //    /// </summary>
    //    protected abstract IDbSet<TDomainClass> DbSet { get; }
    //    public static ApplicationDbContext db;


    //    /// <summary>
    //    /// Entities
    //    /// </summary>
    //    protected IApplicationEntities Entities
    //    {
    //        get
    //        {
    //            return container.Resolve<IApplicationEntities>();
    //        }
    //    }
    //    #endregion
    //    #region Constructor

    //    /// <summary>
    //    /// Constructor
    //    /// </summary>
    //    protected BaseRepository(IUnityContainer container)
    //    {

    //        if (container == null)
    //        {
    //            throw new ArgumentNullException("container");
    //        }
    //        this.container = container;
    //        if (db == null)
    //        {
    //           // string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    //            db = new ApplicationDbContext();
    //        }
    //    }
    //    #endregion
    //    #region Public

    //    /// <summary>
    //    /// Get all
    //    /// </summary>
    //    public virtual IQueryable<TDomainClass> GetAll(TDomainClass instance)
    //    {
    //        return DbSet.Find(instance) as IQueryable<TDomainClass>;
    //    }

    //    /// <summary>
    //    /// Create object instance
    //    /// </summary>
    //    /// <returns>object instance</returns>
    //    public virtual TDomainClass Create()
    //    {
    //        TDomainClass result = container.Resolve<TDomainClass>();
    //        return result;
    //    }

    //    /// <summary>
    //    /// Find entry by key
    //    /// </summary>
    //    public virtual IQueryable<TDomainClass> Find(TDomainClass instance)
    //    {
    //        return DbSet.Find(instance) as IQueryable<TDomainClass>;
    //    }

    //    public TDomainClass Find(int id)
    //    {
    //        return DbSet.Find(id);
    //    }

    //    public IQueryable<TDomainClass> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void SaveChanges()
    //    {
    //        db.SaveChanges();
    //    }

    //    /// <summary>
    //    /// Delete an entry
    //    /// </summary>
    //    public virtual void Delete(TDomainClass instance)
    //    {
    //        DbSet.Remove(instance);

    //    }

    //    /// <summary>
    //    /// Add an entry
    //    /// </summary>
    //    public virtual void Add(TDomainClass instance)
    //    {
    //        DbSet.Add(instance);
    //    }
    //    /// <summary>
    //    /// Add an entry
    //    /// </summary>
    //    public virtual void Update(TDomainClass instance)
    //    {
    //        DbSet.AddOrUpdate(instance);
    //    }

    //    #endregion
    //}
}