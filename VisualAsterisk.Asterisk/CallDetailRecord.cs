using System;
using System.Collections.Generic;
using System.Text;
using Asterisk.NET.Manager.Event;

namespace VisualAsterisk.Asterisk
{
    public class CallDetailRecord
    {
        private static IDictionary<string, Disposition> DISPOSITION_MAP;
        private static IDictionary<string, AmaFlags> AMA_FLAGS_MAP;

        private AsteriskChannel channel;
        private AsteriskChannel destinationChannel;
        private string accountCode;
        private string destinationContext;
        private string destinationExtension;
        private string lastApplication;
        private string lastAppData;
        private DateTime startDate;
        private DateTime answerDate;
        private DateTime endDate;
        private long duration;
        private long billableSeconds;
        private Disposition disposition;
        private AmaFlags amaFlags;
        private string userField;

        public AsteriskChannel Channel
        {
            get { return channel; }
        }

        public AsteriskChannel DestinationChannel
        {
            get { return destinationChannel; }
        }

        public string AccountCode
        {
            get { return accountCode; }
        }

        public string DestinationContext
        {
            get { return destinationContext; }
        }

        public string DestinationExtension
        {
            get { return destinationExtension; }

        }

        public string LastApplication
        {
            get { return lastApplication; }

        }

        public string LastAppData
        {
            get { return lastAppData; }

        }

        public DateTime StartDate
        {
            get { return startDate; }

        }

        public DateTime AnswerDate
        {
            get { return answerDate; }
        }

        public DateTime EndDate
        {
            get { return endDate; }

        }

        public long Duration
        {
            get { return duration; }

        }

        public long BillableSeconds
        {
            get { return billableSeconds; }

        }

        public Disposition Disposition
        {
            get { return disposition; }

        }

        public AmaFlags AmaFlags
        {
            get { return amaFlags; }

        }

        public string UserField
        {
            get { return userField; }
            set { userField = value; }
        }

        static CallDetailRecord()
        {
            DISPOSITION_MAP = new Dictionary<string, Disposition>();
            //DISPOSITION_MAP.Add(CdrEvent.DISPOSITION_ANSWERED, Disposition.ANSWERED);
            //DISPOSITION_MAP.Add(CdrEvent.DISPOSITION_BUSY, Disposition.BUSY);
            //DISPOSITION_MAP.Add(CdrEvent.DISPOSITION_FAILED, Disposition.FAILED);
            //DISPOSITION_MAP.Add(CdrEvent.DISPOSITION_NO_ANSWER, Disposition.NO_ANSWER);
            //DISPOSITION_MAP.Add(CdrEvent.DISPOSITION_UNKNOWN, Disposition.UNKNOWN);

            AMA_FLAGS_MAP = new Dictionary<string, AmaFlags>();
            //AMA_FLAGS_MAP.Add(CdrEvent.AMA_FLAG_BILLING, AmaFlags.BILLING);
            //AMA_FLAGS_MAP.Add(CdrEvent.AMA_FLAG_DOCUMENTATION, AmaFlags.DOCUMENTATION);
            //AMA_FLAGS_MAP.Add(CdrEvent.AMA_FLAG_OMIT, AmaFlags.OMIT);
            //AMA_FLAGS_MAP.Add(CdrEvent.AMA_FLAG_UNKNOWN, AmaFlags.UNKNOWN);
        }

        public CallDetailRecord(AsteriskChannel channel, AsteriskChannel destinationChannel, CdrEvent cdrEvent)
        {
            //TODO add timezone to AsteriskServer
            TimeZone tz = TimeZone.CurrentTimeZone;
            this.channel = channel;
            this.destinationChannel = destinationChannel;

            accountCode = cdrEvent.AccountCode;
            destinationContext = cdrEvent.DestinationContext;
            destinationExtension = cdrEvent.Destination;
            lastApplication = cdrEvent.LastApplication;
            lastAppData = cdrEvent.LastData;
            //startDate = cdrEvent.StartTime;
            //answerDate = cdrEvent.AnswerTime;
            //endDate = cdrEvent.EndTime;
            duration = cdrEvent.Duration;
            billableSeconds = cdrEvent.BillableSeconds;
            if (cdrEvent.AmaFlags != null)
            {
                amaFlags = AMA_FLAGS_MAP[cdrEvent.AmaFlags];
            }
            else
            {
                //amaFlags = null;
            }
            if (cdrEvent.Disposition != null)
            {
                disposition = DISPOSITION_MAP[cdrEvent.Disposition];
            }
            else
            {
                //disposition = null;
            }
            userField = cdrEvent.UserField;
        }

    }
}
