using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;


namespace Code
{
    class Program
    {
        public static void Main()
        {
            Question2();
            //Question1();
           //  Question3();

        }


        public static void Question1()
        {
            string a = "the day is sunny the the the sunny is is";
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            var words = a.Split(' ');

            foreach (var item in words)
            {
                {

                    if (dictionary.ContainsKey(item))
                    {
                        dictionary[item] = dictionary[item] + 1;
                    }
                    else
                    {
                        dictionary[item] = 1;
                    }

                }

            }

            foreach (var f in dictionary)
            {
                Console.WriteLine($"{f.Value}   {f.Key}");
            }

        }


        public static void Question2()
        {
            var words = new string[] { "aaa", "aa", "d", "cd", "aaa", "aaaa" };
            var s = new List<string>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!dictionary.ContainsValue(words[i].Length))
                {
                    s.Add(words[i]);
                    for (int j = 1; j < words.Length; j++)
                    {

                        if (words[i].Length == words[j].Length)
                        {
                            if (!s.Contains(words[j]))
                            {
                                s.Add(words[j]);
                            }
                        }
                    }

                    if (s.Count != 2)
                    {
                        s.Clear();
                    }
                    else
                    {
                        int y = 0;
                        foreach (var g in s[0])
                        {
                            if (s[1].Contains(g))
                            {
                                y++;
                            }
                        }

                        if (y == 0)
                        {
                            dictionary.Add(s[0], s[0].Length);
                            s.Clear();
                        }
                        else
                        {
                            s.Clear();
                        }
                    }
                }


            }
                      


            int p = 0;
            if (dictionary.Count != 0)
            {
                foreach (var g in dictionary)
                {
                    if (p < g.Value)
                    {
                        p = g.Value;
                    }
                }
            }

            Console.WriteLine(p * p);

        }



        public static void Question3()
        {
            string a = "a";
            int g = 0;
            int f = 0;
            int p = 0;
            int d = 0;
            int r = 0;
            if (a.Length >= 6 && a.Length <= 20)
            {
                r += 2;
            }
           
            var t = a.ToUpper();
            var y = a.ToLower();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == t[i])
                {
                    g++;
                }

                if (a[i] == y[i])
                {
                    f++;
                }
                int h;
                var s = int.TryParse(a[i].ToString(), out h);
                if (s)
                {
                    p++;
                }
            }
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    d++;
                }
                else
                {
                    d = 0;
                }
            }

            if (d > 0)
            {
                r += 1;
            }
            if (g > 0)
            {
                r += 1;
            }

            if (f > 0)
            {
                r += 1;
            }

            if (p > 0)
            {
                r += 1;
            }


            if (r < 6)
            {
                Console.WriteLine(6-r);
            }
            else
            {
                Console.WriteLine(0);
            }


        }
    }
}




     
