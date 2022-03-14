using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entity.Notifications
{
    public class Notifier
    {
        public Notifier()
        {
            Notification = new List<Notifier>();
        }

        [NotMapped]
        public string PropertyName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifier> Notification;

        public bool ValidateStringProperty(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notification.Add(new Notifier
                {
                    Message = "Campo Obrigatório",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;
        }

        public bool ValidateIntProperty(int value, string propertyName)
        {

            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notification.Add(new Notifier
                {
                    Message = "Valor deve ser maior que 0",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;

        }

        public bool ValidateDecimalProperty(decimal value, string propertyName)
        {

            if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notification.Add(new Notifier
                {
                    Message = "Valor deve ser maior que 0",
                    PropertyName = propertyName
                });

                return false;
            }

            return true;

        }


    }
}