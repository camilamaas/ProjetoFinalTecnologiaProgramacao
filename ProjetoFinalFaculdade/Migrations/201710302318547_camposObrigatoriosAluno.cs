namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class camposObrigatoriosAluno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alunoes", "CPF", c => c.String(nullable: false));
            AlterColumn("dbo.Alunoes", "DataNascimento", c => c.String(nullable: false));
            AlterColumn("dbo.Alunoes", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alunoes", "Email", c => c.String());
            AlterColumn("dbo.Alunoes", "DataNascimento", c => c.String());
            AlterColumn("dbo.Alunoes", "CPF", c => c.String());
        }
    }
}
