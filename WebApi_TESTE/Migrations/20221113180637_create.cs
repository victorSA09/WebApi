using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_livro",
                table: "tb_emprestimo",
                newName: "Id_livro");

            migrationBuilder.RenameColumn(
                name: "id_leitor",
                table: "tb_emprestimo",
                newName: "Id_leitor");

            migrationBuilder.AddColumn<bool>(
                name: "estado",
                table: "tb_emprestimo",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estado",
                table: "tb_emprestimo");

            migrationBuilder.RenameColumn(
                name: "Id_livro",
                table: "tb_emprestimo",
                newName: "id_livro");

            migrationBuilder.RenameColumn(
                name: "Id_leitor",
                table: "tb_emprestimo",
                newName: "id_leitor");
        }
    }
}
