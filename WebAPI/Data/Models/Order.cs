using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebAPI.Data.Models
{
    public class Order
    {
        //чтобы поле не видел пользователь
        [BindNever]
        public int Id { get; set; }


        [Display(Name = "Введите имя")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина имени не более 20 символов")]
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длина фамилии не менее 20 символов")]
        public string Surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(50)]
        [Required(ErrorMessage = "Длина адреса не более 20 символов")]
        public string Address { get; set; }

        [Display(Name = "Введите номер телефона")]
        [StringLength(11)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера 11 символов")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required(ErrorMessage = "Длина email не более 50 символов")]
        public string Email { get; set; }

        [BindNever]
        //чтобы поле не отображалось даже в исходном коде
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
        }
    }
}
