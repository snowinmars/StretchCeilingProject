using Dapper;
using SandS.Algorithm.Extensions.EnumerableExtensionNamespace;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace StretchCeilingProject.DAL
{
    public class ImageDao : IImageDao
    {
        private const string InsertCommand = @"
insert into
[dbo].[Images] (
    [Id]
    , [Content]
    , [Date]
    )
values (
    @id
    , @content
    , @date
    )";

        private const string SelectCommand = @"
select
    [Id]
    , [Content]
from
    [dbo].[Images]
where
    [Id] = @id";

        public void Add(Image item)
        {
            if (!this.IsValidImage(item))
            {
                throw new InvalidOperationException($"Can't add item with id {item.Id}: data layer validation failed");
            }

            using (SqlConnection sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                sqlConnection.Query<Image>(ImageDao.InsertCommand, param: new { item.Id, item.Content, date=DateTime.Now.ToLongTimeString() });
            }
        }

        public Image Get(Guid id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                return sqlConnection.Query<Image>(ImageDao.SelectCommand, param: new { id })
                                            .FirstOrDefault_AndIfDefaultGiveMe(Image.Empty);
            }
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Image item)
        {
            throw new NotImplementedException();
        }

        private bool IsValidImage(Image item)
        {
            // if I found something
            if (this.Get(item.Id) != Image.Empty)
            {
                return false;
            }

            return true;
        }

        public IEnumerable<Image> GetByFilter(ImageFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}