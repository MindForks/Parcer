using System;
using SQLite;

namespace ABCEnjoy
{
    [Table("Items")]
    public class ItemOfCategory
    {
        [PrimaryKey, AutoIncrement, Column("_id")] //PrimaryKey -  первичный ключ
        public int Id { get; set; }

        public string Title { get; set; }

        public string Preview { get; set; }

        public string Tags { get; set; }

        public string Price{ get; set; }

        public string Location { get; set; }

        public string FullDescription { get; set; }

        public string Image { get; set; }

        public string Date { get; set; }
    }
}
