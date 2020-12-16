namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "studentCode", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "studentLastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "studentCreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "studentModificationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "studentModificationDate");
            DropColumn("dbo.Students", "studentCreationDate");
            DropColumn("dbo.Students", "studentLastName");
            DropColumn("dbo.Students", "studentCode");
        }
    }
}
