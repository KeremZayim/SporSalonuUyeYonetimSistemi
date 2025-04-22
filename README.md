# Spor Salonu Yönetim Sistemi

Bu proje, bir spor salonunun üyelik yönetimi, ödeme işlemleri, antrenman takibi ve sağlık bilgilerini saklamak için kullanılan bir veritabanı yapısını içermektedir. Kullanıcılar, üyelik bilgilerini, ödemelerini, antrenman programlarını ve sağlık durumlarını takip edebilirler. Bu sistem, salon yöneticilerinin üyeleri daha etkin bir şekilde yönetmesine yardımcı olmayı amaçlar.

## Özellikler

### 1. **Üye Bilgileri**
- Üyeler, ad, soyad, doğum tarihi, telefon numarası ve ek notlarla birlikte kayıt edilir.
- Her üyenin benzersiz bir telefon numarası ve kimliği vardır.
- Üye bilgileri, telefon numarası formatı denetimi ile güvenli bir şekilde tutulur.

### 2. **Üyelik Bilgileri**
- Her üye yalnızca bir aktif üyelik bilgisine sahip olabilir (örneğin, aylık, yıllık, VIP üyelik).
- Üyelik başlangıç ve bitiş tarihleri tutulur. Bitiş tarihi boş bırakılabilir (üyelik hala geçerli ise).
- Üyelik bilgileri, bir üye ile ilişkilendirilmiştir.

### 3. **Ödeme Bilgileri**
- Her üyenin ödeme durumu ve ödeme geçmişi saklanır.
- Ödemeler, ödeme durumu (odendi, beklemede, gecikmiş vb.), ödeme tarihi ve tutarı ile kaydedilir.
- Ödeme bilgileri, ilgili üye ile ilişkilendirilmiştir.

### 4. **Antrenman Bilgileri**
- Üyeler için boy, kilo, vücut yağ oranı, kas kütlesi ve hedef bilgileri tutulur.
- Bu bilgiler, antrenman hedeflerine ve sağlık durumuna yönelik öneriler için kullanılabilir.
- Antrenman bilgileri, her üye ile ilişkilendirilmiştir.

### 5. **Antrenman Listesi**
- Üyelerin yapacağı antrenmanlar, her hafta belirli bir gün için planlanabilir.
- Her antrenman listesi, hedef bölge (göğüs, bacaklar vb.) ve antrenman adıyla birlikte kaydedilir.
- Her antrenman, ilgili üyeye atanır.

### 6. **Egzersizler**
- Her antrenman için egzersizler tanımlanır.
- Egzersizler, set sayısı, tekrar sayısı gibi bilgileri içerir.
- Egzersizler, belirli bir antrenman listesi ile ilişkilidir.

### 7. **Antrenörler**
- Spor salonundaki antrenörlerin kişisel bilgileri (ad, soyad, telefon numarası) kaydedilir.
- Antrenörler, üyelerle ilişkili olabilir. Bir üye birden fazla antrenörle çalışabilir ve aynı şekilde bir antrenör de birden fazla üye ile çalışabilir.

### 8. **Üye ve Antrenör İlişkisi**
- Bir üye, bir veya daha fazla antrenörle çalışabilir. Antrenörler ise birden fazla üye ile ilişkili olabilir.
- Bu ilişki, `uye_antrenorleri` tablosu aracılığıyla yönetilir.

### 9. **Salon Katılım Geçmişi**
- Üyelerin spor salonuna katıldıkları tarihler (giriş ve çıkış zamanları) kaydedilir.
- Bu, salonu ne sıklıkla ziyaret ettiklerini takip etmek için kullanılır.

### 10. **Sağlık Bilgileri**
- Üyelerin sağlık durumları, alerjileri ve acil durum iletişim bilgileri saklanır.
- Sağlık bilgileri, üyelerin fiziksel durumlarına göre özelleştirilmiş antrenman ve diyet programları oluşturulmasına yardımcı olabilir.

---

Bu proje, spor salonları için kapsamlı bir üye yönetim sistemi sunarak salon işletmecilerinin daha düzenli ve etkili bir şekilde hizmet sunmalarını sağlar. Sistem, her bir üye için kişisel, üyelik, ödeme, antrenman ve sağlık bilgilerini takip ederken, aynı zamanda antrenman programları ve katılım geçmişi gibi önemli verileri de yönetmektedir.

*Proje Başlangıç Tarihi: 08.03.2025*
