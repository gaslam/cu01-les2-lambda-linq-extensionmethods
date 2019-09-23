using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq.Book.Domain
{
    public class Worker
    {
        public bool WorkDone { get; set; }

        public async void DoWork()
        {
            var Result = await Task.Run(() =>
            {
                WorkDone = false;
                Random random = new Random();
                long som = 0;
                long aantalRuns = 50000000;
                for(int i= 0; i <=aantalRuns; i++)
                {
                    som += random.Next(1, 101);
                }
                WorkDone = true;
                return som;
            });
        }
    }
}
