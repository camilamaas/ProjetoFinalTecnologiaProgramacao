namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracaoModelDisciplina : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Disciplinas", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Disciplinas", "Nome", c => c.String());
        }
    }
}
