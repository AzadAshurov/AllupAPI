﻿using System.ComponentModel.DataAnnotations;

namespace AllupAPI.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DataType CreatedAt { get; set; }
        public DataType UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        protected BaseEntity()
        {
            CreatedBy = "admin";
        }


    }
}
