using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConstantsLibrary.Constants;

/// <summary>
/// r/Daily Programmer Challenges
/// Multiple challenges are added weekly of varying difficulty:
/// easy, medium, hard, troll
/// </summary>
namespace Challenges
{

    /// <summary>
    /// A talking clock takes 24 hr time &
    /// translates into words!
    /// </summary>
    public static class Challenge_321_E
    {
        public static string main(DateTime userInputTime)
        {
            var hrs = userInputTime.Hour.ToString();
            var mins = userInputTime.Minute.ToString();
            return "It is " + TimeToString(hrs.ToString()) + " " + TimeToString(mins.ToString());
        }

        public static string TimeToString(string value)
        {
            var valueArray = value.ToCharArray();
            if (valueArray.Length == 1)
            {
                //pad array left (w/ ascii zero)
            }
            //if leading value is 0, can exclude all other possibilities

            if (valueArray[0] == Ascii.Zero)
            {
                if (value == "00") return TimeConstants.Twelve;
                if (value == "01") return TimeConstants.One;
                if (value == "02") return TimeConstants.Two;
                if (value == "03") return TimeConstants.Three;
                if (value == "04") return TimeConstants.Four;
                if (value == "05") return TimeConstants.Five;
                if (value == "06") return TimeConstants.Six;
                if (value == "07") return TimeConstants.Seven;
                if (value == "08") return TimeConstants.Eight;
                if (value == "09") return TimeConstants.Nine;
            }
            //if starts with "1" is either a special teen or [0]+"teen"
            if (valueArray[0] == 1)
            {
                if (value == "10") return TimeConstants.Ten;
                if (value == "11") return TimeConstants.Eleven;
                if (value == "12") return TimeConstants.Twelve;
                if (value == "13") return TimeConstants.Thirteen;
            }
            //all others are [constant]+[constant]
            if (value == "20") return TimeConstants.Twenty;
            if (value == "30") return TimeConstants.Thirty;
            if (value == "40") return TimeConstants.Forty;
            if (value == "50") return TimeConstants.Fifty;

            return TimeConstants.Error;


        }
    }


}
