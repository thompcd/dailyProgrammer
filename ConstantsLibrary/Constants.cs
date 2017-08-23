using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantsLibrary
{
    static public class Constants
    {
        static public class TimeConstants
        {
            public const string Zero =    "Twelve";
            public const string One =     "One";
            public const string Two =     "Two";
            public const string Three =   "Three";
            public const string Four =    "Four";
            public const string Five =    "Five";
            public const string Six =     "Six";
            public const string Seven =   "Seven";
            public const string Eight =   "Eight";
            public const string Nine =    "Nine";
            public const string Ten =     "Ten";
            public const string Eleven =  "Eleven";
            public const string Twelve =  "Twelve";
            public const string Thirteen ="Thirteen";
            public const string Twenty =  "Twenty";
            public const string Thirty =  "Thirty";
            public const string Forty =   "Forty";
            public const string Fifty =   "Fifty";
            public const string O =       "O'";
            public const string Error =   "ERROR";

        }
        public enum TimeUnits
        {
            Minute,
            Hour,
            Second
        }
        /// <summary>
        /// Ascii character constants.
        /// Can be cast as necessary for ease of use
        /// </summary>
        static public class Ascii
        {
            public const char Null = (char)0;
            public const char StartOfHeading = (char)1;
            public const char StartOfText = (char)2;
            public const char EndOfText = (char)3;
            public const char EndOfTransmission = (char)4;
            public const char Enquiry = (char)5;
            public const char Acknowledge = (char)6;
            public const char Bell = (char)7;
            public const char Backspace = (char)8;
            public const char HorizontalTab = (char)9;
            public const char LineFeed = (char)10;
            public const char VerticalTab = (char)11;
            public const char FormFeed = (char)12;
            public const char CarriageReturn = (char)13;
            public const char ShiftOut = (char)14;
            public const char ShiftIn = (char)15;
            public const char DataLinkEscape = (char)16;
            public const char DeviceControl1 = (char)17;
            public const char DeviceControl2 = (char)18;
            public const char DeviceControl3 = (char)19;
            public const char DeviceControl4 = (char)20;
            public const char NagativeAcknowledge = (char)21;
            public const char SynchronousIdle = (char)22;
            public const char EndOfTrasmissionBlock = (char)23;
            public const char Cancel = (char)24;
            public const char EndOfMedium = (char)25;
            public const char Substitute = (char)26;
            public const char Escape = (char)27;
            public const char FileSeperator = (char)28;
            public const char GroupSeperator = (char)29;
            public const char RecordSeperator = (char)30;
            public const char UnitSeperator = (char)31;

            public const char Zero  =   (char)48        ;//0  
            public const char One   =   (char)49        ;//1  
            public const char Two   =   (char)50        ;//2  
            public const char Three =   (char)51        ;//3  
            public const char Four  =   (char)52        ;//4  
            public const char Five  =   (char)53        ;//5  
            public const char Six   =   (char)54        ;//6  
            public const char Seven =   (char)55        ;//7  
            public const char Eight =   (char)56        ;//8  
            public const char Nine  =   (char)57        ;//9  
            public const char Colon =   (char)58        ;//:  
        }
    }
}
