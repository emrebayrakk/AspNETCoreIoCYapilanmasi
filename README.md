## IoC Yapılanması

Uygulamanın yaşam döngüsü boyunca birbirine bağımlılığı az (loose coupling) olan nesneler oluşturmayı amaçlayan bir yazılım geliştirme prensibidir. Nesnelerin yaşam döngüsünden sorumludur, yönetimini sağlar. IoC kullanan sınıfa bir interface inject edildiğinde, ilgili interface metotları kullanılabilir olur. Böylece IoC kullanan sınıf sadece kullanacağı metotları bilir, sınıf içerisinde daha fazla metot olsa bile interface’de belirtilen metotlara erişebilecektir.

Sınıf içerisinde yapılacak herhangi bir değişiklikte IoC kullanan sınıf etkilenmeyeceği için yeniden yazılabilir ve test edilebilir yazılım geliştirmemizi sağlar. IoC nesne bağlamalar genellikle uygulama başlangıcında yapılandırılmaktadır. Bu anlamda tek bir yerden yapılan IoC yapılandırmalarının değiştirilmesi ve yönetimi de oldukça kolaydır.

### IoC kullanmanın avantajlarını şöyle sıralayabiliriz:

-Loosely coupled (bağımlılığı az) sınıflar oluşturma

-Kolay unit test yazma

-Yönetilebilirlik

-Modüler programlar

-Farklı implementasyonlar arası kolay geçiş

![Ioc](https://user-images.githubusercontent.com/77586103/131522684-2428c88c-a2a4-4a53-b661-a070b2c535ff.png)

## .NET uygulamalarında IoC yapılanmasını sağlayan third party frameworkler mevcuttur.

* Structuremap

* AutoFac

* Ninject
* Vs..


Asp.NET Core mimarisi, bu third party kütüphaneler kadar yetenekli olmasada içerisinde built-in(dahili) olarak IoC Container modülü barınmaktadır.

## Buit-in IoC Container 

Buit-in IoC Container içerisine konulacak değerleri 3 farklı davranışla ele alır.

* Singleton
* Scoped
* Transient

## Singleton

Uygulama bazlı tekil nesne oluşturur ve tüm taleplere o nesneye gönderir.

## Scoped

Her istek başına bir nesne üretir ve o istek üzerinde olan tüm isteklere o nesneyi gönderir

## Transient

Her istek başına bir nesne üretir ve gönderir 


![Kaynak](https://devnot.com/2020/ioc-prensibi-nedir-ornek-proje-ile-kullanimi-ve-avantajlari/)
