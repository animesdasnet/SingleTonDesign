using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesign
{
    public class SingleTonDesign
    {

        private static SingleTonDesign _instance = new SingleTonDesign();
        private SingleTonDesign()
        {

        }

        public static SingleTonDesign Instance
        {
            get { return _instance; }
        }

        public void SingleTonProperty()
        {
            Console.WriteLine("Singleton class code has been called");
        }

    }
}
