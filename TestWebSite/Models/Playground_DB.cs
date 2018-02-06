using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestWebSite.Models
{
    public class Playground_DB
    {
        [Table("Subscriber")]
        public class Subscriber
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Column("SubscriberId")]
            public int SubscriberId { get; set; }
            [Column("AccountId")]
            public int AccountId { get; set; }
            [Column("FullName")]
            public string FullName { get; set; }
            [Column("Email")]
            public string Email { get; set; }
            [Column("Sms")]
            public string Sms { get; set; }
            [Column("Fax")]
            public string Fax { get; set; }

            [ForeignKey("AccountId"), Required]
            public virtual Account Account { get; set; } //db.Subscriber.Account.Name
        }

        [Table("Account")]
        public class Account
        {
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Column("AccountId")]
            public int AccountId { get; set; }
            [Column("Name")]
            public string Name { get; set; }
        }
    }
}