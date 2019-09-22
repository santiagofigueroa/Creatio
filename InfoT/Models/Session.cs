namespace InfoT.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Session
    {
        public int SessionID { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string ExamSite { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
    }
}
