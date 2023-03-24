using System.Drawing;

namespace Quiz
{
    internal class Program1
    {
        static List<String> myList = new List<String>();
       
        static void Main(string[] args)
        {
            Console.WriteLine("CHOCOLATE DISPENSER...");
            addCho("red", 10);
            addCho("green", 5);
            DisplayList();
            Console.WriteLine();
            removeCho(3);
            DisplayList();
            Console.WriteLine();
            dispenseChocolates(2);
            DisplayList();
            Console.WriteLine();
            dispenseChocolatesOfColor("red", 3);
            DisplayList();
            Console.WriteLine();
            noOfChocolates();
            DisplayList();
            Console.WriteLine();
            sortChocolateBasedOnCount();
            DisplayList();
            Console.WriteLine();
            changeChocolateColor("red", 1, "silver");
            DisplayList();
            
            Console.WriteLine();
            changeChocolateColorAllOfxCount("green", "purple");
            DisplayList();
            Console.WriteLine();
            removeChocolateOfColor("silver");
            DisplayList();
            Console.WriteLine();
            dispenseRainbowChocolates();



        }

        public static void addCho(String color, int n)
        {
            for(int i = 0; i < n; i++)
            {
                myList.Add(color);
            }
        }

        public static void removeCho(int n)
        {
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                //Console.Write(myList[myList.Count - 1].ToString() + " ");
                myList.RemoveAt(myList.Count - 1);
            }
        }

        public static void dispenseChocolates(int n)
        {
            for(int i=0; i<n; i++)
            {
                //Console.Write(myList[0].ToString() + " ");
                myList.RemoveAt(0); 
            }
        }

        public static void dispenseChocolatesOfColor(String color, int n)
        {
            for(int i= 0; i<myList.Count; i++)
            {
                if(n == 0)
                {
                    break;
                }
                if (myList[i].ToString() == color)
                {
                    //Console.Write(myList[i].ToString() + " ");  
                    myList.RemoveAt(i);
                    n--;
                }
                else
                {
                    continue;
                }
            }
        }

        public static void noOfChocolates()
        {
            String[] colors = new string[] {"green", "silver", "blue", "crimson", "purple", "red", "pink"};
            foreach(String color in colors)
            {
                Console.Write(color + "  ");
                int c = 0;
                foreach(String color2 in myList) {
                    if(color == color2)
                    {
                        c += 1;
                    }
                }
                Console.Write(c);
                Console.WriteLine();
            }
        }

        public static void sortChocolateBasedOnCount()
        {
            Dictionary<String,int> di = new Dictionary<String,int>();
            foreach(String color in myList)
            {
                if (di.ContainsKey(color))
                {
                    di[color] += 1;
                }
                else
                {
                    di.Add(color, 1);
                }
            }
            myList.Clear();
            foreach (var item in di.OrderByDescending(key => key.Value))
            {
                //Console.Write(item);
                for(int i = 0; i < di[item.Key]; i++)
                {
                    myList.Add(item.Key);
                }
            }
            
        }
        public static void changeChocolateColor(String c1, int n, String c2)
        {
            int i = 0;
            while(n > 0)
            {
                if (myList[i] == c1)
                {
                    myList[i] = c2;
                    n--;
                }
                i++;

            }
            foreach(String c in  myList)
            {
                //Console.Write(c + " ");
            }
        }

        public static void changeChocolateColorAllOfxCount(String c1, String c2)
        {
            for(int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == c1)
                {
                    myList[i] = c2;
                }
            }
        }

        public static void removeChocolateOfColor(String c)
        {
            int l = myList.Count;
            for(int i = l-1; i >= 0; i--)
            {
                if (myList[i] == c)
                {
                    myList.RemoveAt(i);
                    break;
                }
            }
        }

        public static void dispenseRainbowChocolates(int n = 0)
        {
            String c = myList[0];
            int count = 1;
            int ans = 0;
            foreach(String s in myList)
            {
                if(s == c)
                {
                    count += 1;
                    if(count == 3)
                    {
                        ans += 1;
                        count = 0;
                        c = "";
                    }
                }
                else
                {
                    c = s; count = 1;
                }
            }
            Console.WriteLine(ans);

        }
        public static void DisplayList()
        {
            foreach(String s in myList)
            {
                Console.Write(s + " ");
            }
        }
    }
}