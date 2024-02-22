using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FPTJOB.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Introduction { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }


        [ForeignKey("JobId")]
        [DisplayName("Job")]

        public int JobId { get; set; }

        public virtual ICollection<Job>? Jobs { get; set; }
    }
}
