﻿namespace VaporStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using VaporStore.Data.Models.Enums;

    public class Card
    {
        public Card()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        [Required]
        public string Cvc { get; set; }

        [Required]
        public CardType Type { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
