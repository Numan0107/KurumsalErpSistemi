# 🏢 KurumsalErpSistemi - Çoklu Mağaza ve İlişkisel Stok Yönetim ERP Yazılımı

Zincir mağazalara ve holding yapılarına uygun, çoklu şube yönetimi ile merkez ürün havuzu arasındaki ilişkisel veri akışını gerçek zamanlı ve kalıcı olarak yöneten kurumsal bir ERP otomasyonudur.

## 🛠️ Kullanılan Teknolojiler
* **C# 13** & .NET 9.0 (Blazor Server Architecture)
* Entity Framework Core (Code-First)
* SQLite Veritabanı
* HTML5 & Bootstrap CSS (Responsive Tasarım)

## 🚀 Ne Yapıyor?
* **Kalıcı Veritabanı Altyapısı:** Tüm şube, ürün ve stok verileri SQLite veritabanında (`kurumsal_erp.db`) kalıcı olarak saklanır ve sistem kapatılsa dahi veri kaybı yaşanmaz.
* **Merkez Ürün Havuzu:** Barkod, ürün adı, kategori ve fiyat bilgilerini içeren ana ürün tanımlamalarını merkezi bir veritabanı şemasında yönetir.
* **Şube ve Lokasyon Yönetimi:** Holding bünyesindeki aktif şubeleri, yetkili müdürleri ve şehir lokasyonlarını SQL seviyesinde haritalandırır.
* **Gelişmiş Stok Transfer Motoru:** Merkez havuzundaki ürünleri hedef şubelere adet belirterek transfer eder, şube içi satışları düşer ve tüm geçmişi ilişkisel stok hareket logları (`StokHareketleri`) altında kalıcı olarak imzalar.
* **Envanter Raporlama Paneli:** Şube bazlı net stok miktarlarını dinamik olarak hesaplar, kritik stok seviyelerinin altına düşen ürünleri görsel uyarı sistemleri ile raporlar.

