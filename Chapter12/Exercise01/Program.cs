using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var employee = new Employee {
                Id = 1000,
                Name = "関　唯斗",
                HireDate = new DateTime(2003, 10, 21),
            };

            //シリアル化
            using (var write = XmlWriter.Create(v)) {
                var serializer = new XmlSerializer(employee.GetType());
                serializer.Serialize(write, employee);
            }

            //逆シリアル化
            using (XmlReader reader = XmlReader.Create(v)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var emp = serializer.Deserialize(reader) as Employee;
            }
        }

        private static void Exercise1_2(string v) {
            var employees = new Employee[] {
                new Employee {
                    Id = 1001,
                    Name = "黛灰",
                    HireDate = new DateTime(2022, 7, 31),
                },
                new Employee {
                    Id = 1002,
                    Name = "不破湊",
                    HireDate = new DateTime(2021, 8, 19),
                }
            };

            using (var write = XmlWriter.Create(v)) {
                var serializer = new DataContractSerializer(employees.GetType());
                serializer.WriteObject(write, employees);
            }
        }

        private static void Exercise1_3(string v) {
            using (XmlReader reader = XmlReader.Create(v)) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
            }
            Console.WriteLine(File.ReadAllText(v));
        }

        private static void Exercise1_4(string v) {
            var employees = new Employee[] {
                new Employee {
                    Id = 1001,
                    Name = "葛葉",
                    HireDate = new DateTime(2022, 7, 31),
                },
                new Employee {
                    Id = 1002,
                    Name = "叶",
                    HireDate = new DateTime(2021, 8, 19),
                }
            };

            using(var stream = new FileStream(v, FileMode.Create, FileAccess.Write)) {
                var seralizer = new DataContractJsonSerializer(employees.GetType());
                seralizer.WriteObject(stream, employees);
            }
        }
    }
}
