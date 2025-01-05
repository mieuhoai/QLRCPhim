namespace QLRCP_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class buy_tickets
    {
        

        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string movie_id { get; set; }

        public int seat_number { get; set; }

        public DateTime? purchase_date { get; set; }
        public virtual movies Movie { get; set; }
    }
}
