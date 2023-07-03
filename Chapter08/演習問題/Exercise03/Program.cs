﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var tw = new TimeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            Console.WriteLine("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
        }
    }

    class TimeWatch {
        private DateTime StartDate { get; set; }

        public void Start() {
            StartDate = DateTime.Now;
        }

        public TimeSpan Stop() => DateTime.Now - StartDate;
    }
}
