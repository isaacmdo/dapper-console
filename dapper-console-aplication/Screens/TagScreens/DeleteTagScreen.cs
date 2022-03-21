using dapper_console_aplication.Models;
using dapper_console_aplication.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace dapper_console_aplication.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

         

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Tag excluida com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possivel excluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
