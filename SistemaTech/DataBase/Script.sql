create table Categorias(
CategoriaId int primary key identity(1,1),
Nombre Varchar(80),
Descripcion varchar(256),
);

CREATE TABLE Presentacion(
PresentacionId int primary key identity(1,1),
Nombre varchar(80),
Descripcion varchar(256),
);

create table Productos(
ProductoId int primary key identity(1,1),
Codigo Varchar(50),
Nombre varchar(50),
Descripcion varchar(256),
CategoriaId int,
PresentacioId int,
);

create table Proveedores(
ProveedorId int primary key identity(1,1),
Sector_Comercial varchar(50),
Razon_Social varchar(50),
Tipo_Documento varchar(50),
Num_Documuentos varchar(11),
Direccion varchar(100),
Telefono varchar(80),
Email varchar(80),
);



create table Ingresos(
IngresoId int primary key identity(1,1),
ProvedorId int,
Fecha int,
NumIngreso varchar(20),
Itbis decimal(4,2),
ProductoId int,
Nombre varchar(80),
Costo_Compra decimal,
Inventario_Inicial int,
Inventario_Actual int,
Fecha_Ingreso date,
Fecha_Vencimiento date,
);



create table Detalle_Ingresos(
Detalle_IngresoId int primary key identity(1,1),
IngresoId int,
Precio_Compra money,
ProductoId int,
Inventario_Inicial int,
Inventario_Actual int,
Fecha_Ingreso date,
Fecha_Vencimiento date,
);










