using System;

namespace MovieDB.NHibernate.Repo
{
    public class MovieRepo
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Category { get; set; }
        public virtual decimal Rating { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual ProductionCompany ProductionCompany { get; set; }
    }
}
