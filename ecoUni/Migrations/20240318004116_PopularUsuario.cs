using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ecoUni.Migrations
{
    /// <inheritdoc />
    public partial class PopularUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Usuarios(NomeUsuario, Senha, NomeCompleto, Email, Telefone) VALUES('usuariot', 'a', 'Usuario', 'usuarioteste', '119')");
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
