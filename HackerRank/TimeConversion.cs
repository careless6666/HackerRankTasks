namespace HackerRank
{
    /// <summary>
    /// Covert time from 12 hour format to 24 format
    /// </summary>
    public class TimeConversion
    {
        public static string ConvertTime(string srcTime)
        {
            srcTime = srcTime.PadLeft(10, '0');
            if (srcTime.ToUpper().Contains("PM"))
            {
                int time = int.Parse(srcTime.Substring(0, 2));
                if (time != 12)
                    time += 12;

                srcTime = srcTime.Replace("PM", "");
                if (time == 24)
                    time = 0;

                return time.ToString().PadLeft(2, '0') + srcTime.Substring(2);
            }
            else
            {

                srcTime = srcTime.Replace("AM", "");

                int time = int.Parse(srcTime.Substring(0, 2));
                if (time == 24 || time == 12)
                    time = 0;

                return time.ToString().PadLeft(2, '0') + srcTime.Substring(2);
            }
        }
    }
}
