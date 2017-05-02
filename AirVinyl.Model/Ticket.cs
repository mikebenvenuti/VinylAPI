using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirVinyl.Model
{
    public class TICKET
    {
        [Key]
        [Column("Ticket Key")]
        public int? Ticket_Key { get; set; }
                
        [Column("Prospect Key")]      
        public int? Prospect_Key { get; set; }

        [Column("Report Date")]             
        public DateTime? Report_Date { get; set; }

        [Column("Report Time")]             
        public DateTime? Report_Time { get; set; }

        [StringLength(6)]
        [Column("Received By")]
        public string Received_By { get; set; }

        [Column("Entered By")]
        [StringLength(10)]
        public string Entered_By { get; set; }
            
        [StringLength(6)]
        [Column("Assigned To")]     
        public string Assigned_To { get; set; }

        [StringLength(1)]
        [Column("Priority")]    
        public string Priority { get; set; }

        [Column("Start Date")]        
        public DateTime? Start_Date { get; set; }

        [Column("Start Time")]       
        public DateTime? Start_Time { get; set; }

        [Column("End Date")]         
        public DateTime? End_Date { get; set; }

        [StringLength(250)]
        [Column("Short Desc")]       
        public string Short_Desc { get; set; }

        [StringLength(4000)]
        [Column("Solution")]        
        public string Solution { get; set; }

        [StringLength(4)]
        [Column("Status")]     
        public string Status { get; set; }

        [StringLength(6)]
        [Column("Ticket Type")]        
        public string Ticket_Type { get; set; }

        [StringLength(10)]
        [Column("QB Link Key")]         
        public string QB_Link_Key { get; set; }

        [StringLength(1)]
        [Column("Hidden")]         
        public string Hidden { get; set; }

        [Column("Delivery Date")]        
        public DateTime? Delivery_Date { get; set; }

        [Column("Estimated Days")]        
        public float? Estimated_Days { get; set; }

        [Column("Release Version")]        
        [StringLength(10)]
        public string Release_Version { get; set; }

        [StringLength(1)]
        [Column("Added To Development")]   
        public string Added_To_Development { get; set; }

        [StringLength(1)]
        [Column("Added To Customer")]   
        public string Added_To_Customer { get; set; }

        [StringLength(4000)]
        [Column("Release Description")]    
        public string Release_Description { get; set; }

        [StringLength(4000)]
        [Column("Configuration Required")]  
        public string Configuration_Required { get; set; }

        [StringLength(4000)]
        [Column("Database SQL Required")]  
        public string Database_SQL_Required { get; set; }

        [StringLength(20)]
        [Column("Customer Reference")]  
        public string Customer_Reference { get; set; }

        [StringLength(8)]
        [Column("Ticket Group")]       
        public string Ticket_Group { get; set; }

        [Column("Priority Order")]         
        public int? Priority_Order { get; set; }

        [Column("Scheduled Start")]      
        public DateTime? Scheduled_Start { get; set; }

        [Column("Scheduled Finish")]       
        public DateTime? Scheduled_Finish { get; set; }
       
        [Column("Percent Complete")]       
        public int? Percent_Complete { get; set; }

        [StringLength(1)]
        [Column("DEV Merge Verified")]    
        public string DEV_Merge_Verified { get; set; }

        [Column("Release Year")]          
        public int? Release_Year { get; set; }

        [Column("Release Number")]        
        public int? Release_Number { get; set; }

        [StringLength(6)]
        [Column("Ticket Manager")]        
        public string Ticket_manager { get; set; }

        [StringLength(20)]
        [Column("PO Number")]             
        public string PO_Number { get; set; }

        [StringLength(1)]
        [Column("PO Status")]             
        public string PO_Status { get; set; }

        [Column("PO Amount")]             
        public float? PO_Amount { get; set; }

        [Column("Build Number")]          
        public int? Build_Number { get; set; }

        [StringLength(10)]
        [Column("RELEASE KEY")]           
        public string Release_Key { get; set; }

        [StringLength(40)]
        [Column("Version")]               
        public string Version { get; set; }

        [StringLength(4000)]
        [Column("Long Desc")]              
        public string Long_Desc { get; set; }
        
        [StringLength(1)]
        [Column("Delivered To Customer")]  
        public string Delivered_To_Customer { get; set; }

        [Column("Project Key")]     
        public int? Project_Key { get; set; }

        [Column("Milestone Key")]   
        public int? Milestone_key { get; set; }

        [StringLength(1)]
        [Column("Critical")]        
        public string Critical { get; set; }

    }
}
