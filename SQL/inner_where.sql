
--- Tabloları oluşturulduktan sonra -----


Select kitap.Kid,Kitap.Ad,yazar.Yazarid

from YazarKitap

inner join 
Kitap on 
 Kitap.Kid = yazarKitap.Kid
 inner join
 Yazar on
 Yazar.Yazarid = yazarKitap.Yazarid

 ----

 SELECT        dbo.YazarKitap.Kid, dbo.YazarKitap.Yazarid, dbo.KitaP.Kid AS Expr1, dbo.Yazar.Yazarid AS Expr2, dbo.KitaP.Ad, dbo.Yazar.Ad AS Expr3
FROM            dbo.KitaP 
INNER JOIN
 dbo.YazarKitap ON dbo.KitaP.Kid = dbo.YazarKitap.Kid
 INNER JOIN 
  dbo.Yazar ON dbo.YazarKitap.Yazarid = dbo.Yazar.Yazarid



Select yazar.Yazarid, kitap.Ad,yazar.Ad,yazar.Soyad,kitap.Fiyat
 From YazarKitap,Kitap,Yazar



Where dbo.YazarKitap.Yazarid = dbo.Yazar.Yazarid AND
      dbo.KitaP.Kid = dbo.YazarKitap.Kid AND
      Kitap.Kid = 3 and Kitap.ad like '%C#%'
order by kitap.Fiyat desc

Select Count(yazar.Ad) AS YazarSayisi

From YazarKitap,Kitap,Yazar
Where dbo.YazarKitap.Yazarid = dbo.Yazar.Yazarid AND
      dbo.KitaP.Kid = dbo.YazarKitap.Kid AND
      Kitap.Kid = 3 and Kitap.ad like '%C#%'

