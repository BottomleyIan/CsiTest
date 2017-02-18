namespace CsiTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRandomNumbers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO RandomNumbers (Millis, SortedNumbers, Ascending) VALUES (10, '1, 2, 3, 4, 5', 1)");
            Sql("INSERT INTO RandomNumbers (Millis, SortedNumbers, Ascending) VALUES (15, '5, 4, 3, 2, 1', 0)");
        }
        
        public override void Down()
        {
        }
    }
}
