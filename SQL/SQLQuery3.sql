Select ProductName [Ürün Adı], Sum(od.unitPrice * od.Quantity)[Kazanılan Toplam Miktar]
from Products p inner join [Order Details]  od on p.ProductID = od.ProductID 
inner join Orders o on o.OrderID = od.OrderID group by ProductName