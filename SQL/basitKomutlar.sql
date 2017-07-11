use Northwind --Database name

--YORUM SATIRI, Tüm Kayıtları Listele

select * from dbo.orders

select orders.OrderID AS Sipariş_ID ,OrderDate AS Sipariş_Tarih ,ShipName from orders

-- distinct tekrarları siler 1 kere yazar

select distinct city,CustomerID from customers order by city DESC --ASC ( a- z) DESC ( z -a )

SELECT DISTINCT city As Sehirler, Country as Ulkeler from Customers ORDER BY country DESC

--şart işlemleri : " where "

select distinct City from customers where Country = 'Spain'

--seçilen tablonun isminde boşluk varsa [ ] parantezler arasında yazılır -- order by her zaman en sonda olur!

select ORDERID , Quantity , ProductID from [Order Details] where Quantity>=10 and ProductID < 5 order by quantity,productID asc

select ORDERID , Quantity , ProductID from [Order Details] where Quantity between 10 and 20 order by quantity,productID asc

-- M ile başlayan şehirleri getir M% -- M ile biten şehirleri getir %M

--İçersinde ma geçen %ma%

select city from Customers where city Like 'M%' select city from Customers where city Like '%n' select city from Customers where city Like '%xi%'

--in : içinde ('-----') olanı getir

Select city as şehir, Country from Customers where city in('Madrid','London')

--Insert

INSERT INTO Customers (CustomerID,CompanyName,ContactName,Address,City,PostalCode,Country) VALUES ('1912','Cardinal','Tom b. Erichsen','Skagen 21','Stavenger','4006','Norway')

select * from Customers where customerID = '1912'

-- Update

Update Customers set ContactName = 'Alfred Schmidt', City ='Hamburg' where CompanyName = 'Alfreds Futterkiste'; --where yapmazsak bütün satırlar değişir!

---Delete

Delete from Suppliers Where ContactName = 'Elio Rossi'

--- inner join

Select orderID,orderdate,companyname from orders inner join customers on orders.CustomerID = customers.CustomerID order by companyName asc

Select OrderID,OrderDate,CompanyName From Orders, Customers where Orders.CustomerID = Customers.CustomerID

---||

---- //

Select(City + '/' + Country) AS ADRES from Customers

Select ContactName, City, Address, Region, PostalCode From Customers INNER JOIN Orders On Customers.CustomerID = Orders.CustomerID INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID Cross Join Products

-- Seçilen verileri başka bir tabloya aktarma Insert Into Customers (CustomerID,CompanyName,Country) Select Suppliers.SupplierID,Suppliers.CompanyName,Country from Suppliers
