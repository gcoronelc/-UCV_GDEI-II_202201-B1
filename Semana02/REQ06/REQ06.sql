/*
Ennciado
---------------------------------------------------------------------------------------------
Desarrolle una VISTA para encontrar el empleado que tiene el menor salario por departamento.
Base de datos RH.

1. Analizar cada requerimiento.

Todo trabajador tiene un salario según el cargo que ocupa, 
trabajadores del mismo cargo pueden tener salarios diferentes por el tiempo de servicio u otros factores.

En cada departamento laboran varios empleados de diferentes cargos, lo que se solicita 
es conocer quienes son los trabajadores con el menor salario en cada uno de los departamentos.

Es posible que existan empates, entonces debe mostrarse esos empates.

2. Identificar los datos que debe tener el reporte.

- Codigo de departamento
- Nombre de departamento
- Código del empleado
- Nombre del empleado
- Salario del empleado

3. Identificar las tablas de donde obtendrá los datos.

- Codigo de departamento: DEPARTAMENTO
- Nombre de departamento: DEPARTAMENTO
- Código del empleado: EMPLEADO
- Nombre del empleado: EMPLEADO
- Salario del empleado: EMPLEADO

4. Crear la vista en la base de datos.
*/

select * from empleado;
go

-- Paso 1: Calcular el salario total

select 
	idempleado, iddepartamento, idcargo, sueldo+isnull(comision,0) salario_neto
from empleado;
go


-- Paso 2: Menor salario por departamento

with
v1 as (
	select 
		idempleado, iddepartamento, idcargo, sueldo+isnull(comision,0) salario_neto
	from empleado
)
select iddepartamento, min(salario_neto) menor_salario
from v1
group by iddepartamento;
go

-- PAso 3: Encontrar el empleado que corresponde al salario menor.

create view V_GB_REQ06
as
with
v1 as (
	select 
		idempleado, nombre, apellido, iddepartamento, idcargo, sueldo+isnull(comision,0) salario_neto
	from empleado
),
v2 as (
	select iddepartamento, min(salario_neto) menor_salario
	from v1
	group by iddepartamento
)
select v1.* 
from v1 join v2 
on v1.iddepartamento=v2.iddepartamento and v1.salario_neto=v2.menor_salario;
go

select * from V_GB_REQ06;
go

/*
5. Verificar su resultado.
*/

select * from V_GB_REQ06;

select 
	iddepartamento,  min(sueldo+isnull(comision,0)) salario_menor
from empleado
group by iddepartamento;
go

/*
6. Consultar la vista desde Microsoft Excel
*/




