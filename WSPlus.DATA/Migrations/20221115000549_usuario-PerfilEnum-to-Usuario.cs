using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WSPlus.DATA.Migrations
{
    /// <inheritdoc />
    public partial class usuarioPerfilEnumtoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atendente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CPF = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atendente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CPF = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    Endereco = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    RG = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    EmailPrincipal = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ComplementoLogradouro = table.Column<string>(name: "Complemento_Logradouro", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    Cel = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    Naturalidade = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    NomeMae = table.Column<string>(name: "Nome_Mae", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    NomePai = table.Column<string>(name: "Nome_Pai", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DatadoCadastro = table.Column<DateTime>(name: "Data_do_Cadastro", type: "datetime2", nullable: true),
                    Observacao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Profissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RendaMensal = table.Column<float>(name: "Renda_Mensal", type: "real", nullable: true),
                    TipodePessoa = table.Column<int>(name: "Tipo_de_Pessoa", type: "int", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    CodigoCliente = table.Column<string>(name: "Codigo_Cliente", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFantasia = table.Column<string>(name: "Nome_Fantasia", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Codigo = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    RazaoSocial = table.Column<string>(name: "Razao_Social", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CnaeFiscal = table.Column<string>(name: "Cnae_Fiscal", type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    InscricaoEstadual = table.Column<string>(name: "Inscricao_Estadual", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    InscricaoMunicipal = table.Column<string>(name: "Inscricao_Municipal", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    Celular = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", unicode: false, maxLength: 14, nullable: false),
                    Codigo = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Endereco = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ComplementeoEndereco = table.Column<string>(name: "Complementeo_Endereco", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    RazaoSocial = table.Column<string>(name: "Razao_Social", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CNAE = table.Column<string>(type: "varchar(7)", unicode: false, maxLength: 7, nullable: true),
                    InscricaoEstadual = table.Column<string>(name: "Inscricao_Estadual", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    InscricaoMunicipal = table.Column<string>(name: "Inscricao_Municipal", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    TipodePessoa = table.Column<int>(name: "Tipo_de_Pessoa", type: "int", nullable: false),
                    EmailDANFE = table.Column<string>(name: "Email_DANFE", type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CPF = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    Telefone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Celular = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Observacoes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Nome = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Ativa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesa",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesa", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Secao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Codigo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Ativa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Setor_do_Estoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setor_do_Estoque", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Perfil = table.Column<int>(type: "int", unicode: false, maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    IdEmpresa = table.Column<int>(name: "Id_Empresa", type: "int", nullable: false),
                    IdAtendente = table.Column<int>(name: "Id_Atendente", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Atendente",
                        column: x => x.IdAtendente,
                        principalTable: "Atendente",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Usuario_Empresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuantidadeAtual = table.Column<decimal>(name: "Quantidade_Atual", type: "numeric(18,0)", nullable: true),
                    QuantidadeDisponivel = table.Column<decimal>(name: "Quantidade_Disponivel", type: "numeric(18,0)", nullable: true),
                    QuantidadeReservada = table.Column<decimal>(name: "Quantidade_Reservada", type: "numeric(18,0)", nullable: true),
                    IdSetorEstoque = table.Column<int>(name: "Id_Setor_Estoque", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoque_Setor_do_Estoque",
                        column: x => x.IdSetorEstoque,
                        principalTable: "Setor_do_Estoque",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CodigoPrincipal = table.Column<string>(name: "Codigo_Principal", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CodigoBarras = table.Column<string>(name: "Codigo_Barras", type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    PermitirVenda = table.Column<bool>(name: "Permitir_Venda", type: "bit", nullable: false),
                    Inativo = table.Column<bool>(type: "bit", nullable: false),
                    ControlaEstoque = table.Column<bool>(name: "Controla_Estoque", type: "bit", nullable: false),
                    Observacao = table.Column<string>(type: "text", nullable: true),
                    IdEstoqueProduto = table.Column<int>(name: "Id_Estoque_Produto", type: "int", nullable: false),
                    IdMarcaProduto = table.Column<int>(name: "Id_Marca_Produto", type: "int", nullable: true),
                    idSecaoProduto = table.Column<int>(name: "id_Secao_Produto", type: "int", nullable: true),
                    IdFornecedor = table.Column<int>(name: "Id_Fornecedor", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Estoque",
                        column: x => x.IdEstoqueProduto,
                        principalTable: "Estoque",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produto_Fornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "Fornecedor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produto_Marca",
                        column: x => x.IdMarcaProduto,
                        principalTable: "Marca",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Produto_Secao",
                        column: x => x.idSecaoProduto,
                        principalTable: "Secao",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comanda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "varchar(18)", unicode: false, maxLength: 18, nullable: false),
                    IdMesa = table.Column<int>(name: "Id_Mesa", type: "int", nullable: false),
                    IdProduto = table.Column<int>(name: "Id_Produto", type: "int", nullable: false),
                    IdUsuario = table.Column<int>(name: "Id_Usuario", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comanda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comanda_Mesa",
                        column: x => x.IdMesa,
                        principalTable: "Mesa",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Comanda_Produto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comanda_Usuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_Id_Mesa",
                table: "Comanda",
                column: "Id_Mesa");

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_Id_Produto",
                table: "Comanda",
                column: "Id_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_Comanda_Id_Usuario",
                table: "Comanda",
                column: "Id_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_Id_Setor_Estoque",
                table: "Estoque",
                column: "Id_Setor_Estoque");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Id_Estoque_Produto",
                table: "Produto",
                column: "Id_Estoque_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Id_Fornecedor",
                table: "Produto",
                column: "Id_Fornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_Id_Marca_Produto",
                table: "Produto",
                column: "Id_Marca_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_id_Secao_Produto",
                table: "Produto",
                column: "id_Secao_Produto");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Id_Atendente",
                table: "Usuario",
                column: "Id_Atendente");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Id_Empresa",
                table: "Usuario",
                column: "Id_Empresa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Comanda");

            migrationBuilder.DropTable(
                name: "Mesa");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "Secao");

            migrationBuilder.DropTable(
                name: "Atendente");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Setor_do_Estoque");
        }
    }
}
