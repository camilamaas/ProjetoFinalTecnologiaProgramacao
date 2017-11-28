namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteradoTipoParaDateTimeProfessor : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Professors", "DataNascimento", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Professors", "DataNascimento", c => c.String());
        }
    }
}
