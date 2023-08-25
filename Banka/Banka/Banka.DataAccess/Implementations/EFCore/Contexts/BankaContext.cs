using Banka.Model.Dtos.MusteriData;
using Banka.Model.Dtos.MusteriVarlik;
using Banka.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka.DataAccess.Implementations.EFCore.Contexts
{
    public class BankaContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankaBilgi>().HasKey("BankaId");
            modelBuilder.Entity<BankaKarti>().HasKey("BankaKartID");
            modelBuilder.Entity<MusteriData>().HasKey("MusteriDataID");
            modelBuilder.Entity<MusteriVarlikGetDto>().HasKey("MusteriVarlikID");
            modelBuilder.Entity<MusteriDataGetDto>().HasKey("MusteriDataID");
            modelBuilder.Entity<DolarHesap>().HasKey("DolarHesapID");
            modelBuilder.Entity<DolarSwift>().HasKey("DolarSwiftID");
            modelBuilder.Entity<Doviz>().HasKey("DovizID");
            modelBuilder.Entity<EFT>().HasKey("EFTID");
            modelBuilder.Entity<EuroHesap>().HasKey("EuroHesapID");
            modelBuilder.Entity<EuroSwift>().HasKey("EuroSwiftID");
            modelBuilder.Entity<FaturaOde>().HasKey("FaturaYatırİslemID");
            modelBuilder.Entity<GümüsHesap>().HasKey("GümüsHesapID");
            modelBuilder.Entity<Harcama>().HasKey("HarcamaID");
            modelBuilder.Entity<HizliKredi>().HasKey("HizliKrediID");
            modelBuilder.Entity<KartaParaAktar>().HasKey("KartaParaİslemID");
            modelBuilder.Entity<Kartlar>().HasKey("KartlarID");
            modelBuilder.Entity<KrediKartı>().HasKey("KrediKartıID");
            modelBuilder.Entity<KurKorumalıHesap>().HasKey("KurKorumaliHesapId");
            modelBuilder.Entity<MusteriVarlik>().HasKey("MusteriVarlikID");
            modelBuilder.Entity<NakitAvans>().HasKey("NakitAvansID");
            modelBuilder.Entity<SanalKart>().HasKey("SanalKartID");
            modelBuilder.Entity<SterlinHesap>().HasKey("SterlinHesapId");
            modelBuilder.Entity<SterlinSwift>().HasKey("SterlinSwiftID");
            modelBuilder.Entity<TLHavale>().HasKey("HavaleID");
            modelBuilder.Entity<VadeliTLHesap>().HasKey("VadeliTLHesapID");
            modelBuilder.Entity<VadesizTLHesap>().HasKey("VadesizTLHesapID");
            modelBuilder.Entity<VergiBorcuOde>().HasKey("VergiodeİslemID");


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=UMUTWORKSTATIoN;database=bankasistem;trusted_connection=true;");
        }
        public DbSet<BankaBilgi> BankaBilgi { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<BankaKarti> BankaKarti { get; set; }
        public DbSet<DolarHesap> DolarHesap { get; set; }
        public DbSet<DolarSwift> DolarSwift { get; set; }
        public DbSet<Doviz> Doviz { get; set; }
        public DbSet<EFT> EFT { get; set; }
        public DbSet<EuroHesap> EuroHesap { get; set; }
        public DbSet<EuroSwift> EuroSwift { get; set; }
        public DbSet<FaturaOde> FaturaOde { get; set; }
        public DbSet<GümüsHesap> GümüsHesap { get; set; }
        public DbSet<Harcama> Harcama { get; set; }
        public DbSet<HizliKredi> HizliKredi { get; set; }
        public DbSet<KartaParaAktar> KartaParaAktar { get; set; }
        public DbSet<Kartlar> Kartlar { get; set; }
        public DbSet<KrediKartı> KrediKarti { get; set; }
        public DbSet<KurKorumalıHesap> KurKorumalıHesap { get; set; }
        public DbSet<MusteriData> MusteriData { get; set; }
        public DbSet<MusteriVarlik> MusteriVarlik { get; set; }
        public DbSet<NakitAvans> NakitAvans { get; set; }
        public DbSet<SanalKart> SanalKart { get; set; }
        public DbSet<SterlinHesap> SterlinHesap { get; set; }
        public DbSet<SterlinSwift> SterlinSwift { get; set; }
        public DbSet<TLHavale> TLHavale { get; set; }
        public DbSet<VadeliTLHesap> VadeliTLHesap { get; set; }
        public DbSet<VadesizTLHesap> VadesizTLHesap { get; set; }
        public DbSet<VergiBorcuOde> VergiBorcuOde { get; set; }
    


    }
}
