using Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class User : BaseEntity, IAggregateRoot
    {
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("second_name")]
        public string SecondName { get; set; }
        public string password { get; set; }
        [Column("path_avatar")]
        public string Avatar { get; set; }
        public string Email { get; set; }
        [Column("confirm_email")]
        public bool IsConfirmEmail { get; set; }
        public string Company { get; set; }
        [Column("is_teacher")]
        public bool IsTeacher { get; set; }
        [Column("date_registration")]
        public DateTimeOffset DateRegistration { get; private set; } = DateTimeOffset.Now;
    }
}
