namespace QLRCP_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Net.Sockets;

    public partial class movies
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string movie_id { get; set; }

        [Required]
        [StringLength(100)]
        public string movie_name { get; set; }

        [Required]
        [StringLength(50)]
        public string genre { get; set; }

        public decimal price { get; set; }

        public int capacity { get; set; }

        [StringLength(255)]
        public string movie_image { get; set; }

        [Required]
        [StringLength(20)]
        public string status { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? update_date { get; set; }

        public DateTime? delete_date { get; set; }
        public virtual ICollection<buy_tickets> Tickets { get; set; }
    }
}
