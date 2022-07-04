Console.WriteLine("Type in the location");
var path = Console.ReadLine();
string[] readText = File.ReadAllLines(path);
string p = "+";
string n = "-";
string sl = "/";
string t = "*";
foreach (string s in readText)
{
    {
        if (s.Contains(p))
        {
            string split = s.Split('+')[0];
            string split1 = s.Split('+')[1];
            var spl0 = Convert.ToDouble(split);
            var spl1 = Convert.ToDouble(split1);
            Console.WriteLine(spl0 + spl1);
        }
        if (s.Contains(n))
        {
            string split2 = s.Split('-')[0];
            string split3 = s.Split('-')[1];
            var spl2 = Convert.ToDouble(split2);
            var spl3 = Convert.ToDouble(split3);
            Console.WriteLine(spl2 - spl3);
        }
        if (s.Contains(sl))
        {
            string split4 = s.Split('/')[0];
            string split5 = s.Split('/')[1];
            var spl4 = Convert.ToDouble(split4);
            var spl5 = Convert.ToDouble(split5);
            Console.WriteLine(spl4 / spl5);
        }
        if (s.Contains(t))
        {
            string split6 = s.Split('*')[0];
            string split7 = s.Split('*')[1];
            var spl6 = Convert.ToDouble(split6);
            var spl7 = Convert.ToDouble(split7);
            Console.WriteLine(spl6 * spl7);
        }
        }
}
