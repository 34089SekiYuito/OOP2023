using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： ファイルを読み込み、StudentのListを返却
        private static IEnumerable<Student> ReadScore(string filePath) {
            var students = new List<Student>();     //生徒データを格納する
            var lines = File.ReadAllLines(filePath);   //ファイルからすべてのデータを読み込む

            //すべての行から１行ずつ取り出す
            foreach (var line in lines) {
                var items = line.Split(',');   //区切りで項目別に分ける
                //Studentインスタンスを生成
                var student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);    //Studentインスタンスをコレクションに追加
            }
            return students;
        }

        //メソッドの概要： 科目別の点数を集計
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new SortedDictionary<string, int>();
            foreach (var student in _score) {
                if (dict.ContainsKey(student.Subject)) {
                    //科目がすでに存在する(点数加算)
                    dict[student.Subject] += student.Score;
                }
                else {
                    //科目が存在しない(新規格納)
                    dict[student.Subject] = student.Score;
                }
            }
            return dict;
        }
    }
}
