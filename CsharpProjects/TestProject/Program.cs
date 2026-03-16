/* convert the message into a char array
   Reverse the chars
   count the o's
   convert it back to a string
   print it out */
Console.WriteLine("a" == "a ");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
// void BubbleSort()
// {
//     Random rng = new Random();
//     int[] scramble = Enumerable.Range(1, 20).OrderBy(x => rng.Next()).ToArray();
//     //int[] solved = new int[10];

//     int BubbleSwap()
//     {
//         int count = 0;
//         for (int i = 0; i < scramble.Length - 1; i++)
//         {
//             if (scramble[i + 1] < scramble[i])
//             {
//                 int select = scramble[i];
//                 scramble[i] = scramble[i + 1];
//                 scramble[i + 1] = select;
//                 count++;
//             }
//         }
//         return count;
//     }

//     for (int i = 0; i < scramble.Length - 1; i++)
//     {
//         var counted = BubbleSwap();
//         Console.WriteLine(counted);
//         if (counted == 0)
//         {
//             break;
//         }
//     }

//     for (int j = 0; j < scramble.Length; j++)
//     {
//         Console.WriteLine($"Result: {scramble[j]}");
//     }
// }

// BubbleSort();
// void MergeSort()
// {
//     Random rng = new Random();
//     int[] scramble = Enumerable.Range(1, 20).OrderBy(x => rng.Next()).ToArray();

//     List<int> result = new List<int>();
//     int i = 0, j = 0;

//     while (i < left.Length && j < right.Length)
//     {
//         if (left[i] < right[j])
//         {
//             result.Add(left[i]);
//             i++;
//         }
//         else
//         {
//             result.Add(right[j]);
//             j++;
//         }
//     }

//     // Add leftovers
//     while (i < left.Length) result.Add(left[i++]);
//     while (j < right.Length) result.Add(right[j++]);

// }

