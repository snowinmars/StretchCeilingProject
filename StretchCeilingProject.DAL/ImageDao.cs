using StretchCeilingProject.Common;
using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

            SqlCommand sqlInsertCommand = new SqlCommand(ImageDao.InsertCommand);

            sqlInsertCommand.Parameters.AddWithValue("@id", item.Id);
            sqlInsertCommand.Parameters.AddWithValue("@content", item.Content);

            using (SqlConnection sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                sqlConnection.Open();
                sqlInsertCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public Image Get(Guid id)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                SqlCommand sqlSelectCommand = new SqlCommand(ImageDao.SelectCommand, sqlConnection);
                sqlSelectCommand.Parameters.AddWithValue("@id", id);

                sqlConnection.Open();
                SqlDataReader reader = sqlSelectCommand.ExecuteReader();

                if (reader.Read())
                {
                    byte[] content = reader["Content"] as byte[];

                    return new Image(content)
                    {
                        Id = id,
                    };
                }

                sqlConnection.Close();
            }

            return new Image(new byte[0]);
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
            if (this.Get(item.Id).Content.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}