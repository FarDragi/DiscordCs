using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Benckmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Testes>();
        }
    }

    [MemoryDiagnoser]
    public class Testes
    {
        [Params(10000)]
        public int Quantidade { get; set; }
        public Random Random = new Random();

        [Benchmark]
        public void SortedDictionary()
        {
            SortedDictionary<int, int> pairs = new SortedDictionary<int, int>();

            for (int i = 0; i < Quantidade; i++)
            {
                pairs.Add(i, i);
            }

            var findLinq = pairs.FirstOrDefault(x => x.Key == Quantidade - 1);
        }

        [Benchmark]
        public void SortedDictionaryHell()
        {
            int chave = 0;

            SortedDictionary<int, int> pairs = new SortedDictionary<int, int>();

            for (int i = 0; i < Quantidade;)
            {
                chave = Random.Next(-10000, 10000);

                if (pairs.TryAdd(chave, i))
                {
                    ++i;
                }
            }

            var findLinq = pairs.FirstOrDefault(x => x.Key == chave);
        }

        [Benchmark]
        public void SortedList()
        {
            SortedList<int, int> pairs = new SortedList<int, int>();

            for (int i = 0; i < Quantidade; i++)
            {
                pairs.Add(i, i);
            }

            var findLinq = pairs.FirstOrDefault(x => x.Key == Quantidade - 1);
        }

        [Benchmark]
        public void SortedListHell()
        {
            int chave = 0;

            SortedList<int, int> pairs = new SortedList<int, int>();

            for (int i = 0; i < Quantidade;)
            {
                chave = Random.Next(-10000, 10000);

                if (pairs.TryAdd(chave, i))
                {
                    ++i;
                }
            }

            var findLinq = pairs.FirstOrDefault(x => x.Key == chave);
        }

        [Benchmark]
        public void DictionaryHell()
        {
            int chave = 0;

            Dictionary<int, int> pairs = new Dictionary<int, int>();

            for (int i = 0; i < Quantidade;)
            {
                chave = Random.Next(-10000, 10000);

                if (pairs.TryAdd(chave, i))
                {
                    ++i;
                }
            }

            var findLinq = pairs.FirstOrDefault(x => x.Key == chave);
        }

        [Benchmark]
        public void ListTupleHell()
        {
            int chave = 0;

            List<Tuple<int, int>> tuples = new List<Tuple<int, int>>();

            for (int i = 0; i < Quantidade; ++i)
            {
                chave = Random.Next(-10000, 10000);

                tuples.Add(Tuple.Create(chave, i));
            }

            var findLinq = tuples.FirstOrDefault(x => x.Item1 == chave);
        }

        [Benchmark]
        public void ListTupleStructHell()
        {
            int chave = 0;

            List<ValueTuple<int, int>> tuples = new List<ValueTuple<int, int>>();

            for (int i = 0; i < Quantidade; ++i)
            {
                chave = Random.Next(-10000, 10000);

                tuples.Add(ValueTuple.Create(chave, i));
            }

            var findLinq = tuples.FirstOrDefault(x => x.Item1 == chave);
        }
    }
}
