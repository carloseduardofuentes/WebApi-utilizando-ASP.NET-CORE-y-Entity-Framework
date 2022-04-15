using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi_CargoWeb.Models
{
    public partial class CargoContext : DbContext
    {
        public CargoContext()
        {
        }

        public CargoContext(DbContextOptions<CargoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sheet1> Sheet1s { get; set; } = null!;
        public virtual DbSet<TbillOfLading> TbillOfLadings { get; set; } = null!;
        public virtual DbSet<Tcarrier> Tcarriers { get; set; } = null!;
        public virtual DbSet<Testado> Testados { get; set; } = null!;
        public virtual DbSet<ThistorialWarehouse> ThistorialWarehouses { get; set; } = null!;
        public virtual DbSet<Tmodo> Tmodos { get; set; } = null!;
        public virtual DbSet<Tpai> Tpais { get; set; } = null!;
        public virtual DbSet<Tpantalla> Tpantallas { get; set; } = null!;
        public virtual DbSet<Tperfil> Tperfils { get; set; } = null!;
        public virtual DbSet<Tpersona> Tpersonas { get; set; } = null!;
        public virtual DbSet<Tposicion> Tposicions { get; set; } = null!;
        public virtual DbSet<TposicionTpersona> TposicionTpersonas { get; set; } = null!;
        public virtual DbSet<Tpuerto> Tpuertos { get; set; } = null!;
        public virtual DbSet<Treempaque> Treempaques { get; set; } = null!;
        public virtual DbSet<TreempaqueDetalle> TreempaqueDetalles { get; set; } = null!;
        public virtual DbSet<TreempaqueWarehouse> TreempaqueWarehouses { get; set; } = null!;
        public virtual DbSet<TtipoPersona> TtipoPersonas { get; set; } = null!;
        public virtual DbSet<Ttransporte> Ttransportes { get; set; } = null!;
        public virtual DbSet<Tusuario> Tusuarios { get; set; } = null!;
        public virtual DbSet<Twarehouse> Twarehouses { get; set; } = null!;
        public virtual DbSet<TwarehouseDetalle> TwarehouseDetalles { get; set; } = null!;
        public virtual DbSet<ViewModels.TusuarioVM> TusuariosVM { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Cargo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Sheet1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheet1$");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("Address-1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("Address-2");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Contact)
                    .HasMaxLength(255)
                    .HasColumnName("Contact ");

                entity.Property(e => e.Country).HasMaxLength(255);

                entity.Property(e => e.Ein)
                    .HasMaxLength(255)
                    .HasColumnName("EIN");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Email2)
                    .HasMaxLength(255)
                    .HasColumnName("Email-2");

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(255)
                    .HasColumnName("Fax-2");

                entity.Property(e => e.NCodigoPais).HasColumnName("N_CODIGO_PAIS");

                entity.Property(e => e.NCodigoPuerto).HasColumnName("N_CODIGO_PUERTO");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("Name ");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(255)
                    .HasColumnName("Phone-2");

                entity.Property(e => e.Port).HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Zip).HasMaxLength(255);
            });

            modelBuilder.Entity<TbillOfLading>(entity =>
            {
                entity.HasKey(e => e.NCodigoBill)
                    .IsClustered(false);

                entity.ToTable("TBILL_OF_LADING");

                entity.Property(e => e.NCodigoBill)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_BILL");

                entity.Property(e => e.BCorreoEnviado).HasColumnName("B_CORREO_ENVIADO");

                entity.Property(e => e.CBill)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_BILL");

                entity.Property(e => e.CComentarios)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_COMENTARIOS");

                entity.Property(e => e.CRecibidaPor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_RECIBIDA_POR");

                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CREACION");

                entity.Property(e => e.DFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_MODIFICACION");

                entity.Property(e => e.DFechaRecibida)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_RECIBIDA");

                entity.Property(e => e.MCodAmount)
                    .HasColumnType("money")
                    .HasColumnName("M_COD_AMOUNT");

                entity.Property(e => e.NAdvanceDestination)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_ADVANCE_DESTINATION");

                entity.Property(e => e.NAdvanceOrigin)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_ADVANCE_ORIGIN");

                entity.Property(e => e.NCbm)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("N_CBM");

                entity.Property(e => e.NCodigoCharged)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_CHARGED");

                entity.Property(e => e.NCodigoConsignee)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_CONSIGNEE");

                entity.Property(e => e.NCodigoDestino)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_DESTINO");

                entity.Property(e => e.NCodigoEstado)
                    .HasColumnName("N_CODIGO_ESTADO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NCodigoOrigen)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_ORIGEN");

                entity.Property(e => e.NCodigoPosicion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_POSICION");

                entity.Property(e => e.NCodigoShipper)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_SHIPPER");

                entity.Property(e => e.NCreadoPor).HasColumnName("N_CREADO_POR");

                entity.Property(e => e.NCwt)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CWT");

                entity.Property(e => e.NDelivery)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_DELIVERY");

                entity.Property(e => e.NFreight)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_FREIGHT");

                entity.Property(e => e.NModificadoPor).HasColumnName("N_MODIFICADO_POR");

                entity.Property(e => e.NOther)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_OTHER");

                entity.Property(e => e.NOther2)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_OTHER2");

                entity.Property(e => e.NPickup)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_PICKUP");

                entity.Property(e => e.NPieces)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_PIECES");

                entity.Property(e => e.NServiceLevel)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_SERVICE_LEVEL");

                entity.Property(e => e.NTypeFunds)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_TYPE_FUNDS");

                entity.Property(e => e.NWeight)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("N_WEIGHT");

                entity.Property(e => e.NWt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("N_WT");

                entity.HasOne(d => d.NCodigoConsigneeNavigation)
                    .WithMany(p => p.TbillOfLadingNCodigoConsigneeNavigations)
                    .HasForeignKey(d => d.NCodigoConsignee)
                    .HasConstraintName("FK_TBILL_OF_LADING_TPERSONA1");

                entity.HasOne(d => d.NCodigoDestinoNavigation)
                    .WithMany(p => p.TbillOfLadingNCodigoDestinoNavigations)
                    .HasForeignKey(d => d.NCodigoDestino)
                    .HasConstraintName("FK_TBILL_OF_LADING_TPUERTO1");

                entity.HasOne(d => d.NCodigoOrigenNavigation)
                    .WithMany(p => p.TbillOfLadingNCodigoOrigenNavigations)
                    .HasForeignKey(d => d.NCodigoOrigen)
                    .HasConstraintName("FK_TBILL_OF_LADING_TPUERTO");

                entity.HasOne(d => d.NCodigoShipperNavigation)
                    .WithMany(p => p.TbillOfLadingNCodigoShipperNavigations)
                    .HasForeignKey(d => d.NCodigoShipper)
                    .HasConstraintName("FK_TBILL_OF_LADING_TPERSONA");
            });

            modelBuilder.Entity<Tcarrier>(entity =>
            {
                entity.HasKey(e => e.NCodigoCarrier)
                    .IsClustered(false);

                entity.ToTable("TCARRIER");

                entity.Property(e => e.NCodigoCarrier)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_CARRIER");

                entity.Property(e => e.CCarrier)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_CARRIER");
            });

            modelBuilder.Entity<Testado>(entity =>
            {
                entity.HasKey(e => e.NCodigoEstado);

                entity.ToTable("TESTADO");

                entity.Property(e => e.NCodigoEstado)
                    .ValueGeneratedNever()
                    .HasColumnName("N_CODIGO_ESTADO");

                entity.Property(e => e.CEstado)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_ESTADO");
            });

            modelBuilder.Entity<ThistorialWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("THISTORIAL_WAREHOUSE");

                entity.Property(e => e.BCorreoEnviado).HasColumnName("B_CORREO_ENVIADO");

                entity.Property(e => e.BPaqueteria).HasColumnName("B_PAQUETERIA");

                entity.Property(e => e.CAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_ACCION")
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.CAplicacionAccion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_APLICACION_ACCION")
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.CComentarios)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_COMENTARIOS");

                entity.Property(e => e.CDescripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_DESCRIPCION");

                entity.Property(e => e.CMaquinaAccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_MAQUINA_ACCION")
                    .UseCollation("Modern_Spanish_CI_AS");

                entity.Property(e => e.CMedidas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_MEDIDAS");

                entity.Property(e => e.CRecibidaPor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_RECIBIDA_POR");

                entity.Property(e => e.CTracking)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_TRACKING");

                entity.Property(e => e.CWa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_WA");

                entity.Property(e => e.DFechaAccion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_ACCION");

                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CREACION");

                entity.Property(e => e.DFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_MODIFICACION");

                entity.Property(e => e.DFechaRecibida)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_RECIBIDA");

                entity.Property(e => e.FPeso).HasColumnName("F_PESO");

                entity.Property(e => e.NCantidadCajas).HasColumnName("N_CANTIDAD_CAJAS");

                entity.Property(e => e.NCodigoCarrier)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_CARRIER");

                entity.Property(e => e.NCodigoConsignee)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_CONSIGNEE");

                entity.Property(e => e.NCodigoDestino)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_DESTINO");

                entity.Property(e => e.NCodigoEstado).HasColumnName("N_CODIGO_ESTADO");

                entity.Property(e => e.NCodigoModo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_MODO");

                entity.Property(e => e.NCodigoOrigen)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_ORIGEN");

                entity.Property(e => e.NCodigoPosicion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_POSICION");

                entity.Property(e => e.NCodigoShipper)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_SHIPPER");

                entity.Property(e => e.NCodigoWarehouse)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_WAREHOUSE");

                entity.Property(e => e.NCreadoPor).HasColumnName("N_CREADO_POR");

                entity.Property(e => e.NModificadoPor).HasColumnName("N_MODIFICADO_POR");
            });

            modelBuilder.Entity<Tmodo>(entity =>
            {
                entity.HasKey(e => e.NCodigoModo)
                    .IsClustered(false);

                entity.ToTable("TMODO");

                entity.Property(e => e.NCodigoModo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_MODO");

                entity.Property(e => e.CModo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_MODO");
            });

            modelBuilder.Entity<Tpai>(entity =>
            {
                entity.HasKey(e => e.NCodigoPais)
                    .IsClustered(false);

                entity.ToTable("TPAIS");

                entity.Property(e => e.NCodigoPais)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_PAIS");

                entity.Property(e => e.CPais)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_PAIS");
            });

            modelBuilder.Entity<Tpantalla>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TPANTALLA");

                entity.Property(e => e.CClaveEmail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_CLAVE_EMAIL");

                entity.Property(e => e.CCuentaEmail)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_CUENTA_EMAIL");

                entity.Property(e => e.CImpresorEtiqueta)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_IMPRESOR_ETIQUETA");

                entity.Property(e => e.CImpresorRecibo1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_IMPRESOR_RECIBO1");

                entity.Property(e => e.CImpresorRecibo2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_IMPRESOR_RECIBO2");

                entity.Property(e => e.CMensaje)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_MENSAJE");

                entity.Property(e => e.CPuertoSmtp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_PUERTO_SMTP");

                entity.Property(e => e.CRutaVideo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_RUTA_VIDEO");

                entity.Property(e => e.CServidorSmtp)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_SERVIDOR_SMTP");

                entity.Property(e => e.NCantidadRegistros).HasColumnName("N_CANTIDAD_REGISTROS");

                entity.Property(e => e.NSegundos).HasColumnName("N_SEGUNDOS");
            });

            modelBuilder.Entity<Tperfil>(entity =>
            {
                entity.HasKey(e => e.NCodigoPerfil)
                    .IsClustered(false);

                entity.ToTable("TPERFIL");

                entity.Property(e => e.NCodigoPerfil)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_PERFIL");

                entity.Property(e => e.CNombrePerfil)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_NOMBRE_PERFIL");
            });

            modelBuilder.Entity<Tpersona>(entity =>
            {
                entity.HasKey(e => e.NCodigoPersona)
                    .IsClustered(false);

                entity.ToTable("TPERSONA");

                entity.HasIndex(e => e.NCodigoPais, "TPAIS_TPERSONA_FK");

                entity.HasIndex(e => e.NCodigoPuerto, "TPUERTO_TPERSONA_FK");

                entity.HasIndex(e => e.NCodigoTipo, "TTIPO_PERSONA_TPERSONA_FK");

                entity.Property(e => e.NCodigoPersona)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_PERSONA");

                entity.Property(e => e.CCiudad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_CIUDAD");

                entity.Property(e => e.CContacto)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_CONTACTO");

                entity.Property(e => e.CDireccion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_DIRECCION");

                entity.Property(e => e.CDireccion2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_DIRECCION2");

                entity.Property(e => e.CEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_EMAIL");

                entity.Property(e => e.CEmail2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_EMAIL2");

                entity.Property(e => e.CEstado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_ESTADO");

                entity.Property(e => e.CFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_FAX");

                entity.Property(e => e.CFax2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_FAX2");

                entity.Property(e => e.CMarca)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_MARCA");

                entity.Property(e => e.CNombres)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_NOMBRES");

                entity.Property(e => e.CTelefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_TELEFONO");

                entity.Property(e => e.CTelefono2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_TELEFONO2");

                entity.Property(e => e.CZip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_ZIP");

                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CREACION");

                entity.Property(e => e.DFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_MODIFICACION");

                entity.Property(e => e.NCodigoPais)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_PAIS");

                entity.Property(e => e.NCodigoPuerto)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_PUERTO");

                entity.Property(e => e.NCodigoTipo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_TIPO");

                entity.Property(e => e.NCreadoPor).HasColumnName("N_CREADO_POR");

                entity.Property(e => e.NModificadoPor).HasColumnName("N_MODIFICADO_POR");

                entity.HasOne(d => d.NCodigoPaisNavigation)
                    .WithMany(p => p.Tpersonas)
                    .HasForeignKey(d => d.NCodigoPais)
                    .HasConstraintName("FK_TPERSONA_TPAIS");

                entity.HasOne(d => d.NCodigoPuertoNavigation)
                    .WithMany(p => p.Tpersonas)
                    .HasForeignKey(d => d.NCodigoPuerto)
                    .HasConstraintName("FK_TPERSONA_TPUERTO");

                entity.HasOne(d => d.NCodigoTipoNavigation)
                    .WithMany(p => p.Tpersonas)
                    .HasForeignKey(d => d.NCodigoTipo)
                    .HasConstraintName("FK_TPERSONA_TTIPO_PERSONA");
            });

            modelBuilder.Entity<Tposicion>(entity =>
            {
                entity.HasKey(e => e.NCodigoPosicion)
                    .IsClustered(false);

                entity.ToTable("TPOSICION");

                entity.Property(e => e.NCodigoPosicion)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_POSICION");

                entity.Property(e => e.BEstado).HasColumnName("B_ESTADO");

                entity.Property(e => e.CPosicion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_POSICION");
            });

            modelBuilder.Entity<TposicionTpersona>(entity =>
            {
                entity.HasKey(e => new { e.NCodigoPosicion, e.NCodigoPersona });

                entity.ToTable("TPOSICION_TPERSONA");

                entity.Property(e => e.NCodigoPosicion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_POSICION");

                entity.Property(e => e.NCodigoPersona)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_PERSONA");

                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CREACION");

                entity.Property(e => e.DFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_MODIFICACION");

                entity.Property(e => e.NCreadoPor).HasColumnName("N_CREADO_POR");

                entity.Property(e => e.NModificadoPor).HasColumnName("N_MODIFICADO_POR");

                entity.HasOne(d => d.NCodigoPersonaNavigation)
                    .WithMany(p => p.TposicionTpersonas)
                    .HasForeignKey(d => d.NCodigoPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPOSICION_TPERSONA_TPERSONA");

                entity.HasOne(d => d.NCodigoPosicionNavigation)
                    .WithMany(p => p.TposicionTpersonas)
                    .HasForeignKey(d => d.NCodigoPosicion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPOSICION_TPERSONA_TPOSICION");
            });

            modelBuilder.Entity<Tpuerto>(entity =>
            {
                entity.HasKey(e => e.NCodigoPuerto)
                    .IsClustered(false);

                entity.ToTable("TPUERTO");

                entity.HasIndex(e => e.NCodigoPais, "TPAIS_TPUERTO_FK");

                entity.HasIndex(e => e.NCodigoPais, "UNIQ_N_CODIGO_PAIS")
                    .IsUnique();

                entity.Property(e => e.NCodigoPuerto)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_PUERTO");

                entity.Property(e => e.CPuerto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_PUERTO");

                entity.Property(e => e.NCodigoPais)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_PAIS");
            });

            modelBuilder.Entity<Treempaque>(entity =>
            {
                entity.HasKey(e => e.NCodigoReempaque);

                entity.ToTable("TREEMPAQUE");

                entity.Property(e => e.NCodigoReempaque)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_REEMPAQUE");

                entity.Property(e => e.CEntregadoPor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_ENTREGADO_POR");

                entity.Property(e => e.CFolio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_FOLIO");

                entity.Property(e => e.CMc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_MC");

                entity.Property(e => e.CMedidas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_MEDIDAS");

                entity.Property(e => e.CPa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_PA");

                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CREACION");

                entity.Property(e => e.DFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_MODIFICACION");

                entity.Property(e => e.FCbm).HasColumnName("F_CBM");

                entity.Property(e => e.FPeso).HasColumnName("F_PESO");

                entity.Property(e => e.FPesoActual).HasColumnName("F_PESO_ACTUAL");

                entity.Property(e => e.FPesoCobrable).HasColumnName("F_PESO_COBRABLE");

                entity.Property(e => e.FPesoVolumen).HasColumnName("F_PESO_VOLUMEN");

                entity.Property(e => e.NCantidadCajas).HasColumnName("N_CANTIDAD_CAJAS");

                entity.Property(e => e.NCodigoConsignee)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_CONSIGNEE");

                entity.Property(e => e.NCodigoDestino)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_DESTINO");

                entity.Property(e => e.NCodigoOrigen)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_ORIGEN");

                entity.Property(e => e.NCodigoPosicion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_POSICION");

                entity.Property(e => e.NCodigoShipper)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_SHIPPER");

                entity.Property(e => e.NCodigoTransporte).HasColumnName("N_CODIGO_TRANSPORTE");

                entity.Property(e => e.NCreadoPor).HasColumnName("N_CREADO_POR");

                entity.Property(e => e.NModificadoPor).HasColumnName("N_MODIFICADO_POR");

                entity.HasOne(d => d.NCodigoConsigneeNavigation)
                    .WithMany(p => p.Treempaques)
                    .HasForeignKey(d => d.NCodigoConsignee)
                    .HasConstraintName("FK_TREEMPAQUE_TPERSONA");

                entity.HasOne(d => d.NCodigoDestinoNavigation)
                    .WithMany(p => p.Treempaques)
                    .HasForeignKey(d => d.NCodigoDestino)
                    .HasConstraintName("FK_TREEMPAQUE_TPUERTO");

                entity.HasOne(d => d.NCodigoPosicionNavigation)
                    .WithMany(p => p.Treempaques)
                    .HasForeignKey(d => d.NCodigoPosicion)
                    .HasConstraintName("FK_TREEMPAQUE_TPOSICION");
            });

            modelBuilder.Entity<TreempaqueDetalle>(entity =>
            {
                entity.HasKey(e => e.NCodigoReempaqueDetalle);

                entity.ToTable("TREEMPAQUE_DETALLE");

                entity.Property(e => e.NCodigoReempaqueDetalle)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_REEMPAQUE_DETALLE");

                entity.Property(e => e.CMedidas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_MEDIDAS");

                entity.Property(e => e.FCbm).HasColumnName("F_CBM");

                entity.Property(e => e.FPeso).HasColumnName("F_PESO");

                entity.Property(e => e.FPesoActual).HasColumnName("F_PESO_ACTUAL");

                entity.Property(e => e.FPesoCobrable).HasColumnName("F_PESO_COBRABLE");

                entity.Property(e => e.FPesoVolumen).HasColumnName("F_PESO_VOLUMEN");

                entity.Property(e => e.NCantidadCajas).HasColumnName("N_CANTIDAD_CAJAS");

                entity.Property(e => e.NCodigoReempaque)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_REEMPAQUE");

                entity.Property(e => e.NPalete).HasColumnName("N_PALETE");

                entity.HasOne(d => d.NCodigoReempaqueNavigation)
                    .WithMany(p => p.TreempaqueDetalles)
                    .HasForeignKey(d => d.NCodigoReempaque)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TREEMPAQUE_DETALLE_TREEMPAQUE");
            });

            modelBuilder.Entity<TreempaqueWarehouse>(entity =>
            {
                entity.HasKey(e => new { e.NCodigoReempaque, e.NCodigoWarehouse });

                entity.ToTable("TREEMPAQUE_WAREHOUSE");

                entity.Property(e => e.NCodigoReempaque)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_REEMPAQUE");

                entity.Property(e => e.NCodigoWarehouse)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_WAREHOUSE");

                entity.Property(e => e.FPeso).HasColumnName("F_PESO");

                entity.Property(e => e.NCantidadCajas).HasColumnName("N_CANTIDAD_CAJAS");

                entity.HasOne(d => d.NCodigoReempaqueNavigation)
                    .WithMany(p => p.TreempaqueWarehouses)
                    .HasForeignKey(d => d.NCodigoReempaque)
                    .HasConstraintName("FK_TREEMPAQUE_WAREHOUSE_TREEMPAQUE");

                entity.HasOne(d => d.NCodigoWarehouseNavigation)
                    .WithMany(p => p.TreempaqueWarehouses)
                    .HasForeignKey(d => d.NCodigoWarehouse)
                    .HasConstraintName("FK_TREEMPAQUE_WAREHOUSE_TWAREHOUSE");
            });

            modelBuilder.Entity<TtipoPersona>(entity =>
            {
                entity.HasKey(e => e.NCodigoTipo)
                    .IsClustered(false);

                entity.ToTable("TTIPO_PERSONA");

                entity.Property(e => e.NCodigoTipo)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_TIPO");

                entity.Property(e => e.CTipo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_TIPO");
            });

            modelBuilder.Entity<Ttransporte>(entity =>
            {
                entity.HasKey(e => e.NCodigoTransporte);

                entity.ToTable("TTRANSPORTE");

                entity.Property(e => e.NCodigoTransporte).HasColumnName("N_CODIGO_TRANSPORTE");

                entity.Property(e => e.CObservaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_OBSERVACIONES");

                entity.Property(e => e.CTransporte)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_TRANSPORTE");
            });

            modelBuilder.Entity<Tusuario>(entity =>
            {
                entity.HasKey(e => e.NCodigoUsuario)
                    .IsClustered(false);

                entity.ToTable("TUSUARIO");

                entity.Property(e => e.NCodigoUsuario)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_USUARIO");

                entity.Property(e => e.BActivo).HasColumnName("B_ACTIVO");

                entity.Property(e => e.CAplicacionCreado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_APLICACION_CREADO");

                entity.Property(e => e.CAplicacionModificado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_APLICACION_MODIFICADO");

                entity.Property(e => e.CIMpresorEtiqueta)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_iMPRESOR_ETIQUETA");

                entity.Property(e => e.CImpresorRecibo1)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_IMPRESOR_RECIBO1");

                entity.Property(e => e.CImpresorRecibo2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_IMPRESOR_RECIBO2");

                entity.Property(e => e.CMaquinaCreado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_MAQUINA_CREADO");

                entity.Property(e => e.CMaquinaModificado)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_MAQUINA_MODIFICADO");

                entity.Property(e => e.CNombrePersona)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_NOMBRE_PERSONA");

                entity.Property(e => e.CNombreUsuario)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_NOMBRE_USUARIO");

                entity.Property(e => e.CPassword)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_PASSWORD");

                entity.Property(e => e.DFechaCaducidad)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CADUCIDAD");

                entity.Property(e => e.DFechaCreado)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CREADO");

                entity.Property(e => e.DFechaModificado)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_MODIFICADO");

                entity.HasMany(d => d.NCodigoPerfils)
                    .WithMany(p => p.NCodigoUsuarios)
                    .UsingEntity<Dictionary<string, object>>(
                        "TperfilUsuario",
                        l => l.HasOne<Tperfil>().WithMany().HasForeignKey("NCodigoPerfil").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TPERFIL_USUARIO_TPERFIL"),
                        r => r.HasOne<Tusuario>().WithMany().HasForeignKey("NCodigoUsuario").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_TPERFIL_USUARIO_TUSUARIO"),
                        j =>
                        {
                            j.HasKey("NCodigoUsuario", "NCodigoPerfil");

                            j.ToTable("TPERFIL_USUARIO");

                            j.HasIndex(new[] { "NCodigoPerfil" }, "TPERFIL_USUARIO2_FK");

                            j.HasIndex(new[] { "NCodigoUsuario" }, "TPERFIL_USUARIO_FK");

                            j.IndexerProperty<decimal>("NCodigoUsuario").HasColumnType("numeric(18, 0)").HasColumnName("N_CODIGO_USUARIO");

                            j.IndexerProperty<decimal>("NCodigoPerfil").HasColumnType("numeric(18, 0)").HasColumnName("N_CODIGO_PERFIL");
                        });
            });

            modelBuilder.Entity<Twarehouse>(entity =>
            {
                entity.HasKey(e => e.NCodigoWarehouse)
                    .IsClustered(false);

                entity.ToTable("TWAREHOUSE");

                entity.HasIndex(e => e.NCodigoCarrier, "TCARRIER_TWAREHOUSE_FK");

                entity.HasIndex(e => e.NCodigoModo, "TMODO_TWAREHOUSE_FK");

                entity.HasIndex(e => e.NCodigoConsignee, "TPERSONA_TWAREHOUSE1_FK");

                entity.HasIndex(e => e.NCodigoShipper, "TPERSONA_TWAREHOUSE2_FK");

                entity.HasIndex(e => e.NCodigoPosicion, "TPOSICION_TWAREHOUSE_FK");

                entity.HasIndex(e => e.NCodigoOrigen, "TPUERTO_TWAREHOUSE1_FK");

                entity.HasIndex(e => e.NCodigoDestino, "TPUERTO_TWAREHOUSE2_FK");

                entity.Property(e => e.NCodigoWarehouse)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("N_CODIGO_WAREHOUSE");

                entity.Property(e => e.BCorreoEnviado).HasColumnName("B_CORREO_ENVIADO");

                entity.Property(e => e.BPaqueteria).HasColumnName("B_PAQUETERIA");

                entity.Property(e => e.CComentarios)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_COMENTARIOS");

                entity.Property(e => e.CDescripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_DESCRIPCION");

                entity.Property(e => e.CMedidas)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("C_MEDIDAS");

                entity.Property(e => e.CRecibidaPor)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("C_RECIBIDA_POR");

                entity.Property(e => e.CTracking)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("C_TRACKING");

                entity.Property(e => e.CWa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_WA");

                entity.Property(e => e.DFechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_CREACION");

                entity.Property(e => e.DFechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_MODIFICACION");

                entity.Property(e => e.DFechaRecibida)
                    .HasColumnType("datetime")
                    .HasColumnName("D_FECHA_RECIBIDA");

                entity.Property(e => e.FCbm).HasColumnName("F_CBM");

                entity.Property(e => e.FPeso).HasColumnName("F_PESO");

                entity.Property(e => e.NCantidadCajas).HasColumnName("N_CANTIDAD_CAJAS");

                entity.Property(e => e.NCodigoCarrier)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_CARRIER");

                entity.Property(e => e.NCodigoConsignee)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_CONSIGNEE");

                entity.Property(e => e.NCodigoDestino)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_DESTINO");

                entity.Property(e => e.NCodigoEstado)
                    .HasColumnName("N_CODIGO_ESTADO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NCodigoModo)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_MODO");

                entity.Property(e => e.NCodigoOrigen)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_ORIGEN");

                entity.Property(e => e.NCodigoPosicion)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_POSICION");

                entity.Property(e => e.NCodigoShipper)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_SHIPPER");

                entity.Property(e => e.NCreadoPor).HasColumnName("N_CREADO_POR");

                entity.Property(e => e.NModificadoPor).HasColumnName("N_MODIFICADO_POR");

                entity.HasOne(d => d.NCodigoCarrierNavigation)
                    .WithMany(p => p.Twarehouses)
                    .HasForeignKey(d => d.NCodigoCarrier)
                    .HasConstraintName("FK_TWAREHOUSE_TCARRIER");

                entity.HasOne(d => d.NCodigoConsigneeNavigation)
                    .WithMany(p => p.TwarehouseNCodigoConsigneeNavigations)
                    .HasForeignKey(d => d.NCodigoConsignee)
                    .HasConstraintName("FK_TWAREHOUSE_TPERSONA1");

                entity.HasOne(d => d.NCodigoDestinoNavigation)
                    .WithMany(p => p.TwarehouseNCodigoDestinoNavigations)
                    .HasForeignKey(d => d.NCodigoDestino)
                    .HasConstraintName("FK_TWAREHOUSE_TPUERTO1");

                entity.HasOne(d => d.NCodigoModoNavigation)
                    .WithMany(p => p.Twarehouses)
                    .HasForeignKey(d => d.NCodigoModo)
                    .HasConstraintName("FK_TWAREHOUSE_TMODO");

                entity.HasOne(d => d.NCodigoOrigenNavigation)
                    .WithMany(p => p.TwarehouseNCodigoOrigenNavigations)
                    .HasForeignKey(d => d.NCodigoOrigen)
                    .HasConstraintName("FK_TWAREHOUSE_TPUERTO");

                entity.HasOne(d => d.NCodigoPosicionNavigation)
                    .WithMany(p => p.Twarehouses)
                    .HasForeignKey(d => d.NCodigoPosicion)
                    .HasConstraintName("FK_TWAREHOUSE_TPOSICION");

                entity.HasOne(d => d.NCodigoShipperNavigation)
                    .WithMany(p => p.TwarehouseNCodigoShipperNavigations)
                    .HasForeignKey(d => d.NCodigoShipper)
                    .HasConstraintName("FK_TWAREHOUSE_TPERSONA");
            });

            modelBuilder.Entity<TwarehouseDetalle>(entity =>
            {
                entity.HasKey(e => new { e.NCodigoWarehouse, e.NCodigoWarehouseDetalle })
                    .IsClustered(false);

                entity.ToTable("TWAREHOUSE_DETALLE");

                entity.HasIndex(e => e.NCodigoWarehouse, "TWAREHOUSE_DETALLE_TWAREHOUSE_FK");

                entity.Property(e => e.NCodigoWarehouse)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("N_CODIGO_WAREHOUSE");

                entity.Property(e => e.NCodigoWarehouseDetalle).HasColumnName("N_CODIGO_WAREHOUSE_DETALLE");

                entity.Property(e => e.NAlto).HasColumnName("N_ALTO");

                entity.Property(e => e.NAncho).HasColumnName("N_ANCHO");

                entity.Property(e => e.NCantidadCajas).HasColumnName("N_CANTIDAD_CAJAS");

                entity.Property(e => e.NLargo).HasColumnName("N_LARGO");

                entity.HasOne(d => d.NCodigoWarehouseNavigation)
                    .WithMany(p => p.TwarehouseDetalles)
                    .HasForeignKey(d => d.NCodigoWarehouse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TWAREHOUSE_DETALLE_TWAREHOUSE");
            });

            //modelBuilder.Entity<ViewModels.TusuarioVM>(entity =>
            //{
            //    entity.HasKey(e => e.NCodigoUsuario)
            //        .IsClustered(false);

            //    entity.ToTable("TUSUARIO");

            //    entity.Property(e => e.NCodigoUsuario)
            //        .HasColumnType("numeric(18, 0)")
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("N_CODIGO_USUARIO");

            //    entity.Property(e => e.BActivo).HasColumnName("B_ACTIVO");

            //    entity.Property(e => e.CAplicacionCreado)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_APLICACION_CREADO");

            //    entity.Property(e => e.CAplicacionModificado)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_APLICACION_MODIFICADO");

            //    entity.Property(e => e.CIMpresorEtiqueta)
            //        .HasMaxLength(500)
            //        .IsUnicode(false)
            //        .HasColumnName("C_iMPRESOR_ETIQUETA");

            //    entity.Property(e => e.CImpresorRecibo1)
            //        .HasMaxLength(500)
            //        .IsUnicode(false)
            //        .HasColumnName("C_IMPRESOR_RECIBO1");

            //    entity.Property(e => e.CImpresorRecibo2)
            //        .HasMaxLength(500)
            //        .IsUnicode(false)
            //        .HasColumnName("C_IMPRESOR_RECIBO2");

            //    entity.Property(e => e.CMaquinaCreado)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_MAQUINA_CREADO");

            //    entity.Property(e => e.CMaquinaModificado)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_MAQUINA_MODIFICADO");

            //    entity.Property(e => e.CNombrePersona)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_NOMBRE_PERSONA");

            //    entity.Property(e => e.CNombreUsuario)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_NOMBRE_USUARIO");

            //    entity.Property(e => e.CPassword)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_PASSWORD");

            //    entity.Property(e => e.DFechaCaducidad)
            //        .HasColumnType("datetime")
            //        .HasColumnName("D_FECHA_CADUCIDAD");

            //    entity.Property(e => e.DFechaCreado)
            //        .HasColumnType("datetime")
            //        .HasColumnName("D_FECHA_CREADO");

            //    entity.Property(e => e.DFechaModificado)
            //        .HasColumnType("datetime")
            //        .HasColumnName("D_FECHA_MODIFICADO");

            //    entity.Property(e => e.NCodigoPerfil)
            //        .HasColumnType("numeric(18, 0)")
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("N_CODIGO_PERFIL");

            //    entity.Property(e => e.CNombrePerfil)
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("C_NOMBRE_PERFIL");

            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
