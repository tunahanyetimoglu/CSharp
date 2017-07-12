create database kitapevi


use kitapevi


create table ktgr(

 kid integer not null,
 kategori varChar not null

 Constraint kid primary key ("kid")

)

create table yazarlar(

yaid integer not null,
yazaradi varChar not null

 Constraint yaid primary key ("yaid")

)

create table yayinevi(

yeid integer not null,
yayinevi varChar not null,

Constraint yeid primary key("yeid")

)

create table stok(

kitapid integer not null,
kitapadi varChar not null,
yaid integer not null,
yeid integer not null,
kid integer not null,

Constraint kitapid2 primary key("kitapid"),
Constraint yaid2 foreign key("yaid") references yazarlar("yaid"),
Constraint yeid2 foreign key("yeid") references yayinevi("yeid"),
Constraint kid2 foreign key("kid") references ktgr("kid")

)
