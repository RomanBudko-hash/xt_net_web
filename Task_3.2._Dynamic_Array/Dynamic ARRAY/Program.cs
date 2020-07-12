namespace Dynamic_ARRAY
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyArrayList<int> myArray = new MyArrayList<int>();

            myArray.Add(2);
            myArray.Add(4);
            myArray.Add(6);
            myArray.Add(8);
            myArray.Add(10);
            myArray.Add(12);
            myArray.Add(14);
            myArray.Add(15);
            myArray.Add(1);

            MyArrayList<int> list = new MyArrayList<int>(10);

            myArray.Remove(2);
        }
    }
}
