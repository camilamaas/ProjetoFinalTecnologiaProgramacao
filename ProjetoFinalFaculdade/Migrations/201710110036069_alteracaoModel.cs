namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracaoModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alunoes", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alunoes", "Nome", c => c.String());
        }
    }
}
