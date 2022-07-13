using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagement.Models.ViewModels
{
    public class RecordsViewModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int rec_id { get; set; }
        [Required]
        public string color { get; set; }
        [Required]
        [DisplayName("Title")]
        public string title { get; set; }
        [Required]
        [DisplayName("Summary")]
        public string description { get; set; }
        [Required]
        [DisplayName("Select Date and Time")]
        public string dateTime { get; set; }
        public int reg_id { get; set; }
        [ForeignKey("reg_id")]
        public virtual RegisterViewModel RegisterViewModel { get; set; }

       
    }
}
