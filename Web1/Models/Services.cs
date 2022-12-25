namespace Web1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Xunit;

    public partial class Services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Services()
        {
            this.Record = new HashSet<Record>();
            this.Work = new HashSet<Works>();
        }

        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Name { get; set; }

        [Display(Name = "Стоимость")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [RegularExpression(@"[z0-9]{0,10}", ErrorMessage = "Некорректная стоимость")]
        public int Price { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Комментарий")]
        public string Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Record> Record { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Works> Work { get; set; }
        public string Concat
        {
            get
            {
                return string.Format("{0} {1} ", Name, Price);
            }
            set { }
        }
    }
}