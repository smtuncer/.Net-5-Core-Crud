using System;
using System.ComponentModel.DataAnnotations;

namespace PersonelPlakaTakibi.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        [Required(ErrorMessage ="Ad Boş Bırakılamaz")]
        public string PersonelAd { get; set; }
        [Required(ErrorMessage = "Soyad Boş Bırakılamaz")]
        public string PersonelSoyad { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Boş Bırakılamaz")]
        public string PersonelTelNo { get; set; }
        public string PersonelAracPlakasi { get; set; }
        public string PersonelAracÖzellikleri { get; set; }
        public bool PersonelAracVarMi { get; set; }
    }
}
