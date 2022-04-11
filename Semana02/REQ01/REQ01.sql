/*
Enunciado:

Desarrolle una VISTA para encontrar los departamentos que tienen más de 5 trabajadores.
Base de datos RH.
*/


/*
1. Analizar cada requerimiento.

Cada trabajador pertenece a un departamento, a departamento pertenecen varios trabajadores.
La cantidad de trabajadores por departamento, depende de las necesidades de cada departamento.
Para saber que departamentos tienen mas de 5 trabajadores se debe contar la cantidad de 
trabajadores en cada departamento, y luego identificar aquellos departamentos que tienen 
más de 5 empleados.

2. Identificar los datos que debe tener el reporte.

Los datos del reporte:
- Codigo del departamento
- Nombre del departamento
- Cantidad de trabajadores

CODIGO    NOMBRE    TRABAJADORES
-----------------------------------------------------------

------------------------------------------------------------

3. Identificar las tablas de donde obtendrá los datos.

Los origenes de los datos son:
- Codigo del departamento: Tabla DEPARTAMENTO
- Nombre del departamento: Tabla DEPARTAMENTO
- Cantidad de trabajadores: Tabla EMPLEADO

4. Crear la vista en la base de datos.

Paso 1: Encontrar la cantidad de trabajadores por departamento.
Paso 2: Filtrar los departamentos que tienen mas de 5 trabajadores.
Paso 3: Completar los datos

*/

-- Paso 1: Encontrar la cantidad de trabajadores por departamento.

select iddepartamento, count(1) trabajadores
from rh..empleado
group by iddepartamento;
go

-- Paso 2: Filtrar los departamentos que tienen mas de 5 trabajadores.

with 
v1 as (
	select iddepartamento, count(1) trabajadores
	from rh..empleado
	group by iddepartamento
)
select * from v1 
where trabajadores > 5;
go

-- Paso 3: Completar los datos

create view dbo.V_GB_REQ01
as
with 
v1 as (
	select iddepartamento, count(1) trabajadores
	from rh..empleado
	group by iddepartamento
),
v2 as (
	select iddepartamento, trabajadores from v1 
	where trabajadores > 5
)
select d.iddepartamento, d.nombre, v2.trabajadores 
from v2 join rh..departamento d 
on v2.iddepartamento=d.iddepartamento
go

select * from rh..V_GB_REQ01;
go


/*
5. Verificar su resultado.
*/

select * from rh..V_GB_REQ01 order by 3 desc;

select iddepartamento, count(1) trabajadores
from rh..empleado
group by iddepartamento
order by 2 desc;
go


/*
6. Consultar la vista desde Microsoft Excel
*/