namespace CodeFirstTemplate.DATA.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ParticipationStrategy
    {
        public ParticipationStrategy()
        {
            this.Contests = new HashSet<Contest>();
        }

        [Key]
        public int ID { get; set; }

        public string name { get; set; }

        public virtual ICollection<Contest> Contests { get; set; }
    }
}
