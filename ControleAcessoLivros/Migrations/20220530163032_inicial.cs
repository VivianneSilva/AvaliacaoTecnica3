using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleAcessoLivros.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeAutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.AutorId);
                });

            migrationBuilder.CreateTable(
                name: "Leitor",
                columns: table => new
                {
                    LeitorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLeitor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leitor", x => x.LeitorId);
                });

            migrationBuilder.CreateTable(
                name: "StatusLivro",
                columns: table => new
                {
                    StatusLivroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusLivro", x => x.StatusLivroId);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    LivroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLivro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutorId = table.Column<int>(type: "int", nullable: false),
                    AnoLancamento = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.LivroId);
                    table.ForeignKey(
                        name: "FK_Livro_Autor_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autor",
                        principalColumn: "AutorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Leitura",
                columns: table => new
                {
                    LeituraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeitorId = table.Column<int>(type: "int", nullable: false),
                    LivroId = table.Column<int>(type: "int", nullable: false),
                    StatusLivroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leitura", x => x.LeituraId);
                    table.ForeignKey(
                        name: "FK_Leitura_Leitor_LeitorId",
                        column: x => x.LeitorId,
                        principalTable: "Leitor",
                        principalColumn: "LeitorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leitura_Livro_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livro",
                        principalColumn: "LivroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Leitura_StatusLivro_StatusLivroId",
                        column: x => x.StatusLivroId,
                        principalTable: "StatusLivro",
                        principalColumn: "StatusLivroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leitura_LeitorId",
                table: "Leitura",
                column: "LeitorId");

            migrationBuilder.CreateIndex(
                name: "IX_Leitura_LivroId",
                table: "Leitura",
                column: "LivroId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Leitura_StatusLivroId",
                table: "Leitura",
                column: "StatusLivroId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_AutorId",
                table: "Livro",
                column: "AutorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leitura");

            migrationBuilder.DropTable(
                name: "Leitor");

            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "StatusLivro");

            migrationBuilder.DropTable(
                name: "Autor");
        }
    }
}
