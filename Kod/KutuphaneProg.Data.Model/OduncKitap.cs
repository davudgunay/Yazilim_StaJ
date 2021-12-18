using System;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneProg.Data.Model
{
    public class OduncKitap:BaseEntity
    {
        [Required]
        public int KitapId { get; set; }

        [Required]
        public int UyeId { get; set; }

        [Required]
        public DateTime AlisTarihi { get; set; }

        [Required]
        public DateTime GetirecegiTarih { get; set; }

        public DateTime? GetirdigiTarih { get; set; }
    }
}
