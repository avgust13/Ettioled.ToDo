namespace Ettioled.ToDo.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredFlagUserId : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ToDoRecords", "UserId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ToDoRecords", "UserId", c => c.String());
        }
    }
}
