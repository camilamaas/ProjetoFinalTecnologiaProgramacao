namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionadaValidacaoIdadeMinimaAluno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alunoes", "DataNascimento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alunoes", "DataNascimento", c => c.String(nullable: false));
        }
    }
}
