/*
Desarrolle una función que reporte la cantidad de alumnos matriculados 
y las vacantes disponibles de un determinado curso. 
Base de datos EDUTEC.
*/

/*
1. Analizar del requerimiento.

En EDUTEC se programan ciclos cortos de 1 mes de duración, en cada ciclo 
se programan diversos cursos en diferentes horarios.

Un determinado curso se puede programar varias veces en un ciclo, incluso
con diferentes profesores.

En este requerimiento asumiremos que se trata del reporte de todas las 
programaciones realizadas de un curso en un ciclo especifico.
*/

select * from CursoProgramado
where IdCiclo='2021-01'
order by 2;
go



/*
2. Identificar los datos que debe retornar la función.
3. Identificar las tablas de donde obtendrá los datos.
4. Crear la función en la base de datos.
*/


alter function dbo.fn_reporte(@ciclo char(7), @curso char(4))
returns table
as
return
select cp.IdCursoProg, cp.IdCurso, c.NomCurso, cp.Vacantes, cp.Matriculados
from CursoProgramado cp
join curso c on cp.IdCurso = c.IdCurso
where cp.IdCiclo=@ciclo and cp.IdCurso=@curso;
go

select * from dbo.fn_reporte('2021-01', 'C004');
go

/*
5. Verificar su resultado.
*/