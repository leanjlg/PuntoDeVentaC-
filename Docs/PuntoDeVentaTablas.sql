use PuntoDeVenta
CREATE TABLE factura (
    id_factura int PRIMARY KEY NOT NULL,
    fecha_factura DATETIME,
    coste_total MONEY ,
    id_local INT,
    empleado_legajo INT,
    nro_cliente INT,
    id_chango INT
)
