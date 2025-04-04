﻿namespace Someren.Models
{
    public class Activities
    {
        public int ActivityID { get; set; }
        public string ActivityName { get; set; }
        public TimeSpan StartTime { get; set; }  // TimeSpan voor tijd
        public DateTime StartDate { get; set; }  // DateTime voor datum

        public Activities(int activityId, string activityName, TimeSpan startTime, DateTime startDate)
        {
            ActivityID = activityId;
            ActivityName = activityName;
            StartTime = startTime;
            StartDate = startDate;
        }

        public Activities() { }
    }
}
