using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class BookConverter
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;

            return new Book
            {
                id = origin.id,
                title = origin.title,
                author = origin.author,
                price = origin.price,
                launchDate = origin.launchDate
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;

            return new BookVO
            {
                id = origin.id,
                title = origin.title,
                author = origin.author,
                price = origin.price,
                launchDate = origin.launchDate
            };
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null) return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
