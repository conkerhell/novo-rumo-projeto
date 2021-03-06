﻿using NovoRumoProjeto.Utilities.Validation;
using Resources;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace NovoRumoProjeto.Models
{
    public class DonationViewModel
    {
        [Required(ErrorMessageResourceType = typeof(LocalizedMessages),
            ErrorMessageResourceName = "PropertyValueRequired")]
        public bool Terms { get; set; }

        [Required]
        public int DonationOption { get; set; }

        public string Value { get; set; }

        [StringLength(5)]
        [RequiredIf("Value", true)]
        public string SpecificValue { get; set; }

        [Display(Name = "OrdemID")]
        public int OrderId { get; set; }

        [Display(Name = "Tipo")]
        public int TypeId { get; set; }

        [Display(Name = "UsuarioID")]
        public int UserId { get; set; }

        [Display(Name = "Codigo de Notificação")]
        public string NotificationCode { get; set; }

        [Display(Name = "PaypalGUID")]
        public string PaypalGuid { get; set; }

        [Display(Name = "Total")]
        public decimal Total { get; set; }

        [Display(Name = "Data de gravação")]
        public DateTime? RecordDate { get; set; }

        public decimal GetTotal()
        {
            return (Value.Equals(true.ToString())) ? Convert.ToDecimal(SpecificValue) : Convert.ToDecimal(Value);
        }
    }
}