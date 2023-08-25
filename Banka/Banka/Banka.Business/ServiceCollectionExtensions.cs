using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banka.Business.Implementations;
using Banka.Business.Interfaces;
using Banka.Business.Profiles;
using Banka.DataAccess.Interfaces;
using WS.DataAccess.Implementations.EFCore.Repositories;
using Banka.DataAccess.Implementations.EFCore.Repositories;
using WS.DataAccess.Interfaces;
using Banka.DataAccess.EF.Repositories;
using Banka.DataAccess.EFCore.Repositories;

namespace Banka.Business
{
    public static class ServiceCollectionExtensions
    {
        public static void AddBusinessServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(BankaBilgiProfile));

            services.AddScoped<IBankaBilgiBs, BankaBilgiBs>();
            services.AddScoped<IBankaBilgiRepository, BankaBilgiRepository>();

            services.AddScoped<IBankaKartiBs, BankaKartiBs>();
            services.AddScoped<IBankaKartiRepository, BankaKartiRepository>();

            services.AddScoped<IDolarHesapBs, DolarHesapBs>();
            services.AddScoped<IDolarHesapRepository, DolarHesapRepository>();

            services.AddScoped<IDolarSwiftBs, DolarSwiftBs>();
            services.AddScoped<IDolarSwiftRepository, DolarSwiftRepository>();

            services.AddScoped<IDovizBs, DovizBs>();
            services.AddScoped<IDovizRepository, DovizRepository>();

            services.AddScoped<IEFTBs, EFTBs>();
            services.AddScoped<IEFTRepository, EFTRepository>();

            services.AddScoped<IEuroHesapBs, EuroHesapBs>();
            services.AddScoped<IEuroHesapRepository, EuroHesapRepository>();

            services.AddScoped<IEuroSwiftBs, EuroSwiftBs>();
            services.AddScoped<IEuroSwiftRepository, EuroSwiftRepository>();

            services.AddScoped<IFaturaOdeBs, FaturaOdeBs>();
            services.AddScoped<IFaturaOdeRepository, FaturaOdeRepository>();

            services.AddScoped<IGümüsHesapBs, GümüsHesapBs>();
            services.AddScoped<IGümüsHesapRepository, GümüsHesapRepository>();

            services.AddScoped<IHarcamaBs, HarcamaBs>();
            services.AddScoped<IHarcamaRepository, HarcamaRepository>();

            services.AddScoped<IHizliKrediBs, HizliKrediBs>();
            services.AddScoped<IHizliKrediRepository, HizliKrediRepository>();

            services.AddScoped<IKartaParaAktarBs, KartaParaAktarBs>();
            services.AddScoped<IKartaParaAktarRepository, KartaParaAktarRepository>();

            services.AddScoped<IKartlarBs, KartlarBs>();
            services.AddScoped<IKartlarRepository, KartlarRepository>();

            services.AddScoped<IKrediKartıBs, KrediKartıBs>();
            services.AddScoped<IKrediKartıRepository, KrediKartıRepository>();

            services.AddScoped<IKurKorumalıHesapBs, KurKorumalıHesapBs>();
            services.AddScoped<IKurKorumalıHesapRepository, KurKorumalıHesapRepository>();

            services.AddScoped<IMusteriDataBs, MusteriDataBs>();
            services.AddScoped<IMusteriDataRepository, MusteriDataRepository>();

            services.AddScoped<IMusteriVarlikBs, MusteriVarlikBs>();
            services.AddScoped<IMusteriVarlikRepository, MusteriVarlikRepository>();

            services.AddScoped<INakitAvansBs, NakitAvansBs>();
            services.AddScoped<INakitAvansRepository, NakitAvansRepository>();

            services.AddScoped<ISanalKartBs, SanalKartBs>();
            services.AddScoped<ISanalKartRepository, SanalKartRepository>();

            services.AddScoped<ISterlinHesapBs, SterlinHesapBs>();
            services.AddScoped<ISterlinHesapRepository, SterlinHesapRepository>();

            services.AddScoped<ISterlinSwiftBs, SterlinSwiftBs>();
            services.AddScoped<ISterlinSwiftRepository, SterlinSwiftRepository>();

            services.AddScoped<ITLHavaleBs, TLHavaleBs>();
            services.AddScoped<ITLHavaleRepository, TLHavaleRepository>();

            services.AddScoped<IVadeliTLHesapBs, VadeliTLHesapBs>();
            services.AddScoped<IVadeliTLHesapRepository, VadeliTLHesapRepository>();

            services.AddScoped<IVadesizTLHesapBs, VadesizTLHesapBs>();
            services.AddScoped<IVadesizTLHesapRepository, VadesizTLHesapRepository>();

            services.AddScoped<IVergiBorcuOdeBs, VergiBorcuOdeBs>();
            services.AddScoped<IVergiBorcuOdeRepository, VergiBorcuOdeRepository>();

            services.AddScoped<IAdminUserBs, AdminUserBs>();
            services.AddScoped<IAdminUserRepository, AdminUserRepository>();

         

        }
    }
}
