public class Isa
{
     public string AuthorizationInformationQualifier { get; set; }
        public string AuthorizationInformation { get; set; }
        public string SecurityInformationQualifier { get; set; }
        public string SecurityInformation { get; set; }
        public string InterchangeIdQualifier { get; set; }
        public string InterchangeSenderId { get; set; }
        public string InterchangeIdQualifierReciever { get; set; }
        public string InterchangeReceiverId { get; set; }
        public DateOnly Date  { get; set; }
        public TimeOnly Time { get; set; } 
        public string InterchangeControlStandardIdCode { get; set; }
        public string InterchangeVersion { get; set; }
        public string InterchangeControlNbr { get; set; }
        public string AcknowledgementRequested { get; set; }
        public string TestIndicator { get; set; }
        public string SubElementSeparator { get; set; }       
}