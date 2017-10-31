namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposObrigatoriosCurso : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cursoes", "Ementa", c => c.String(nullable: false));
            AlterColumn("dbo.Cursoes", "Duracao", c => c.String(nullable: false));
            AlterColumn("dbo.Cursoes", "Coordenador", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cursoes", "Coordenador", c => c.String());
            AlterColumn("dbo.Cursoes", "Duracao", c => c.String());
            AlterColumn("dbo.Cursoes", "Ementa", c => c.String());
        }
    }
}
