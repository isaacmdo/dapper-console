using dapper_console_aplication.Models;
using dapper_console_aplication.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace dapper_console_aplication.Screens.TagScreens
{
    internal class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova tag");
            Console.WriteLine("-------------");
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Tag cadastrada com sucesso!");
            } catch(Exception ex)
            {
                Console.WriteLine("Não foi possivel salvar a tag");
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
