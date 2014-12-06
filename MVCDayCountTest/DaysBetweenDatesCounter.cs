using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDayCountTest
{
    public class DaysBetweenDatesCounter
    {
        public int GetDays(string StartDate, string EndDate)
        {
            //Math forumla from "Number of Days between Two Dates" by Ask Dr Math (http://mathforum.org/library/drmath/view/66535.html)
            
            //Converting the dates to usable int's
            int[] FinalStartDate = Array.ConvertAll(StartDate.Split('/'), s => int.Parse(s));
            int[] FinalEndDate = Array.ConvertAll(EndDate.Split('/'), s => int.Parse(s));

            //If the month is 1 or 2, then you add 12 to the month and subtract 1 from the year. 
            //Do this for both the StartDate and Enddate
            if (FinalStartDate[0] == 01) { FinalStartDate[0] = 13; FinalStartDate[2]--; }
            if (FinalStartDate[0] == 02) { FinalStartDate[0] = 14; FinalStartDate[2]--; }

            if (FinalEndDate[0] == 01) { FinalEndDate[0] = 13; FinalEndDate[2]--; }
            if (FinalEndDate[0] == 02) { FinalEndDate[0] = 14; FinalEndDate[2]--; }

            //Tally up the days
            int TotalDaysCounted = (365 * FinalStartDate[2] + FinalStartDate[2] / 4 - FinalStartDate[2] / 100 + FinalStartDate[2] / 400 + FinalStartDate[1] + (153 * FinalStartDate[0] + 8) / 5) - (365 * FinalEndDate[2] + FinalEndDate[2] / 4 - FinalEndDate[2] / 100 + (FinalEndDate[2] / 400) + FinalEndDate[1] + (153 * FinalEndDate[0] + 8) / 5);

            //Be sure to only send back a positive number.
            //This way if a user puts in a later date into the
            //Start Date field the system only sends back a positive number.
            return Math.Abs(TotalDaysCounted);
        }


    }
}