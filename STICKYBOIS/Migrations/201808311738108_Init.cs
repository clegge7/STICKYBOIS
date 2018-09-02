namespace STICKYBOIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StartTime = c.String(),
                        EndTime = c.String(),
                        TotalTime = c.String(),
                        Thrower = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Records");
        }
    }
}
