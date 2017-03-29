﻿namespace CodeFirstTemplate.DATA.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RewardStrategy
    {
        public RewardStrategy()
        {
            this.Contests = new HashSet<Contest>();
        }

        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Contest> Contests { get; set; }
    }
}