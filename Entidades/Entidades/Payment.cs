using Entidades.Notificações;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    [Table("PAYMENT")]
    public class Payment : Notifica
    {        
        [Column("AMOUNT")]
        public int Amount { get; set; }

        [ForeignKey("WALLET")]
        [Column(Order = 1)]
        public string OwnerId { get; set; }
        public virtual Wallet Wallet { get; set; }

        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }
    }
}
