using System;
using System.Threading;
using System.Threading.Tasks;

namespace ClassDemoThreadsApp
{
    internal class AWorker
    {
        public void Start()
        {
            for (int i = 0; i < 15; i++)
            {
                int k = i;
                //Thread t = new Thread(() => PrintNoget(i));
                //t.Start();

                Task.Run(() =>
                {
                    PrintNoget(k);
                });
            }




        }


        protected void PrintNoget(int i)
        {
            for (int j = 0; j < 50; j++)
            {
                Console.WriteLine($"Dette er tråd nummer {i}");

            }

        }
    }
}