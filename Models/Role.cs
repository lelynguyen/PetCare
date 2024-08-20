﻿namespace PetCareMVC.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        // Navigation properties
        public virtual ICollection<Employee> Employees { get; set; }
    }
}