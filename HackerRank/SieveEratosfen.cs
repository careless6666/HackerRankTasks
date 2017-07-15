using System.Collections.Generic;

namespace HackerRank
{
    public class Eratosfen
    {
        private List<int> _simple;

        public Eratosfen(int MaxNumber)
        {
            _simple = new List<int>();
            for (int i = 1; i < MaxNumber; i++)
                _simple.Add(i);
            DoEratosfen();
        }

        int Step(int prime, int startFrom)
        {
            int i = startFrom + 1;
            int removed = 0;
            while (i < _simple.Count)
                if (_simple[i] % prime == 0)
                {
                    _simple.RemoveAt(i);
                    removed++;
                }
                else
                    i++;
            return removed;
        }

        void DoEratosfen()
        {
            int i = 1;
            while (i < _simple.Count)
            {
                Step(_simple[i], i);
                i++;
            }
        }

        public int[] Simple => _simple.ToArray();
    }
}
