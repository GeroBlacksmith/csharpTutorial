using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }
        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }
        public void ShowData()
        {
            Console.WriteLine("{0} is {1}", this.key, this.value);
        }
    }
}
