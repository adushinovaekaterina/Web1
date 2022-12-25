namespace Web1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Records
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Услуга")]
        public int Id_Services { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Сотрудник")]
        public int Id_Employee { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Клиент")]
        public int Id_Clients { get; set; }

        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        public System.DateTime Date { get; set; }


        [Required(ErrorMessage = "Поле должно быть заполнено")]
        [Display(Name = "Время")]
        [DataType(DataType.Time)]
        public System.TimeSpan Time { get; set; }

        [Display(Name = "Комментарий")]
        public string Comment { get; set; }

        public virtual Clients Clients { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Services Services { get; set; }
    }
}