using System;
class Task1
{
    private int symb;
    public Task1(int s)
    {
        AZ = (char)s;
    }
    public Task1(char s)
    {
        AZ = s;
    }
    public override string ToString()
    {
        string txt = "";
        return txt + AZ;
    }
    public char AZ
    {
        get
        {
            return (char)symb;
        }
        set
        {
            symb = (value <= 90 ? value : value - 32);
        }   
    }
}
class Task2
{
    private int[] nums;
    private int index = 0;
    public Task2(int n)
    {
        nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
            nums[i] = i + 1;
    }
    public int Cycle
    {
        get
        {
            return nums[index++ % nums.Length];
        }
        set
        {
            nums[index % nums.Length] = value;
        }
    }
    public override string ToString()
    {
        string txt = "";
        return txt + Cycle + "[" + ((index - 1) % nums.Length) + "]";
    }
}
class Task3
{
    public int[] nums;
    public Task3(int n)
    {
        nums = new int[n];
        for (int i = 0; i < n; i++)
            nums[i] = i + 1;
    }
    public int sum
    {
        get
        {
            int s = 0;
            foreach (int i in nums)
                s += i;
            return s;
        }
    }
    public override string ToString()
    {
        string txt = "";
        foreach (int s in nums)
            txt += s + " ";
        return txt;
    }
    public void Print()
    {
        foreach (int s in nums)
            Console.Write(s + " ");
        Console.WriteLine();
    }
}
class Task4
{
    private uint num;
    private string str;
    public Task4(int n)
    {
        num = (uint)Math.Abs(n);
        str = Convert.ToString(num, 8);
    }
    public string DecToOct(int n)
    {
        string result = "";

        return result;
    }
    public int set
    {
        set
        {
            num = (uint)Math.Abs(value); ;
            str = Convert.ToString(num, 8);
        }
    }
    public string get
    {
        get
        {
            return str;
        }
    }
}
class Task5
{
    public static int nums = 1;
    public static int get
    {
        get
        {
            return nums;
        }
    }
    public static void next()
    {
            nums += 2; 
    }
    public static int set
    {
        set
        {
            nums = 1;
            if (value != 1)
            {
                for (int i = 1; i <= value; i++)
                    nums += 2;
            }
        }
    }
}
class Task6
{
    private int[] nums;
    public Task6(int n)
    {
        nums = new int[n];
        for (int i = 0; i < n; i++)
            nums[i] = i + 1;
    }
    public int this[int i]
    {
        get
        {
            return nums[i];
        }
        set
        {
            nums[i] = value;
        }
    }
}
class Task7
{
    public string this[int n]
    {
        get
        {
            //string str = Convert.ToString(n, 2);
            string str = "";
            while (n != 0)
            {
                string temp = "";
                temp += n % 2;
                str = str.Insert(0, temp);
                n /= 2;
            }
            return str;
        }
    }
}
class Task8
{
    public uint num;
    public Task8(int n)
    {
        num = (uint)Math.Abs(n);
    }
    public int this[int n]
    {
        set
        {
            string result = "", temp = "";
            result += num;
            temp += value % 10;
            result = result.Remove(n, 1);
            result = result.Insert(n, temp);
            num = UInt32.Parse(result);
        }
    }
}
class Task9
{
    public int[,] nums;
    public Task9(int a, int b)
    {
        nums = new int[a, b];
        Random rnd = new Random();
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = rnd.Next(1, 11);
            }
        }
    }
    public void show()
    {
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write(nums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public int this[int a, int b]
    {
        get
        {
            return nums[a, b];
        }
        set
        {
            nums[a, b] = value;
        }
    }
    public int this[int a]
    {
        get
        {
            int max = nums[a, 0];
            for (int i = a; i < nums.GetLength(0); i++)
            {
                for (int j = 1; j < nums.GetLength(1); j++)
                {
                    if (nums[a, j] > max)
                        max = nums[a, j];
                }
                break;
            }
            return max;
        }
        set
        {
            int max = nums[a, 0];
            int[] temp = new int[2];
            for (int i = a; i < nums.GetLength(0); i++)
            {
                for (int j = 1; j < nums.GetLength(1); j++)
                {
                    if (nums[a, j] > max)
                    {
                        max = nums[a, j];
                        temp[0] = a;
                        temp[1] = j;
                    }
                }
                nums[temp[0], temp[1]] = value;
                break;
            }
        }
    }
}
class Task10
{
    public string[] strarray;
    public Task10(params string[] str)
    {
        strarray = new string[str.Length];
        for (int i = 0; i < str.Length; i++)
            strarray[i] = str[i];
    }
    public string this[int a]
    {
        get
        {
            return strarray[a];
        }
        set
        {
            strarray[a] = value;
        }
    }
    public string this[int a, int b]
    {
        get
        {
            string str = "";
            str += strarray[a][b];
            return str;
        }
        set
        {
            string str = strarray[a], temp = "";
            temp += value;
            str = str.Remove(b, 1);
            str = str.Insert(b, temp);
            strarray[a] = str;
        }
    }
    public void Show()
    {
        foreach (string s in strarray)
            Console.WriteLine(s);
    }
}
class Programm
{
    static void Main()
    {
        {
            Task1 task1 = new Task1('a');
            Console.WriteLine(task1);
            task1.AZ = 'b';
            Console.WriteLine(task1);
            task1.AZ = (char)99;
            Console.WriteLine(task1);
            task1 = new Task1(68);
            Console.WriteLine(task1);
            Console.WriteLine("----------------");
        }
        {
            Task2 obj = new Task2(6);
            for (int i = 0; i < 12; i++)
                Console.WriteLine(obj);
            obj.Cycle = 66;
            Console.WriteLine(obj);
            obj.Cycle = 3;
            Console.WriteLine(obj);
            Console.WriteLine("----------------");
        }
        {
            Task3 obj = new Task3(3);
            Console.WriteLine(obj);
            Console.WriteLine(obj.sum);
            Console.WriteLine("----------------");
        }
        {
            Task4 obj = new Task4(-10);
            Console.WriteLine(obj.get);
            obj.set = -17;
            Console.WriteLine(obj.get);
            Console.WriteLine("----------------");
        }
        {
            Console.WriteLine(Task5.get);
            Task5.next();
            Console.WriteLine(Task5.get);
            Task5.set = 5;
            Console.WriteLine(Task5.get);
            Task5.set = 1;
            Console.WriteLine(Task5.get);
            Console.WriteLine("----------------");
        }
        {
            Task6 obj = new Task6(9);
            Console.WriteLine(obj[0]);
            obj[1] = 9;
            Console.WriteLine(obj[1]);
            Console.WriteLine("----------------");
        }
        {
            Task7 obj = new Task7();
            Console.WriteLine(obj[4]);
            Console.WriteLine(obj[10]);
            Console.WriteLine(obj[15]);
            Console.WriteLine("----------------");
        }
        {
            Task8 obj = new Task8(1111);
            Console.WriteLine(obj.num);
            obj[0] = 9;
            Console.WriteLine(obj.num);
            obj[1] = 8;
            Console.WriteLine(obj.num);
            obj[2] = 7;
            Console.WriteLine(obj.num);
            obj[3] = 6;
            Console.WriteLine(obj.num);
            string str = "";
            str += obj.num;
            for (int i = 0; i < str.Length; i++)
                obj[i] = i + 1;
            Console.WriteLine(obj.num);
            Console.WriteLine("----------------");
        }
        {
            Task9 obj = new Task9(4, 2);
            obj.show();
            Console.WriteLine(obj[0, 0]);
            obj[1, 1] = 7;
            obj.show();
            Console.WriteLine(obj[0]);
            obj[0] = 11;
            obj.show();
            Console.WriteLine("----------------");
        }
        {
            Task10 obj = new Task10("abc", "limonad", "pastila");
            obj.Show();
            Console.WriteLine("Console.WriteLine(obj[1]); " + obj[1]);
            obj[0] = "izum";
            obj.Show();
            Console.WriteLine(obj[1, 0] + obj[0, 0]+ obj[2, 2] + obj[1, 5]);
            obj[2, 2] = "z";
            Console.WriteLine(obj[1, 0] + obj[0, 0] + obj[2, 2] + obj[1, 5]);
        }
    }
}