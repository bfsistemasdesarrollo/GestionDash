using System;
using System.Collections.Generic;
using GestionDash.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionDash.Server.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alimento> Alimentos { get; set; }

    public virtual DbSet<Anualart> Anualarts { get; set; }

    public virtual DbSet<Arqlinea> Arqlineas { get; set; }

    public virtual DbSet<Arqueo> Arqueos { get; set; }

    public virtual DbSet<Artdeposito> Artdepositos { get; set; }

    public virtual DbSet<Artdescuento> Artdescuentos { get; set; }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<Artimpret> Artimprets { get; set; }

    public virtual DbSet<Artinven> Artinvens { get; set; }

    public virtual DbSet<Artprecio> Artprecios { get; set; }

    public virtual DbSet<Artstock> Artstocks { get; set; }

    public virtual DbSet<Auditor> Auditors { get; set; }

    public virtual DbSet<Autvenart> Autvenarts { get; set; }

    public virtual DbSet<Autventa> Autventas { get; set; }

    public virtual DbSet<Billete> Billetes { get; set; }

    public virtual DbSet<Cae> Caes { get; set; }

    public virtual DbSet<Centrocosto> Centrocostos { get; set; }

    public virtual DbSet<Clidicose> Clidicoses { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Cligrupoafi> Cligrupoafis { get; set; }

    public virtual DbSet<Clinota> Clinotas { get; set; }

    public virtual DbSet<Clisaldo> Clisaldos { get; set; }

    public virtual DbSet<Cobrador> Cobradors { get; set; }

    public virtual DbSet<Codigocfe> Codigocves { get; set; }

    public virtual DbSet<Control> Controls { get; set; }

    public virtual DbSet<Costoope> Costoopes { get; set; }

    public virtual DbSet<Deposito> Depositos { get; set; }

    public virtual DbSet<Desctasa> Desctasas { get; set; }

    public virtual DbSet<Descuento> Descuentos { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Entrega> Entregas { get; set; }

    public virtual DbSet<Entregaslinea> Entregaslineas { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Forcomponente> Forcomponentes { get; set; }

    public virtual DbSet<Forhispre> Forhispres { get; set; }

    public virtual DbSet<Forinven> Forinvens { get; set; }

    public virtual DbSet<Formapago> Formapagos { get; set; }

    public virtual DbSet<Formatprima> Formatprimas { get; set; }

    public virtual DbSet<Formula> Formulas { get; set; }

    public virtual DbSet<Forprecio> Forprecios { get; set; }

    public virtual DbSet<Forregistro> Forregistros { get; set; }

    public virtual DbSet<Gruafiforpago> Gruafiforpagos { get; set; }

    public virtual DbSet<Gruafinidad> Gruafinidads { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<Grupocli> Grupoclis { get; set; }

    public virtual DbSet<HistorialEliminado> HistorialEliminados { get; set; }

    public virtual DbSet<Impresora> Impresoras { get; set; }

    public virtual DbSet<Impuesto> Impuestos { get; set; }

    public virtual DbSet<Impuestos1> Impuestos1s { get; set; }

    public virtual DbSet<Laboratorio> Laboratorios { get; set; }

    public virtual DbSet<Lisprecio> Lisprecios { get; set; }

    public virtual DbSet<Lispresubsec> Lispresubsecs { get; set; }

    public virtual DbSet<Localidad> Localidads { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Matprima> Matprimas { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<Monedas1> Monedas1s { get; set; }

    public virtual DbSet<Movcuota> Movcuotas { get; set; }

    public virtual DbSet<Movdocafectado> Movdocafectados { get; set; }

    public virtual DbSet<Movdocumento> Movdocumentos { get; set; }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<Movrubro> Movrubros { get; set; }

    public virtual DbSet<Movstock> Movstocks { get; set; }

    public virtual DbSet<Numera> Numeras { get; set; }

    public virtual DbSet<Ordene> Ordenes { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Planprod> Planprods { get; set; }

    public virtual DbSet<Plazoscli> Plazosclis { get; set; }

    public virtual DbSet<Preimpreso> Preimpresos { get; set; }

    public virtual DbSet<GestionDash.Server.Models.Program> Programs { get; set; }

    public virtual DbSet<Pronota> Pronotas { get; set; }

    public virtual DbSet<Prosaldo> Prosaldos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Reparto> Repartos { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<Saldocaja> Saldocajas { get; set; }

    public virtual DbSet<Saldorubro> Saldorubros { get; set; }

    public virtual DbSet<Seccione> Secciones { get; set; }

    public virtual DbSet<Segtipmov> Segtipmovs { get; set; }

    public virtual DbSet<Seguri> Seguris { get; set; }

    public virtual DbSet<Seguri1> Seguri1s { get; set; }

    public virtual DbSet<Subsec> Subsecs { get; set; }

    public virtual DbSet<Sucursale> Sucursales { get; set; }

    public virtual DbSet<Tasasint> Tasasints { get; set; }

    public virtual DbSet<Tasasintmon> Tasasintmons { get; set; }

    public virtual DbSet<Tipcli> Tipclis { get; set; }

    public virtual DbSet<Tipmov> Tipmovs { get; set; }

    public virtual DbSet<Tipmovret> Tipmovrets { get; set; }

    public virtual DbSet<Tipo> Tipos { get; set; }

    public virtual DbSet<Tiponota> Tiponotas { get; set; }

    public virtual DbSet<Titulo> Titulos { get; set; }

    public virtual DbSet<Unidade> Unidades { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    public virtual DbSet<Vehtarea> Vehtareas { get; set; }

    public virtual DbSet<Zona> Zonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Alimento>(entity =>
        {
            entity.HasKey(e => new { e.ArtNro, e.AliMatPriNro }).HasName("PK__ALIMENTO__0D827E71513AFB4D");

            entity.ToTable("ALIMENTOS", tb => tb.HasTrigger("trg_ALIMENTOS_Delete"));

            entity.HasIndex(e => e.AliMatPriNro, "IALIMENTOS2");

            entity.Property(e => e.AliMatPriPor).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Anualart>(entity =>
        {
            entity.HasKey(e => new { e.ArtNro, e.ArtMes }).HasName("PK__ANUALART__054A6B5C18027DF1");

            entity.ToTable("ANUALART", tb => tb.HasTrigger("trg_ANUALART_Delete"));

            entity.Property(e => e.ArtMes).HasColumnType("datetime");
            entity.Property(e => e.ArtCant).HasColumnType("money");
        });

        modelBuilder.Entity<Arqlinea>(entity =>
        {
            entity.HasKey(e => new { e.ArqFecha, e.ArqSucCod, e.ArqMonCod, e.ArqLinea }).HasName("PK__ARQLINEA__29EA0B0832B6742D");

            entity.ToTable("ARQLINEAS", tb => tb.HasTrigger("trg_ARQLINEAS_Delete"));

            entity.HasIndex(e => e.ArqBilNro, "IARQLINEAS1");

            entity.Property(e => e.ArqFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<Arqueo>(entity =>
        {
            entity.HasKey(e => new { e.ArqFecha, e.ArqSucCod, e.ArqMonCod }).HasName("PK__ARQUEOS__61170F8B2EE5E349");

            entity.ToTable("ARQUEOS", tb => tb.HasTrigger("trg_ARQUEOS_Delete"));

            entity.HasIndex(e => e.ArqMonCod, "IARQUEOS1");

            entity.HasIndex(e => e.ArqSucCod, "IARQUEOS2");

            entity.Property(e => e.ArqFecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<Artdeposito>(entity =>
        {
            entity.HasKey(e => new { e.ArtNro, e.ArtDnro }).HasName("PK__ARTDEPOS__27EDF77653584DE9");

            entity.ToTable("ARTDEPOSITOS", tb => tb.HasTrigger("trg_ARTDEPOSITOS_Delete"));

            entity.HasIndex(e => e.ArtDnro, "IARTDEPO2");

            entity.Property(e => e.ArtDnro).HasColumnName("ArtDNro");
            entity.Property(e => e.ArtDact)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ArtDAct");
            entity.Property(e => e.ArtDstkIni)
                .HasColumnType("money")
                .HasColumnName("ArtDStkIni");
        });

        modelBuilder.Entity<Artdescuento>(entity =>
        {
            entity.HasKey(e => new { e.ArtNro, e.ArtDesCod }).HasName("PK__ARTDESCU__952447345AF96FB1");

            entity.ToTable("ARTDESCUENTOS", tb => tb.HasTrigger("trg_ARTDESCUENTOS_Delete"));

            entity.HasIndex(e => e.ArtDesCod, "IARTICULOSDESC12");
        });

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.ArtNro).HasName("PK__ARTICULO__FAB2EFBC4BB72C21");

            entity.ToTable("ARTICULOS", tb => tb.HasTrigger("trg_ARTICULOS_Delete"));

            entity.HasIndex(e => e.ArtCodigo, "IARTCOD");

            entity.HasIndex(e => e.ArtDes, "IARTDES");

            entity.HasIndex(e => e.ArtCosOpeC, "IARTICULOS2");

            entity.HasIndex(e => e.ArtImpCod, "IARTICULOS4");

            entity.HasIndex(e => new { e.ArtLabNro, e.ArtDes }, "IARTLABD");

            entity.HasIndex(e => new { e.ArtSecNro, e.ArtSsecNro, e.ArtDes }, "IARTSSDES");

            entity.Property(e => e.ArtNro).ValueGeneratedNever();
            entity.Property(e => e.ArtCodBar)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtCodigo)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtConVta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtCos30).HasColumnType("money");
            entity.Property(e => e.ArtCosInv).HasColumnType("money");
            entity.Property(e => e.ArtDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtEquiv).HasColumnType("smallmoney");
            entity.Property(e => e.ArtEsDto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtInven)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtLibre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtLista)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtModValor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtNota)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.ArtPreCosto).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.ArtPreFlete).HasColumnType("smallmoney");
            entity.Property(e => e.ArtPrePond).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.ArtPresen)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtPuntos).HasColumnType("smallmoney");
            entity.Property(e => e.ArtReceta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtRedondeo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtSecNro)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtSsecNro)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ArtSSecNro");
            entity.Property(e => e.ArtStkMin).HasColumnType("money");
            entity.Property(e => e.ArtStock).HasColumnType("money");
            entity.Property(e => e.ArtUniCan).HasColumnType("smallmoney");
            entity.Property(e => e.ArtVen2).HasColumnType("datetime");
            entity.Property(e => e.ArtVence).HasColumnType("datetime");
        });

        modelBuilder.Entity<Artimpret>(entity =>
        {
            entity.HasKey(e => new { e.ArtNro, e.ArtImpRet }).HasName("PK__ARTIMPRE__465124F93A5795F5");

            entity.ToTable("ARTIMPRET", tb => tb.HasTrigger("trg_ARTIMPRET_Delete"));

            entity.Property(e => e.ArtRetTasa).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Artinven>(entity =>
        {
            entity.HasKey(e => new { e.ArtNro, e.ArtDnro, e.ArtDfch }).HasName("PK__ARTINVEN__B005BECA681E60A5");

            entity.ToTable("ARTINVEN", tb => tb.HasTrigger("trg_ARTINVEN_Delete"));

            entity.HasIndex(e => new { e.ArtNro, e.ArtDfch }, "IARTFCHINV");

            entity.Property(e => e.ArtDnro).HasColumnName("ArtDNro");
            entity.Property(e => e.ArtDfch)
                .HasColumnType("datetime")
                .HasColumnName("ArtDFch");
            entity.Property(e => e.ArtInvPenEnt).HasColumnType("money");
            entity.Property(e => e.ArtInvPenRec).HasColumnType("money");
            entity.Property(e => e.ArtInvReal).HasColumnType("money");
        });

        modelBuilder.Entity<Artprecio>(entity =>
        {
            entity.HasKey(e => new { e.ArtNro, e.ArtLisPreNro }).HasName("PK__ARTPRECI__7B84D8134F87BD05");

            entity.ToTable("ARTPRECIOS", tb => tb.HasTrigger("trg_ARTPRECIOS_Delete"));

            entity.HasIndex(e => e.ArtLisPreNro, "IARTPRECIOS2");

            entity.Property(e => e.ArtLisFePre).HasColumnType("datetime");
            entity.Property(e => e.ArtLisPor).HasColumnType("smallmoney");
            entity.Property(e => e.ArtLporAct)
                .HasColumnType("smallmoney")
                .HasColumnName("ArtLPorAct");
            entity.Property(e => e.ArtPreAnt).HasColumnType("money");
            entity.Property(e => e.ArtPrecio).HasColumnType("money");
        });

        modelBuilder.Entity<Artstock>(entity =>
        {
            entity.HasKey(e => e.ArtCodAnt).HasName("PK__ARTSTOCK__4A184FDB2374309D");

            entity.ToTable("ARTSTOCK", tb => tb.HasTrigger("trg_ARTSTOCK_Delete"));

            entity.Property(e => e.ArtCodAnt)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ArtStkAnt).HasColumnType("money");
        });

        modelBuilder.Entity<Auditor>(entity =>
        {
            entity.HasKey(e => e.AudNro).HasName("PK__AUDITOR__9C01316271DCD509");

            entity.ToTable("AUDITOR", tb => tb.HasTrigger("trg_AUDITOR_Delete"));

            entity.HasIndex(e => e.AudUsuCod, "IAUDITOR1");

            entity.Property(e => e.AudNro).ValueGeneratedNever();
            entity.Property(e => e.AudEvento)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudFchIng).HasColumnType("datetime");
            entity.Property(e => e.AudFecha).HasColumnType("datetime");
            entity.Property(e => e.AudHora)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudMovFch).HasColumnType("datetime");
            entity.Property(e => e.AudNota)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudPrograma)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudRubro)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudTipCta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudTipo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AudTmovCod).HasColumnName("AudTMovCod");
            entity.Property(e => e.AudValAnt).HasColumnType("money");
            entity.Property(e => e.AudValor).HasColumnType("money");
        });

        modelBuilder.Entity<Autvenart>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.AutMovNro, e.AutArtLin }).HasName("PK__AUTVENAR__31B51CCB10615C29");

            entity.ToTable("AUTVENART", tb => tb.HasTrigger("trg_AUTVENART_Delete"));

            entity.HasIndex(e => e.AutForCod, "IAUTVENART1");

            entity.HasIndex(e => e.AutArtNro, "IAUTVENART2");

            entity.HasIndex(e => e.AutDepNro, "IAUTVENART4");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.AutArtCan).HasColumnType("money");
            entity.Property(e => e.AutArtDet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutArtEntre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutArtImpu).HasColumnType("money");
            entity.Property(e => e.AutArtLote)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutArtNeto).HasColumnType("money");
            entity.Property(e => e.AutArtPorDto).HasColumnType("smallmoney");
            entity.Property(e => e.AutArtPreLis).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.AutArtPrecio).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.AutArtRecInt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutArtReceta)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutForEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutRecResp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Autventa>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.AutMovNro }).HasName("PK__AUTVENTA__7BB87AA10C90CB45");

            entity.ToTable("AUTVENTAS", tb => tb.HasTrigger("trg_AUTVENTAS_Delete"));

            entity.HasIndex(e => e.AutLisPreNro, "IAUTVENTAS1");

            entity.HasIndex(e => e.AutSucCod, "IAUTVENTAS10");

            entity.HasIndex(e => e.AutCenCosC, "IAUTVENTAS11");

            entity.HasIndex(e => e.AutCliNro, "IAUTVENTAS2");

            entity.HasIndex(e => e.AutUsuAuC, "IAUTVENTAS3");

            entity.HasIndex(e => e.AutUsuFac, "IAUTVENTAS4");

            entity.HasIndex(e => e.AutForPnro, "IAUTVENTAS5");

            entity.HasIndex(e => e.AutMonCod, "IAUTVENTAS6");

            entity.HasIndex(e => e.AutUsuCod, "IAUTVENTAS8");

            entity.HasIndex(e => e.AutUsuVen, "IAUTVENTAS9");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.AutCenCosC)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutDirCobro)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutDirEnvio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutFchAut).HasColumnType("datetime");
            entity.Property(e => e.AutFchEnt).HasColumnType("datetime");
            entity.Property(e => e.AutFchIng).HasColumnType("datetime");
            entity.Property(e => e.AutForPnro).HasColumnName("AutForPNro");
            entity.Property(e => e.AutHorEnt)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutImpresora)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutLocalidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMot1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMot2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMot3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMovCot).HasColumnType("smallmoney");
            entity.Property(e => e.AutMovCp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AutMovCP");
            entity.Property(e => e.AutMovDocu)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMovEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMovFch).HasColumnType("datetime");
            entity.Property(e => e.AutMovNota)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMovOrden)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMovRem)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutMovTotal).HasColumnType("money");
            entity.Property(e => e.AutMovVen).HasColumnType("datetime");
            entity.Property(e => e.AutOriGen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutResponsable)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutTelOri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.AutTotFac).HasColumnType("money");
        });

        modelBuilder.Entity<Billete>(entity =>
        {
            entity.HasKey(e => e.BilNro).HasName("PK__BILLETES__7834AAE42B155265");

            entity.ToTable("BILLETES", tb => tb.HasTrigger("trg_BILLETES_Delete"));

            entity.Property(e => e.BilNro).ValueGeneratedNever();
            entity.Property(e => e.BilActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BilDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Cae>(entity =>
        {
            entity.HasKey(e => e.Caenro).HasName("PK__CAE__AF91F19B7760A435");

            entity.ToTable("CAE", tb => tb.HasTrigger("trg_CAE_Delete"));

            entity.HasIndex(e => e.Caecfetipo, "ICAE1");

            entity.Property(e => e.Caenro)
                .HasColumnType("decimal(12, 0)")
                .HasColumnName("CAENro");
            entity.Property(e => e.Caecfetipo).HasColumnName("CAECFETipo");
            entity.Property(e => e.Caeestado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CAEEstado");
            entity.Property(e => e.CaenroDesde).HasColumnName("CAENroDesde");
            entity.Property(e => e.CaenroHasta).HasColumnName("CAENroHasta");
            entity.Property(e => e.Caeserie)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CAESerie");
            entity.Property(e => e.Caestandard)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CAEStandard");
            entity.Property(e => e.CaeultNumero).HasColumnName("CAEUltNumero");
            entity.Property(e => e.Caevencimiento)
                .HasColumnType("datetime")
                .HasColumnName("CAEVencimiento");
        });

        modelBuilder.Entity<Centrocosto>(entity =>
        {
            entity.HasKey(e => e.CenCosCod).HasName("PK__CENTROCO__9AABE00673901351");

            entity.ToTable("CENTROCOSTOS", tb => tb.HasTrigger("trg_CENTROCOSTOS_Delete"));

            entity.Property(e => e.CenCosCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CenCosDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CenCosEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CenCosNota)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CenCosPar)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Clidicose>(entity =>
        {
            entity.HasKey(e => new { e.CliNro, e.CliDicose }).HasName("PK__CLIDICOS__AD85B20E0ADD8CFD");

            entity.ToTable("CLIDICOSE", tb => tb.HasTrigger("trg_CLIDICOSE_Delete"));

            entity.HasIndex(e => e.CliDicLoc, "ICLIDICOSE");

            entity.Property(e => e.CliDicose)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliDicNota)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.CliNro).HasName("PK__CLIENTES__8F14E0383FDB6521");

            entity.ToTable("CLIENTES", tb => tb.HasTrigger("trg_CLIENTES_Delete"));

            entity.HasIndex(e => e.CliCedula, "ICLICEDULA");

            entity.HasIndex(e => e.CliLocCod1, "ICLIENTES10");

            entity.HasIndex(e => e.CliLocCod2, "ICLIENTES11");

            entity.HasIndex(e => e.TipCliNro, "ICLIENTES2");

            entity.HasIndex(e => e.CliCobNro, "ICLIENTES3");

            entity.HasIndex(e => e.CliLisPre, "ICLIENTES4");

            entity.HasIndex(e => e.CliMonCod, "ICLIENTES5");

            entity.HasIndex(e => e.CliUsuCod, "ICLIENTES6");

            entity.HasIndex(e => e.CliGrupo, "ICLIENTES7");

            entity.HasIndex(e => e.PlazoCod, "ICLIENTES8");

            entity.HasIndex(e => e.TasaNro, "ICLIENTES9");

            entity.HasIndex(e => e.CliNom, "ICLINOM");

            entity.HasIndex(e => e.CliRazSoc, "ICLIRSOC");

            entity.HasIndex(e => e.CliRut, "ICLIRUT");

            entity.Property(e => e.CliNro).ValueGeneratedNever();
            entity.Property(e => e.CliActiva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliAdic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliAutor)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliCcmail)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CliCCMail");
            entity.Property(e => e.CliCedula)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliCel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliConforme)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliContacto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliDir)
                .HasMaxLength(70)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliDir2)
                .HasMaxLength(70)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliEnvFacWapp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CliEnvFacWApp");
            entity.Property(e => e.CliEnvMail)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliFecAut).HasColumnType("datetime");
            entity.Property(e => e.CliFecIng).HasColumnType("datetime");
            entity.Property(e => e.CliFecPago).HasColumnType("datetime");
            entity.Property(e => e.CliFecUlt).HasColumnType("datetime");
            entity.Property(e => e.CliInteres)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliMail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliNom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliRazSoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliRut)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CliRUT");
            entity.Property(e => e.CliTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliTel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliTipoCta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliTipoTope)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliTope).HasColumnType("money");
            entity.Property(e => e.PlazoCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Cligrupoafi>(entity =>
        {
            entity.HasKey(e => new { e.CliNro, e.CliGruAfiNro }).HasName("PK__CLIGRUPO__8C8B510D47E69B3D");

            entity.ToTable("CLIGRUPOAFI", tb => tb.HasTrigger("trg_CLIGRUPOAFI_Delete"));

            entity.HasIndex(e => e.CliGruAfiNro, "ICLIGRUAFI12");
        });

        modelBuilder.Entity<Clinota>(entity =>
        {
            entity.HasKey(e => new { e.CliNro, e.CliNotaNro }).HasName("PK__CLINOTAS__A02D7BB90EAE1DE1");

            entity.ToTable("CLINOTAS", tb => tb.HasTrigger("trg_CLINOTAS_Delete"));

            entity.HasIndex(e => e.CliNotaFpen, "CLIFECHAPEN");

            entity.HasIndex(e => e.CliNotaTipo, "ICLINOTAS");

            entity.HasIndex(e => e.CliNotaUsu, "ICLINOTAS1");

            entity.Property(e => e.CliAutCed)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliAutNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliNotaAut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliNotaDet)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliNotaEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CliNotaFecha).HasColumnType("datetime");
            entity.Property(e => e.CliNotaFpen)
                .HasColumnType("datetime")
                .HasColumnName("CliNotaFPen");
            entity.Property(e => e.CliNotaTipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Clisaldo>(entity =>
        {
            entity.HasKey(e => new { e.CliNro, e.CliSalMon }).HasName("PK__CLISALDO__CB82605C797DF6D1");

            entity.ToTable("CLISALDOS", tb => tb.HasTrigger("trg_CLISALDOS_Delete"));

            entity.Property(e => e.CliFecAtr).HasColumnType("datetime");
            entity.Property(e => e.CliSalAnt).HasColumnType("money");
        });

        modelBuilder.Entity<Cobrador>(entity =>
        {
            entity.HasKey(e => e.CobNro).HasName("PK__COBRADOR__74D32CC660E75331");

            entity.ToTable("COBRADOR", tb => tb.HasTrigger("trg_COBRADOR_Delete"));

            entity.Property(e => e.CobNro).ValueGeneratedNever();
            entity.Property(e => e.CobCel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CobDir)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CobNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CobPorcen).HasColumnType("smallmoney");
            entity.Property(e => e.CobTel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Codigocfe>(entity =>
        {
            entity.HasKey(e => e.Cfecodigo).HasName("PK__CODIGOCF__E1040A3D7B313519");

            entity.ToTable("CODIGOCFE", tb => tb.HasTrigger("trg_CODIGOCFE_Delete"));

            entity.Property(e => e.Cfecodigo)
                .ValueGeneratedNever()
                .HasColumnName("CFECodigo");
            entity.Property(e => e.Cfeconting)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CFEConting");
            entity.Property(e => e.Cfedesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CFEDesc");
        });

        modelBuilder.Entity<Control>(entity =>
        {
            entity.HasKey(e => e.CtrlPc).HasName("PK__CONTROL__A5E765B84DD47EBD");

            entity.ToTable("CONTROL", tb => tb.HasTrigger("trg_CONTROL_Delete"));

            entity.Property(e => e.CtrlPc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CtrlPC");
            entity.Property(e => e.CtrImpCdo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CtrImpCre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CtrImpRec)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CtrImpRem)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CtrlBf)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CtrlBF");
        });

        modelBuilder.Entity<Costoope>(entity =>
        {
            entity.HasKey(e => e.CosOpeCod).HasName("PK__COSTOOPE__4BDFAF4541F8B7BD");

            entity.ToTable("COSTOOPE", tb => tb.HasTrigger("trg_COSTOOPE_Delete"));

            entity.Property(e => e.CosOpeCod).ValueGeneratedNever();
            entity.Property(e => e.CosOpeDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CosOpeVal).HasColumnType("money");
        });

        modelBuilder.Entity<Deposito>(entity =>
        {
            entity.HasKey(e => e.DepNro).HasName("PK__DEPOSITO__4D39831D1A1FD08D");

            entity.ToTable("DEPOSITOS", tb => tb.HasTrigger("trg_DEPOSITOS_Delete"));

            entity.Property(e => e.DepNro).ValueGeneratedNever();
            entity.Property(e => e.DepAcEnt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DepDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DepDirec)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DepForImp)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DepTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Desctasa>(entity =>
        {
            entity.HasKey(e => new { e.DesCod, e.DesFecha }).HasName("PK__DESCTASA__7AC39A8A34D3C6C9");

            entity.ToTable("DESCTASAS", tb => tb.HasTrigger("trg_DESCTASAS_Delete"));

            entity.Property(e => e.DesFecha).HasColumnType("datetime");
            entity.Property(e => e.DesFePor).HasColumnType("decimal(7, 4)");
        });

        modelBuilder.Entity<Descuento>(entity =>
        {
            entity.HasKey(e => e.DesCod).HasName("PK__DESCUENT__F3D15FEE310335E5");

            entity.ToTable("DESCUENTOS", tb => tb.HasTrigger("trg_DESCUENTOS_Delete"));

            entity.HasIndex(e => e.DesArtNro, "IDESCUENTOS1");

            entity.Property(e => e.DesCod).ValueGeneratedNever();
            entity.Property(e => e.DesDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DesGral)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DesPorcen).HasColumnType("decimal(7, 4)");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.EmpCod).HasName("PK__EMPRESA__D0EB733F5575A085");

            entity.ToTable("EMPRESA", tb => tb.HasTrigger("trg_EMPRESA_Delete"));

            entity.Property(e => e.EmpCod).ValueGeneratedNever();
            entity.Property(e => e.EmiCiudad)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiComercial)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiCorreoEmisor)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiDepartamento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiDomFiscal)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiGiroEmis)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiMontoMinimo).HasColumnType("money");
            entity.Property(e => e.EmiRznSoc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiSucursal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiTelefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmiTelefono2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpAlogo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpALogo");
            entity.Property(e => e.EmpAplicaDto)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpBaseUrl)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpBaseURL");
            entity.Property(e => e.EmpBddataSource)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpBDDataSource");
            entity.Property(e => e.EmpBdinitialCatalog)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpBDInitialCatalog");
            entity.Property(e => e.EmpBdpassword)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpBDPassword");
            entity.Property(e => e.EmpBduserId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpBDUserId");
            entity.Property(e => e.EmpCarpetaQr)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpCarpetaQR");
            entity.Property(e => e.EmpCenCos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpCfecontingencia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpCFEContingencia");
            entity.Property(e => e.EmpCfefechaValorUi)
                .HasColumnType("datetime")
                .HasColumnName("EmpCFEFechaValorUI");
            entity.Property(e => e.EmpClaveAcc)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpClfrm).HasColumnName("EmpCLFrm");
            entity.Property(e => e.EmpCodigo).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.EmpConSuc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpCupon).HasColumnType("smallmoney");
            entity.Property(e => e.EmpDesCup).HasColumnType("datetime");
            entity.Property(e => e.EmpDir)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpFax)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpFeCaja).HasColumnType("datetime");
            entity.Property(e => e.EmpFeCie).HasColumnType("datetime");
            entity.Property(e => e.EmpFeCos).HasColumnType("datetime");
            entity.Property(e => e.EmpFeInv).HasColumnType("datetime");
            entity.Property(e => e.EmpHasCup).HasColumnType("datetime");
            entity.Property(e => e.EmpHost)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpImpCdo)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpImpCre)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpImpRec)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpImpRem)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpIntMdo)
                .HasColumnType("smallmoney")
                .HasColumnName("EmpIntMDo");
            entity.Property(e => e.EmpIntMpe)
                .HasColumnType("smallmoney")
                .HasColumnName("EmpIntMPe");
            entity.Property(e => e.EmpMail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpMaut).HasColumnName("EmpMAut");
            entity.Property(e => e.EmpMmail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpMMail");
            entity.Property(e => e.EmpMmailRespuesta)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpMMailRespuesta");
            entity.Property(e => e.EmpMmailcopia)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpMMailcopia");
            entity.Property(e => e.EmpMnom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpMNom");
            entity.Property(e => e.EmpMpass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpMPass");
            entity.Property(e => e.EmpMport).HasColumnName("EmpMPort");
            entity.Property(e => e.EmpMsec).HasColumnName("EmpMSec");
            entity.Property(e => e.EmpMser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpMSer");
            entity.Property(e => e.EmpMtiem).HasColumnName("EmpMTiem");
            entity.Property(e => e.EmpMusu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpMUsu");
            entity.Property(e => e.EmpNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpNotEc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpNotEC");
            entity.Property(e => e.EmpNotEc2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpNotEC2");
            entity.Property(e => e.EmpNota)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpParAdic)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpPk)
                .HasMaxLength(32)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpPK");
            entity.Property(e => e.EmpPlim).HasColumnName("EmpPLim");
            entity.Property(e => e.EmpPorDtoA).HasColumnType("smallmoney");
            entity.Property(e => e.EmpPorDtoB).HasColumnType("smallmoney");
            entity.Property(e => e.EmpRedMe)
                .HasColumnType("smallmoney")
                .HasColumnName("EmpRedME");
            entity.Property(e => e.EmpRedMn)
                .HasColumnType("smallmoney")
                .HasColumnName("EmpRedMN");
            entity.Property(e => e.EmpResolAutDgi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpResolAutDGI");
            entity.Property(e => e.EmpRut)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpTel)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EmpTfs)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpTFS");
            entity.Property(e => e.EmpTlogo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpTLogo");
            entity.Property(e => e.EmpTred).HasColumnName("EmpTRed");
            entity.Property(e => e.EmpWappHost)
                .HasMaxLength(120)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWAppHost");
            entity.Property(e => e.EmpWappUrl)
                .HasMaxLength(120)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWAppURL");
            entity.Property(e => e.EmpWsAceptacionRecibidos)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWS_AceptacionRecibidos");
            entity.Property(e => e.EmpWsAnulacionFactura)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWS_AnulacionFactura");
            entity.Property(e => e.EmpWsConsultaFactura)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWS_ConsultaFactura");
            entity.Property(e => e.EmpWsConsultaRecibidos)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWS_ConsultaRecibidos");
            entity.Property(e => e.EmpWsDescargaRecibidos)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWS_DescargaRecibidos");
            entity.Property(e => e.EmpWsEmisionFactura)
                .HasMaxLength(80)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EmpWS_EmisionFactura");
            entity.Property(e => e.EmpWww)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Entrega>(entity =>
        {
            entity.HasKey(e => e.EntDoc).HasName("PK__ENTREGAS__0A01A79E04EFA97D");

            entity.ToTable("ENTREGAS", tb => tb.HasTrigger("trg_ENTREGAS_Delete"));

            entity.HasIndex(e => e.UsuCod, "IENTREGAS2");

            entity.HasIndex(e => e.CliNro, "IENTREGAS3");

            entity.Property(e => e.EntDoc).ValueGeneratedNever();
            entity.Property(e => e.EntFec).HasColumnType("datetime");
            entity.Property(e => e.EntFini)
                .HasColumnType("datetime")
                .HasColumnName("EntFIni");
            entity.Property(e => e.EntHini)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EntHIni");
            entity.Property(e => e.EntNota)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EntTip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Entregaslinea>(entity =>
        {
            entity.HasKey(e => new { e.EntDoc, e.EntNoLin }).HasName("PK__ENTREGAS__12B1B27708C03A61");

            entity.ToTable("ENTREGASLINEAS", tb => tb.HasTrigger("trg_ENTREGASLINEAS_Delete"));

            entity.HasIndex(e => e.EntLote, "IENTLOTE");

            entity.HasIndex(e => new { e.EntDoc, e.TmovCod, e.MovNro }, "IENTMOV");

            entity.HasIndex(e => new { e.TmovCod, e.MovNro, e.MovArtLin }, "IENTREGASLINEAS1");

            entity.Property(e => e.EntCan).HasColumnType("money");
            entity.Property(e => e.EntLote)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => new { e.SproCod, e.SeveNom }).HasName("PK__EVENTOS__8BAB529236F11965");

            entity.ToTable("EVENTOS", tb => tb.HasTrigger("trg_EVENTOS_Delete"));

            entity.Property(e => e.SproCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SProCod");
            entity.Property(e => e.SeveNom)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEveNom");
            entity.Property(e => e.SeveAud)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEveAud");
            entity.Property(e => e.SeveDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEveDes");
            entity.Property(e => e.SeveDoble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEveDoble");
        });

        modelBuilder.Entity<Forcomponente>(entity =>
        {
            entity.HasKey(e => new { e.ForCod, e.ForComArtNro }).HasName("PK__FORCOMPO__085572E145C948A1");

            entity.ToTable("FORCOMPONENTES", tb => tb.HasTrigger("trg_FORCOMPONENTES_Delete"));

            entity.HasIndex(e => e.ForComArtNro, "IFORMULASLEVEL12");

            entity.Property(e => e.ForComCant).HasColumnType("decimal(9, 4)");
        });

        modelBuilder.Entity<Forhispre>(entity =>
        {
            entity.HasKey(e => new { e.ForCod, e.ForFePrecio, e.ForFeLin }).HasName("PK__FORHISPR__9D364F78607D3EDD");

            entity.ToTable("FORHISPRE", tb => tb.HasTrigger("trg_FORHISPRE_Delete"));

            entity.Property(e => e.ForFePrecio).HasColumnType("datetime");
            entity.Property(e => e.ForCosFlete).HasColumnType("money");
            entity.Property(e => e.ForCosto).HasColumnType("money");
            entity.Property(e => e.ForPreCon).HasColumnType("money");
            entity.Property(e => e.ForPreConEsp).HasColumnType("money");
            entity.Property(e => e.ForPreCre1).HasColumnType("money");
            entity.Property(e => e.ForPreCre2).HasColumnType("money");
        });

        modelBuilder.Entity<Forinven>(entity =>
        {
            entity.HasKey(e => new { e.ForCod, e.ForInvDepNro, e.ForInvDepFch }).HasName("PK__FORINVEN__38763E016BEEF189");

            entity.ToTable("FORINVEN", tb => tb.HasTrigger("trg_FORINVEN_Delete"));

            entity.HasIndex(e => new { e.ForCod, e.ForInvDepFch }, "IFORFCH");

            entity.HasIndex(e => e.ForInvDepNro, "IFORINVEN2");

            entity.Property(e => e.ForInvDepFch).HasColumnType("datetime");
            entity.Property(e => e.ForInvStkPen).HasColumnType("money");
            entity.Property(e => e.ForInvStkReal).HasColumnType("money");
        });

        modelBuilder.Entity<Formapago>(entity =>
        {
            entity.HasKey(e => e.ForPagNro).HasName("PK__FORMAPAG__5BCE8F145728DECD");

            entity.ToTable("FORMAPAGO", tb => tb.HasTrigger("trg_FORMAPAGO_Delete"));

            entity.HasIndex(e => e.ForPagDcod, "IFORMAPAGO1");

            entity.HasIndex(e => e.ForRubCod, "IFORMAPAGO2");

            entity.Property(e => e.ForPagNro).ValueGeneratedNever();
            entity.Property(e => e.ForPagAct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagCdo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagCre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagDcod).HasColumnName("ForPagDCod");
            entity.Property(e => e.ForPagDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagEsp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagGen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagPos)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagRec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPagTip)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForRubCod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Formatprima>(entity =>
        {
            entity.HasKey(e => new { e.ForRegArt, e.ForMatPriNro }).HasName("PK__FORMATPR__80B4E31A58DC1D15");

            entity.ToTable("FORMATPRIMA", tb => tb.HasTrigger("trg_FORMATPRIMA_Delete"));

            entity.HasIndex(e => e.ForMatPriNro, "IFORREGMAT2");

            entity.Property(e => e.ForMatPriMax).HasColumnType("smallmoney");
            entity.Property(e => e.ForMatPriMin).HasColumnType("smallmoney");
            entity.Property(e => e.ForMatPriVal).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Formula>(entity =>
        {
            entity.HasKey(e => e.ForCod).HasName("PK__FORMULAS__8661CDED3E2826D9");

            entity.ToTable("FORMULAS", tb => tb.HasTrigger("trg_FORMULAS_Delete"));

            entity.HasIndex(e => e.ForArtNro, "IFORMULAS1");

            entity.HasIndex(e => e.ForCosOpeC, "IFORMULAS2");

            entity.Property(e => e.ForCod).ValueGeneratedNever();
            entity.Property(e => e.ForAct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForEquipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForEsBase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForLisPrecio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForModValor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForPrD).HasColumnType("money");
            entity.Property(e => e.ForPre).HasColumnType("money");
            entity.Property(e => e.ForTot).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.ForUltMod).HasColumnType("datetime");
        });

        modelBuilder.Entity<Forprecio>(entity =>
        {
            entity.HasKey(e => new { e.ForCod, e.ForLisPreNro }).HasName("PK__FORPRECI__DE32119B4999D985");

            entity.ToTable("FORPRECIOS", tb => tb.HasTrigger("trg_FORPRECIOS_Delete"));

            entity.HasIndex(e => e.ForLisPreNro, "IFORPRECIOSFORPRECIOS2");

            entity.Property(e => e.ForPreAnt).HasColumnType("money");
            entity.Property(e => e.ForPreFecha).HasColumnType("datetime");
            entity.Property(e => e.ForPrePor).HasColumnType("smallmoney");
            entity.Property(e => e.ForPrePorCal).HasColumnType("smallmoney");
            entity.Property(e => e.ForPrecio).HasColumnType("money");
        });

        modelBuilder.Entity<Forregistro>(entity =>
        {
            entity.HasKey(e => e.ForRegArt).HasName("PK__FORREGIS__0EDCE5B6550B8C31");

            entity.ToTable("FORREGISTRO", tb => tb.HasTrigger("trg_FORREGISTRO_Delete"));

            entity.Property(e => e.ForRegArt).ValueGeneratedNever();
            entity.Property(e => e.ForRegAct)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForRegFecha).HasColumnType("datetime");
            entity.Property(e => e.ForRegNota)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ForRegVence).HasColumnType("datetime");
        });

        modelBuilder.Entity<Gruafiforpago>(entity =>
        {
            entity.HasKey(e => new { e.GruAfiNro, e.GruAfiForPag }).HasName("PK__GRUAFIFO__F5C55FBB44160A59");

            entity.ToTable("GRUAFIFORPAGO", tb => tb.HasTrigger("trg_GRUAFIFORPAGO_Delete"));

            entity.HasIndex(e => e.GruAfiForPag, "IGRUAFIFORPAGO");
        });

        modelBuilder.Entity<Gruafinidad>(entity =>
        {
            entity.HasKey(e => e.GruAfiNro).HasName("PK__GRUAFINI__27FCF42740457975");

            entity.ToTable("GRUAFINIDAD", tb => tb.HasTrigger("trg_GRUAFINIDAD_Delete"));

            entity.Property(e => e.GruAfiNro).ValueGeneratedNever();
            entity.Property(e => e.GruAfiActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GruAfiCon)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GruAfiDir)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GruAfiMail)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GruAfiNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GruAfiNota).IsUnicode(false);
            entity.Property(e => e.GruAfiTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.HasKey(e => e.SgruCod).HasName("PK__GRUPOS__72BA4ABA3AC1AA49");

            entity.ToTable("GRUPOS", tb => tb.HasTrigger("trg_GRUPOS_Delete"));

            entity.HasIndex(e => e.SgruSucCod, "IGRUPOS1");

            entity.Property(e => e.SgruCod)
                .ValueGeneratedNever()
                .HasColumnName("SGruCod");
            entity.Property(e => e.SgruDes)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SGruDes");
            entity.Property(e => e.SgruSucCod).HasColumnName("SGruSucCod");
        });

        modelBuilder.Entity<Grupocli>(entity =>
        {
            entity.HasKey(e => e.GrupoNro).HasName("PK__GRUPOCLI__B2F6930D127EAEC5");

            entity.ToTable("GRUPOCLI", tb => tb.HasTrigger("trg_GRUPOCLI_Delete"));

            entity.HasIndex(e => e.GrupoNombre, "IGRUPONOM");

            entity.Property(e => e.GrupoNro).ValueGeneratedNever();
            entity.Property(e => e.GrupoContacto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoDirec)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoMail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoNombre)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoNota).IsUnicode(false);
            entity.Property(e => e.GrupoTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoTel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrupoTope).HasColumnType("money");
        });

        modelBuilder.Entity<HistorialEliminado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Historia__3214EC07B28C88C8");

            entity.ToTable("Historial_Eliminados");

            entity.Property(e => e.FechaEliminacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Tabla)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<Impresora>(entity =>
        {
            entity.HasKey(e => e.ImpFor).HasName("PK__IMPRESOR__D232151F1431ED0D");

            entity.ToTable("IMPRESORAS", tb => tb.HasTrigger("trg_IMPRESORAS_Delete"));

            entity.Property(e => e.ImpFor)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpNota)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpNroSer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpTip)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpTipNro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Impuesto>(entity =>
        {
            entity.HasKey(e => e.ImpCod).HasName("PK__IMPUESTO__D27E2F591D864D1D");

            entity.ToTable("IMPUESTO", tb => tb.HasTrigger("trg_IMPUESTO_Delete"));

            entity.HasIndex(e => e.ImpRubVco, "IIMPUESTO");

            entity.HasIndex(e => e.ImpRubCcod, "IIMPUESTO1");

            entity.HasIndex(e => e.ImpRubVcod, "IIMPUESTO2");

            entity.HasIndex(e => e.ImpRubVcr, "IIMPUESTO3");

            entity.HasIndex(e => e.ImpRubCc, "IIMPUESTO4");

            entity.Property(e => e.ImpCod).ValueGeneratedNever();
            entity.Property(e => e.ImpDes)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpDesCor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpEsIva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpExpAsim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ImpRubCc)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ImpRubCC");
            entity.Property(e => e.ImpRubCcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ImpRubCCod");
            entity.Property(e => e.ImpRubVco)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ImpRubVCo");
            entity.Property(e => e.ImpRubVcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ImpRubVCod");
            entity.Property(e => e.ImpRubVcr)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ImpRubVCr");
            entity.Property(e => e.ImpTasaActual).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Impuestos1>(entity =>
        {
            entity.HasKey(e => new { e.ImpCod, e.ImpFecha }).HasName("PK__IMPUESTO__43A34B54688874F9");

            entity.ToTable("IMPUESTOS1", tb => tb.HasTrigger("trg_IMPUESTOS1_Delete"));

            entity.Property(e => e.ImpFecha).HasColumnType("datetime");
            entity.Property(e => e.ImpTaPor).HasColumnType("smallmoney");
            entity.Property(e => e.ImpTasa).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Laboratorio>(entity =>
        {
            entity.HasKey(e => e.LabNro).HasName("PK__LABORATO__302CD2DE1DF06171");

            entity.ToTable("LABORATORIOS", tb => tb.HasTrigger("trg_LABORATORIOS_Delete"));

            entity.HasIndex(e => e.LabNombre, "ILABNOM");

            entity.Property(e => e.LabNro).ValueGeneratedNever();
            entity.Property(e => e.LabNomAnt)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LabNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Lisprecio>(entity =>
        {
            entity.HasKey(e => e.LisPreNro).HasName("PK__LISPRECI__47776D4D070CFC19");

            entity.ToTable("LISPRECIOS", tb => tb.HasTrigger("trg_LISPRECIOS_Delete"));

            entity.Property(e => e.LisPreNro).ValueGeneratedNever();
            entity.Property(e => e.LisPreAut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LisPreCon)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LisPreDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LisPreEsp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LisPreMas).HasColumnType("smallmoney");
            entity.Property(e => e.LisPreMen).HasColumnType("smallmoney");
            entity.Property(e => e.LisPrePesp)
                .HasColumnType("smallmoney")
                .HasColumnName("LisPrePEsp");
            entity.Property(e => e.LisPrePor).HasColumnType("smallmoney");
            entity.Property(e => e.LisPreTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LisPreTit)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Lispresubsec>(entity =>
        {
            entity.HasKey(e => new { e.LisPreNro, e.LisPreSec, e.LisPreSubSec }).HasName("PK__LISPRESU__5920F1DD644DCFC1");

            entity.ToTable("LISPRESUBSEC", tb => tb.HasTrigger("trg_LISPRESUBSEC_Delete"));

            entity.HasIndex(e => new { e.LisPreSec, e.LisPreSubSec }, "ILISPRECIOSLEVEL11");

            entity.Property(e => e.LisPreSec)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LisPreSubSec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LisPreSecEsp).HasColumnType("smallmoney");
            entity.Property(e => e.LisPreSecPor).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity.HasKey(e => e.LocCod).HasName("PK__LOCALIDA__FD947FD36C5905DD");

            entity.ToTable("LOCALIDAD", tb => tb.HasTrigger("trg_LOCALIDAD_Delete"));

            entity.HasIndex(e => e.PaisCod, "ILOCALIDAD1");

            entity.Property(e => e.LocCod).ValueGeneratedNever();
            entity.Property(e => e.LocCp).HasColumnName("LocCP");
            entity.Property(e => e.LocDepartamento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.LocNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaisCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.MarcaCod).HasName("PK__MARCA__A2052A3F02D256E1");

            entity.ToTable("MARCA", tb => tb.HasTrigger("trg_MARCA_Delete"));

            entity.Property(e => e.MarcaCod).ValueGeneratedNever();
            entity.Property(e => e.MarcaNom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Matprima>(entity =>
        {
            entity.HasKey(e => e.MatPriNro).HasName("PK__MATPRIMA__A5C59E5F4D6A6A69");

            entity.ToTable("MATPRIMAS", tb => tb.HasTrigger("trg_MATPRIMAS_Delete"));

            entity.Property(e => e.MatPriNro).ValueGeneratedNever();
            entity.Property(e => e.MatPriDchi)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MatPriDChi");
            entity.Property(e => e.MatPriDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Moneda>(entity =>
        {
            entity.HasKey(e => e.MonCod).HasName("PK__MONEDAS__C8041D6373FA27A5");

            entity.ToTable("MONEDAS", tb => tb.HasTrigger("trg_MONEDAS_Delete"));

            entity.HasIndex(e => e.MonDes, "IMONDES");

            entity.Property(e => e.MonCod).ValueGeneratedNever();
            entity.Property(e => e.CotFecVig).HasColumnType("datetime");
            entity.Property(e => e.CotVigente).HasColumnType("money");
            entity.Property(e => e.MonCodFe)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MonCodFE");
            entity.Property(e => e.MonDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MonSim)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Monedas1>(entity =>
        {
            entity.HasKey(e => new { e.MonCod, e.CotFecha }).HasName("PK__MONEDAS1__08D5F608702996C1");

            entity.ToTable("MONEDAS1", tb => tb.HasTrigger("trg_MONEDAS1_Delete"));

            entity.HasIndex(e => new { e.MonCod, e.CotFecha }, "IMONFEC").IsDescending(false, true);

            entity.Property(e => e.CotFecha).HasColumnType("datetime");
            entity.Property(e => e.CotCompra).HasColumnType("decimal(8, 4)");
            entity.Property(e => e.CotInter).HasColumnType("decimal(8, 4)");
            entity.Property(e => e.CotVenta).HasColumnType("decimal(8, 4)");
        });

        modelBuilder.Entity<Movcuota>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.MovNro, e.MovCuoLin }).HasName("PK__MOVCUOTA__5AC3086A75AD65ED");

            entity.ToTable("MOVCUOTAS", tb => tb.HasTrigger("trg_MOVCUOTAS_Delete"));

            entity.HasIndex(e => new { e.MovCuoCta, e.MovCuoVen }, "IMOVCUOTAF");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.MovCuoImp).HasColumnType("money");
            entity.Property(e => e.MovCuoVen).HasColumnType("datetime");
        });

        modelBuilder.Entity<Movdocafectado>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.MovNro, e.MovAfeCod, e.MovAfeNro }).HasName("PK__MOVDOCAF__3AD628A9011F1899");

            entity.ToTable("MOVDOCAFECTADOS", tb => tb.HasTrigger("trg_MOVDOCAFECTADOS_Delete"));

            entity.HasIndex(e => new { e.MovAfeCod, e.MovAfeNro }, "IMOVDOCAFECTADOSMOVAFEC2");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.MovAfeImp).HasColumnType("money");
        });

        modelBuilder.Entity<Movdocumento>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.MovNro, e.MovDocLin }).HasName("PK__MOVDOCUM__104A0B4A7D4E87B5");

            entity.ToTable("MOVDOCUMENTOS", tb => tb.HasTrigger("trg_MOVDOCUMENTOS_Delete"));

            entity.HasIndex(e => e.MovDocTipo, "IMOVDOC2");

            entity.HasIndex(e => new { e.MovDocEst, e.MovDocFecha }, "IMOVDOCF");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.MovDocEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovDocFecha).HasColumnType("datetime");
            entity.Property(e => e.MovDocImp).HasColumnType("money");
            entity.Property(e => e.MovDocNota)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovDocNro)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.MovNro }).HasName("PK__MOVIMIEN__958107FD5ECA0095");

            entity.ToTable("MOVIMIENTOS", tb => tb.HasTrigger("trg_MOVIMIENTOS_Delete"));

            entity.HasIndex(e => new { e.MovCliNro, e.MovFch }, "IMOVCLIFD").IsDescending(false, true);

            entity.HasIndex(e => new { e.MovCliNro, e.TmovCod, e.MovFch }, "IMOVCLIT");

            entity.HasIndex(e => new { e.MovCliNro, e.MovVence }, "IMOVCLIVEN");

            entity.HasIndex(e => new { e.TmovCod, e.MovDocu }, "IMOVDOCU");

            entity.HasIndex(e => e.MovFchIng, "IMOVFING");

            entity.HasIndex(e => e.MovRubCod, "IMOVIM12");

            entity.HasIndex(e => e.MovMonCod, "IMOVIM13");

            entity.HasIndex(e => e.MovImpCod, "IMOVIM16");

            entity.HasIndex(e => new { e.MovCliNro, e.MovFch }, "IMOVIMIE1");

            entity.HasIndex(e => new { e.MovProNro, e.MovFch }, "IMOVIMIE2");

            entity.HasIndex(e => new { e.MovFch, e.TmovCod }, "IMOVIMIE3");

            entity.HasIndex(e => e.MovUsuCod, "IMOVIMIE6");

            entity.HasIndex(e => e.MovVenUsu, "IMOVIMIE7");

            entity.HasIndex(e => e.MovForPnro, "IMOVIMIE8");

            entity.HasIndex(e => e.PagoMonCod, "IMOVIMIENTOS");

            entity.HasIndex(e => e.MovLisPreNro, "IMOVIMIENTOS1");

            entity.HasIndex(e => e.MovAutUsu, "IMOVIMIENTOS2");

            entity.HasIndex(e => e.MovUsuFac, "IMOVIMIENTOS3");

            entity.HasIndex(e => e.MovSucCod, "IMOVIMIENTOS4");

            entity.HasIndex(e => e.MovCenCosC, "IMOVIMIENTOS5");

            entity.HasIndex(e => new { e.MovSecCod, e.MovSsecCod }, "IMOVIMIENTOS6");

            entity.HasIndex(e => e.MovCaenro, "IMOVIMIENTOS7");

            entity.HasIndex(e => e.MovCfecodigo, "IMOVIMIENTOS8");

            entity.HasIndex(e => e.RepartoNro, "IMOVIMIENTOS9");

            entity.HasIndex(e => new { e.MovProNro, e.MovFch }, "IMOVPROFD").IsDescending(false, true);

            entity.HasIndex(e => new { e.MovProNro, e.MovVence }, "IMOVPROVEN");

            entity.HasIndex(e => e.MovRemito, "IMOVREMITO");

            entity.HasIndex(e => new { e.TmovCod, e.MovFch }, "IMOVTFCH");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.MovAut1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovAut2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovAut3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovAutCp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MovAutCP");
            entity.Property(e => e.MovCaenro)
                .HasColumnType("decimal(12, 0)")
                .HasColumnName("MovCAENro");
            entity.Property(e => e.MovCaerango)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MovCAERango");
            entity.Property(e => e.MovCaevencimiento)
                .HasColumnType("datetime")
                .HasColumnName("MovCAEVencimiento");
            entity.Property(e => e.MovCenCosC)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovCfecodSeguridad)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MovCFECodSeguridad");
            entity.Property(e => e.MovCfecodigo).HasColumnName("MovCFECodigo");
            entity.Property(e => e.MovCfeestado).HasColumnName("MovCFEEstado");
            entity.Property(e => e.MovCfeestadoAcuse).HasColumnName("MovCFEEstadoAcuse");
            entity.Property(e => e.MovCfenro).HasColumnName("MovCFENro");
            entity.Property(e => e.MovCferepImpresa)
                .IsUnicode(false)
                .HasColumnName("MovCFERepImpresa");
            entity.Property(e => e.MovCfeserie)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MovCFESerie");
            entity.Property(e => e.MovCot).HasColumnType("smallmoney");
            entity.Property(e => e.MovDirCob)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovDirEnvio)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovDocu)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovEstAut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovEvCont)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovFch).HasColumnType("datetime");
            entity.Property(e => e.MovFchEnt).HasColumnType("datetime");
            entity.Property(e => e.MovFchIng).HasColumnType("datetime");
            entity.Property(e => e.MovFiscal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovFletePen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovForPnro).HasColumnName("MovForPNro");
            entity.Property(e => e.MovHoraEst)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovImpu).HasColumnType("money");
            entity.Property(e => e.MovLocalidad)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovNomCli)
                .HasMaxLength(35)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovNota)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovOrdInt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovOrden)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovOriGen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovPasado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovPenRec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovRemito)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovResponsable)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovRubCod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovSecCod)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovSsecCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MovSSecCod");
            entity.Property(e => e.MovTelOri)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovTotDebe).HasColumnType("money");
            entity.Property(e => e.MovTotDto).HasColumnType("money");
            entity.Property(e => e.MovTotFac).HasColumnType("money");
            entity.Property(e => e.MovTotHaber).HasColumnType("money");
            entity.Property(e => e.MovTotSal).HasColumnType("money");
            entity.Property(e => e.MovTotal).HasColumnType("money");
            entity.Property(e => e.MovVence).HasColumnType("datetime");
            entity.Property(e => e.PagoImporte).HasColumnType("money");
        });

        modelBuilder.Entity<Movrubro>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.MovNro, e.MovLin }).HasName("PK__MOVRUBRO__F01E4B04629A9179");

            entity.ToTable("MOVRUBRO", tb => tb.HasTrigger("trg_MOVRUBRO_Delete"));

            entity.HasIndex(e => new { e.TmovCod, e.MovNro, e.MovLinDh }, "IMOVDH");

            entity.HasIndex(e => new { e.MrubCod, e.MovLinFch }, "IMOVICTA3");

            entity.HasIndex(e => new { e.MrubCod, e.MovLinVen }, "IMOVICTA4");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.MovLinDh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MovLinDH");
            entity.Property(e => e.MovLinFch).HasColumnType("datetime");
            entity.Property(e => e.MovLinIva).HasColumnType("smallmoney");
            entity.Property(e => e.MovLinNot)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovLinTot).HasColumnType("money");
            entity.Property(e => e.MovLinVen).HasColumnType("datetime");
            entity.Property(e => e.MrubCod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MRubCod");
        });

        modelBuilder.Entity<Movstock>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.MovNro, e.MovArtLin }).HasName("PK__MOVSTOCK__73E10CAE6A3BB341");

            entity.ToTable("MOVSTOCK", tb => tb.HasTrigger("trg_MOVSTOCK_Delete"));

            entity.HasIndex(e => new { e.MovArtEntre, e.MovArtFch }, "IMOVENTRE");

            entity.HasIndex(e => new { e.MovArtNro, e.MovArtLote, e.MovArtFch }, "IMOVLOTE");

            entity.HasIndex(e => e.MovArtFch, "IMOVSTFCH");

            entity.HasIndex(e => new { e.MovArtNro, e.MovArtFch }, "IMOVSTFD").IsDescending(false, true);

            entity.HasIndex(e => new { e.MovForCod, e.MovArtFch }, "IMOVSTFOR");

            entity.HasIndex(e => e.MovDepNro, "IMOVSTOCK3");

            entity.HasIndex(e => new { e.MovArtNro, e.MovArtFch }, "IMOVSTOCKF");

            entity.HasIndex(e => new { e.TmovCod, e.MovArtNro, e.MovArtFch }, "IMOVSTTAR");

            entity.HasIndex(e => new { e.TmovCod, e.MovArtFch }, "IMOVTMFCH");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.MovArPrNeto).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.MovArtCant).HasColumnType("money");
            entity.Property(e => e.MovArtDet)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovArtEntre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovArtFch).HasColumnType("datetime");
            entity.Property(e => e.MovArtImpu).HasColumnType("money");
            entity.Property(e => e.MovArtIva).HasColumnType("smallmoney");
            entity.Property(e => e.MovArtLote)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovArtNeto).HasColumnType("money");
            entity.Property(e => e.MovArtPorDto).HasColumnType("smallmoney");
            entity.Property(e => e.MovArtPreLis).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.MovArtPrecio).HasColumnType("decimal(11, 4)");
            entity.Property(e => e.MovArtReceta)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovArtVen).HasColumnType("datetime");
            entity.Property(e => e.MovCantReal).HasColumnType("money");
            entity.Property(e => e.MovForEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovPlaUlin).HasColumnName("MovPlaULin");
            entity.Property(e => e.MovRecInt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovRecResp)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovRetPor).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Numera>(entity =>
        {
            entity.HasKey(e => e.NumTipo).HasName("PK__NUMERA__EFD0411E51A50FA1");

            entity.ToTable("NUMERA", tb => tb.HasTrigger("trg_NUMERA_Delete"));

            entity.HasIndex(e => e.NumCfetipoF, "INUMERA1");

            entity.HasIndex(e => e.NumCfetipoT, "INUMERA2");

            entity.HasIndex(e => e.NumCfetipoC, "INUMERA3");

            entity.HasIndex(e => e.NumCfetipoCt, "INUMERA4");

            entity.Property(e => e.NumTipo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumCfetipoC).HasColumnName("NumCFETipoC");
            entity.Property(e => e.NumCfetipoCt).HasColumnName("NumCFETipoCT");
            entity.Property(e => e.NumCfetipoF).HasColumnName("NumCFETipoF");
            entity.Property(e => e.NumCfetipoT).HasColumnName("NumCFETipoT");
        });

        modelBuilder.Entity<Ordene>(entity =>
        {
            entity.HasKey(e => e.OrdNro).HasName("PK__ORDENES__4C383E8A6FBF826D");

            entity.ToTable("ORDENES", tb => tb.HasTrigger("trg_ORDENES_Delete"));

            entity.HasIndex(e => new { e.OrdFecha, e.OrdArtNro }, "IORDENES1");

            entity.HasIndex(e => new { e.OrdArtNro, e.OrdFecha }, "IORDENES2");

            entity.HasIndex(e => new { e.OrdInicio, e.OrdForCod, e.OrdForArtNro }, "IORDENES3");

            entity.HasIndex(e => new { e.OrdFecha, e.OrdForArtNro, e.OrdForCod, e.OrdTipoCarga }, "IORDENES4");

            entity.HasIndex(e => e.OrdFecha, "IORDENES5").IsDescending();

            entity.Property(e => e.OrdNro).ValueGeneratedNever();
            entity.Property(e => e.OrdArtDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdDes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdFecha).HasColumnType("datetime");
            entity.Property(e => e.OrdFin).HasColumnType("datetime");
            entity.Property(e => e.OrdForArtDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdForComCant).HasColumnType("decimal(9, 4)");
            entity.Property(e => e.OrdForDes)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.OrdInicio).HasColumnType("datetime");
            entity.Property(e => e.OrdKg).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.OrdSetPoint).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.OrdTipoCarga)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.PaisCod).HasName("PK__PAIS__6A1EDFF47F01C5FD");

            entity.ToTable("PAIS", tb => tb.HasTrigger("trg_PAIS_Delete"));

            entity.Property(e => e.PaisCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PaisNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Planprod>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.MovNro, e.MovArtLin, e.MovPlaLin }).HasName("PK__PLANPROD__A87184A15CACADF9");

            entity.ToTable("PLANPROD", tb => tb.HasTrigger("trg_PLANPROD_Delete"));

            entity.HasIndex(e => e.MovPlaProCod, "IPLANPROD");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.MovPlaCarFin).HasColumnType("datetime");
            entity.Property(e => e.MovPlaCarga).HasColumnType("datetime");
            entity.Property(e => e.MovPlaEstado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovPlaFecha).HasColumnType("datetime");
            entity.Property(e => e.MovPlaHora)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovPlaKgs).HasColumnType("money");
            entity.Property(e => e.MovPlaKgsReal).HasColumnType("money");
            entity.Property(e => e.MovPlaNota)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MovPlaTrans)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Plazoscli>(entity =>
        {
            entity.HasKey(e => e.PlazoCod).HasName("PK__PLAZOSCL__D05FB24F164F3FA9");

            entity.ToTable("PLAZOSCLI", tb => tb.HasTrigger("trg_PLAZOSCLI_Delete"));

            entity.Property(e => e.PlazoCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.PlazoDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Preimpreso>(entity =>
        {
            entity.HasKey(e => e.PreNro).HasName("PK__PREIMPRE__34FC1BB2666B225D");

            entity.ToTable("PREIMPRESO", tb => tb.HasTrigger("trg_PREIMPRESO_Delete"));

            entity.HasIndex(e => new { e.PreFch, e.PreNro }, "IPREIMPFCN");

            entity.HasIndex(e => e.PreNro, "IPREIMPN").IsDescending();

            entity.HasIndex(e => new { e.TmovCod, e.MovNro }, "IPREIMPRESO2");

            entity.Property(e => e.PreNro).ValueGeneratedNever();
            entity.Property(e => e.PreFch).HasColumnType("datetime");
            entity.Property(e => e.PreNota)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
        });

        modelBuilder.Entity<GestionDash.Server.Models.Program>(entity =>
        {
            entity.HasKey(e => e.SproCod).HasName("PK__PROGRAM__C577993333208881");

            entity.ToTable("PROGRAM", tb => tb.HasTrigger("trg_PROGRAM_Delete"));

            entity.Property(e => e.SproCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SProCod");
            entity.Property(e => e.SproDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SProDes");
        });

        modelBuilder.Entity<Pronota>(entity =>
        {
            entity.HasKey(e => new { e.ProNro, e.ProNotaNro }).HasName("PK__PRONOTAS__6CEAA2783C74E891");

            entity.ToTable("PRONOTAS", tb => tb.HasTrigger("trg_PRONOTAS_Delete"));

            entity.HasIndex(e => e.ProNotaUsu, "IPRONOTAS2");

            entity.HasIndex(e => e.ProTipoNota, "IPRONOTAS3");

            entity.Property(e => e.ProNotaDet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProNotaEst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProNotaFech).HasColumnType("datetime");
            entity.Property(e => e.ProNotaFpen)
                .HasColumnType("datetime")
                .HasColumnName("ProNotaFPen");
            entity.Property(e => e.ProTipoNota)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Prosaldo>(entity =>
        {
            entity.HasKey(e => new { e.ProNro, e.ProMonCod }).HasName("PK__PROSALDO__08831E4A1FA39FB9");

            entity.ToTable("PROSALDOS", tb => tb.HasTrigger("trg_PROSALDOS_Delete"));

            entity.Property(e => e.ProSaldo).HasColumnType("money");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.ProNro).HasName("PK__PROVEEDO__3C685E9538A457AD");

            entity.ToTable("PROVEEDORES", tb => tb.HasTrigger("trg_PROVEEDORES_Delete"));

            entity.HasIndex(e => e.ProNom, "IPRONOM");

            entity.Property(e => e.ProNro).ValueGeneratedNever();
            entity.Property(e => e.ProActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProCedula)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProCel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProComen)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProContacto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProDir)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProDir2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProDtoD).HasColumnType("smallmoney");
            entity.Property(e => e.ProDtoP).HasColumnType("smallmoney");
            entity.Property(e => e.ProFecAut).HasColumnType("datetime");
            entity.Property(e => e.ProFecIng).HasColumnType("datetime");
            entity.Property(e => e.ProFecPago).HasColumnType("datetime");
            entity.Property(e => e.ProFecUlt).HasColumnType("datetime");
            entity.Property(e => e.ProMail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProRazSoc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProRut)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ProRUT");
            entity.Property(e => e.ProTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProTel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProTipoCta)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Reparto>(entity =>
        {
            entity.HasKey(e => e.RepartoNro).HasName("PK__REPARTO__743A00CC06A2E7C5");

            entity.ToTable("REPARTO", tb => tb.HasTrigger("trg_REPARTO_Delete"));

            entity.HasIndex(e => e.RepZonasCodigo, "IREPARTO1");

            entity.HasIndex(e => e.VehCod, "IREPARTO2");

            entity.Property(e => e.RepartoFecha).HasColumnType("datetime");
            entity.Property(e => e.RepartoFechaEntrega).HasColumnType("datetime");
        });

        modelBuilder.Entity<Rubro>(entity =>
        {
            entity.HasKey(e => e.RubCod).HasName("PK__RUBROS__208C803330992191");

            entity.ToTable("RUBROS", tb => tb.HasTrigger("trg_RUBROS_Delete"));

            entity.HasIndex(e => e.RubMonCod, "IRUBRO1");

            entity.HasIndex(e => e.RubImpCod, "IRUBROS");

            entity.Property(e => e.RubCod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RubActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RubAsiDc).HasColumnName("RubAsiDC");
            entity.Property(e => e.RubExterno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RubNom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RubTitulo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Saldocaja>(entity =>
        {
            entity.HasKey(e => new { e.SalCaFecha, e.SucCod }).HasName("PK__SALDOCAJ__7DFFA06F2DBCB4E6");

            entity.ToTable("SALDOCAJAS", tb => tb.HasTrigger("trg_SALDOCAJAS_Delete"));

            entity.HasIndex(e => e.SucCod, "ISALDOCAJAS1");

            entity.Property(e => e.SalCaFecha).HasColumnType("datetime");
            entity.Property(e => e.SalCaDol).HasColumnType("money");
            entity.Property(e => e.SalCaPesos).HasColumnType("money");
        });

        modelBuilder.Entity<Saldorubro>(entity =>
        {
            entity.HasKey(e => new { e.SalRubCod, e.SalRubFecha, e.SalSucCod }).HasName("PK__SALDORUB__373BB325233F2673");

            entity.ToTable("SALDORUBROS", tb => tb.HasTrigger("trg_SALDORUBROS_Delete"));

            entity.Property(e => e.SalRubCod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SalRubFecha).HasColumnType("datetime");
            entity.Property(e => e.SalDolPesos).HasColumnType("money");
            entity.Property(e => e.SalPesosDol).HasColumnType("money");
            entity.Property(e => e.SalRubDol).HasColumnType("money");
            entity.Property(e => e.SalRubPesos).HasColumnType("money");
            entity.Property(e => e.SalTodoDol).HasColumnType("money");
            entity.Property(e => e.SalTodoPesos).HasColumnType("money");
        });

        modelBuilder.Entity<Seccione>(entity =>
        {
            entity.HasKey(e => e.SecNro).HasName("PK__SECCIONE__A080677559463169");

            entity.ToTable("SECCIONES", tb => tb.HasTrigger("trg_SECCIONES_Delete"));

            entity.HasIndex(e => e.SecRubCcod, "ISECCIONES1");

            entity.HasIndex(e => e.SecRubVcod, "ISECCIONES2");

            entity.Property(e => e.SecNro)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SecRubCcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SecRubCCod");
            entity.Property(e => e.SecRubVcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SecRubVCod");
            entity.Property(e => e.SecStock)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Segtipmov>(entity =>
        {
            entity.HasKey(e => new { e.SgruCod, e.TmovCod }).HasName("PK__SEGTIPMO__7479B9F16E0C4425");

            entity.ToTable("SEGTIPMOV", tb => tb.HasTrigger("trg_SEGTIPMOV_Delete"));

            entity.HasIndex(e => e.TmovCod, "ISEGTIPMOV11");

            entity.Property(e => e.SgruCod).HasColumnName("SGruCod");
            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.TmovAut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovAut");
            entity.Property(e => e.TmovDel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovDel");
            entity.Property(e => e.TmovMod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovMod");
        });

        modelBuilder.Entity<Seguri>(entity =>
        {
            entity.HasKey(e => new { e.SgruCod, e.SproCod }).HasName("PK__SEGURI__5EED33293E923B2D");

            entity.ToTable("SEGURI", tb => tb.HasTrigger("trg_SEGURI_Delete"));

            entity.HasIndex(e => e.SproCod, "ISEGURI1");

            entity.Property(e => e.SgruCod).HasColumnName("SGruCod");
            entity.Property(e => e.SproCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SProCod");
        });

        modelBuilder.Entity<Seguri1>(entity =>
        {
            entity.HasKey(e => new { e.SgruCod, e.SproCod, e.SeveNom }).HasName("PK__SEGURI1__4A00FF934262CC11");

            entity.ToTable("SEGURI1", tb => tb.HasTrigger("trg_SEGURI1_Delete"));

            entity.HasIndex(e => new { e.SproCod, e.SeveNom }, "ISEGURI4");

            entity.Property(e => e.SgruCod).HasColumnName("SGruCod");
            entity.Property(e => e.SproCod)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SProCod");
            entity.Property(e => e.SeveNom)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEveNom");
            entity.Property(e => e.SeveAut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SEveAut");
            entity.Property(e => e.SeveHasta)
                .HasColumnType("datetime")
                .HasColumnName("SEveHasta");
        });

        modelBuilder.Entity<Subsec>(entity =>
        {
            entity.HasKey(e => new { e.SecNro, e.SubSecNro }).HasName("PK__SUBSEC__34370F625D16C24D");

            entity.ToTable("SUBSEC", tb => tb.HasTrigger("trg_SUBSEC_Delete"));

            entity.HasIndex(e => e.SubSrubCc, "ISUBSEC2");

            entity.HasIndex(e => e.SubSrubVc, "ISUBSEC3");

            entity.Property(e => e.SecNro)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubSecNro)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubSecDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubSecLis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubSecNota)
                .HasMaxLength(120)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubSecStock)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.SubSrubCc)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SubSRubCC");
            entity.Property(e => e.SubSrubVc)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SubSRubVC");
        });

        modelBuilder.Entity<Sucursale>(entity =>
        {
            entity.HasKey(e => e.SucCod).HasName("PK__SUCURSAL__73EF123E2744C181");

            entity.ToTable("SUCURSALES", tb => tb.HasTrigger("trg_SUCURSALES_Delete"));

            entity.Property(e => e.SucCod).ValueGeneratedNever();
            entity.Property(e => e.SucFeCaja).HasColumnType("datetime");
            entity.Property(e => e.SucNom)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Tasasint>(entity =>
        {
            entity.HasKey(e => e.TasaNro).HasName("PK__TASASINT__3A79AED621C0F255");

            entity.ToTable("TASASINT", tb => tb.HasTrigger("trg_TASASINT_Delete"));

            entity.Property(e => e.TasaNro).ValueGeneratedNever();
            entity.Property(e => e.TasaDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Tasasintmon>(entity =>
        {
            entity.HasKey(e => new { e.TasaNro, e.TasaMonCod }).HasName("PK__TASASINT__8D9AC81A25918339");

            entity.ToTable("TASASINTMON", tb => tb.HasTrigger("trg_TASASINTMON_Delete"));

            entity.HasIndex(e => e.TasaMonCod, "ITASASINTTASASINTMON2");

            entity.Property(e => e.TasaMonPor).HasColumnType("smallmoney");
            entity.Property(e => e.TasaPorCon).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Tipcli>(entity =>
        {
            entity.HasKey(e => e.TipCliNro).HasName("PK__TIPCLI__4B19D06B033C6B35");

            entity.ToTable("TIPCLI", tb => tb.HasTrigger("trg_TIPCLI_Delete"));

            entity.HasIndex(e => e.TipCliSuc, "ITIPCLI1");

            entity.Property(e => e.TipCliNro).ValueGeneratedNever();
            entity.Property(e => e.TipCliDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Tipmov>(entity =>
        {
            entity.HasKey(e => e.TmovCod).HasName("PK__TIPMOV__6C3F34B17B9B496D");

            entity.ToTable("TIPMOV", tb => tb.HasTrigger("trg_TIPMOV_Delete"));

            entity.HasIndex(e => e.RubFijoPcod, "ITIPMOV1");

            entity.HasIndex(e => e.NumTipo, "ITIPMOV2");

            entity.HasIndex(e => e.RubFijoDcod, "ITIPMOV3");

            entity.HasIndex(e => e.RubVarPcod, "ITIPMOV4");

            entity.HasIndex(e => e.RubVarDcod, "ITIPMOV5");

            entity.HasIndex(e => e.TmovLiqui, "ITIPTIP").IsDescending();

            entity.Property(e => e.TmovCod)
                .ValueGeneratedNever()
                .HasColumnName("TMovCod");
            entity.Property(e => e.NumTipo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RubFijoDcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RubFijoDCod");
            entity.Property(e => e.RubFijoPcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RubFijoPCod");
            entity.Property(e => e.RubVarDcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RubVarDCod");
            entity.Property(e => e.RubVarPcod)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RubVarPCod");
            entity.Property(e => e.TmovAcc).HasColumnName("TMovAcc");
            entity.Property(e => e.TmovCaja).HasColumnName("TMovCaja");
            entity.Property(e => e.TmovCom)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovCom");
            entity.Property(e => e.TmovCon).HasColumnName("TMovCon");
            entity.Property(e => e.TmovConforme).HasColumnName("TMovConforme");
            entity.Property(e => e.TmovDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovDes");
            entity.Property(e => e.TmovFac)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovFac");
            entity.Property(e => e.TmovFijoDh)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovFijoDH");
            entity.Property(e => e.TmovLiqui)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovLiqui");
            entity.Property(e => e.TmovPrubV)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovPRubV");
            entity.Property(e => e.TmovRet).HasColumnName("TMovRet");
            entity.Property(e => e.TmovSalRub).HasColumnName("TMovSalRub");
            entity.Property(e => e.TmovStock).HasColumnName("TMovStock");
            entity.Property(e => e.TmovTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("TMovTipo");
        });

        modelBuilder.Entity<Tipmovret>(entity =>
        {
            entity.HasKey(e => new { e.TmovCod, e.TmovImpCod }).HasName("PK__TIPMOVRE__EF59F33036870511");

            entity.ToTable("TIPMOVRET", tb => tb.HasTrigger("trg_TIPMOVRET_Delete"));

            entity.HasIndex(e => e.TmovImpCod, "ITIPMOVTMOVIMPRET2");

            entity.Property(e => e.TmovCod).HasColumnName("TMovCod");
            entity.Property(e => e.TmovImpCod).HasColumnName("TMovImpCod");
            entity.Property(e => e.TmovImpInc).HasColumnName("TMovImpInc");
        });

        modelBuilder.Entity<Tipo>(entity =>
        {
            entity.HasKey(e => e.TipoCod).HasName("PK__TIPO__C53EF2200A7378A9");

            entity.ToTable("TIPO", tb => tb.HasTrigger("trg_TIPO_Delete"));

            entity.Property(e => e.TipoCod).ValueGeneratedNever();
            entity.Property(e => e.TipoConTa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipoNom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Tiponota>(entity =>
        {
            entity.HasKey(e => e.TipNotCod).HasName("PK__TIPONOTA__7DA1550D2962141D");

            entity.ToTable("TIPONOTAS", tb => tb.HasTrigger("trg_TIPONOTAS_Delete"));

            entity.Property(e => e.TipNotCod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipNotAso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipNotDes)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TipNotPen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Titulo>(entity =>
        {
            entity.HasKey(e => e.TitCod).HasName("PK__TITULOS__C1DA881A7F6BDA51");

            entity.ToTable("TITULOS", tb => tb.HasTrigger("trg_TITULOS_Delete"));

            entity.Property(e => e.TitCod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TitDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Unidade>(entity =>
        {
            entity.HasKey(e => e.UniCod).HasName("PK__UNIDADES__40564B942D32A501");

            entity.ToTable("UNIDADES", tb => tb.HasTrigger("trg_UNIDADES_Delete"));

            entity.Property(e => e.UniCod).ValueGeneratedNever();
            entity.Property(e => e.UniDes)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniDesChi)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuCod).HasName("PK__USUARIOS__DE100B1746335CF5");

            entity.ToTable("USUARIOS", tb => tb.HasTrigger("trg_USUARIOS_Delete"));

            entity.HasIndex(e => e.SgruCod, "IUSUARI1");

            entity.HasIndex(e => e.UsuNom, "IUSUNOM").IsUnique();

            entity.Property(e => e.UsuCod).ValueGeneratedNever();
            entity.Property(e => e.SgruCod).HasColumnName("SGruCod");
            entity.Property(e => e.UsuAdic)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuCamPre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuCla).HasMaxLength(32);
            entity.Property(e => e.UsuExtra)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuIngSis)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuMail)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValue("mail@mail.com")
                .IsFixedLength();
            entity.Property(e => e.UsuNom)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuNomLar)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuNotPen)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuPerm)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuVeTodo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuVende)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.VehCod).HasName("PK__VEHICULO__59908A430E44098D");

            entity.ToTable("VEHICULO", tb => tb.HasTrigger("trg_VEHICULO_Delete"));

            entity.HasIndex(e => e.VehMatAc, "IMATAC");

            entity.HasIndex(e => e.VehNoInt, "INOINT");

            entity.HasIndex(e => e.MarcaCod, "IVEHICULO1");

            entity.HasIndex(e => e.TipoCod, "IVEHICULO2");

            entity.Property(e => e.VehCod).ValueGeneratedNever();
            entity.Property(e => e.VehCdesde)
                .HasColumnType("smallmoney")
                .HasColumnName("VehCDesde");
            entity.Property(e => e.VehChasis)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehChasta)
                .HasColumnType("smallmoney")
                .HasColumnName("VehCHasta");
            entity.Property(e => e.VehColor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehCombus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehDesc)
                .HasMaxLength(79)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehEstado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehFecCom).HasColumnType("datetime");
            entity.Property(e => e.VehFecGar).HasColumnType("datetime");
            entity.Property(e => e.VehFecIng).HasColumnType("datetime");
            entity.Property(e => e.VehMatAc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehModelo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehNoInt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehNoMotor)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehObs)
                .HasMaxLength(79)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehTcont)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VehTCont");
            entity.Property(e => e.VehTman)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VehTMan");
            entity.Property(e => e.VehUbDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.VehUbMcol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("VehUbMCol");
            entity.Property(e => e.VehUbMfil).HasColumnName("VehUbMFil");
            entity.Property(e => e.VehUltSfe)
                .HasColumnType("datetime")
                .HasColumnName("VehUltSFe");
        });

        modelBuilder.Entity<Vehtarea>(entity =>
        {
            entity.HasKey(e => new { e.VehCod, e.TarCod }).HasName("PK__VEHTAREA__7655674212149A71");

            entity.ToTable("VEHTAREAS", tb => tb.HasTrigger("trg_VEHTAREAS_Delete"));

            entity.Property(e => e.TarDes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TarTipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Zona>(entity =>
        {
            entity.HasKey(e => e.ZonasCodigo).HasName("PK__ZONAS__473E2FEE15E52B55");

            entity.ToTable("ZONAS", tb => tb.HasTrigger("trg_ZONAS_Delete"));

            entity.HasIndex(e => e.LocCod, "IZONAS1");

            entity.Property(e => e.ZonasCodigo).ValueGeneratedNever();
            entity.Property(e => e.ZonasDescripcion)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
