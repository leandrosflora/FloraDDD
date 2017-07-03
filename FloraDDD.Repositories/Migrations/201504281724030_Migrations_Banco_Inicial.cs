namespace FloraDDD.Repositories.Migrations
{
    using System;
    //using System.Data.Entity.Migrations;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class Migrations_Banco_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        }
        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.CreateTable(
        //       name: "AspNetRoles",
        //       columns: table => new
        //       {
        //           Id = table.Column<string>(nullable: false),
        //           ConcurrencyStamp = table.Column<string>(nullable: true),
        //           Name = table.Column<string>(maxLength: 256, nullable: true),
        //           NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
        //       },
        //       constraints: table =>
        //       {
        //           table.PrimaryKey("PK_AspNetRoles", x => x.Id);
        //       });

        //    migrationBuilder.CreateTable(
        //        name: "dbo.Usuario",
        //        columns: c => new
        //        {
        //            Id = c.Column<int>(nullable: false),
        //            Cpf = c.Column<Long>(nullable: false),
        //            Email = c.String(maxLength: 254, unicode: false),
        //            Login = c.String(maxLength: 30, unicode: false),
        //            Logradouro = c.String(maxLength: 150, unicode: false),
        //            Complemento = c.String(maxLength: 150, unicode: false),
        //            Numero = c.String(maxLength: 50, unicode: false),
        //            Bairro = c.String(maxLength: 150, unicode: false),
        //            Cidade = c.String(maxLength: 150, unicode: false),
        //            Uf = c.Int(),
        //            Cep = c.Long(),
        //            Senha = c.Binary(),
        //            TokenAlteracaoDeSenha = c.Guid(nullable: false),
        //            DtInclusao = c.DateTime(nullable: false),
        //            DtAlteracao = c.DateTime(),
        //        })
        //        .PrimaryKey(t => t.Id)
        //        .Index(t => t.Cpf, unique: true, name: "IX_CPF")
        //        .Index(t => t.Email, unique: true)
        //        .Index(t => t.Login, unique: true);

        //}

        //public override void Down()
        //{
        //    DropIndex("dbo.Usuario", new[] { "Login" });
        //    DropIndex("dbo.Usuario", new[] { "Email" });
        //    DropIndex("dbo.Usuario", "IX_CPF");
        //    DropTable("dbo.Usuario");
        //}
    }
}
