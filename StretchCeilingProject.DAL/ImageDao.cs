using StretchCeilingProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StretchCeilingProject.Common;

namespace StretchCeilingProject.DAL
{
    public class ImageDao : IDao<Image>
    {
        private readonly SqlCommand insertCommand = new SqlCommand(@"
insert into 
table (
        id
        , content
        )
values (
        @id
        , @content
        )
");

        public void Add(Image item)
        {
            this.insertCommand.Parameters.AddWithValue("@content", item.Content);
            this.insertCommand.Parameters.AddWithValue("@id", item.Id);

            using (SqlConnection sqlConnection = new SqlConnection(Constant.ConnectionString))
            {
                sqlConnection.Open();
                this.insertCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        public Image Get(Guid id)
        {
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
    }
}