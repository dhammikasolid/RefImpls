using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Lang
{
    public class Abstracts
    {
        private readonly ITestOutputHelper output;

        public Abstracts(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void AbstractClasses()
        {
            var aArray = new A[]
            {
                new B1(), 
                new B2()
            };

            foreach (var a in aArray)
            {
                a.Method(output);
            }
        }

        // Static Polimorpism: Method/Operator Overloading.

        // Static Polimorpism violation

        //int A()
        //{
        //    return 1;
        //}

        //string A()
        //{
        //    return "";
        //}
    }

    abstract class A
    {
        public abstract void Method(ITestOutputHelper output);
    }

    class B1 : A
    {
        public override void Method(ITestOutputHelper output)
        {
            output.WriteLine("B1");
        }
    }

    class B2 : A
    {
        public override void Method(ITestOutputHelper output)
        {
            output.WriteLine("B2");
        }
    }
}
