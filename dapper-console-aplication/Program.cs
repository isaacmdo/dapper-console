using System;
using dapper_console_aplication.Models;
using dapper_console_aplication.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace dapper_console_aplication
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=ISAAC;Database=Blog;User ID=sa;Password=YOURPASSWORD";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);

            connection.Open();
            ReadUsersWithRoles(connection);
            //ReadRoles(connection);
            //ReadTags(connection);
            //CreateUser(connection);
            //UpdateUser();
            //DeleteUser();
            connection.Close();
        }

        public static void ReadUsersWithRoles(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }

        }

        public static void CreateUser(SqlConnection connection)
        {

            var user = new User()
            {
                Email = "test2@balta.io",
                Bio = "Bio",
                Image = "imagem",
                Name = "Name",
                PasswordHash = "hash",
                Slug = "slug test"
            };
            var repository = new Repository<User>(connection);
            repository.Create(user);

        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.Get();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }


        }


        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.Get();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
    }