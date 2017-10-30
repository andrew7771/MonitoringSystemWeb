using System.Data.Entity;

namespace MonitoringSystemModel
{
    public class TotalJournalContextWeb : DbContext
    {
        public TotalJournalContextWeb() 
            : base("name=TotalJournalContextWeb") {}

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<SchoolKid> SchoolKids { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }        

        public virtual DbSet<SubjectCP> SubjectCPs { get; set; }

        public virtual DbSet<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual DbSet<CPLineMaxPoint> CPLineMaxPoints { get; set; }
    }
}