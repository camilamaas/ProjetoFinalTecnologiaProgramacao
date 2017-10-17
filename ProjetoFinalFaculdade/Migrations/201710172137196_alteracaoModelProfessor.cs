namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracaoModelProfessor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Professors", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Professors", "Nome", c => c.String());
        }
    }
}
