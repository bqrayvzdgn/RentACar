# 🚗 Rent A Car Uygulaması

Bu proje, basit bir **Rent A Car (Araç Kiralama)** uygulamasıdır. Müşteri ve araç yönetimini sağlayarak kiralama süreçlerini takip etmeye olanak tanır.

## 📌 Özellikler
- 🧑‍💼 **Müşteri Yönetimi**: Müşteri ekleme, güncelleme ve silme.
- 🚙 **Araç Yönetimi**: Araç ekleme, güncelleme ve uygunluk durumu takibi.
- 📆 **Kiralama İşlemleri**: Müşterilere belirli tarihler arasında araç kiralama.
- 💰 **Ödeme Takibi**: Kiralama ücretlerinin ödenmesini takip etme.

## 🛠️ Kullanılan Teknolojiler
- **Backend**: C# (.NET Core / .NET Framework)
- **Veritabanı**: PostgreSQL
- **ORM**: Entity Framework
- **Tools**: CQRS, Mediatr

## 📥 Kurulum
1. **Projeyi klonlayın:**
   ```sh
   git clone https://github.com/bqrayvzdgn/Rent-A-Car.git
   cd Rent-A-Car
   ```
2. **Veritabanını oluşturun:**
   `SQL Server` kullanarak aşağıdaki scripti çalıştırın:
   ```sql
   CREATE DATABASE RentACarDb;
   ```
3. **Bağımlılıkları yükleyin (.NET Core için):**
   ```sh
   dotnet restore
   ```
4. **Uygulamayı çalıştırın:**
   ```sh
   dotnet run
   ```

## 🤝 Katkıda Bulunma
Projeye katkıda bulunmak için bir `Pull Request` gönderebilir veya `Issue` açabilirsiniz.

## 📄 Lisans
Bu proje **MIT** lisansı ile lisanslanmıştır.
