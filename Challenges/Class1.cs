using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConstantsLibrary.Constants;
using Toolbox;

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
            if (value.Length > 2) return TimeConstants.Error;

            //if single digit time, must start with '0'
            if (value.Length == 1)
            {
                string zero = "0";
                value = value.Insert(0, zero);
            }
            var valueOnes = value[1].ToString();
            var valueTens = value[0].ToString();

            //if leading value is 0, can exclude all other possibilities

            if (valueTens == "0")
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
            if (valueTens == "1")
            {
                if (value == "10") return TimeConstants.Ten;
                if (value == "11") return TimeConstants.Eleven;
                if (value == "12") return TimeConstants.Twelve;
                if (value == "13") return TimeConstants.Thirteen;

                //if begins with one and has not found case yet,
                //number is a teen with standard format
            }

                StringBuilder returnValue = new StringBuilder { };

                //all others are [constant]+[constant]
                if (valueTens == "2") returnValue.Insert(0,TimeConstants.Twenty    );
                if (valueTens == "3") returnValue.Insert(0,TimeConstants.Thirty    );
                if (valueTens == "4") returnValue.Insert(0,TimeConstants.Forty     );
                if (valueTens == "5") returnValue.Insert(0,TimeConstants.Fifty     );
                // insert space between words if not a teen
                if (valueTens != "1")
                    returnValue.Insert(returnValue.Length, " ");

                if (valueOnes == "0") returnValue.Insert(returnValue.Length, TimeConstants.Twelve) ;
                if (valueOnes == "1") returnValue.Insert(returnValue.Length, TimeConstants.One   ) ;
                if (valueOnes == "2") returnValue.Insert(returnValue.Length, TimeConstants.Two   ) ;
                if (valueOnes == "3") returnValue.Insert(returnValue.Length, TimeConstants.Three ) ;
                if (valueOnes == "4") returnValue.Insert(returnValue.Length, TimeConstants.Four  ) ;
                if (valueOnes == "5") returnValue.Insert(returnValue.Length, TimeConstants.Five  ) ;
                if (valueOnes == "6") returnValue.Insert(returnValue.Length, TimeConstants.Six   ) ;
                if (valueOnes == "7") returnValue.Insert(returnValue.Length, TimeConstants.Seven ) ;
                if (valueOnes == "8") returnValue.Insert(returnValue.Length, TimeConstants.Eight ) ;
                if (valueOnes == "9") returnValue.Insert(returnValue.Length, TimeConstants.Nine  ) ;

                if (valueTens == "1") returnValue.Insert(returnValue.Length, "teen");

                return returnValue.ToString();

        }
    }


}
