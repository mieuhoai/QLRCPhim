namespace QLRCP_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [Required]
        [StringLength(20)]
        public string role { get; set; }

        [Required]
        [StringLength(20)]
        public string status { get; set; }

        public DateTime? date_reg { get; set; }

        public DateTime? update_date { get; set; }

        public DateTime? delete_date { get; set; }
    }
}
