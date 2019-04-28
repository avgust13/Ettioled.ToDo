namespace Ettioled.ToDo.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateToDoTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoRecords",
                c => new
                    {
                        ToDoId = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        IsDone = c.Boolean(nullable: false),
                        Description = c.String(),
                        LastUpdatedDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoRecords");
        }
    }
}
