using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplicationDotnetCore.Models
{
    public class PaymentDetail
    {
        //primary key 
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(200)")]
        public string cardOwner { get; set; }

        [Required]
        [Column(TypeName = "varchar(16")]
        public string cardNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string expiration { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string cvv { get; set; }


        public PaymentDetail(int id,string cardOwner,string cardNumber,string expiration,string cvv)
        {
            this.id = id;
            this.cardOwner = cardOwner;
            this.cardNumber = cardNumber;
            this.expiration = expiration;
            this.cvv = cvv;
        }

    }
}
