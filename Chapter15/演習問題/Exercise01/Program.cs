using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var book = Library.Books.First(b => b.Price == Library.Books.Max(m => m.Price));
            Console.WriteLine(book.ToString());
        }

        private static void Exercise1_3() {
            var books = Library.Books.GroupBy(b => b.PublishedYear).OrderBy(g => g.Key);
            foreach (var book in books) {
                Console.WriteLine("{0}年　{1}冊", book.Key, book.Count());
            }

        }

        private static void Exercise1_4() {
            var sortbooks = Library.Books.OrderByDescending(b => b.PublishedYear).ThenByDescending(x => x.Price)
                .Join(Library.Categories,
                book => book.CategoryId,
                category => category.Id,
                (book, category) => new {
                    PublishedYear = book.PublishedYear,
                    Price = book.Price,
                    Title = book.Title,
                    Category = category.Name,
                });
            foreach (var book in sortbooks) {
                Console.WriteLine("{0}年 {1}円 {2}({3})", book.PublishedYear, book.Price, book.Title, book.Category);
            }
        }

        private static void Exercise1_5() {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                book => book.CategoryId,
                categiry => categiry.Id,
               (book, category) => category.Name)
                .Distinct();
            foreach (var name in names) {
                Console.WriteLine(name);
            }

        }

        private static void Exercise1_6() {
            var groups = Library.Categories
                .Join(Library.Books,
                category => category.Id,
                book => book.CategoryId,
               (category, book) => new {
                   category = category.Name,
                   Books = book,
               }).GroupBy(b => b.category)
               .OrderBy(b => b.Key);

            foreach (var group in groups) {
                Console.WriteLine($"#{group.Key}");
                foreach (var book in group) {
                    Console.WriteLine($" {book.Books.Title}");
                }
            }
        }

        private static void Exercise1_7() {
            var dev = Library.Categories
                .Join(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, b) => new {
                    Category = c.Name,
                    Title = b.Title,
                    PublishedYear = b.PublishedYear,
                })
                .Where(c => c.Category == "Development")
                .GroupBy(b => b.PublishedYear)
                .OrderBy(b => b.Key);

            foreach (var group in dev) {
                Console.WriteLine($"#{group.Key}年");
                foreach (var book in group) {
                    Console.WriteLine($" {book.Title}");
                }
            }

            //解答例
            //var catid = Library.Categories.Single(c => c.Name == "Development").Id;
            //var groups = Library.Books
            //    .Where(b => b.CategoryId == catid)
            //    .GroupBy(b => b.PublishedYear)
            //    .OrderBy(b => b.Key);
            //foreach (var group in groups) {
            //    Console.WriteLine("#{0}年", group.Key);
            //    foreach (var book in group) {
            //        Console.WriteLine(" {0}", book.Title);
            //    }
            //}

        }

        private static void Exercise1_8() {
            var cat = Library.Categories
                .GroupJoin(Library.Books,
                c => c.Id,
                b => b.CategoryId,
                (c, b) => new {
                    Category = c.Name,
                    Count = b.Count()
                }).Where(b => b.Count >= 4);
            foreach (var item in cat) {
                Console.WriteLine(item.Category);
            }
        }
    }
}
