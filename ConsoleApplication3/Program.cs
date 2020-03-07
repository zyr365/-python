using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*执行bin目录下test.py*/
            /*ScriptEngine pyEngine = Python.CreateEngine();//创建Python解释器对象
            dynamic py = pyEngine.ExecuteFile(@"test.py");//读取脚本文件
            int[] array = new int[9] { 9, 3, 5, 7, 2, 1, 3, 6, 8 };
            string reStr = py.main(array);//调用脚本文件中对应的函数
            Console.WriteLine(reStr);
            Console.ReadKey();*/
            ScriptRuntime pyRunTime = Python.CreateRuntime();
            dynamic obj = pyRunTime.UseFile("test.py");
            Console.WriteLine(obj.welcome(10));
            Console.ReadKey();
        }
    }
}
