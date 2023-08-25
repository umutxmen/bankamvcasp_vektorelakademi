## ASP.NET Core ve MVC İle Banka Uygulaması:
Bu projede, finansal işlemleri modern bir yaklaşımla yönetmek üzere ASP.NET Core 6 ve MVC kullanılarak bir Banka Uygulaması oluşturdum. Amacımız, kullanıcıların finansal işlemlerini,kredilerini,borçlarını,kartlarını vs tutup bir arayüz üzerinden güncelleme silme ve ekleme işlemlerinin yapılabilmesi.

Teknolojik Altyapı ve Kullanılan Araçlar
ASP.NET Core 6: Web tabanlı uygulamaları hızlıca geliştirmek için güçlü bir platform.

Entity Framework Core: Veritabanı işlemlerini yönetmek için kullanılan modern bir ORM (Object-Relational Mapping) aracı.

Identity Framework: Kullanıcı kimlik doğrulama, yetkilendirme ve hesap yönetimi işlemlerini basit ve etkili bir şekilde halletmemizi sağlayan bileşen.

Fluent Validation: Kullanıcı girişlerini doğrulamak ve iş kurallarını uygulamak için kullanılan kütüphane.

AutoMapper: Nesneler arasında veri dönüşümlerini hızlı ve otomatik bir şekilde yapmamıza yardımcı olur.

Swagger: API belgelerini otomatik olarak oluşturan bir arayüz sağlar.

## Proje Yapısı ve Katmanlar:
Bu projede, düzenli ve sürdürülebilir bir şekilde kod yazabilmek için katmanlı bir yapı kullanılmıştır:

Altyapı (Infrastructure) Katmanı: Temel işlemleri yönetmek için gerekli araçları içerir. Örneğin, veritabanı bağlantısı ve e-posta gönderme gibi.

Veri Erişim (DataAccess) Katmanı: Veritabanı işlemleri için soyutlamaları içerir. Generic repository arayüzü ve Entity Framework Core ile entegre edilen sınıflar burada bulunur.

İş Mantığı (Business) Katmanı: Finansal işlemleri yöneten kodların bulunduğu yer. Hesap açma, para transferi gibi işlemler burada gerçekleştirilir. Aynı zamanda, giriş verilerinin doğrulama kuralları ve hata mesajları da bu katmanda tanımlanır.

API Katmanı: Web API'nin oluşturulduğu yerdir. Kimlik doğrulama ayarları gibi yapılandırmalar appsettings.json dosyasında yapılır. Hata yönetimi ve API metotları burada bulunur.

MVC Katmanı: Kullanıcı arayüzünün oluşturulduğu yerdir. Kullanıcıların hesaplarını görüntülemesi, işlem yapması gibi işlemleri içeren bileşenler burada yer alır.
MVC Katmanları ve Görevleri
MVC (Model-View-Controller) tasarım deseni, projenin katmanlarını mantıklı ve düzenli bir şekilde organize eder. İşte bu uygulamada kullanılan MVC katmanlarının görevlerini ayrıntılı bir şekilde açıklamaları:

## Model Katmanı:

Verilerin yapısal temsilini sağlar.
Veritabanı işlemleri ve nesne ilişkilendirmeleri burada gerçekleştirilir.
Örneğin, Hesap ve İşlem gibi sınıflar bu katmanda yer alır.
View Katmanı:

Kullanıcı arayüzünün tasarımını ve sunumunu sağlar.
HTML, CSS ve Razor kodlarını içerir.
Kullanıcıya sunulan sayfalar ve kullanıcı etkileşimi bu katmanda tasarlanır.
Controller Katmanı:

Kullanıcının taleplerini karşılar ve işlemleri yönetir.
Kullanıcının giriş yapma, hesap işlemleri gibi talepleri bu katmanda ele alınır.
Model ve View arasındaki iletişimi sağlar.
Ara Katmanlar:

Bu katmanlar, projenin düzenini ve iş akışını daha iyi yönetmek için kullanılır.
Örneğin, Servisler ve Dependency Injection yönetimi bu katmanlarda yer alır.
ViewModel Katmanı:

Model ve View arasında veri taşıma ve dönüşümünü sağlar.
Kullanıcının ihtiyaçlarına uygun veri düzenlemeleri yapar.
Özellikle, View tarafından ihtiyaç duyulan spesifik verileri içerebilir.
MVC Katmanlarının Çalışma Süreci
Kullanıcı bir tarayıcıdan belirli bir sayfayı talep eder (örneğin, hesap detayları).

Talep, Controller katmanında ilgili yönlendiriciye yönlendirilir.

Yönlendirici, ilgili Controller'a gerekli işlemi yapması için talimat verir.

Controller, işlemleri gerçekleştirmek için gerekli olan servisleri kullanarak Model ve ViewModel'i hazırlar.

Model ve ViewModel, View'e geçirilir. View, bu verileri kullanarak sayfanın görüntüsünü oluşturur.

Oluşturulan görüntü, kullanıcıya sunulur.

Bu adımlar, kullanıcının talep ettiği sayfanın hazırlanması ve sunulması sürecini temsil eder. Her katmanın ayrı görevleri olduğu için uygulamanın sürdürülebilirliği artar ve geliştirme daha kolay hale gelir.
## Proje Tanıtım Videosu

[Tanıtım Videosu](https://www.youtube.com/watch?v=JJAnnqGDPsQ)

## NOT
Banka : Service katmanı
BankaMVC: MVC katmanı

Banka service katmanındaki  BankaContextdeki sqlserver adresi bireysel bilgisayarınıza göre güncellenmelidir.