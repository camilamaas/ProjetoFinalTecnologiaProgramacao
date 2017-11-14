namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterarParaTiposNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Professors", "Telefone", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Professors", "Telefone", c => c.Int(nullable: false));
        }
    }
}
