using System;
using Realms;

namespace WillDo.Repository.Models
{
    public class Goal : RealmObject
    {
        public Goal()
        {
        }

        [PrimaryKey]
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }
        public DateTimeOffset CompletionDate
        {
            get;
            set;
        }
        public DateTimeOffset CreatedDate
        {
            get;
            set;
        }
    }
}
