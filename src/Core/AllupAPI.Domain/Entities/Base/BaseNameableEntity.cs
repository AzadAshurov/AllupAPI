﻿namespace AllupAPI.Domain.Entities.Base
{
    public abstract class BaseNameableEntity : BaseEntity
    {
        public string Name { get; set; }
    }
}
