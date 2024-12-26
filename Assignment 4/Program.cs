using System.Data;
using System.Globalization;

namespace Assignment_4
{
    internal class Program
    {
        static void Sumsub(int x,int y,out int sum,out int sub)
        {
            sum=x+y;
            sub=x-y;
        }

        static bool IsPrinme(int n)
        {
           
            bool prime = true;
            for(int i=2; i<n/2; i++)
            {
                if(n%i==0)
                {
                    prime = false;
                    break;
                }    
            }
            return prime;
        }

        static int factorial_calc(int n)
        {
            int fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void MinMaxArray(int[] array,out  int min,out int max)
        {
            min = int.MaxValue;
            max = int.MinValue ;
            for(int i=0;i<array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                 if (array[i] > max)
                    max = array[i];
            }
        }

        static string ChangeChar(ref string s,int position,char c)
        {
            char[] charArray = s.ToCharArray();
            charArray[position] = c;
            s = new string(charArray);
            return s;
        }
        static void ModifyParameters(int val,ref int num)
        {
            val += 5;
            num += 5;
        }

        static void ModifyByValue(int[] arr)
        {
            arr[0] = 10; // Modifies the content of the original object
            arr = new int[] { 100, 200, 300 }; // Reassignment does not affect the original reference
        }

        static void ModifyByReference(ref int[] arr)
        {
            arr[0] = 20; // Modifies the content of the original object
            arr = new int[] { 500, 600, 700 }; // Reassignment affects the original reference
        }
        static void Main(string[] args)
        {
            #region Q1.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //int[] arr1 = new[] { 5, 0, 10, 1, 6 };
            //int[] arr2 = new[] { 3, 0, 10, 2, 21 };
            //int[] arr3 = new int [10]; 
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr3[i]=arr1[i];
            //    arr3[i + 5] = arr2[i];
            //}
            //for (int i = 0;i < arr3.Length; i++)
            //{
            //    for (int j = i+1; j < arr3.Length; j++)
            //    {
            //        if (arr3[i] >= arr3[j])
            //        {
            //            //Swap
            //            int temp = arr3[i];
            //            arr3[i] = arr3[j];
            //            arr3[j] = temp;

            //        }
            //    }
            //}
            //foreach(int i in arr3)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion

            #region Q2.Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr= new int[] { 1, 2, 3, 2, 2, 5, 1, 10, 9, 6, 3, 2, 1, 0, 21 };
            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] <= arr[j])
            //            {
            //                int temp = arr[i];
            //                arr[i] = arr[j];
            //                arr[j] = temp;
            //            }
            //        }
            //    }
            //    int cnt = 0, x = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (!(i == arr.Length - 1)) x++;
            //        cnt++;
            //        if (arr[i] != arr[x])
            //        {
            //            Console.WriteLine($"the element {arr[i]} has frecuency :  {cnt}");
            //            cnt = 0;

            //        }

            //    }
            //}
            #endregion


            #region Q3.Write a program in C# Sharp to find maximum and minimum element in an array
            //int n;
            //bool flag = true;
            //do
            //{
            //    Console.Write("Enter a valid size for array : ");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag && n < 0);

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter the elemet number {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] <= arr[j])
            //            {
            //                int temp = arr[i];
            //                arr[i] = arr[j];
            //                arr[j] = temp;
            //            }
            //        }
            //    }
            //    Console.WriteLine($"the min element in the array is : {arr[0]}");
            //    Console.WriteLine($"the Max Element in the array is : {arr[arr.Length - 1]}");
            //}

            #endregion


            #region Q4.Write a program in C# Sharp to find the second largest element in an array.
            //int n;
            //bool flag = true;
            //do
            //{
            //    Console.Write("Enter a valid size for array : ");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag && n < 0);

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter the elemet number {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //if (arr is not null)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        for (int j = 0; j < arr.Length; j++)
            //        {
            //            if (arr[i] <= arr[j])
            //            {
            //                int temp = arr[i];
            //                arr[i] = arr[j];
            //                arr[j] = temp;
            //            }
            //        }
            //    }
            //    Console.WriteLine($"the second largest  element in the array is : {arr[arr.Length-2]}");

            //}
            #endregion


            #region Q5.the Distance between Equal Cells
            //int n;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter a valid size for the array : ");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag && n<0);
            //int[] arr = new int[n];
            //for (int i = 0;i<n;i++)
            //{
            //    Console.Write($"Enter the element {i+1} : ");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //int distance=0;
            //if (arr is not null)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = n - 1; j >= 0; j--)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                if (distance < j - i - 1)
            //                {
            //                    distance = j - i - 1;
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"he longest Distance is {distance}");


            #endregion

            #region Q6.Given a list of space separated words, reverse the order of the words
            //Console.Write("Enter the sentance : ");
            //string word=Console.ReadLine();
            //string[] wordsArray = word.Split(' ');
            //string[] wordsArrayReversed= new String[wordsArray.Length];
            //for(int i=0,j= wordsArray.Length- 1 ;i < wordsArray.Length && j>=0;i++,j--)
            //{
            //    wordsArrayReversed[i] = wordsArray[j];
            //}
            //foreach(string w in wordsArrayReversed)
            //{
            //    Console.Write(w+" ");
            //}
            #endregion

            #region Q7.Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array
            //int[][] TwoDArr = new int[2][];
            //int n;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter the size for the array : ");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag && n < 0);
            //TwoDArr[0] = new int[n];
            //TwoDArr[1] = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter the Element {i + 1} : ");
            //    int.TryParse(Console.ReadLine(), out TwoDArr[0][i]);
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    TwoDArr[1][i] = TwoDArr[0][i];
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(TwoDArr[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q8.Write a Program to Print One Dimensional Array in Reverse Order
            //int n;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter the size for the array : ");
            //    flag=int.TryParse(Console.ReadLine(), out n);
            //} while (!flag && n<0);
            //int[] arr=new int[n];
            //int[] reverseArr=new int[n];
            //for(int i = 0; i < n; )
            //{
            //    Console.Write($"Enter the Elemet {i+1} : ");
            //    flag =int.TryParse((Console.ReadLine()), out arr[i]);
            //    if (flag) { i++; } 
            //}
            //int j = 0;
            //for(int i = n-1;i >0; i--)
            //{
            //    reverseArr[j] = arr[i];
            //    j++;
            //}

            //foreach(int num in reverseArr )
            //{
            //    Console.Write(num +" ");
            //}

            #endregion

            #region Q9
            int valueParam = 10;      // Value type passed by value
            int refParam = 20;        // Value type passed by reference

            ModifyParameters(valueParam, ref refParam);
            Console.WriteLine(valueParam);
            Console.WriteLine(refParam);
            #endregion

            #region Q.10
            int[] numbers = { 1, 2, 3 }; // Reference type

            Console.WriteLine($"Before: {numbers[0]}");

            // Passing by value
            ModifyByValue(numbers);
            Console.WriteLine($"After ModifyByValue: {numbers[0]}");

            // Passing by reference
            ModifyByReference(ref numbers);
            Console.WriteLine($"After ModifyByReference: {numbers[0]}");
            #endregion

          

            #region Q11.-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //Console.WriteLine("Enter the number 1 : ");
            //int.TryParse(Console.ReadLine(), out int n);
            //Console.WriteLine("Enter the number 2: ");
            //int.TryParse(Console.ReadLine(), out int x);
            //int sum = 0, sub = 0;
            //Sumsub(n,x,out sum,out sub);
            //Console.WriteLine($"the sum is : {sum} the sub is {sub}");
            #endregion


            #region Q12.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
            //int n;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter the number : ");
            //    flag =int.TryParse(Console.ReadLine(), out n );
            //} while (!flag);
            //int sum = 0;
            //while (n > 0)
            //{
            //    sum += n % 10;
            //    n /= 10;
            //}
            //Console.WriteLine($"the sum is : {sum}");
            #endregion

            #region Q.13 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not
            //int n;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter number : ");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //}while(!flag);
            //if(IsPrinme(n))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{ Console.WriteLine("No"); }
            #endregion

            #region Q14.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int n;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter the size for the array : ");
            //    flag = int.TryParse(Console.ReadLine(), out n);
            //} while (!flag);
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter the element {i + 1}");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //int min, max;
            //MinMaxArray(arr,out min,out max);
            //Console.WriteLine(min);
            //Console.WriteLine(max);
            #endregion

            #region Q15.-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter number : ");
            //    flag = int.TryParse(Console.ReadLine(), out number);
            //}while(!flag);
            //Console.WriteLine($"{number}! =  {factorial_calc(number)}");
            #endregion


            #region Q16.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.WriteLine("Enter the word: ");
            //string s=Console.ReadLine();
            //int position;
            //Console.WriteLine("Enter the position you want to make change on it :");
            //int.TryParse(Console.ReadLine(), out position);
            //Console.WriteLine("Enter the char :");
            //char c;
            //char.TryParse(Console.ReadLine(), out c);
            //Console.WriteLine(ChangeChar(ref s,  position,c));
            #endregion
        }
    }
}