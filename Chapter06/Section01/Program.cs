using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4, };

            var books = Books.GetBooks();

            //1 タイトルに「物語」が含まれている書籍の平均ページ数
            var pageAve = books.Where(b => b.Title.Contains("物語")).Average(b => b.Pages);
            Console.WriteLine(pageAve);

            //2 タイトルが長い順
            var bookObj = books.OrderByDescending(b => b.Title.Length);
            foreach (var book in bookObj) {
                Console.WriteLine(book.Title);
            }
        }
    }
}
