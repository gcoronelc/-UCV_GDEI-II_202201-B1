
sp_help cliente;
go

select * from cliente order by 1 desc;
select * from contador;
go

create procedure usp_registra_cliente
(
	@p_paterno    varchar (25),
	@p_materno    varchar (25),
	@p_nombre     varchar (30),
	@p_dni        char    (8 ),
	@p_ciudad     varchar (30),
	@p_direccion  varchar (50),
	@p_telefono   varchar (20),
	@p_email      varchar (50),
	@p_codigo     char    (5)   out,
	@p_estado     int           out
)
as
begin
	-- Declaracion de variables

	-- Validacion

	-- Proceso
	BEGIN TRY 
		-- Inicio de la TX
		BEGIN TRANSACTION; 


		-- Confirmar la TX
		COMMIT TRANSACTION; 
	END TRY 
	BEGIN CATCH 
		-- Cancelar la TX
		ROLLBACK TRANSACTION; 
	END CATCH;
end;
go
