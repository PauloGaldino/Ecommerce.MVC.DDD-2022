using Ecommerce.Entity.Entities.Enums;
using Ecommerce.Entity.Entities.Persons.Indentity.Users;
using Ecommerce.Entity.Entities.Products;
using Ecommerce.Entity.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entity.Entities.Shpos
{
    [Table("CompraUsuario")]
    public class UserShop : Notifier
    {
        [Column("USUARIOID")]
        [Display(Name = "CÓDIGO")]
        public int Id { get; set; }

        [Column("ESTADO")]
        [Display(Name = "ESTADO_COMPRA")]
        public ShopStatus Status { get; set; }

        [Column("QUANTIDADE")]
        [Display(Name = "QUANTIDADE")]
        public int Quantity { get; set; }

        //Relacionamento entre as tabelas

        [Display(Name = "USUÁRIO")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "PRODUTO")]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }

    }
}