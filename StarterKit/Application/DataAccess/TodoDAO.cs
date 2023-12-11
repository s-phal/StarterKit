
using Dapper;
using Npgsql;
using StarterKit.Application.Config;
using StarterKit.Application.Models;
using System.Data;

namespace CodeCloner.Application.DataAccess
{
    public class TodoDAO
    {
        public string connectionString { get; } = DBConnection.GetConnectionString();

        // CREATE
        public Todo Create(Todo todo)
        {
            using (IDbConnection connection = new NpgsqlConnection(connectionString))
            {
                string sqlQuery = $"CALL TODO_CREATE(@Title, @Details, @Guid)";

                connection.Execute(sqlQuery, new
                {
                    Title = todo.title,
                    Details = todo.details,
                    Guid = todo.guid
                });



            }

            return todo;

        }

        // READ SINGLE
        public Todo Retrieve(string pathId)
        {

            using (IDbConnection connection = new NpgsqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * " +
                    "FROM path " +
                    "WHERE path_id = @PathId";

                return connection.QuerySingle<Todo>(sqlQuery, new
                {
                    PathId = pathId
                });

            }
        }

        // READ ALL
        public List<Todo> RetrieveAll()
        {
            using (IDbConnection connection = new NpgsqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM todo";

                return connection.Query<Todo>(sqlQuery).ToList();
            }
        }

        // UPDATE
        public void Update(Todo todo)
        {
            using (IDbConnection connection = new NpgsqlConnection(connectionString))
            {
                string sqlQuery = $"CALL TODO_UPDATE(@id, @title, @details, @updatedAt, @isActive)";

                connection.Execute(sqlQuery, new
                {
                    Id = todo.todo_id,
                    Title = todo.title,
                    Details = todo.details,
                    UpdatedAt = todo.updated_at,
                    IsActive = todo.is_active
                });
            }
        }


        // DELETE
        public void Delete(int pathId)
        {
            using (IDbConnection connection = new NpgsqlConnection(connectionString))
            {
                string sqlQuery = $"CALL TODO_DELETE(@Id)";

                connection.Execute(sqlQuery, new
                {
                    Id = pathId
                });
            }
        }

    }
}
