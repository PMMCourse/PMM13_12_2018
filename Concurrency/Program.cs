using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter writer = new StreamWriter("");

            List<int> numbers = new List<int>();

            /*
            var numbersTo100 = numbers.AsParallel()
                .Where(x => x > 100);
                .ForEach(x => Console.WriteLine(x));
                */

            ToDoSample();
            
            Console.ReadKey();
        }

        private static void ToDoSample()
        {
            Console.WriteLine("Delay Instance");
            var delayAction = new DelayAction(PerformToAction);
            var delayActionF = new DelayAction((str) =>
            {
                Console.WriteLine(str);
            });


            Thread.Sleep(1000);                        
        }

        private static void PerformToAction(string obj)
        {
            Console.WriteLine(obj);
        }

        private static void Perform(int obj)
        {
            throw new NotImplementedException();
        }

        private async Task<string> ConcatAllTextsAsync()
        {            
            StreamReader reader = new StreamReader("");
            StreamReader readerTwo = new StreamReader("");
            StreamReader readerThree = new StreamReader("");

            var promiseForReadingOne = reader.ReadToEndAsync();
            var promiseForReadingTwo = readerTwo.ReadToEndAsync();
            var promiseForReadingThree = readerThree.ReadToEndAsync();

            var texts = await Task.WhenAll(promiseForReadingOne, promiseForReadingTwo, promiseForReadingThree);

            return string.Concat(texts);
        }

        private async void A()
        {
            var text = ConcatAllTextsAsync();
        }

        private async Task AAsync()
        {
            var text = await ConcatAllTextsAsync();            
        }

        public Task<string> DoActionWhatever()
        {
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();                        
            tcs.TrySetResult(string.Empty);
            return tcs.Task;
        }




    }
}
