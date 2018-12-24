namespace GurupithWebApi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblreg")]
    public partial class tblreg
    {
        public int ID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(255)]
        public string MobileNo { get; set; }

        public int? RegNo { get; set; }
    }
}
