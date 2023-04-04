using Entidades.Notificações;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Entidades
{
    [Table("WALLET")]
    public class Wallet : Notifica
    {
        [Column("OWNER_NAME")]
        public string OwnerName { get; set; }

        [Column("Created_At")]
        public DateTime CreatedAt { get; set; }
    }
}
