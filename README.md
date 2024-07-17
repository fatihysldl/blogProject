# blogProject
Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş bir yemek tarifi blogu uygulamasıdır. Proje, N-tier mimarisi ile tasarlanmış olup aşağıdaki katmanlardan oluşmaktadır:

1) Entity Layer: Veritabanı tablolarını temsil eden entity sınıfları bulunmaktadır.

2) Data Access Layer: Entity Framework Core kullanılarak, SQL Server üzerindeki veritabanı işlemleri bu katmanda yönetilmektedir.

3) Business Layer: İş mantığı işlemleri burada gerçekleştirilmekte, veri erişim katmanı ile arayüz katmanı arasında köprü görevi görmektedir.

4) DTO Layer: Veri transfer nesneleri (DTO'lar), farklı katmanlar arasında veri alışverişi yapmak için kullanılmaktadır.

5) UI Layer: ASP.NET Core MVC ile oluşturulan kullanıcı arayüzü katmanıdır.
Kullanılan Teknolojiler:
---
1) ASP.NET Core MVC
2) Entity Framework Core
3) Web API
4) AutoMapper
5) FluentValidation
6) SQL Server
7) Areas
Bu proje, kullanıcıların yemek tariflerini keşfetmelerini ve paylaşmalarını sağlayan modern bir web uygulamasıdır.

