namespace Task2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Reservation
    {
        public int Id { get; set; }

        [Required]
        public string ActivitiyName { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public int ActivityId { get; set; }

        public virtual Activity Activity { get; set; }
    }
}
