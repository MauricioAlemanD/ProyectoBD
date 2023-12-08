	CREATE DATABASE CINEOMAU

	USE CINEOMAU

	CREATE TABLE DetalleFactura (
    NumeroDetalleFactura VARCHAR(20) NOT NULL,
    NumeroFactura VARCHAR(20) NOT NULL,
    IDPelicula VARCHAR(10) NOT NULL,
    CantidadBoletos INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    CONSTRAINT PK_DetalleFactura PRIMARY KEY (NumeroDetalleFactura),
    CONSTRAINT FK_DetalleFactura_Pelicula FOREIGN KEY (IDPelicula) REFERENCES Peliculas (IDPelicula),
    CONSTRAINT FK_DetalleFactura_Factura FOREIGN KEY (NumeroFactura) REFERENCES Facturas (NumeroFactura)
	)


	CREATE TABLE Empleados (
    IDEmpleado VARCHAR(10) NOT NULL,
    IDUsuario VARCHAR(10) NOT NULL,
    TurnoEmpleado VARCHAR(20) NOT NULL,
    SueldoEmpleado DECIMAL(10, 2) NOT NULL,
    RFCEmpleado VARCHAR(13) NOT NULL,
    NSSEmpleado VARCHAR(25) NOT NULL,
    EstadoCivilEmpleado VARCHAR(20) NOT NULL,
    CONSTRAINT PK_Empleados PRIMARY KEY (IDEmpleado),
    CONSTRAINT FK_Empleados_Usuarios FOREIGN KEY (idUsuario) REFERENCES Usuarios (IDUsuario)
	)

	CREATE TABLE Facturas (
    NumeroFactura VARCHAR(20) NOT NULL,
    IDUsuario VARCHAR(10) NOT NULL,
    FechaEmisionFactura DATE NOT NULL,
    CONSTRAINT PK_Facturas PRIMARY KEY (NumeroFactura)
	)

	CREATE TABLE Peliculas (
    IDPelicula VARCHAR(10) NOT NULL,
    TituloPelicula VARCHAR(50) NOT NULL,
    DuracionMinutosPelicula VARCHAR(50) NOT NULL,
    ClasificacionEdadPelicula VARCHAR(10) NOT NULL,
    GeneroPelicula VARCHAR(20) NOT NULL,
    CONSTRAINT PK_Peliculas PRIMARY KEY (IDPelicula)
	)

	CREATE TABLE Usuarios (
    IDUsuario VARCHAR(10) NOT NULL,
    NombreUsuario VARCHAR(50) NOT NULL,
    PrimerApellidoUsuario VARCHAR(50) NOT NULL,
    SegundoApellidoUsuario VARCHAR(50) NOT NULL,
    CorreoElectronicoUsuario VARCHAR(100) NOT NULL,
    SexoUsuario VARCHAR(20) NOT NULL,
    NacimientoUsuario DATE NOT NULL,
    TelefonoUsuario INT NOT NULL,
    DireccionUsuario VARCHAR(100) NOT NULL,
    CiudadUsuario VARCHAR(30) NOT NULL,
    EstadoUsuario VARCHAR(30) NOT NULL,
    PaisUsuario VARCHAR(30) NOT NULL,
    CONSTRAINT PK_Usuarios PRIMARY KEY (IDUsuario)
	)










