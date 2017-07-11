create Database C
use C

	create table SatisTemsilcisi(
		
		Ad  varChar not null,
		Soyad VarChar not null,
		tcNo INTEGER not null,
		Constraint "TcNo" Primary Key("tcNo")		
	)
	create table KargoFirması(
	  
	   Kod integer not null,
	   Ad VarChar not null,
	   Soyad VarChar not null,
	   Adress Varchar not null,
	   Temsilci varchar not null,
	   
	   Constraint "koD" Primary Key ("Kod")
	)
	create table Iller(
	
	PlakaNo integer,
	IlAdi char,

	Constraint PlakaNo primary key (PlakaNo)

	)
	create table Musteri(
	
		MusteriNo integer not null,
		Ad  varChar not null,
		Soyad VarChar not null,
		Yasadigiil char not null,
		tcNo INTEGER not null,

		Constraint "MusteriNo" Primary Key("MusteriNo")
		
	)
	create table Fatura(
	 FaturaNo integer not null,
	 Tarih integer not null,

	 Constraint "FaturaNo" Primary Key("FaturaNo")
	)

	create table Siparis(
	 
	 SiparisNo integer not null,
	 BarkodNo Integer not null,
	 SpiarisAdedi Integer not null,
	 BirimFiyat Integer not null,
	 KargoFirmasi VarChar not null,
	 FaturaNo integer not null,
	 MusteriNo integer not null,
	 SatisTemsilcisiNo integer not null,

	 constraint SiparisNo Primary Key("SiparisNo")
	 

	)

	create table Kategori(
	
	KategoriKodu integer not null ,
	Adi char not null,

	constraint KategoriKodu primary key (KategoriKodu)

	)

	create table Urun(
	
	KategoriKodu integer not null ,
	UrunKodu integer not null,
	adi char not null,
	stokmiktar integer not null,
	BirimFiyati integer not null,


	constraint UrunKodu Primary Key (Urunkodu)
	
	)

	create table SiparisUrun(
	
	Id Integer not null,
	SiparisNo integer not null,
	UrunKodu integer not null,
	KategoriKodu integer not null,
	
	constraint Id primary key (Id),

	)

	
