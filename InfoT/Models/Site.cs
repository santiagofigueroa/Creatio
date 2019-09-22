namespace InfoT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Site
    {
        public int SiteID { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
		public string SiteCode { get; set; }
		[Required(ErrorMessage = "This Field is Required")]
        public string SiteName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        
  
    }
}
