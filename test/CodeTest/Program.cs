using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new();

            List<string> lists = teste.ToList();
        }
    }

    public class Teste : IEnumerable<string>
    {
        Dictionary<string, string> hash;

        public Teste()
        {
            hash = new Dictionary<string, string>()
            {
                { "a", "1" },
                { "b", "2" },
                { "c", "3" },
                { "d", "4" },
                { "e", "5" }
            };
        }

        public IEnumerator<string> GetEnumerator()
        {
            return hash.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
