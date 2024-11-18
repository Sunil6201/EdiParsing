public class Isa
{
     public string Authorization_Information_Qualifier { get; set; }
        public string Authorization_Information { get; set; }
        public string Security_Information_Qualifier { get; set; }
        public string Security_Information { get; set; }
        public string Interchange_Id_Qualifier { get; set; }
        public string Interchange_Sender_Id { get; set; }
        public string Interchange_Id_Qualifier_reciever { get; set; }
        public string Interchange_Receiver_Id { get; set; }
        public DateOnly Date  { get; set; }
        public TimeOnly Time { get; set; } 
        public string Interchange_Control_Standard_Id_Code { get; set; }
        public string Interchange_Version { get; set; }
        public string Interchange_Control_Nbr { get; set; }
        public string Acknowledgement_Requested { get; set; }
        public string Test_Indicator { get; set; }
        public string Sub_element_Separator { get; set; }       
}