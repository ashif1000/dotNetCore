﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotNetCore.Models;
using dotNetCore.Controllers;

namespace dotNetCore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById (int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title == title || x.Author == authorName).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id =1, Title = "1stTitle", Author ="1stAuthor"},
                new BookModel(){Id =2, Title = "2ndTitle", Author ="2ndAuthor"},
                new BookModel(){Id =3, Title = "3rdTitle", Author ="3rdAuthor"},
                new BookModel(){Id =4, Title = "4thTitle", Author ="4thAuthor"},

            };
        }
    }
}
