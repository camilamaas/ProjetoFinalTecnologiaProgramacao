namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracaoModelCurso : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cursoes", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cursoes", "Nome", c => c.String());
        }
    }
}
