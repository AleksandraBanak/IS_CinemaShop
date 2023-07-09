using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Cinema.Domain.DomainModels
{
    public class Ticket : BaseEntity
    {
       
        [Required]
        [Display(Name = "Movie Name")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Movie ticket price")]
        public int TicketPrice { get; set; }
        [Required]
        [Display(Name = "Movie date")]
        public DateTime Date { get; set; }
        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
        public virtual ICollection<TicketInOrder> Orders { get; set; }
    }
}
