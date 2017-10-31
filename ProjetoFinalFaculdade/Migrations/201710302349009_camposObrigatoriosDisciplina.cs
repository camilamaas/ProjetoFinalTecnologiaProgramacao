namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposObrigatoriosDisciplina : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Disciplinas", "Ementa", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Disciplinas", "Ementa", c => c.String());
        }
    }
}
