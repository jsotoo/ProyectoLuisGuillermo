CREATE DATABASE Ceramicas
use Ceramicas


CREATE TABLE Categorias
(
id_categ INT NOT NULL IDENTITY(1,1),
nom_categ varchar(30) NOT NULL,
CONSTRAINT PK_Categorias PRIMARY KEY (id_categ)
)



CREATE TABLE Marcas
(
id_marca INT NOT NULL IDENTITY(1,1) ,
nom_marca varchar(30) NOT NULL,
tel_marca int NOT NULL,
CONSTRAINT PK_Marca PRIMARY KEY (id_marca)
)



CREATE TABLE Productos 
(
id_prod INT NOT NULL IDENTITY(1,1),
nombre_prod varchar(50) not null,
descp_prod varchar(100) null,
id_categ INT NOT NULL,
id_marca INT NOT NULL,
CONSTRAINT PK_Productos PRIMARY KEY (id_prod),
CONSTRAINT FK_Productos_Categorias FOREIGN KEY (id_categ) REFERENCES Categorias (id_categ),
CONSTRAINT FK_Productos_Marcas FOREIGN KEY (id_marca) REFERENCES Marcas (id_marca)
)



CREATE TABLE Usuario
(
id_usu INT NOT NULL IDENTITY(1,1),
tipo_usu char(1) not null,
nombres_usu varchar(50) not null,
Apellidos_usu varchar(50) not null,
telefono_usu INT null,
CONSTRAINT PK_Personas PRIMARY KEY (id_usu, tipo_usu)	
)


CREATE TABLE Ventas
(
id_venta INT NOT NULL IDENTITY(1,1),
fecha_venta DATETIME NOT NULL,
total_venta INT NOT NULL,
id_usu INT NOT NULL,
tipo_usu CHAR(1) NOT NULL,
CONSTRAINT PK_Ventas PRIMARY KEY (id_venta),
CONSTRAINT FK_Ventas_Usuario FOREIGN KEY (id_usu,tipo_usu) REFERENCES Usuario (id_usu,tipo_usu)
)


CREATE TABLE VentasXProductos
(
id_ven_prod INT NOT NULL IDENTITY(1,1),
id_venta INT NOT NULL,
id_prod INT NOT NULL,
CONSTRAINT FK_VentasXProductos_Ventas FOREIGN KEY (id_venta) REFERENCES Ventas (id_venta),
CONSTRAINT FK_VentasXProductos_Productos FOREIGN KEY (id_prod) REFERENCES Productos (id_prod)
)


CREATE TABLE Proveedores
(
id_prov INT NOT NULL IDENTITY(1,1),
ciudad_prov INT NOT NULL,
id_per int NOT NULL,
CONSTRAINT PK_Proveedores PRIMARY KEY (id_prov)

)



CREATE TABLE ProveedoresXProductos
(
id_prov_prod INT NOT NULL IDENTITY(1,1),
id_prov INT NOT NULL,
id_prod INT NOT NULL,
CONSTRAINT FK_ProveedoresXProductos_Proveedores FOREIGN KEY (id_prov) REFERENCES Proveedores (id_prov),
CONSTRAINT FK_ProveedoresXProductos_Productos FOREIGN KEY (id_prod) REFERENCES Productos (id_prod)
)




CREATE TABLE Bodega
(
id_bog INT NOT NULL IDENTITY(1,1),
id_prod INT NOT NULL,
cantidad int NOT NULL,
CONSTRAINT PK_Bodega PRIMARY KEY (id_bog),
CONSTRAINT FK_Bodega_Producto FOREIGN KEY (id_prod) REFERENCES Productos (id_prod)

)

CREATE TABLE Devoluciones
(
id_devolucion INT NOT NULL IDENTITY(1,1),
queja_devolucion varchar(50) NULL
CONSTRAINT PK_Devoluciones PRIMARY KEY (id_devolucion)

)

CREATE TABLE DevolucionesXProductos
(
id_dev_prod INT NOT NULL IDENTITY(1,1),
id_devolucion INT NOT NULL,
id_prod int NOT NULL,
CONSTRAINT FK_DevolucionesXProductos_Devoluciones FOREIGN KEY (id_devolucion) REFERENCES Devoluciones (id_devolucion),
CONSTRAINT FK_DevolucionesXProductos_Productos FOREIGN KEY (id_prod) REFERENCES Productos (id_prod)
)


CREATE TABLE Gastos
(
id_gasto INT NOT NULL IDENTITY(1,1),
total int NOT NULL,
CONSTRAINT PK_Gastos PRIMARY KEY (id_gasto)
)

CREATE TABLE GastosXProductos
(
id_gas_prod INT NOT NULL IDENTITY(1,1),
id_gasto INT NOT NULL,
id_prod INT NOT NULL,
CONSTRAINT FK_GastosXProductos_Gastos FOREIGN KEY (id_gasto) REFERENCES Gastos (id_gasto),
CONSTRAINT FK_GastosXProductos_Productos FOREIGN KEY (id_prod) REFERENCES Productos (id_prod)
)