namespace Maryam_project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class M_Admin
    {
        [Key]
        public int Admin_Id { get; set; }

        [StringLength(50)]
        public string Admin_Name { get; set; }

        [StringLength(50)]
        public string Admin_Email { get; set; }

        [StringLength(50)]
        public string Admin_Password { get; set; }

        [StringLength(50)]
        public string Admin_Contact { get; set; }

        [StringLength(50)]
        public string Admin_Address { get; set; }
    }
}
