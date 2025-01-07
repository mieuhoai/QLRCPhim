namespace QLRCP_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_film
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int ticket_id { get; set; }

        public int seat_number { get; set; }

        public DateTime? purchase_date { get; set; }

        [Required]
        [StringLength(20)]
        public string status { get; set; }

        public virtual buy_tickets buy_tickets { get; set; }

        public virtual user user { get; set; }
    }
}
