public class Solution
        {
            public char FindTheDifference(string s, string t)
            {
                bool ok = false;
                for (int i = 0; i < t.Length; i++)
                {
                    ok = false;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (t[i] == s[j])
                        {
                            if (j + 1 == s.Length) s = s.Substring(0, j);
                            else s = s.Substring(0, j) + s.Substring(j + 1, s.Length - j - 1);
                            ok = true;
                            break;
                        }
                    }
                    if (!ok) return t[i];
                }
                return 'A';
            }
        }