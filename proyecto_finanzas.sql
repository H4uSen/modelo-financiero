CREATE DATABASE hausencito247_finanzas
GO
USE hausencito247_finanzas
GO
SELECT * FROM entradasEscenarios
SELECT * FROM datosEscenarios
SELECT * FROM variables
SELECT * FROM amortizacion

SELECT * FROM costoCapital
--DROP DATABASE hausencito247_finanzas
--USE master
GO
GO
CREATE TABLE entradasEscenarios
(
    id_escenario             int identity(1,1) primary key,
    nombre_escenario         varchar(100),
    fecha_creacion           datetime default getdate(),
    tamano_mercado           int,
    crecimiento_mercado      decimal(16,8),
    encuestas                int,
    personas_interesadas     int,
    objetivo_mercado         decimal(16,8),
    inversion_equipos        decimal(18, 4),
    depreciacion_anios       int,
    precio_inicial           decimal(18, 2),
    incremento_precio        decimal(16,8),
    inflacion                decimal(16,8),
    ipp                      decimal(16,8),
    costo_produccion_inicial decimal(18, 2),
    otros_ingresos           decimal(16,8),
    gastos_operativos        decimal(16,8),
    capital_trabajo          decimal(16,8),
    porcentaje_deuda         decimal(16,8),
    plazo_credito            int,
    tasa_libre_riesgo        decimal(16,8),
    beta_sector              decimal(16,8),
    prima_riesgo_mercado     decimal(16,8),
    gradiente_flujos         decimal(16,8),
    tasa_impuestos           decimal(16,8)
)
GO
CREATE TABLE datosEscenarios
(
    id                       INT PRIMARY KEY IDENTITY (1,1),
    escenario_id             INT,

    mercado_esperado_anio1   DECIMAL(16,8),  -- encuestas/personas_interesadas
    variacion_nominal_precio DECIMAL(16,8),  --(1+inflacion)*(1+incremento_precio)-1
    variacion_nominal_ipp    DECIMAL(16,8),  --(1+inflacion)*(1+ipp)-1
    valor_inversion_inicial  DECIMAL(18, 2), --inversion_equipos*(objetivo_mercado*100)
    financiado_con_credito   DECIMAL(18, 2), --valor_inversion_inicial*porcentaje_deuda
    costo_deuda              DECIMAL(16,8),  -- Se saca el porcentaje de la tabla de tasas de interés según % de deuda
    financiado_con_aportes   DECIMAL(18, 4), --valor_inversion_inicial-financiado_con_credito

    FOREIGN KEY (escenario_id) REFERENCES entradasEscenarios (id_escenario)
)

GO
CREATE TABLE variables
(
    id                    int identity (1,1) primary key,
    id_escenario          int,

    anio                  int,
    tamanio_mercado       DECIMAL(18, 2) DEFAULT 0,
    participacion_mercado DECIMAL(16,8)  DEFAULT 0,
    unidades_vendidas     int            DEFAULT 0,
    precio_venta          DECIMAL(18, 2) DEFAULT 0,
    costo_produccion      DECIMAL(18, 2) DEFAULT 0,

    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario)
)
GO
CREATE TABLE amortizacion
(
    id            int identity (1,1) primary key,
    id_escenario  int,

    anio          int,
    saldo_inicial DECIMAL(18, 2) DEFAULT 0,
    cuota         DECIMAL(18, 2) DEFAULT 0,
    interes       DECIMAL(18, 2) DEFAULT 0,
    abono_capital DECIMAL(18, 2) DEFAULT 0,
    saldo_final   DECIMAL(18, 2) DEFAULT 0,
    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario)
)
GO
CREATE TABLE estadoResultados
(
    id                       int identity (1,1) primary key,
    id_escenario             int,
    anio                     int,
    ventas                   DECIMAL(18, 2) DEFAULT 0,
    costo_ventas             DECIMAL(18, 2) DEFAULT 0,
    utilidad_bruta           DECIMAL(18, 2) DEFAULT 0,
    gastos_operativos        DECIMAL(18, 2) DEFAULT 0,
    depreciacion             DECIMAL(18, 2) DEFAULT 0,
    total_gastos             DECIMAL(18, 2) DEFAULT 0,
    utilidad_operativa       DECIMAL(18, 2) DEFAULT 0,
    gastos_financieros       DECIMAL(18, 2) DEFAULT 0,
    otros_ingresos           DECIMAL(18, 2) DEFAULT 0,
    neto_otros_ingresos      DECIMAL(18, 2) DEFAULT 0,
    utilidad_antes_impuestos DECIMAL(18, 2) DEFAULT 0,
    impuestos                DECIMAL(18, 2) DEFAULT 0,
    utilidad_neta            DECIMAL(18, 2) DEFAULT 0,
    capital_trabajo          DECIMAL(18, 2) DEFAULT 0,

    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario)
)

--SALIDAS DEL PROYECTO
CREATE TABLE costoCapital
(
    id                            int identity (1,1) primary key,
    id_escenario                  int,

    porcentaje_deuda              DECIMAL(16,8) DEFAULT 0,
    porcentaje_aportes            DECIMAL(16,8) DEFAULT 0,
    costo_deuda                   DECIMAL(16,8) DEFAULT 0,
    costo_deuda_despues_impuestos DECIMAL(16,8) DEFAULT 0,
    betaL_sector                  DECIMAL(16,8) DEFAULT 0,
    costo_patrimonio              DECIMAL(16,8) DEFAULT 0,
    costo_capital                 DECIMAL(16,8) DEFAULT 0,

    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario)
)
GO
CREATE TABLE flujoCajaLibre
(
    id                        int identity (1,1) primary key,
    id_escenario              int,

    anio                      int,
    utilidad_neta             DECIMAL(18, 2) DEFAULT 0,
    gasto_financiero          DECIMAL(18, 2) DEFAULT 0,
    impuestos_causados        DECIMAL(18, 2) DEFAULT 0,
    ebit                      DECIMAL(18, 2) DEFAULT 0,
    impuestos_ajustados       DECIMAL(18, 2) DEFAULT 0,
    ebit_uodi                 DECIMAL(18, 2) DEFAULT 0,
    depreciacion              DECIMAL(18, 2) DEFAULT 0,
    flujo_bruto               DECIMAL(18, 2) DEFAULT 0,
    inversion_capital_trabajo DECIMAL(18, 2) DEFAULT 0,
    inversion_activos_fijos   DECIMAL(18, 2) DEFAULT 0,
    flujo_caja_libre          DECIMAL(18, 2) DEFAULT 0,

    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario)
)
GO
CREATE TABLE resultados_caja_libre
(
    id                        int identity (1,1) primary key,
    id_escenario              int,

    valor_terminal            DECIMAL(18, 2) DEFAULT 0,
    valor_presente_flujos     DECIMAL(18, 2) DEFAULT 0,
    valor_presente_terminal   DECIMAL(18, 2) DEFAULT 0,
    valor_mercado_negocio     DECIMAL(18, 2) DEFAULT 0,
    inversion_inicial_activos DECIMAL(18, 2) DEFAULT 0,
    valor_presente_neto       DECIMAL(18, 2) DEFAULT 0,

    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario),
)
GO
--TABLA para hacer la relacion de un escenario con sus resultados
-- y preparar el analisis de VPN de acuerdo a la variacion
-- del IPC y el objetivo de participacion de mercado
CREATE TABLE analisis_vpn
(
    id                              int identity (1,1) primary key,
    id_escenario                    int,
    variacion_ipc                   DECIMAL(16,8)  DEFAULT 0,
    variacion_participacion_mercado DECIMAL(16,8)  DEFAULT 0,
    valor_presente_neto             DECIMAL(18, 2) DEFAULT 0
)
GO
CREATE TABLE sensibilidad_puntual_vpn
(
    id                        int identity (1,1) primary key,
    id_escenario              int,
    variacion_porcentual      int, -- valor independiente de cuanto va a variar ejemplo 4%
    esAumento                 BIT, -- TRUE para aumento, FALSE para disminucion

    valor_equipos             DECIMAL(18, 2) DEFAULT 0,
    valor_equipos_vpn         DECIMAL(18, 2) DEFAULT 0,
    tamanio_mercado           DECIMAL(18, 2) DEFAULT 0,
    tamanio_mercado_vpn       DECIMAL(18, 2) DEFAULT 0,
    crecimiento_mercado       DECIMAL(16,8)  DEFAULT 0,
    crecimiento_mercado_vpn   DECIMAL(16,8)  DEFAULT 0,
    participacion_mercado     DECIMAL(16,8)  DEFAULT 0,
    participacion_mercado_vpn DECIMAL(16,8)  DEFAULT 0,
    precio_venta              DECIMAL(18, 2) DEFAULT 0,
    precio_venta_vpn          DECIMAL(18, 2) DEFAULT 0,
    inflacion_anual           DECIMAL(16,8)  DEFAULT 0,
    inflacion_anual_vpn       DECIMAL(16,8)  DEFAULT 0,
    costo_produccion          DECIMAL(18, 2) DEFAULT 0,
    costo_produccion_vpn      DECIMAL(18, 2) DEFAULT 0,
    gastos_operativos         DECIMAL(18, 2) DEFAULT 0,
    gastos_operativos_vpn     DECIMAL(18, 2) DEFAULT 0,
    gradiente_flujos          DECIMAL(16,8)  DEFAULT 0,
    gradiente_flujos_vpn      DECIMAL(16,8)  DEFAULT (0),
    tasa_impuestos            DECIMAL(16,8)  DEFAULT 0,
    tasa_impuestos_vpn        DECIMAL(16,8)  DEFAULT 0,
    costo_capital             DECIMAL(16,8)  DEFAULT 0,
    costo_capital_vpn         DECIMAL(16,8)  DEFAULT 0,

    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario)
)
GO
--resultados para el analisis de sensibilidad puntual del VPN
CREATE TABLE resultados_sensibilidad_puntual_vpn
(
    id                              int identity (1,1) primary key,
    id_escenario                    int,
    id_sensibilidad_puntual         int,
    variacion_porcentual            DECIMAL(16,8),
    esAumento                       BIT,
    grado_sensibilidad              DECIMAL(5,2),

    FOREIGN KEY (id_escenario) REFERENCES entradasEscenarios (id_escenario),
    FOREIGN KEY (id_sensibilidad_puntual) REFERENCES sensibilidad_puntual_vpn
)
GO


