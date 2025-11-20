# Otobüs Bilet Satış Web Programı

Bu projede, otobüs bilet satış uygulaması geliştirilecektir. Teknoloji yığını:
- **Frontend:** Angular (Typescript), Bootstrap
- **Backend:** C# .NET Web API
- **Veritabanı:** SQL Server

---

## Klasör ve Dosya Yapısı

```
/bus-ticket-app/
├── backend/
│   ├── BusTicketAPI/
│   │   ├── Controllers/
│   │   │   ├── AuthController.cs
│   │   │   ├── BusesController.cs
│   │   │   ├── TripsController.cs
│   │   │   └── TicketsController.cs
│   │   ├── Models/
│   │   │   ├── User.cs
│   │   │   ├── Bus.cs
│   │   │   ├── Trip.cs
│   │   │   └── Ticket.cs
│   │   ├── Data/
│   │   │   ├── AppDbContext.cs
│   │   │   └── SeedData.cs
│   │   ├── DTOs/
│   │   ├── Services/
│   │   │   └── AuthService.cs
│   │   ├── Program.cs
│   │   └── appsettings.json
│   └── BusTicketAPI.sln
│
├── database/
│   ├── schema.sql
│   ├── seed.sql
│
├── frontend/
│   ├── bus-ticket-ui/
│   │   ├── src/
│   │   │   ├── app/
│   │   │   │   ├── components/
│   │   │   │   │   ├── login/
│   │   │   │   │   ├── register/
│   │   │   │   │   ├── search-trips/
│   │   │   │   │   ├── trip-detail/
│   │   │   │   │   ├── buy-ticket/
│   │   │   │   │   └── admin-panel/
│   │   │   │   ├── services/
│   │   │   │   │   ├── auth.service.ts
│   │   │   │   │   ├── trip.service.ts
│   │   │   │   │   └── ticket.service.ts
│   │   │   │   ├── models/
│   │   │   │   │   ├── user.model.ts
│   │   │   │   │   ├── bus.model.ts
│   │   │   │   │   ├── trip.model.ts
│   │   │   │   │   └── ticket.model.ts
│   │   │   │   ├── app.module.ts
│   │   │   │   ├── app.component.ts
│   │   │   │   ├── app-routing.module.ts
│   │   │   ├── assets/
│   │   ├── angular.json
│   │   ├── package.json
│   │   └── README.md
│
└── README.md
```

---

## Açıklamalar

- **backend/BusTicketAPI**  
  C# .NET Web API projesi. API endpointleri, servisler ve modeller burada.
- **database/schema.sql & seed.sql**  
  SQL Server için şemalar ve örnek veri dosyaları.
- **frontend/bus-ticket-ui**  
  Angular ve Bootstrap ile geliştirilen kullanıcı arayüzü.
- **components/**  
  Sayfa ve arayüz bileşenleri (login, sefer arama, bilet alma, yönetici paneli vs.)
- **services/**  
  Angular servisleri (API ile iletişim, kimlik doğrulama vb.)
- **models/**  
  Frontend veri modelleri.
- **README.md**  
  Proje dokümantasyonu.

## Kurulum Adımları (Kısa)

1. **Database oluştur:**  
   `database/schema.sql` ve `seed.sql` dosyaları ile veritabanını kurun.

2. **Backend (C# .NET API):**  
   - `BusTicketAPI` dizininde `dotnet restore` ve ardından `dotnet run`.

3. **Frontend (Angular):**  
   - `bus-ticket-ui` dizininde `npm install` ve ardından `ng serve` ile başlatın.

---

## Notlar

- API bağlantı adresi, frontend `environment.ts` dosyasında tanımlanmalıdır.
- Kimlik doğrulama (JWT) zorunludur.
- İsteğe bağlı olarak ileri seviye özellikler (PDF bilet çıktısı, ödeme entegrasyonu, admin paneli vb.) ekleyebilirsiniz.

---

Başlamak için:
- Detaylı kod örneği veya dosya şablonu isterseniz belirtin!
