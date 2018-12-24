namespace GurupithWebApi.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class personal_information
    {
        public long? sadhakid { get; set; }

        [StringLength(100)]
        public string nameofperson { get; set; }

        [StringLength(500)]
        public string addressofcorrespondance { get; set; }

        [StringLength(100)]
        public string city { get; set; }

        [StringLength(100)]
        public string districy { get; set; }

        [StringLength(100)]
        public string state { get; set; }

        [StringLength(100)]
        public string country { get; set; }

        [StringLength(100)]
        public string mobileno { get; set; }

        [StringLength(100)]
        public string landlineno { get; set; }

        [StringLength(100)]
        public string emailid { get; set; }

        [StringLength(100)]
        public string occupation { get; set; }

        [StringLength(100)]
        public string education { get; set; }

        public long? age { get; set; }

        public DateTime? dateofbirth { get; set; }

        public DateTime? dateofdiksha { get; set; }

        [StringLength(100)]
        public string anuualmember { get; set; }

        public long? noofattempt { get; set; }

        public DateTime? lastintensivedate { get; set; }

        [StringLength(100)]
        public string intensivelocation { get; set; }

        [StringLength(100)]
        public string areofzone { get; set; }

        [StringLength(100)]
        public string zonalhead { get; set; }

        [StringLength(100)]
        public string zonalheadcontact { get; set; }

        [StringLength(100)]
        public string designation { get; set; }

        public long? totalfamilymembers { get; set; }

        public long? totalsadhak { get; set; }

        public long? totalattempts { get; set; }

        public long? mahashivratritotal { get; set; }

        public long? mahashivratriatmpt { get; set; }

        public long? gurupurnimatotal { get; set; }

        public long? gurupurnimaatmpt { get; set; }

        public long? navtratritotal { get; set; }

        public long? navtratriatmpt { get; set; }

        [StringLength(100)]
        public string status { get; set; }

        [Key]
        public int Pid { get; set; }
    }
}
