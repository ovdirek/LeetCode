public class Solution
        {
            public int[] ConstructRectangle(int area)
            {
                int kareKok = Convert.ToInt32(Math.Sqrt(area));
                while (area % kareKok != 0)
                {
                    kareKok++;
                }
                int[] sonuc = new int[2];
                if (kareKok < area / kareKok)
                {
                    sonuc[0] = area / kareKok;
                    sonuc[1] = kareKok;
                }
                else
                {
                    sonuc[0] = kareKok;
                    sonuc[1] = area / kareKok;
                }
                return sonuc;
            }
        }