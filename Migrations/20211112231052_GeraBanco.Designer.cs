﻿// <auto-generated />
using System;
using AssistenteMedicoSenior.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AssistenteMedicoSenior.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211112231052_GeraBanco")]
    partial class GeraBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Consulta", b =>
                {
                    b.Property<int>("Cod_Consulta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Medico")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Paciente")
                        .HasColumnType("int");

                    b.Property<bool>("Confirmado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Criador")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Data_Registro")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Lembrete")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("PacienteCod_Paciente")
                        .HasColumnType("int");

                    b.Property<bool>("Realizada")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Relatorio")
                        .HasColumnType("longtext");

                    b.Property<string>("Resumo_Saude")
                        .HasColumnType("longtext");

                    b.HasKey("Cod_Consulta");

                    b.HasIndex("Cod_Pessoa_Medico");

                    b.HasIndex("Cod_Pessoa_Paciente");

                    b.HasIndex("PacienteCod_Paciente");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Contato", b =>
                {
                    b.Property<int>("Cod_Contato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Cod_Pessoa")
                        .HasColumnType("int");

                    b.Property<bool>("Emergencia")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("PessoaCod_Pessoa")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Cod_Contato");

                    b.HasIndex("PessoaCod_Pessoa");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Deficiencia", b =>
                {
                    b.Property<int>("Cod_Deficiencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome_Deficiencia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Cod_Deficiencia");

                    b.ToTable("Deficiencias");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Dispositivo", b =>
                {
                    b.Property<int>("Cod_Dispositivo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apelido_Dispositivo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cod_Dispositivo_Smartphone")
                        .HasColumnType("longtext");

                    b.Property<int>("Cod_Pessoa")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PessoaCod_Pessoa")
                        .HasColumnType("int");

                    b.HasKey("Cod_Dispositivo");

                    b.HasIndex("PessoaCod_Pessoa");

                    b.ToTable("Dispositivos");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Enfermidade", b =>
                {
                    b.Property<int>("Cod_Enfermidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod_Deficiencia")
                        .HasColumnType("int");

                    b.Property<int?>("DeficienciaCod_Deficiencia")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome_Cientifico")
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)");

                    b.Property<bool>("Possui_Tratamento")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Cod_Enfermidade");

                    b.HasIndex("DeficienciaCod_Deficiencia");

                    b.ToTable("Enfermidades");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Enfermidade_Paciente", b =>
                {
                    b.Property<int>("Cod_Enfermidade_Paciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativa")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Cod_Enfermidade")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Medico")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Paciente")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("EnfermidadeCod_Enfermidade")
                        .HasColumnType("int");

                    b.Property<string>("InformacoesAdicionais")
                        .HasColumnType("longtext");

                    b.Property<int?>("PacienteCod_Paciente")
                        .HasColumnType("int");

                    b.HasKey("Cod_Enfermidade_Paciente");

                    b.HasIndex("Cod_Pessoa_Medico");

                    b.HasIndex("Cod_Pessoa_Paciente");

                    b.HasIndex("EnfermidadeCod_Enfermidade");

                    b.HasIndex("PacienteCod_Paciente");

                    b.ToTable("Enfermidades_Pacientes");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Medico", b =>
                {
                    b.Property<int>("Cod_Medico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa")
                        .HasColumnType("int");

                    b.Property<string>("Crm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Crm_Secundario")
                        .HasColumnType("longtext");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("PessoaCod_Pessoa")
                        .HasColumnType("int");

                    b.HasKey("Cod_Medico");

                    b.HasIndex("PessoaCod_Pessoa");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Paciente", b =>
                {
                    b.Property<int>("Cod_Paciente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Altura")
                        .HasColumnType("float");

                    b.Property<int>("Cod_Pessoa")
                        .HasColumnType("int");

                    b.Property<float>("Peso")
                        .HasColumnType("float");

                    b.Property<int?>("PessoaCod_Pessoa")
                        .HasColumnType("int");

                    b.HasKey("Cod_Paciente");

                    b.HasIndex("PessoaCod_Pessoa");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Paciente_Relacionamento", b =>
                {
                    b.Property<int>("Codigo_Relacionamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("Cod_Pessoa_Medico")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Cod_Pessoa_Paciente")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("PacienteCod_Paciente")
                        .HasColumnType("int");

                    b.HasKey("Codigo_Relacionamento");

                    b.HasIndex("Cod_Pessoa_Medico");

                    b.HasIndex("Cod_Pessoa_Paciente");

                    b.HasIndex("PacienteCod_Paciente");

                    b.ToTable("Paciente_Relacionamentos");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Pessoa", b =>
                {
                    b.Property<int>("Cod_Pessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.Property<int>("Cod_Pessoa_Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<int>("Num_Endereco")
                        .HasColumnType("int");

                    b.Property<int?>("Pessoa_TipoCod_Pessoa_Tipo")
                        .HasColumnType("int");

                    b.Property<string>("Raca_Cor")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.HasKey("Cod_Pessoa");

                    b.HasIndex("Pessoa_TipoCod_Pessoa_Tipo");

                    b.ToTable("Pessoas");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Pessoa_Tipo", b =>
                {
                    b.Property<int>("Cod_Pessoa_Tipo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome_Tipo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Tipo_ativo")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Cod_Pessoa_Tipo");

                    b.ToTable("Pessoa_Tipos");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Questionario_Medico", b =>
                {
                    b.Property<int>("Cod_Questionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativa")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("Cod_Enfermidade")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Medico")
                        .HasColumnType("int");

                    b.Property<int?>("Cod_Pessoa_Paciente")
                        .HasColumnType("int");

                    b.Property<bool>("Dispositivo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("EnfermidadeCod_Enfermidade")
                        .HasColumnType("int");

                    b.Property<string>("Questao")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("Cod_Questionario");

                    b.HasIndex("Cod_Pessoa_Medico");

                    b.HasIndex("Cod_Pessoa_Paciente");

                    b.HasIndex("EnfermidadeCod_Enfermidade");

                    b.ToTable("Questionarios_Medicos");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Questionario_Resposta", b =>
                {
                    b.Property<string>("Cod_Resposta")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Cod_Diario")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Dispositivo")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Medico")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Paciente")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Questionario")
                        .HasColumnType("int");

                    b.Property<int?>("DispositivoCod_Dispositivo")
                        .HasColumnType("int");

                    b.Property<int?>("Questionario_MedicoCod_Questionario")
                        .HasColumnType("int");

                    b.Property<int?>("Relatorio_DiarioCod_Diario")
                        .HasColumnType("int");

                    b.Property<string>("Resposta")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Cod_Resposta");

                    b.HasIndex("Cod_Pessoa_Medico");

                    b.HasIndex("Cod_Pessoa_Paciente");

                    b.HasIndex("DispositivoCod_Dispositivo");

                    b.HasIndex("Questionario_MedicoCod_Questionario");

                    b.HasIndex("Relatorio_DiarioCod_Diario");

                    b.ToTable("Questionarios_Respostas");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Receituario", b =>
                {
                    b.Property<int>("Cod_Receituario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod_Consulta")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Enfermidade")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Medico")
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa_Paciente")
                        .HasColumnType("int");

                    b.Property<int?>("ConsultaCod_Consulta")
                        .HasColumnType("int");

                    b.Property<string>("Dosagem")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("EnfermidadeCod_Enfermidade")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Intervalo_Horas")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Lembrete")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Medicamento")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Cod_Receituario");

                    b.HasIndex("Cod_Pessoa_Medico");

                    b.HasIndex("Cod_Pessoa_Paciente");

                    b.HasIndex("ConsultaCod_Consulta");

                    b.HasIndex("EnfermidadeCod_Enfermidade");

                    b.ToTable("Receituarios");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Relatorio_Diario", b =>
                {
                    b.Property<int>("Cod_Diario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cod_Pessoa")
                        .HasColumnType("int");

                    b.Property<bool>("Cod_Questionario")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Data_Diario")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("PacienteCod_Paciente")
                        .HasColumnType("int");

                    b.Property<int?>("PacienteCod_Pessoa")
                        .HasColumnType("int");

                    b.Property<int?>("Questionario_MedicoCod_Questionario")
                        .HasColumnType("int");

                    b.Property<string>("Sintomas")
                        .HasColumnType("longtext");

                    b.HasKey("Cod_Diario");

                    b.HasIndex("PacienteCod_Paciente");

                    b.HasIndex("PacienteCod_Pessoa");

                    b.HasIndex("Questionario_MedicoCod_Questionario");

                    b.ToTable("Relatorios_Diarios");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Consulta", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Medico")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Paciente")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Paciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Paciente", null)
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteCod_Paciente");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Contato", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Pessoa")
                        .WithMany("Contatos")
                        .HasForeignKey("PessoaCod_Pessoa");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Dispositivo", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaCod_Pessoa");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Enfermidade", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Deficiencia", "Deficiencia")
                        .WithMany("Enfermidades")
                        .HasForeignKey("DeficienciaCod_Deficiencia");

                    b.Navigation("Deficiencia");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Enfermidade_Paciente", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Medico")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Paciente")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Paciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Enfermidade", "Enfermidade")
                        .WithMany("Enfermidades_Pacientes")
                        .HasForeignKey("EnfermidadeCod_Enfermidade");

                    b.HasOne("AssistenteMedicoSenior.Models.Paciente", null)
                        .WithMany("Enfermidades")
                        .HasForeignKey("PacienteCod_Paciente");

                    b.Navigation("Enfermidade");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Medico", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaCod_Pessoa");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Paciente", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaCod_Pessoa");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Paciente_Relacionamento", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Medico")
                        .WithMany("RelacionamentosMedico")
                        .HasForeignKey("Cod_Pessoa_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Paciente")
                        .WithMany("RelacionamentosPaciente")
                        .HasForeignKey("Cod_Pessoa_Paciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Paciente", null)
                        .WithMany("Paciente_Relacionamentos")
                        .HasForeignKey("PacienteCod_Paciente");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Pessoa", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa_Tipo", "Pessoa_Tipo")
                        .WithMany("Pessoas")
                        .HasForeignKey("Pessoa_TipoCod_Pessoa_Tipo");

                    b.Navigation("Pessoa_Tipo");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Questionario_Medico", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Medico")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Paciente")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Paciente");

                    b.HasOne("AssistenteMedicoSenior.Models.Enfermidade", "Enfermidade")
                        .WithMany()
                        .HasForeignKey("EnfermidadeCod_Enfermidade");

                    b.Navigation("Enfermidade");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Questionario_Resposta", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Medico")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Paciente")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Paciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Dispositivo", "Dispositivo")
                        .WithMany()
                        .HasForeignKey("DispositivoCod_Dispositivo");

                    b.HasOne("AssistenteMedicoSenior.Models.Questionario_Medico", "Questionario_Medico")
                        .WithMany("Respostas_Questionarios")
                        .HasForeignKey("Questionario_MedicoCod_Questionario");

                    b.HasOne("AssistenteMedicoSenior.Models.Relatorio_Diario", "Relatorio_Diario")
                        .WithMany()
                        .HasForeignKey("Relatorio_DiarioCod_Diario");

                    b.Navigation("Dispositivo");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");

                    b.Navigation("Questionario_Medico");

                    b.Navigation("Relatorio_Diario");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Receituario", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Medico")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Medico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Paciente")
                        .WithMany()
                        .HasForeignKey("Cod_Pessoa_Paciente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssistenteMedicoSenior.Models.Consulta", "Consulta")
                        .WithMany("Receitas")
                        .HasForeignKey("ConsultaCod_Consulta");

                    b.HasOne("AssistenteMedicoSenior.Models.Enfermidade", "Enfermidade")
                        .WithMany()
                        .HasForeignKey("EnfermidadeCod_Enfermidade");

                    b.Navigation("Consulta");

                    b.Navigation("Enfermidade");

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Relatorio_Diario", b =>
                {
                    b.HasOne("AssistenteMedicoSenior.Models.Paciente", null)
                        .WithMany("Relatorio_Diarios")
                        .HasForeignKey("PacienteCod_Paciente");

                    b.HasOne("AssistenteMedicoSenior.Models.Pessoa", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteCod_Pessoa");

                    b.HasOne("AssistenteMedicoSenior.Models.Questionario_Medico", "Questionario_Medico")
                        .WithMany()
                        .HasForeignKey("Questionario_MedicoCod_Questionario");

                    b.Navigation("Paciente");

                    b.Navigation("Questionario_Medico");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Consulta", b =>
                {
                    b.Navigation("Receitas");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Deficiencia", b =>
                {
                    b.Navigation("Enfermidades");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Enfermidade", b =>
                {
                    b.Navigation("Enfermidades_Pacientes");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Paciente", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Enfermidades");

                    b.Navigation("Paciente_Relacionamentos");

                    b.Navigation("Relatorio_Diarios");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Pessoa", b =>
                {
                    b.Navigation("Contatos");

                    b.Navigation("RelacionamentosMedico");

                    b.Navigation("RelacionamentosPaciente");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Pessoa_Tipo", b =>
                {
                    b.Navigation("Pessoas");
                });

            modelBuilder.Entity("AssistenteMedicoSenior.Models.Questionario_Medico", b =>
                {
                    b.Navigation("Respostas_Questionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
