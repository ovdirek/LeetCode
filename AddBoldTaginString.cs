using System;

class MainClass
{

    public static string AddBoldTag(string str, string[] dict)
    {
        string[] strBold = new string[str.Length];
        string sonuc = "";
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < dict.Length; j++)
            {
                if (String.IsNullOrEmpty(dict[j]) || i + dict[j].Length > str.Length)
                    continue;
                string araEleman = str.Substring(i, dict[j].Length);
                if (araEleman.Contains(dict[j]))
                {
                    for (int k = 0; k < dict[j].Length; k++)
                    {
                        strBold[i + k] = "1";
                    }
                }
            }
        }

        bool bold = false;
        for (int i = 0; i < strBold.Length; i++)
        {
            //Bold işlemi başladı.
            if (strBold[i] == "1" & !bold)
            {
                bold = true;
                sonuc = sonuc + "<b>" + str[i].ToString();
            }
            //Bold işlemi devam ediyor.
            else if (strBold[i] == "1" & bold)
                sonuc = sonuc + str[i].ToString();
            //Bold işlemi başlamamış bu şekilde devam ediyor.
            else if (strBold[i] == string.Empty & !bold)
                sonuc = sonuc + str[i].ToString();
            //Bold işlemi başlamış burada bitiyor.
            else if (strBold[i] == null & bold)
            {
                bold = false;
                sonuc = sonuc + "</b>" + str[i].ToString();
            }
            else
                sonuc = sonuc + str[i];
        }
        return sonuc;
    }

    static void Main()
    {
        string str = "aaabbcc";
        string[] dict = new string[100];
        dict[0] = "aaa";
        dict[1] = "aab";
        dict[2] = "bc";
        string sonuc = AddBoldTag(str, dict);
        Console.WriteLine(sonuc);
    }

}
