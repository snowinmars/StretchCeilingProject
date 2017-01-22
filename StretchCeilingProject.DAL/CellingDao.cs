using Dapper;
using Newtonsoft.Json;
using SandS.Algorithm.Extensions.EnumerableExtensionNamespace;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace StretchCeilingProject.DAL
{
    public class CellingDao : ICeilingDao
    {
        public void Add(Celling item)
        {
            if (!this.IsValidImage(item))
            {
                throw new InvalidOperationException($"Can't add celling with id {item.Id}: data layer validation failed");
            }

            using (var sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                sqlConnection.Query<Image>(CellingDao.InsertCommand, param: new { item.Id, item.ImageUrl, item.Cost, Description = item.Title });
            }
        }

        private const string InsertCommand = @"
insert into
[dbo].[Celling] (
    [Id]
    , [ImageUrl]
    , [Cost]
    , [Title]
    , [Category]
    , [Description]
    )
values (
    @id
    , @imageUrl
    , @cost
    , @title
    , @category
    , @description
    )";

        private const string SelectCommand = @"
select
    [Id]
    , [ImageUrl]
    , [Cost]
    , [Title]
    , [Category]
    , [Description]
from
    [dbo].[Celling]
where
    [Id] = @id";

        private const string SelectAllComand = @"
select
    [Id]
    , [ImageUrl]
    , [Cost]
    , [Title]
    , [Category]
    , [Description]
from
    [dbo].[Celling]";

        private const string SelectDescriptionCommand = @"
select
    [Id]
    , [Procs]
    , [ImageUrls]
    , [Description]
from
    [dbo].[CellingDescription]
where
    [Id] = @id
";

        private bool IsValidImage(Celling item)
        {
            // if I found something
            if (this.Get(item.Id) != Celling.Empty)
            {
                return false;
            }

            return true;
        }

        public Celling Get(Guid id)
        {
            using (var sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                return sqlConnection.Query<Celling>(CellingDao.SelectCommand, param: new { id })
                                            .FirstOrDefault_AndIfDefaultGiveMe(Celling.Empty);
            }
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Celling item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Celling> GetByFilter(CellingFilter filter)
        {
            using (var sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                return sqlConnection.Query<Celling>(CellingDao.SelectAllComand);
            }
        }

        public IEnumerable<IGrouping<CellingCategory, Celling>> GetGroupedByCategory()
        {
            return this.GetByFilter(new CellingFilter()).GroupBy(item => item.Category);
        }

        public CellingDescription GetDescription(Guid id)
        {
            using (var sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                var tmps = sqlConnection.Query<TmpCellingDescription>(CellingDao.SelectDescriptionCommand, param: new { id });

                if (tmps == null)
                {
                    return CellingDescription.Empty;
                }

                foreach (var tmp in tmps)
                {
                    var c = new CellingDescription
                    {
                        Description = tmp.Description,
                        Id = tmp.Id,
                    };

                    IEnumerable<string> procs = JsonConvert.DeserializeObject<IEnumerable<string>>(tmp.Procs);
                    IEnumerable<string> imageUrls = JsonConvert.DeserializeObject<IEnumerable<string>>(tmp.ImageUrls);

                    foreach (var proc in procs)
                    {
                        c.Procs.Add(proc);
                    }

                    foreach (var imageUrl in imageUrls)
                    {
                        c.ImageIds.Add(imageUrl);
                    }

                    return c;
                }

                return CellingDescription.Empty;
            }
        }
    }

    internal class TmpCellingDescription
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Procs { get; set; }
        public string ImageUrls { get; set; }
    }
}