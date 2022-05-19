
-- Analisis de tablas afectadas
select * from VENTA; -- INSERT
select * from PUBLICACION; -- SELECT y UPDATE
select * from PROMOCION; -- SELECT
select * from CONTROL; -- SELECT y UPDATE

select * from empleado;
go

rollback tran

create procedure usp_registrar_venta
(
	@p_cliente varchar(150),
	@p_empleado int,
	@p_publicacion char(8),
	@p_cantidad int,
	@p_idventa int out,
	@p_estado int out
)
as
begin
	-- variables
	declare @precio money, @stock int;
	declare @porcDescuento numeric(8,4), @descuento money;
	declare @subtotal money, @impuesto money, @total money;
	declare @igv money;
	-- Validaciones

	-- Proceso
	SET @p_estado = 1;
	BEGIN TRY 
		-- Inicia la Tx
		BEGIN TRANSACTION; 
		-- Obtener codigo de venta
		update control set valor = valor + 1
		where parametro='VENTA';
		if(@@ROWCOUNT<>1)
		begin
			set @p_estado = -2;
			THROW 51000, 'Error en la generacion del codigo.', 1;
		end;
		select @p_idventa =  valor
		from control c
		where parametro='VENTA';
		-- Datos de la publicacion
		select @precio=precio, @stock=stock
		from PUBLICACION
		where idpublicacion=@p_publicacion;
		-- Validar stock
		if(@stock<@p_cantidad)
		begin
			set @p_estado = -3;
			THROW 51000, 'No hay stock suficiente.', 1;
		end;
		update PUBLICACION
		set stock = stock - @p_cantidad
		where idpublicacion=@p_publicacion;
		-- Leer porcentaje de descuento
		select @porcDescuento = porcentaje
		from PROMOCION
		where @p_cantidad between cantmin and cantmax;
		-- Leer el IGV
		select @igv = VALOR
		from CONTROL
		where parametro='IGV'
		-- Calculos
		set @descuento = @precio * @porcDescuento;
		set @total = (@precio - @descuento) * @p_cantidad;
		set @subtotal = @total / (1+@igv);
		set @impuesto = @total - @subtotal;
		-- Insertar la venta
		insert into venta(idventa,cliente,fecha, idempleado, idpublicacion,
			cantidad, precio, dcto, subtotal, impuesto, total)
		values(@p_idventa,@p_cliente, getdate(), @p_empleado,
			@p_publicacion, @p_cantidad, @precio, @descuento,
			@subtotal, @impuesto, @total);
		-- Confirma la Tx
		COMMIT TRANSACTION; 
	END TRY 
	BEGIN CATCH 
		-- Cancela la Tx
		print(ERROR_MESSAGE());
		ROLLBACK TRANSACTION;
		if(@p_estado=1) set @p_estado = -1;
	END CATCH;
end;
go

-- Prueba del procedimiento

declare @idventa int, @estado int;
exec usp_registrar_venta 'Gustavo', 6, 'SEP00006', 3, @idventa out, @estado out;
print concat('Codigo: ', @idventa);
print concat('estado: ', @estado);
go

