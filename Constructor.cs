using System;
namespace Constructor
{
    class Constructor
    {
        private int width = 0;
        private int height = 0;

        public Constructor(int width, int height)
        {
            if (width >= 0) this.width = width;
            if (height >= 0) this.height = height;
        }
        public void ShowData() => Console.WriteLine("Height - {0} cm, width - {1} cm", height, width);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Constructor[] arr = new Constructor[10];
            Random value = new Random();
            for (int i = 0; i < 10; i++)
                arr[i] = new Constructor(value.Next(50, 200), value.Next(50, 200));
            foreach (var i in arr)
                i.ShowData();
        }
    }
}