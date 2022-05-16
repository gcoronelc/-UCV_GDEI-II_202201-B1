/*
Se necesita hacer b�squedas de empleados por nombre y apellido, 
se le pide dise�ar la mejor soluci�n, justifique su respuesta.
Implementar su propuesta y verificarla recogiendo las evidencias del caso.
*/

/*
1. Analizar del requerimiento.

select * from empleado;
go

La tabla empleado tiene la columna apellido y nombre, normalmente
las consultas se realizan pro mas de una columna.

La idea es optimzar esas consultas y se realizan con mucha frecuencia.
*/




/*
2. Dise�ar una soluci�n.

- Tabla de prueba

select * into empleado2
from empleado;
go

- Dise�o dela consulta

select * from empleado
where apellido like '%RO%' and nombre like '%ta%';
go

- Dise�o del indice

CREATE INDEX EMPLEADO2_IDX 
ON EMPLEADO2(APELLIDO,NOMBRE);
GO

*/

/*
3. Implementar la soluci�n.
*/

-- Profesor, ejecute sta sentencia 10 veces
INSERT INTO EMPLEADO2 
SELECT * FROM empleado;
GO

select * from empleado2
where apellido like '%RO%' and nombre like '%ta%';
go

CREATE INDEX EMPLEADO2_IDX 
ON EMPLEADO2(APELLIDO,NOMBRE);
GO

select * from empleado2
where apellido like 'RO%' and nombre like 'ta%';
go


/*
4. Verificar su funcionamiento.
5. Recoger evidencias.
6. Elaborar informe que incluya conclusiones y recomendaciones.
*/