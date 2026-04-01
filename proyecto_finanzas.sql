CREATE DATABASE db_finanzas
Go
USE db_finanzas
GO

create table entradasEscenarios
(
    id_escenario             int identity
        primary key,
    nombre_escenario         varchar(100),
    fecha_creacion           datetime default getdate(),
    tamano_mercado           int,
    crecimiento_mercado      decimal(5, 4),
    encuestas                int,
    personas_interesadas     int,
    objetivo_mercado         decimal(5, 4),
    inversion_equipos        decimal(18, 2),
    depreciacion_anios       int,
    precio_inicial           decimal(18, 2),
    incremento_precio        decimal(5, 4),
    inflacion                decimal(5, 4),
    ipp                      decimal(5, 4),
    costo_produccion_inicial decimal(18, 2),
    otros_ingresos           decimal(5, 4),
    gastos_operativos        decimal(5, 4),
    capital_trabajo          decimal(5, 4),
    porcentaje_deuda         decimal(5, 4),
    plazo_credito            int,
    tasa_libre_riesgo        decimal(5, 4),
    beta_sector              decimal(5, 4),
    prima_riesgo_mercado     decimal(5, 4),
    gradiente_flujos         decimal(5, 4),
    tasa_impuestos           decimal(5, 4)
)
GO
CREATE TABLE datosEscenarios (
    id INT PRIMARY KEY IDENTITY(1,1),
    escenario_id INT,
    mercado_esperado DECIMAL(5,4),
    variacion_nominal_precio DECIMAL(5,4),
    variacion_nominal_ipp DECIMAL(5,4),
    valor_inversion_inicial DECIMAL(18,2),
    financiado_con_credito DECIMAL(18,2),
    costo_deuda DECIMAL(5,4),
    financiado_con_aportes DECIMAL(18,2),

    FOREIGN KEY (escenario_id) REFERENCES entradasEscenarios(id_escenario)
);
GO
CREATE TABLE variables
(
    id int identity(1,1) primary key,
    id_escenario int,
    anio int,
    tamanio_mercado DECIMAL(18, 2) DEFAULT 0,
    participacion_mercado DECIMAL(5, 4) DEFAULT 0,
    unidades_vendidas int DEFAULT 0,
    precio_venta DECIMAL(18, 2) DEFAULT 0,
    costo_produccion DECIMAL(18, 2) DEFAULT 0,
    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios(id_escenario)
)
GO
CREATE TABLE amortizacion
(
    id int identity(1,1) primary key,
    id_escenario int,
    anio int,
    saldo_inicial DECIMAL(18, 2) DEFAULT 0,
    cuota DECIMAL(18, 2) DEFAULT 0,
    interes DECIMAL(18, 2) DEFAULT 0,
    abono_capital DECIMAL(18, 2) DEFAULT 0,
    saldo_final DECIMAL(18, 2) DEFAULT 0,
    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios(id_escenario)
)
GO
CREATE TABLE estadoResultados
(
    id int identity(1,1) primary key,
    id_escenario int,
    anio int,
    ventas DECIMAL(18, 2) DEFAULT 0,
    costo_ventas DECIMAL(18, 2) DEFAULT 0,
    -- utilidad_bruta DECIMAL(18, 2) DEFAULT 0,
    gastos_operativos DECIMAL(18, 2) DEFAULT 0,
    depreciacion DECIMAL(18, 2) DEFAULT 0,
    -- total_gastos DECIMAL(18, 2) DEFAULT 0,
    -- utilidad_operativa DECIMAL(18, 2) DEFAULT 0,
    gastos_financieros DECIMAL(18, 2) DEFAULT 0,
    otros_ingresos DECIMAL(18, 2) DEFAULT 0,
    --neto_otros_ingresos DECIMAL(18, 2) DEFAULT 0,
    -- utilidad_antes_impuestos DECIMAL(18, 2) DEFAULT 0,
    impuestos DECIMAL(18, 2) DEFAULT 0,
    --utilidad_neta DECIMAL(18, 2) DEFAULT 0),
    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios(id_escenario)
)