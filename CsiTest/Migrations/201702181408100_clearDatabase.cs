namespace CsiTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clearDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM RandomNumbers");
        }
        
        public override void Down()
        {
        }
    }
}
