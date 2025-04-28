# TakeAwayNight.Catalog API

**TakeAwayNight.Catalog**, Swagger ile belgelemiş olduğum bir RESTful API projesidir. Projede aşağıdaki katmanlar yer alır:

- **Core**: Domain modelleri, arayüzler (IRepository, IService vb.)  
- **Infrastructure**:  
  - **DAL**: Entity Framework Core ile veritabanı erişim katmanı (`CatalogContext`)  
  - **DTOs**: Veri transfer objeleri  
  - **Mappings**: AutoMapper profilleri  
- **Presentation**: ASP.NET Core Web API katmanı, Swagger UI entegrasyonu  

## Özellikler & Denenen Endpoints

API’yi Swagger arayüzünden test ederek aşağıdaki HTTP metodlarını ve parametrelerini denedim:

### Kategoriler (`/api/categories`)
- **GET** `/api/categories`  
  Tüm kategorileri listeler.  
- **GET** `/api/categories/{id}`  
  Belirli bir kategoriyi döner.  
  - Parametre: `id` (int)  
- **POST** `/api/categories`  
  Yeni kategori oluşturur.  
  - Body (JSON):  
    ```json
    {
      "name": "Yeni Kategori",
      "description": "Açıklama"
    }
    ```
- **PUT** `/api/categories/{id}`  
  Var olan kategoriyi günceller.  
  - Parametre: `id` (int)  
  - Body (JSON): aynı POST gövdesi  
- **DELETE** `/api/categories/{id}`  
  Var olan kategoriyi siler.  
  - Parametre: `id` (int)  

### Ürünler (`/api/products`)
- **GET** `/api/products`  
- **GET** `/api/products/{id}`  
- **POST** `/api/products`  
- **PUT** `/api/products/{id}`  
- **DELETE** `/api/products/{id}`  

*(Her endpoint için benzer parametre ve JSON gövdeleri mevcut.)*

## Kullanılan Teknolojiler
- **ASP.NET Core Web API**  
- **Entity Framework Core**  
- **AutoMapper**  
- **Swagger / Swashbuckle**  
- **SQL Server**  

---

**Not:** Proje katmanlı mimari yapısı sayesinde test edilebilir, genişletilebilir ve bakımı kolay bir şekilde organize edilmiştir. Tüm CRUD operasyonları Swagger UI üzerinden canlı olarak test edilmiştir. ```
