Proje Takip
Proje Takip, bir proje yönetim sistemidir ve personel bilgileri ile personel projelerinin yönetimini sağlamak için geliştirilmiş bir masaüstü uygulamasıdır. Bu uygulama, personel ve proje veritabanları üzerinde CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirmek üzere tasarlanmıştır.

Özellikler
1. Ana Form
Ana Ekran: Uygulama, açılışta kullanıcılara iki seçenek sunan bir ana form (Form1) ile başlar. Kullanıcılar, personel bilgilerini yönetmek veya personel projelerini yönetmek için ilgili formları açabilirler.

2. Personel Bilgileri Yönetimi
Personel Bilgileri Formu: PersonelBilgileri formu, personel kayıtlarını yönetmek için kullanılır. Bu form üzerinde, kullanıcılar personel ekleme, güncelleme, silme ve listeleme işlemlerini gerçekleştirebilir.

Ekleme: Yeni bir personel kaydı ekleyebilirsiniz.

Güncelleme: Mevcut bir personel kaydını güncelleyebilirsiniz.

Silme: Bir personel kaydını silebilirsiniz.

Listeleme: Tüm personel kayıtlarını görüntüleyebilirsiniz.

4. Personel Projeleri Yönetimi
Personel Projeleri Formu: PersonelProjeleri formu, personel projelerini yönetmek için kullanılır. Bu form üzerinde, kullanıcılar personel projeleri ile ilgili bilgileri ekleyebilir, güncelleyebilir, silebilir ve görüntüleyebilir.

5. Form Geçişleri
Formlar Arası Geçiş: Ana formdan (Form1) diğer formlara (PersonelBilgileri ve PersonelProjeleri) geçiş yapılabilir. Her bir form, açıldığında mevcut formu gizler ve kullanıcının ilgili yönetim ekranına geçmesini sağlar.

Kullanım

Personel Bilgileri Yönetimi: Ana ekranda "Personel Bilgileri" butonuna tıklayarak personel bilgilerini yönetebilirsiniz. Buradan personel ekleme, güncelleme ve silme işlemlerini gerçekleştirebilirsiniz.

Personel Projeleri Yönetimi: Ana ekranda "Personel Projeleri" butonuna tıklayarak personel projelerini yönetebilirsiniz. Proje ekleme, güncelleme ve silme işlemlerini buradan yapabilirsiniz.
Kod Detayları

Önemli Kod Parçaları

Form Geçişleri:
button1_Click: PersonelBilgileri formunu açar ve ana formu gizler.

button2_Click: PersonelProjeleri formunu açar ve ana formu gizler.

CRUD İşlemleri: PersonelBilgileri ve PersonelProjeleri formlarında, veritabanı işlemleri SQL komutları ile gerçekleştirilir.

Proje Takip, bir proje yönetim sistemidir ve personel bilgilerini yönetmek için geliştirilmiş bir masaüstü uygulamasıdır. Bu uygulama, personel veritabanı üzerinde CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirmek üzere tasarlanmıştır.

Özellikler

1. Personel Bilgileri Listeleme
Listeleme: Uygulama açıldığında, tüm personel kayıtları DataGridView üzerinde listelenir. Bu işlem, listele() metodu ile gerçekleştirilir. Metod, SQL veritabanından tüm personel bilgilerini çeker ve DataGridView üzerinde görüntüler.

2. Personel Bilgisi Ekleme
Ekleme: Yeni bir personel kaydı eklemek için kullanılan form alanları, kullanıcıdan gerekli bilgileri alır ve button1_Click metodu ile veritabanına ekler. Tüm alanlar doldurulduktan sonra, SQL INSERT komutu çalıştırılarak yeni personel kaydı veritabanına eklenir.

3. Personel Bilgisi Güncelleme
Güncelleme: Var olan bir personel kaydını güncellemek için button2_Click metodu kullanılır. Kullanıcı, DataGridView üzerinde bir personel kaydına tıkladığında ilgili bilgiler form alanlarına otomatik olarak doldurulur. Değişiklikler yapıldıktan sonra, SQL UPDATE komutu çalıştırılarak kayıt güncellenir.

4. Personel Bilgisi Silme
Silme: Mevcut bir personel kaydını silmek için button3_Click metodu kullanılır. Kullanıcı, DataGridView üzerinde bir personel kaydını seçtikten sonra "Sil" butonuna basarak bu kaydı veritabanından silebilir. SQL DELETE komutu kullanılarak ilgili kayıt veritabanından silinir.

5. Veritabanı Bağlantısı
Uygulama, SQL Server ile bağlantı kurarak veritabanı işlemlerini gerçekleştirir. Bağlantı dizesi, SqlConnection nesnesi aracılığıyla tanımlanır ve bu dize, PROJETAKIPDB veritabanına bağlanmak için kullanılır.

Kullanım

Uygulamayı başlattığınızda, personel bilgileri otomatik olarak listelenir.

Yeni bir personel eklemek için gerekli alanları doldurun ve "Ekle" butonuna basın.

Mevcut bir kaydı güncellemek için DataGridView üzerinde ilgili personeli seçin, değişikliklerinizi yapın ve "Güncelle" butonuna basın.

Bir kaydı silmek için DataGridView üzerinde ilgili personeli seçin ve "Sil" butonuna basın.

Kod Detayları

Önemli Kod Parçaları
listele(): Tüm personel kayıtlarını veritabanından çeker ve DataGridView üzerinde listeler.

button1_Click: Yeni bir personel kaydı ekler.

button2_Click: Seçili personel kaydını günceller.

button3_Click: Seçili personel kaydını siler.

dataGridView1_CellEnter: Kullanıcı, DataGridView üzerinde bir hücreye tıkladığında, ilgili satırdaki veriler form alanlarına doldurulur.

İletişim

Sorularınız veya geri bildirimleriniz için benimle iletişime geçebilirsiniz:

E-posta: alitokmak3535@gmail.com

GitHub: AlITOKMAK35 - https://github.com/AlITOKMAK35 -
