namespace CinemaApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracija1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Time1", c => c.String());
            AlterColumn("dbo.Movies", "Time2", c => c.String());
            AlterColumn("dbo.Movies", "Time3", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Time3", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Time2", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Time1", c => c.String(nullable: false));
        }
    }
}
