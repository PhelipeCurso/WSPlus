﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSPlus.DATA.Models;

#nullable disable

namespace WSPlus.DATA.Migrations
{
    [DbContext(typeof(WSPlusContext))]
    [Migration("20221115000549_usuario-PerfilEnum-to-Usuario")]
    partial class usuarioPerfilEnumtoUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WSPlus.DATA.Models.Atendente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cpf")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Atendente");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cel")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Cep")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("CodigoCliente")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Codigo_Cliente");

                    b.Property<string>("ComplementoLogradouro")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Complemento_Logradouro");

                    b.Property<string>("Cpf")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("CPF");

                    b.Property<DateTime?>("DataDoCadastro")
                        .HasColumnType("datetime2")
                        .HasColumnName("Data_do_Cadastro");

                    b.Property<string>("EmailPrincipal")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Endereco")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Naturalidade")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NomeMae")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome_Mae");

                    b.Property<string>("NomePai")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome_Pai");

                    b.Property<string>("Observacao")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Profissao")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<float?>("RendaMensal")
                        .HasColumnType("real")
                        .HasColumnName("Renda_Mensal");

                    b.Property<string>("Rg")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("RG");

                    b.Property<string>("Telefone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<int>("TipoDePessoa")
                        .HasColumnType("int")
                        .HasColumnName("Tipo_de_Pessoa");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(18)
                        .IsUnicode(false)
                        .HasColumnType("varchar(18)");

                    b.Property<int>("IdMesa")
                        .HasColumnType("int")
                        .HasColumnName("Id_Mesa");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int")
                        .HasColumnName("Id_Produto");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int")
                        .HasColumnName("Id_Usuario");

                    b.HasKey("Id");

                    b.HasIndex("IdMesa");

                    b.HasIndex("IdProduto");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Comanda");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Celular")
                        .HasColumnType("text");

                    b.Property<string>("CnaeFiscal")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("Cnae_Fiscal");

                    b.Property<string>("Cnpj")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Codigo")
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Inscricao_Estadual");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Inscricao_Municipal");

                    b.Property<string>("NomeFantasia")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nome_Fantasia");

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Razao_Social");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdSetorEstoque")
                        .HasColumnType("int")
                        .HasColumnName("Id_Setor_Estoque");

                    b.Property<decimal?>("QuantidadeAtual")
                        .HasColumnType("numeric(18, 0)")
                        .HasColumnName("Quantidade_Atual");

                    b.Property<decimal?>("QuantidadeDisponivel")
                        .HasColumnType("numeric(18, 0)")
                        .HasColumnName("Quantidade_Disponivel");

                    b.Property<decimal?>("QuantidadeReservada")
                        .HasColumnType("numeric(18, 0)")
                        .HasColumnName("Quantidade_Reservada");

                    b.HasKey("Id");

                    b.HasIndex("IdSetorEstoque");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Celular")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Cep")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cnae")
                        .HasMaxLength(7)
                        .IsUnicode(false)
                        .HasColumnType("varchar(7)")
                        .HasColumnName("CNAE");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(14)
                        .IsUnicode(false)
                        .HasColumnType("varchar(14)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("Codigo")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("ComplementeoEndereco")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Complementeo_Endereco");

                    b.Property<string>("Cpf")
                        .HasMaxLength(13)
                        .IsUnicode(false)
                        .HasColumnType("varchar(13)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmailDanfe")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Email_DANFE");

                    b.Property<string>("Endereco")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Inscricao_Estadual");

                    b.Property<string>("InscricaoMunicipal")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Inscricao_Municipal");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Observacoes")
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Razao_Social");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("TipoDePessoa")
                        .HasColumnType("int")
                        .HasColumnName("Tipo_de_Pessoa");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Nome")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(18)
                        .IsUnicode(false)
                        .HasColumnType("varchar(18)");

                    b.HasKey("Id");

                    b.ToTable("Mesa");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoBarras")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Codigo_Barras");

                    b.Property<string>("CodigoPrincipal")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("Codigo_Principal");

                    b.Property<bool>("ControlaEstoque")
                        .HasColumnType("bit")
                        .HasColumnName("Controla_Estoque");

                    b.Property<int>("IdEstoqueProduto")
                        .HasColumnType("int")
                        .HasColumnName("Id_Estoque_Produto");

                    b.Property<int?>("IdFornecedor")
                        .HasColumnType("int")
                        .HasColumnName("Id_Fornecedor");

                    b.Property<int?>("IdMarcaProduto")
                        .HasColumnType("int")
                        .HasColumnName("Id_Marca_Produto");

                    b.Property<int?>("IdSecaoProduto")
                        .HasColumnType("int")
                        .HasColumnName("id_Secao_Produto");

                    b.Property<bool>("Inativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Observacao")
                        .HasColumnType("text");

                    b.Property<bool>("PermitirVenda")
                        .HasColumnType("bit")
                        .HasColumnName("Permitir_Venda");

                    b.HasKey("Id");

                    b.HasIndex("IdEstoqueProduto");

                    b.HasIndex("IdFornecedor");

                    b.HasIndex("IdMarcaProduto");

                    b.HasIndex("IdSecaoProduto");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Secao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativa")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Secao");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.SetorDoEstoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Setor_do_Estoque");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("IdAtendente")
                        .HasColumnType("int")
                        .HasColumnName("Id_Atendente");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int")
                        .HasColumnName("Id_Empresa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Perfil")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("IdAtendente");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Comanda", b =>
                {
                    b.HasOne("WSPlus.DATA.Models.Mesa", "IdMesaNavigation")
                        .WithMany("Comanda")
                        .HasForeignKey("IdMesa")
                        .IsRequired()
                        .HasConstraintName("FK_Comanda_Mesa");

                    b.HasOne("WSPlus.DATA.Models.Produto", "IdProdutoNavigation")
                        .WithMany("Comanda")
                        .HasForeignKey("IdProduto")
                        .IsRequired()
                        .HasConstraintName("FK_Comanda_Produto");

                    b.HasOne("WSPlus.DATA.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("Comanda")
                        .HasForeignKey("IdUsuario")
                        .IsRequired()
                        .HasConstraintName("FK_Comanda_Usuario");

                    b.Navigation("IdMesaNavigation");

                    b.Navigation("IdProdutoNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Estoque", b =>
                {
                    b.HasOne("WSPlus.DATA.Models.SetorDoEstoque", "IdSetorEstoqueNavigation")
                        .WithMany("Estoque")
                        .HasForeignKey("IdSetorEstoque")
                        .IsRequired()
                        .HasConstraintName("FK_Estoque_Setor_do_Estoque");

                    b.Navigation("IdSetorEstoqueNavigation");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Produto", b =>
                {
                    b.HasOne("WSPlus.DATA.Models.Estoque", "IdEstoqueProdutoNavigation")
                        .WithMany("Produto")
                        .HasForeignKey("IdEstoqueProduto")
                        .IsRequired()
                        .HasConstraintName("FK_Produto_Estoque");

                    b.HasOne("WSPlus.DATA.Models.Fornecedor", "IdFornecedorNavigation")
                        .WithMany("Produto")
                        .HasForeignKey("IdFornecedor")
                        .HasConstraintName("FK_Produto_Fornecedor");

                    b.HasOne("WSPlus.DATA.Models.Marca", "IdMarcaProdutoNavigation")
                        .WithMany("Produto")
                        .HasForeignKey("IdMarcaProduto")
                        .HasConstraintName("FK_Produto_Marca");

                    b.HasOne("WSPlus.DATA.Models.Secao", "IdSecaoProdutoNavigation")
                        .WithMany("Produto")
                        .HasForeignKey("IdSecaoProduto")
                        .HasConstraintName("FK_Produto_Secao");

                    b.Navigation("IdEstoqueProdutoNavigation");

                    b.Navigation("IdFornecedorNavigation");

                    b.Navigation("IdMarcaProdutoNavigation");

                    b.Navigation("IdSecaoProdutoNavigation");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Usuario", b =>
                {
                    b.HasOne("WSPlus.DATA.Models.Atendente", "IdAtendenteNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdAtendente")
                        .HasConstraintName("FK_Usuario_Atendente");

                    b.HasOne("WSPlus.DATA.Models.Empresa", "IdEmpresaNavigation")
                        .WithMany("Usuario")
                        .HasForeignKey("IdEmpresa")
                        .IsRequired()
                        .HasConstraintName("FK_Usuario_Empresa");

                    b.Navigation("IdAtendenteNavigation");

                    b.Navigation("IdEmpresaNavigation");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Atendente", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Empresa", b =>
                {
                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Estoque", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Fornecedor", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Marca", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Mesa", b =>
                {
                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Produto", b =>
                {
                    b.Navigation("Comanda");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Secao", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.SetorDoEstoque", b =>
                {
                    b.Navigation("Estoque");
                });

            modelBuilder.Entity("WSPlus.DATA.Models.Usuario", b =>
                {
                    b.Navigation("Comanda");
                });
#pragma warning restore 612, 618
        }
    }
}
