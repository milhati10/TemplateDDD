using Flunt.Notifications;
using System;

namespace ProjectTemplate.Domain.Entities
{
    public abstract class Entity : Notifiable
    {
        public Guid ID { get; private set; }

        public Entity()
        {
            ID = Guid.NewGuid();
        }
    }
}
