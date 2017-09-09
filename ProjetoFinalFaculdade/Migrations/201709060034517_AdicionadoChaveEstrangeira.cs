namespace ProjetoFinalFaculdade.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionadoChaveEstrangeira : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alunoes", "Curso_Id", "dbo.Cursoes");
            DropForeignKey("dbo.Disciplinas", "Professor_Id", "dbo.Professors");
            DropForeignKey("dbo.Disciplinas", "Curso_Id", "dbo.Cursoes");
            DropIndex("dbo.Alunoes", new[] { "Curso_Id" });
            DropIndex("dbo.Disciplinas", new[] { "Professor_Id" });
            DropIndex("dbo.Disciplinas", new[] { "Curso_Id" });
            RenameColumn(table: "dbo.Alunoes", name: "Curso_Id", newName: "CursoId");
            RenameColumn(table: "dbo.Disciplinas", name: "Professor_Id", newName: "ProfessorId");
            RenameColumn(table: "dbo.Disciplinas", name: "Curso_Id", newName: "CursoId");
            AlterColumn("dbo.Alunoes", "CursoId", c => c.Int(nullable: false));
            AlterColumn("dbo.Disciplinas", "ProfessorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Disciplinas", "CursoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Alunoes", "CursoId");
            CreateIndex("dbo.Disciplinas", "ProfessorId");
            CreateIndex("dbo.Disciplinas", "CursoId");
            AddForeignKey("dbo.Alunoes", "CursoId", "dbo.Cursoes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Disciplinas", "ProfessorId", "dbo.Professors", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Disciplinas", "CursoId", "dbo.Cursoes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Disciplinas", "CursoId", "dbo.Cursoes");
            DropForeignKey("dbo.Disciplinas", "ProfessorId", "dbo.Professors");
            DropForeignKey("dbo.Alunoes", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.Disciplinas", new[] { "CursoId" });
            DropIndex("dbo.Disciplinas", new[] { "ProfessorId" });
            DropIndex("dbo.Alunoes", new[] { "CursoId" });
            AlterColumn("dbo.Disciplinas", "CursoId", c => c.Int());
            AlterColumn("dbo.Disciplinas", "ProfessorId", c => c.Int());
            AlterColumn("dbo.Alunoes", "CursoId", c => c.Int());
            RenameColumn(table: "dbo.Disciplinas", name: "CursoId", newName: "Curso_Id");
            RenameColumn(table: "dbo.Disciplinas", name: "ProfessorId", newName: "Professor_Id");
            RenameColumn(table: "dbo.Alunoes", name: "CursoId", newName: "Curso_Id");
            CreateIndex("dbo.Disciplinas", "Curso_Id");
            CreateIndex("dbo.Disciplinas", "Professor_Id");
            CreateIndex("dbo.Alunoes", "Curso_Id");
            AddForeignKey("dbo.Disciplinas", "Curso_Id", "dbo.Cursoes", "Id");
            AddForeignKey("dbo.Disciplinas", "Professor_Id", "dbo.Professors", "Id");
            AddForeignKey("dbo.Alunoes", "Curso_Id", "dbo.Cursoes", "Id");
        }
    }
}
