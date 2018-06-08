﻿using System;
using System.Linq;
using System.Threading.Tasks;
using WeihanLi.Common.Helpers;

namespace DotNetCoreSample
{
    internal static class TaskTest
    {
        public static async Task TaskWhenAllTest()
        {
            var time = await InvokeHelper.ProfileAsync(() => Task.WhenAll(Enumerable.Range(1, 5).Select(_ => Task.Delay(1000))));
            Console.WriteLine("await Task.WhenAll time:{0} ms", time);

            time = InvokeHelper.Profile(() => Task.WhenAll(Enumerable.Range(1, 5).Select(_ => Task.Delay(1000))));
            Console.WriteLine("Task.WhenAll no wait time:{0} ms", time);

            time = InvokeHelper.Profile(() => Task.WhenAll(Enumerable.Range(1, 5).Select(_ => Task.Delay(1000))).Wait());
            Console.WriteLine("Task.WhenAll wait time:{0} ms", time);
        }
    }
}