using System;

namespace RedmineTimeTracker
{
    public class Session
    {
        /// <summary>
        /// Issue identifier
        /// </summary>
        /// <remarks>
        /// 0 - no identifier,
        /// less than 0 - custom identifier,
        /// greater than 0 - redmine issue identifier</remarks>
        public int IssueId { get; set; }

        /// <summary>
        /// Session start timestamp
        /// </summary>
        public DateTime Begin { get; set; }

        /// <summary>
        /// Session end timestamp
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Session duration
        /// </summary>
        public TimeSpan Duration => End < Begin ? DateTime.Now - Begin : End - Begin;

        public Session(DateTime begin, DateTime end, int issueId = 0)
        {
            Begin = begin;
            End = end;
            IssueId = issueId;
        }

        public Session(long begin, long end, int issueId = 0)
        {
            Begin = new DateTime(begin);
            End = new DateTime(end);
            IssueId = issueId;
        }

        /// <summary>
        /// Start new session
        /// </summary>
        /// <returns></returns>
        internal static Session Start()
            => new Session(DateTime.Now, DateTime.MinValue);

        /// <summary>
        /// Stop session
        /// </summary>
        internal void Stop()
            => End = DateTime.Now;
    }
}
