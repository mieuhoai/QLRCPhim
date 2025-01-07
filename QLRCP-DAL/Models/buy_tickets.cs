namespace QLRCP_DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class buy_tickets
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public buy_tickets()
        {
            user_film = new HashSet<user_film>();
        }

        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [StringLength(20)]
        public string movie_id { get; set; }

        public int seat_number { get; set; }

        public DateTime? purchase_date { get; set; }

        public int? totalPrice { get; set; }

        public virtual user user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user_film> user_film { get; set; }
    }
}
