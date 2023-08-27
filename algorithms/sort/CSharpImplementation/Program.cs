
namespace Algorithms;

class Program
{
    static void Main(string[] args)
    {
        int[] fixedArr = { 100, 35, 26, 490, 1, 60, 52, 34, 55, 98 };
        int[] randomArr = new int[10];
        int[] repeatedArr = { 3, 3, 57, 8, 1, 2, 4, 4, 3, 10};

        Random rndObj = new Random();

        for (int i = 0; i < randomArr.Length; i++)
            randomArr[i] = rndObj.Next(0, 999);

        //randomArr.Print();

        //Bubble.Sort(randomArr);
        //Selection.Sort(randomArr);
        //Insertion.Sort(fixedArr);
        Merge.Sort(fixedArr);
    }
}

