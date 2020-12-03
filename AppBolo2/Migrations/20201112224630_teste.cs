using Microsoft.EntityFrameworkCore.Migrations;

namespace AppBolo2.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagamento",
                columns: table => new
                {
                    IdPagamento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoPagamento = table.Column<string>(nullable: true),
                    DataPagamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamento", x => x.IdPagamento);
                });

            migrationBuilder.CreateTable(
                name: "Tema",
                columns: table => new
                {
                    IdTema = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Personalizado = table.Column<string>(nullable: true),
                    Predefinido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tema", x => x.IdTema);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Telefone = table.Column<float>(nullable: false),
                    CPF = table.Column<float>(nullable: false),
                    CartaoCredito = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataPedido = table.Column<int>(nullable: false),
                    StatusPedido = table.Column<string>(nullable: true),
                    TipoPedido = table.Column<string>(nullable: true),
                    ValorTotal = table.Column<float>(nullable: false),
                    PagamentoIdPagamento = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedido_Pagamento_PagamentoIdPagamento",
                        column: x => x.PagamentoIdPagamento,
                        principalTable: "Pagamento",
                        principalColumn: "IdPagamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedido_USER_UserId",
                        column: x => x.UserId,
                        principalTable: "USER",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bolo",
                columns: table => new
                {
                    IdBolo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SaborRecheio = table.Column<string>(nullable: true),
                    SaborMassa = table.Column<string>(nullable: true),
                    TemaIdTema = table.Column<int>(nullable: true),
                    TipoCobertura = table.Column<string>(nullable: true),
                    DiamentroCentimetro = table.Column<float>(nullable: false),
                    QuantidadeAndar = table.Column<int>(nullable: false),
                    QuantidadeBolo = table.Column<int>(nullable: false),
                    ValorUnitario = table.Column<float>(nullable: false),
                    PedidoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolo", x => x.IdBolo);
                    table.ForeignKey(
                        name: "FK_Bolo_Pedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bolo_Tema_TemaIdTema",
                        column: x => x.TemaIdTema,
                        principalTable: "Tema",
                        principalColumn: "IdTema",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bolo_PedidoId",
                table: "Bolo",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Bolo_TemaIdTema",
                table: "Bolo",
                column: "TemaIdTema");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PagamentoIdPagamento",
                table: "Pedido",
                column: "PagamentoIdPagamento");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_UserId",
                table: "Pedido",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolo");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Tema");

            migrationBuilder.DropTable(
                name: "Pagamento");

            migrationBuilder.DropTable(
                name: "USER");
        }
    }
}
