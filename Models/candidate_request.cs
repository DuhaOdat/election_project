//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrangeProjectMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class candidate_request
    {
        public int id { get; set; }
        public int election_list_request_id { get; set; }
        public string type_of_chair { get; set; }
        public int user_id { get; set; }
        public bool is_representative { get; set; }
        public string img_url { get; set; }
    
        public virtual election_list_request election_list_request { get; set; }
        public virtual voter_user voter_user { get; set; }
    }
}
