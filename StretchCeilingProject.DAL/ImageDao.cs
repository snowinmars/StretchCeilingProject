using Dapper;
using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace StretchCeilingProject.DAL
{
    public class ImageDao : IDao<Image>
    {
        private const string InsertCommand = @"
insert into
[dbo].[Images] (
    [Id]
    , [Content]
    )
values (
    @id
    , @content
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
                sqlConnection.Query<Image>(ImageDao.InsertCommand, param: new { item.Id, item.Content });
            }
        }

        public Image Get(Guid id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                return sqlConnection.Query<Image>(ImageDao.SelectCommand, param: new { id }).First();
            }
        }

        public IEnumerable<Image> GetByFilter()
        {
            throw new NotImplementedException();
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
            if (this.Get(item.Id).Content.Length != 0)
            {
                return false;
            }

            return true;
        }
    }
}