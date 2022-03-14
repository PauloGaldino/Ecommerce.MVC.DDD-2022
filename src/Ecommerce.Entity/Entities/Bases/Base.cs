using Ecommerce.Entity.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Entity.Entities.Bases
{
    public class Base : Notifier
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}
