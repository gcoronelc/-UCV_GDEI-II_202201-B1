

select idempleado, sum(total) ventas
from BOOKSTORE..VENTA
group by idempleado;
go

