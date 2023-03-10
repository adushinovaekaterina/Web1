//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Xunit;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            this.Records = new HashSet<Records>();
            this.Works = new HashSet<Works>();
        }

        public int Id { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Surname { get; set; }

        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Name { get; set; }

        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Middle { get; set; }

        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [DataType(DataType.PhoneNumber)]
        [UIHint("String")]
        [RegularExpression(@"^\+?[78][-\(]?\d{3}\)?-?\d{3}-?\d{2}-?\d{2}$", ErrorMessage = "Некорректный номер телефона")]
        public decimal Phone { get; set; }

        [Display(Name = "День рождение")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "01.01.1940", "01.01.2008",
            ErrorMessage = "Значение для {0} должно быть между {1} и {2}")]
        public Nullable<System.DateTime> Birhdate { get; set; }

        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        public string Post { get; set; }

        [Display(Name = "Комментарий")]
        [DataType(DataType.MultilineText)]
        public string Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Records> Records { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Works> Works { get; set; }

        public string FIO
        {
            get
            {
                return string.Format("{0} {1} {2} {3}", Surname, Name, Middle, Post);
            }
            set { }
        }
    }
}