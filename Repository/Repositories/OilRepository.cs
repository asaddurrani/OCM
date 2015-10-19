using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using Interfaces.Repository;
using Microsoft.Practices.Unity;
using Models.DomainModels;
using Models.ResponseModels;
using Repository.BaseRepository;

namespace Repository.Repositories
{
    public class OilRepository : BaseRepository<Oil>, IOilRepository
    {
        public OilRepository(IUnityContainer container)
            : base(container)
        {
        }

        protected override IDbSet<Oil> DbSet
        {
            get { return db.Oils; }
        }


        public OilResponse GetAllOils(Models.RequestModels.OilSearchRequest request)
        {
            int fromRow = (request.PageNo - 1) * request.PageSize;
            int toRow = request.PageSize;
            Expression<Func<Oil, bool>> query =
                s => (!request.OilId.HasValue || s.OilId == request.OilId) &&
                     (string.IsNullOrEmpty(request.SearchString) || s.OilName.Contains(request.SearchString)) &&
                     (request.OilMakerCompany == null || s.OilMakerId == request.OilMakerCompany);
            IEnumerable<Oil> oils = request.IsAsc ? DbSet.Where(query).Include("OilMakerCompany")
                                            .OrderBy(oil => oil.OilId).Skip(fromRow).Take(toRow).ToList()
                                            : DbSet.Where(query).Include("OilMakerCompany")
                                                .OrderByDescending(oil => oil.OilId).Skip(fromRow).Take(toRow).ToList();
            return new OilResponse { Oils = oils, TotalCount = DbSet.Count(query) };
        }

        public OilResponse GetAllRecords()
        {
            var oilsList = db.Oils.ToList();
            return new OilResponse
            {
                Oils = oilsList,
                TotalCount = oilsList.Count
            };
        }

        public Oil GetOilById(int id)
        {
            if (id > 0)
            {
                return DbSet.Include("OilMakerCompany").FirstOrDefault(x => x.OilId == id);
            }
            return null;
        }

        public Oil Save(Oil oil)
        {
            if (oil.OilId > 0)
            {
                #region Update Record
                Oil oilDbVersion = GetOilById(oil.OilId);
                oilDbVersion.OilName = oil.OilName;
                oilDbVersion.OilMakerId = oil.OilMakerId;
                oilDbVersion.OilAverageMilage = oil.OilAverageMilage;
                oilDbVersion.OilPower = oil.OilPower;
                oilDbVersion.OilPrice = oil.OilPrice;
                oilDbVersion.OilDescription = oil.OilDescription;
                oilDbVersion.OilNetWeightId = oil.OilNetWeightId;
                DbSet.AddOrUpdate(oilDbVersion);
                db.SaveChanges();

                #endregion
            }
            else
            {
                #region Add New Record

                DbSet.Add(oil);
                db.SaveChanges();

                #endregion
            }
            return GetOilById(oil.OilId);
        }
    }
}
