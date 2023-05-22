using System;
using System.Windows.Forms;

namespace Lab_work_4
{
    public partial class Form1 : Form
    {
        int[] Array;
        bool BoolSort;
        bool BoolGenerate;
        Random random = new Random();
        Sort sort = new Sort();
        Search search = new Search();
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            BoolGenerate = true;
            BoolSort = false;
            int N = (int)(20 + 0.6 * Convert.ToInt32(UpDownNumber.Value));
            labSize.Text = "розмір масиву: " + N;
            Array = new int[N];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(10, 100);
            }
            AddList(ref lbArray, Array);
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (!BoolGenerate)
                btGenerate_Click(sender, e);

            BoolSort = true;
            sort.QuickSort(Array);
            AddList(ref lbArray, Array);
        }

        static void AddList(ref ListBox list, int[] Array)
        {
            list.Items.Clear();
            foreach (int item in Array)
                list.Items.Add(item);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchItem = int.Parse(tbSearchItem.Text);
                int num = search.BinarySearch(Array, searchItem);
                if (!BoolSort)
                {
                    btSort_Click(sender, e);
                    btSearch_Click(sender, e);
                }
                else if (num == -1)
                {
                    MessageBox.Show("Елемнт відсутній");
                }
                else
                {
                    MessageBox.Show($"Елемент {searchItem} зустрічається {num} разів");
                }
            }
            catch { MessageBox.Show("Введіть елмент пошуку", "Помилка"); }
        }
    }
    class Sort
    {
        static void Swap(ref int i, ref int j)
        {
            int t = i;
            i = j;
            j = t;
        }
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            int pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);
            return array;
        }

        public int[] QuickSort(int[] array) { return QuickSort(array, 0, array.Length - 1); }
    }
    class Search
    {
        public int BinarySearch(int[] array, int Value)
        {
            int number = 0;
            int i = BinarySearch(array, Value, 0, array.Length - 1);
            while (i != -1)
            {
                if (i == array.Length - 1)
                {
                    number++;
                    break;
                }
                number++;
                array = ArrayRemoveAt(array, i);
                i = BinarySearch(array, Value, 0, array.Length - 1);
            }
            return number;
        }
        public int BinarySearch(int[] array, int Value, int i, int j)
        {
            if (i > j)
            {
                return -1;
            }
            int middle = (i + j) / 2;
            int middleValue = array[middle];

            if (middleValue == Value)
            {
                return middle;
            }
            else
            {
                if (middleValue > Value)
                {
                    return BinarySearch(array, Value, i, middle - 1);
                }
                else
                {
                    return BinarySearch(array, Value, middle + 1, j);
                }
            }
        }
        static int[] ArrayRemoveAt(int[] array, int i)
        {
            int[] newArray = new int[array.Length - 1];
            for (int j = 0; j < array.Length; j++)
            {
                if (j < i)
                {
                    newArray[j] = array[j];
                }
                else if (j > i)
                {
                    newArray[j - 1] = array[j];
                }
            }
            return newArray;
        }
    }
}
