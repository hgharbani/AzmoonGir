using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzmoonGir.Model
{
    [Table("Questions")]
    public class Question
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public long GroupId { get; set; }
        public string ClassNO { get; set; }
        public string QuestionText { get; set; }
        public string case1 { get; set; }
        public string case2 { get; set; }
        public string case3 { get; set; }
        public string case4 { get; set; }
        public int Answare { get; set; }
    }
}