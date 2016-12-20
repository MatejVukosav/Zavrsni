﻿using Rationarum_v3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Rationarum_v3.ViewModels
{
    public class ExpenditureViewModel:ExpenditureReceiptViewModel
    {

        [Required(ErrorMessage = "Iznos u gotovini je obavezan!")]
        [Display(Name = "U gotovini")]
        [RegularExpression(@"[0-9]{1,8}\,[0-9]{1,2}", ErrorMessage = "Iznos mora biti sveden na dvije decimale (koristiti decimalni zarez)")]
        public string AmountCash { get; set; }


        [Required(ErrorMessage = "Iznos na žiro račun je obavezan!")]
        [Display(Name = "Na žiro-račun")]
        [RegularExpression(@"[0-9]{1,8}\,[0-9]{1,2}", ErrorMessage = "Iznos mora biti sveden na dvije decimale (koristiti decimalni zarez)")]
        public string AmountTransferAccount { get; set; }


        [Required(ErrorMessage = "Iznos u naravi obavezan!")]
        [Display(Name = "U naravi")]
        [RegularExpression(@"[0-9]{1,8}\,[0-9]{1,2}", ErrorMessage = "Iznos mora biti sveden na dvije decimale (koristiti decimalni zarez)")]
        public string AmountNonCashBenefit { get; set; }


        [Required(ErrorMessage = "Iznos u PDV je obavezan!")]
        [Display(Name = "Iznos PDV-a")]
        [RegularExpression(@"[0-9]{1,8}\,[0-9]{1,2}", ErrorMessage = "Iznos mora biti sveden na dvije decimale (koristiti decimalni zarez)")]
        public string ValueAddedTax { get; set; }


        [Required(ErrorMessage = "Iznos u članku 22 je obavezan!")]
        [Display(Name = "Izdaci iz članka 22")]
        [RegularExpression(@"[0-9]{1,8}\,[0-9]{1,2}", ErrorMessage = "Iznos mora biti sveden na dvije decimale (koristiti decimalni zarez)")]
        public string Article22 { get; set; }


        [Required]
        [Display(Name = "Ukupno")]
        [DataType(DataType.Currency)]
        public decimal Totaled { get; set; }
    }
}