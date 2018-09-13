namespace Himac.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1c : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DM_VANBAN", "FilePath", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DM_VANBAN", "FilePath");
        }
    }
}
