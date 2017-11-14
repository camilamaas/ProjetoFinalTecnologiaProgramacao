namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterarParaTiposNullableEmAluno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alunoes", "Telefone", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alunoes", "Telefone", c => c.Int(nullable: false));
        }
    }
}
