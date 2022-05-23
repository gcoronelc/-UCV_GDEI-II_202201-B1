
CREATE TABLE dbo.TIEMPO_DIM
( 
	Tiempo_Key           integer  NOT NULL ,
	Fecha                datetime  NOT NULL ,
	Semestre             integer  NULL ,
	Trimestre            varchar(20)  NULL ,
	Mes                  integer  NULL ,
	Dia                  char(18)  NOT NULL ,
	CONSTRAINT XPKTIEMPO_DIM PRIMARY KEY (Tiempo_Key ASC)
)
go



CREATE TABLE dbo.PRODUCTO_DIM
( 
	Producto_Key         int  NOT NULL ,
	Nombre               varchar(150)  NOT NULL ,
	Categoria            varchar(100)  NOT NULL ,
	CONSTRAINT XPKPRODUCTO_DIM PRIMARY KEY (Producto_Key ASC)
)
go



CREATE TABLE dbo.ALMACEN_DIM
( 
	Almacen_Key          integer  NOT NULL ,
	Nombre               varchar(150)  NOT NULL ,
	CONSTRAINT XPKALMACEN_DIM PRIMARY KEY (Almacen_Key ASC)
)
go



CREATE TABLE dbo.VENTAS_FACT
( 
	Tiempo_Key           integer  NOT NULL ,
	Producto_Key         int  NOT NULL ,
	Almacen_Key          integer  NOT NULL ,
	Importe              money  NOT NULL ,
	Unidades             integer  NOT NULL ,
	CONSTRAINT XPKVENTAS_FACT PRIMARY KEY (Tiempo_Key ASC,Producto_Key ASC,Almacen_Key ASC),
	CONSTRAINT FK_VENTAS_FACT_TIEMPO_DIM FOREIGN KEY (Tiempo_Key) REFERENCES dbo.TIEMPO_DIM(Tiempo_Key)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT FK_VENTAS_FACT_PRODUCTO_DIM FOREIGN KEY (Producto_Key) REFERENCES dbo.PRODUCTO_DIM(Producto_Key)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
CONSTRAINT FK_VENTAS_FACTALMACEN_DIM FOREIGN KEY (Almacen_Key) REFERENCES dbo.ALMACEN_DIM(Almacen_Key)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION
)
go


