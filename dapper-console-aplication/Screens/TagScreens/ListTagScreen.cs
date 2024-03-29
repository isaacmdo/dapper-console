﻿using dapper_console_aplication.Models;
using dapper_console_aplication.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace dapper_console_aplication.Screens.TagScreens
{
    public static class ListTagScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.Get();
            foreach (var item in tags)
            {   
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");
            }
        }
    }
}
