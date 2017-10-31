namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposObrigatoriosProfessor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Professors", "CPF", c => c.String(nullable: false));
            AlterColumn("dbo.Professors", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Professors", "Email", c => c.String());
            AlterColumn("dbo.Professors", "CPF", c => c.String());
        }
    }
}
