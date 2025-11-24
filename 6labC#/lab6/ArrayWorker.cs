using System;
using System.Diagnostics;

namespace _3lab
{
    public class ArrayWorker
    {
        private int _length;
        private int[] _array;

        public int Length
        {
            get { return _length; }
            private set { _length = value; }
        }

        public int[] Array
        {
            get { return _array; }
            set { _array = value; }
        }

        public ArrayWorker()
        {
            _length = 10;
            _array = GenerateRandomArray(_length);
        }

        public ArrayWorker(int length)
        {
            _length = length;
            _array = GenerateRandomArray(_length);
        }

        public void Randomize()
        {
            _array = GenerateRandomArray(_length);
        }

        public int GetMin()
        {
            if (_array == null || _length == 0) return 0;

            int min = _array[0];
            for (int i = 1; i < _length; i++)
            {
                if (_array[i] < min) min = _array[i];
            }
            return min;
        }

        public int GetMax()
        {
            if (_array == null || _length == 0) return 0;

            int max = _array[0];
            for (int i = 1; i < _length; i++)
            {
                if (_array[i] > max) max = _array[i];
            }
            return max;
        }

        public double GetAverage()
        {
            if (_array == null || _length == 0) return 0;

            double sum = 0;
            for (int i = 0; i < _length; i++)
            {
                sum += _array[i];
            }
            return sum / _length;
        }

        private int[] GenerateRandomArray(int n)
        {
            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-100, 100);
            }
            return arr;
        }

        public int[] CopyArray()
        {
            int[] copyArr = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                copyArr[i] = _array[i];
            }
            return copyArr;
        }

        public double BubbleSort()
        {
            int[] arr = CopyArray();
            var stopwatch = Stopwatch.StartNew();

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            stopwatch.Stop();
            _array = arr;
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public double ShellSort()
        {
            int[] arr = CopyArray();
            var stopwatch = Stopwatch.StartNew();

            int n = arr.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j = i;
                    while (j >= gap && arr[j - gap] > temp)
                    {
                        arr[j] = arr[j - gap];
                        j -= gap;
                    }
                    arr[j] = temp;
                }
                gap /= 2;
            }

            stopwatch.Stop();
            _array = arr;
            return stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}