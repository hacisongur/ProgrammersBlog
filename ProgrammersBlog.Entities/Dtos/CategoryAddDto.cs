using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Kategori Adı boş geçilemez.")]
        [MaxLength(70,ErrorMessage ="{0}{1} karekterden büyük olamaz.")]
        [MinLength(3, ErrorMessage = "{0}{1} karekterden az olamaz.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0}{1} karekterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0}{1} karekterden az olmamalıdır.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0}{1} karekterden büyük olmamalıdır.")]
        [MinLength(3, ErrorMessage = "{0}{1} karekterden az olmamalıdırz.")]
        public string Note { get; set; }
        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilemez.")]
        public bool IsActive { get; set; }
      
    }
}
