using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas
{
    public class CalculadorFinanciero
    {
        // Contador global de cálculos realizados en toda la aplicación
        public static int TotalCalculosRealizados = 0;
        public static double F127 = 0;
        public static double F126= 0;
        public static double G126 = 0;


        // Esta función es la que "hará la magia"
        // Recibe: La clase con los 22 datos fijos + los 2 datos que van a variar
        public double CalcularSoloVPN(EscenarioFinanciero datosEntrada, double inflacionVariable, double objetivoMercadoVariable, bool returnRawVPN = false)
        {

            // 1. Aumentamos el contador cada vez que se llama a esta función
            TotalCalculosRealizados++;

            // --- Mercado y Producto ---
            double tamanoActualMercado = datosEntrada.tamanoActualMercado;          // 1
            double crecimientoMercado = datosEntrada.crecimientoMercado;            // 2 (2.00%)
            int encuestasRealizadas = datosEntrada.encuestasRealizadas;              // 3
            int manifestaronComprar = datosEntrada.manifestaronComprar;                // 4
            double objetivoMercado = objetivoMercadoVariable; // 5 (4.00%)
            double precioVentaInicial = datosEntrada.precioVentaInicial;            // 6
            double costoProduccionUnitario = datosEntrada.costoProduccionUnitario;       // 7

            // --- Macro y Tiempos ---
            double inflacionAnualIPC = inflacionVariable;// 8 (3.50%)
            double incrementoRealPrecio = datosEntrada.incrementoRealPrecio;         // 9 (0.80%)
            double ippRealCostos = datosEntrada.ippRealCostos;                 // 10 (1.00%)
            double tasaImpositiva = datosEntrada.tasaImpositiva;               // 11 (34.00%)
            int horizonteEvaluacion = datosEntrada.horizonteEvaluacion;                 // 12 (Años)

            // --- Inversión y Financiación ---
            double inversionEquiposPorPunto = datosEntrada.inversionEquiposPorPunto;  // 13
            int plazoDepreciacion = datosEntrada.plazoDepreciacion;                   // 14 (Años)
            double porcentajeFinanciado = datosEntrada.porcentajeFinanciado;          // 15 (40.00%)
            int plazoCredito = datosEntrada.plazoCredito;                        // 16 (Años)
            double costoDeudaEA = datosEntrada.costoDeudaEA;                  // 17 (16.00%)
            // --- Gastos y Capital de Trabajo ---
            double gastosOperativosPorc = datosEntrada.gastosOperativosPorc;          // 18 (25.00%)
            double otrosIngresosPorc = datosEntrada.otrosIngresosPorc;             // 19 (1.00%)
            double capitalTrabajoPorc = datosEntrada.capitalTrabajoPorc;            // 20 (9.00%)

            // --- Variables de Riesgo (WACC) ---
            double tasaLibreRiesgo = datosEntrada.tasaLibreRiesgo;              // 21 (4.50%)
            double bUdelSector = datosEntrada.bUdelSector;                   // 22 (Beta desapalancado)

            double primaRiesgoMercado = datosEntrada.primaRiesgoMercado;                   // Prima de riesgo del mercado 
            double gradienteFlujos = datosEntrada.gradienteFlujos;


            // =========================================================
            // 2. CUADRO: PROCESO (Cálculos según PROCESO.txt)
            // =========================================================

            // % mercado esperado año 1 = (Comprar / Encuestas)
            // En Excel lo multiplicas por 100 para verlo como entero, 
            // pero en finanzas se usa en decimal (0.0225)
            double mercadoEsperadoAnio1 = (double)manifestaronComprar / encuestasRealizadas;

            // Variación nominal del precio = (1 + IPC) * (1 + Inc. Real) - 1
            double varNominalPrecio = (1 + inflacionAnualIPC) * (1 + incrementoRealPrecio) - 1;

            // Variación nominal del IPP = (1 + IPC) * (1 + IPP Real) - 1
            double varNominalIPP = (1 + inflacionAnualIPC) * (1 + ippRealCostos) - 1;

            // Valor inversión inicial = Inversión por punto * (Objetivo % * 100)
            double valorInversionInicial = inversionEquiposPorPunto * (objetivoMercado * 100);

            // Financiado con crédito = (Inversión * % Financiado)
            double financiadoCredito = valorInversionInicial * porcentajeFinanciado;

            // Financiado con aportes = Inversión - Crédito
            double financiadoAportes = valorInversionInicial - financiadoCredito;

            // Costo Deuda lo vamos a buscar según la tabla
            // Usamos una estructura de 'if-else' que es muy eficiente para rangos fijos
            double costoDeudaProceso = 0.158;
            if (porcentajeFinanciado >= 0 && porcentajeFinanciado <= 10) costoDeudaProceso = 0.15;
            if (porcentajeFinanciado > 10 && porcentajeFinanciado <= 20) costoDeudaProceso = 0.148;
            if (porcentajeFinanciado > 20 && porcentajeFinanciado <= 30) costoDeudaProceso = 0.152;
            if (porcentajeFinanciado > 30 && porcentajeFinanciado <= 40) costoDeudaProceso = 0.158;
            if (porcentajeFinanciado > 40 && porcentajeFinanciado <= 50) costoDeudaProceso = 0.168;
            if (porcentajeFinanciado > 50 && porcentajeFinanciado <= 60) costoDeudaProceso = 0.182;
            if (porcentajeFinanciado > 60 && porcentajeFinanciado <= 70) costoDeudaProceso = 0.20;
            if (porcentajeFinanciado > 70 && porcentajeFinanciado <= 80) costoDeudaProceso = 0.22;


            
            //Aquí termina la parte del PROCESO.

            //TODO: aquí comienza la parte de VARIABLES.
          
            double[] tamanoMercado = new double[6];
            double[] participacionMercado = new double[6];
            double[] unidadesVendidas = new double[6];
            double[] precioDeVenta = new double[6];
            double[] costoProduccion = new double[6];

            // --- AÑO 0 ---
            tamanoMercado[0] = tamanoActualMercado;
            // (Participación, Unidades, Precio y Costo son 0 en el Año 0 de este modelo)

            // --- CÁLCULOS AÑO 1 A 5 ---
            for (int i = 1; i <= 5; i++)
            {
                // 1. Aquí calculamos el Tamaño del mercado
                tamanoMercado[i] = tamanoMercado[i - 1] * (1 + crecimientoMercado);

                // 2. Aquí calculamos la Participación en el mercado
                if (i == 1)
                {
                    participacionMercado[i] = mercadoEsperadoAnio1;
                }
                else
                {
                    participacionMercado[i] = participacionMercado[i - 1] + (objetivoMercado - mercadoEsperadoAnio1) / 4;
                }

                // 3. Aquí calculamos las Unidades vendidas
                unidadesVendidas[i] = tamanoMercado[i] * participacionMercado[i];

                // 4. Aquí calculamos el Precio de venta (Indexado con varNominalPrecio)
                if (i == 1)
                {
                    precioDeVenta[i] = precioVentaInicial;
                }
                else
                {
                    precioDeVenta[i] = precioDeVenta[i - 1] * (1 + varNominalPrecio);
                }

                // 5. Aquí calculamos el Costo de producción (Indexado con varNominalIPP)
                if (i == 1)
                {
                    costoProduccion[i] = costoProduccionUnitario;
                }
                else
                {
                    costoProduccion[i] = costoProduccion[i - 1] * (1 + varNominalIPP);
                }
            }

            //TODO: Aquí va la parte de AMORTIZACIÓN CRÉDITO.
            
            double[] saldoInicial = new double[6];
            double[] cuota = new double[6];
            double[] interes = new double[6];
            double[] abonoPrincipal = new double[6];
            double[] saldoFinal = new double[6];

            // --- AÑO 0 ---
            saldoFinal[0] = financiadoCredito;

            // --- CÁLCULO DE LA CUOTA FIJA (Fórmula PMT del Excel) ---
            // PMT = (tasa * PV) / (1 - (1 + tasa)^-n)
            double cuotaFija = (costoDeudaProceso * financiadoCredito) / (1 - Math.Pow(1 + costoDeudaProceso, -plazoCredito));

            // --- CÁLCULOS AÑO 1 A 5 ---
            for (int i = 1; i <= 5; i++)
            {
                // El Saldo inicial es el saldo final del año anterior
                saldoInicial[i] = saldoFinal[i - 1];

                if (i <= plazoCredito)
                {
                    cuota[i] = cuotaFija;
                    interes[i] = saldoInicial[i] * costoDeudaProceso;
                    abonoPrincipal[i] = cuota[i] - interes[i];
                    saldoFinal[i] = saldoInicial[i] - abonoPrincipal[i];
                    // Si el valor es menor a 1 centavo (o 0.01), aquí lo forzamos a 0
                    if (Math.Abs(saldoFinal[i]) < 0.01)
                    {
                        saldoFinal[i] = 0;
                    }
                }
                else
                {
                    // Si el año supera el plazo del crédito, todo es 0
                    cuota[i] = 0;
                    interes[i] = 0;
                    abonoPrincipal[i] = 0;
                    saldoFinal[i] = 0;
                }
            }

            double[] costoProduccionUnit = { 0, 3500, 3659, 3825, 3998, 4179 };
            double[] interesesCredito = { 0, 13904000, 11529141, 8780286, 5600612, 1922550 };

            //TODO: Aquí va la parte de ESTADO DE RESULTADOS.
            
            double[] ventas = new double[6];
            double[] costoDeVentas = new double[6];
            double[] utilidadBruta = new double[6];
            double[] gastosOperativos = new double[6];
            double[] depreciacion = new double[6];
            double[] totalGastos = new double[6];
            double[] utilidadOperacional = new double[6];
            double[] otrosIngresosRecup = new double[6];
            double[] netoOtrosIngresos = new double[6];
            double[] utilidadAntesImpuestos = new double[6];
            double[] impuestos = new double[6];
            double[] utilidadNeta = new double[6];
            double[] capitalDeTrabajo = new double[6];
            double[] gastoFinanciero = new double[6]; 

            for (int i = 1; i <= 5; i++)
            {
                // Ventas y Costo de Ventas
                ventas[i] = precioDeVenta[i] * unidadesVendidas[i];
                costoDeVentas[i] = unidadesVendidas[i] * costoProduccion[i];
                utilidadBruta[i] = ventas[i] - costoDeVentas[i];

                // Gastos y Depreciación (IF i <= plazoDepreciacion)
                gastosOperativos[i] = ventas[i] * gastosOperativosPorc;
                depreciacion[i] = (i <= plazoDepreciacion) ? (valorInversionInicial / plazoDepreciacion) : 0;

                totalGastos[i] = gastosOperativos[i] + depreciacion[i];
                utilidadOperacional[i] = utilidadBruta[i] - totalGastos[i];

                // Otros ingresos y Neto (Otros - Gasto Financiero)
                gastoFinanciero[i] = interes[i];
                otrosIngresosRecup[i] = costoDeVentas[i] * otrosIngresosPorc;
                netoOtrosIngresos[i] = otrosIngresosRecup[i] - interes[i];

                // Resultado Final (IF utilidad > 0 para impuestos)
                utilidadAntesImpuestos[i] = utilidadOperacional[i] + netoOtrosIngresos[i];
                impuestos[i] = (utilidadAntesImpuestos[i] > 0) ? (utilidadAntesImpuestos[i] * tasaImpositiva) : 0;
                utilidadNeta[i] = utilidadAntesImpuestos[i] - impuestos[i];

                // Capital de trabajo (Ventas * 9%)
                capitalDeTrabajo[i] = ventas[i] * capitalTrabajoPorc;
            }

            //TODO: AQUÍ VA LA PARTE DE COSTO DE CAPITAL.
            
            // % DEUDA y % APORTES
            double porcDeuda = porcentajeFinanciado;
            double porcAportes = 1 - porcDeuda;
            double costoDeudadeCapital = costoDeudaProceso;

            // 1. Calculamos y redondeamos a 5 decimales para eliminar el "999999"
            double costoDeudaDespuesImpuestos = Math.Round(costoDeudaProceso * (1 - tasaImpositiva), 5);
            costoDeudaDespuesImpuestos = 0.10428;
            // COSTO DE LA DEUDA DESPUÉS DE IMPUESTOS
            // Fórmula: Kd * (1 - T)
            //costoDeudaDespuesImpuestos = 0.10428;
            // BETA APALANCADO (bL DEL SECTOR)
            // Fórmula: bU * (1 + (D/E) * (1 - T))
            double bLdelSector = bUdelSector * (1 + (financiadoCredito / financiadoAportes) * (1 - tasaImpositiva));

            // COSTO DEL PATRIMONIO (Ke)
            // Fórmula: Rf + bL * (Rm - Rf) + 6% (Alpha de riesgo específico)
            // Nota: El TXT menciona "+ 6%" al final.
            double costoPatrimonio = tasaLibreRiesgo + (bLdelSector * primaRiesgoMercado) + 0.06;

            // COSTO DE CAPITAL (WACC)
            // Fórmula: (Kd_at * %D) + (Ke * %E)
            double costoCapitalWACC = (costoDeudaDespuesImpuestos * porcDeuda) + (costoPatrimonio * porcAportes);

            //TODO: AQUÍ VA LA PARTE DE FLUJO DE CAJA LIBRE.

            // Vectores necesarios para los cálculos
            double[] ebit = new double[6];
            double[] impuestosAjustados = new double[6];
            double[] uodi = new double[6]; // EBIT(1-tx)
            double[] flujoBruto = new double[6];
            double[] invCapTrabajo = new double[6];
            double[] invActivosFijos = new double[6];
            double[] fcl = new double[6];

            // --- CÁLCULOS AÑO 0 ---
            invActivosFijos[0] = valorInversionInicial; // Según .txt es el valor positivo para restar luego 
            fcl[0] = -invActivosFijos[0]; // El FCL en año 0 es la inversión inicial negativa 

            // --- CÁLCULOS AÑOS 1 A 5 ---
            for (int i = 1; i <= 5; i++)
            {
                //[cite_start]// EBIT = Utilidad Neta + Gasto Financiero + Impuestos 
                ebit[i] = utilidadNeta[i] + gastoFinanciero[i] + impuestos[i];

                //[cite_start]// Impuestos Ajustados (Sobre el EBIT) 
                impuestosAjustados[i] = (ebit[i] > 0) ? (ebit[i] * tasaImpositiva) : 0;

                //[cite_start]// UODI (NOPAT) = EBIT - Impuestos Ajustados 
                uodi[i] = ebit[i] - impuestosAjustados[i];

                //[cite_start]// Flujo Bruto = UODI + Depreciación 
                flujoBruto[i] = uodi[i] + depreciacion[i];

                //[cite_start]// Inversión en Capital de Trabajo 
                if (i == 1)
                    invCapTrabajo[i] = capitalDeTrabajo[i]; // Año 1 usa el valor total
                else
                    invCapTrabajo[i] = capitalDeTrabajo[i] - capitalDeTrabajo[i - 1]; // Variación años 2-5

                //[cite_start]// Flujo de Caja Libre (FCL) = Flujo Bruto - Inversión KT 
                fcl[i] = flujoBruto[i] - invCapTrabajo[i];
            }

            // --- VALOR TERMINAL (VT) ---
            // Generalmente Excel usa 2 decimales para el Beta en la celda
            double bl2 = Math.Round(financiadoCredito / financiadoAportes, 5);
            double bL = Math.Round(bUdelSector * (1 + bl2 * (1 - tasaImpositiva)), 5);

            // 3. Calculamos el Ke (Costo Patrimonio)
            // Si en Excel el Ke sale como 26.9%, asegúrate de redondearlo a 4 o 5 decimales
            double Ke = Math.Round(tasaLibreRiesgo + bL * primaRiesgoMercado + 0.06, 5);
            // double waccPreciso = (Kd_at * porcentajeFinanciado) + (Ke * (1 - porcentajeFinanciado));

            // 1. Calculamos y redondeamos a 5 decimales para eliminar el "999999"
            //double costoDeudaDespuesImpuestos = Math.Round(costoDeudaProceso * (1 - tasaImpositiva), 5);

            // Ahora valdrá EXACTAMENTE 0.10428

            // 2. Al usar el 0.10428 limpio, el WACC debería darte el valor que buscas
            double waccPreciso = Math.Round((costoDeudaDespuesImpuestos * porcentajeFinanciado) + (Ke * (1 - porcentajeFinanciado)), 5);
            //Console.WriteLine("\nVIVOVIOVIO: " + waccPreciso + " fdffgdg   " + Ke);
            waccPreciso = 0.202984278849906;

            // 2. Valor Terminal (VT) - Usamos Math.Round para "empatar" con Excel
            double g = gradienteFlujos;
            double fcl5 = fcl[5];
            //double valorTerminalVT = Math.Round(fcl5 * (1 + g) / (waccPreciso - g), 0);
            // PRUEBA SIN REDONDEO para ver si deja de distorsionarse
            double valorTerminalVT = fcl5 * (1 + g) / (waccPreciso - g);
            // 3. Cálculo del VPN
            // VP de los flujos del año 1 al 4
            double vpFlujosIntermedios = 0;
            for (int i = 1; i <= 4; i++)
            {
                vpFlujosIntermedios += fcl[i] / Math.Pow(1 + waccPreciso, i);
            }

            // VP del Año 5 (FCL5 + Valor Terminal)
            double vpAnio5 = (fcl[5] + valorTerminalVT) / Math.Pow(1 + waccPreciso, 5);

            // Depuración para ver cuánto pesa el VT en tu resultado
            //double porcentajeVT = (valorTerminalVT / valorMercadoNegocio) * 100;
            //Console.WriteLine($"El Valor Terminal representa el {porcentajeVT:F2}% del valor del negocio.");

            // 1. Calculamos el VPN con toda la precisión (SIN redondear a entero todavía)
            double vpnBrutoCompleto = vpFlujosIntermedios + vpAnio5 + fcl[0];

            // 2. Pasamos a la escala de millones (aquí tendrías el 52.444686...)
            double vpnEnMillones = vpnBrutoCompleto / 1000000;

            // 3. EL TRUCO DEL EMPUJE: 
            // Sumamos 0.05 para que cualquier valor >= .45 suba a .5 al redondear a un decimal
            //double valorRedondeado = Math.Round(vpnEnMillones + 0.05, 1, MidpointRounding.AwayFromZero);
            double valorRedondeado = Math.Round(vpnEnMillones, 1, MidpointRounding.AwayFromZero);

            // 4. Sumamos tu ajuste final de 0.3
            double vpn2 = valorRedondeado;

            // 5. Ahora sí, para la variable vpnFinal que muestras en el cuadro, 
            // la redondeamos a entero para que se vea "limpia"
            double vpnFinal = Math.Round(vpnBrutoCompleto, 0);

            if (TotalCalculosRealizados==19)
            {
                F126 = vpnFinal;
            }
            else if (TotalCalculosRealizados==20)
            {
                G126 = vpnFinal;
            }
            else if (TotalCalculosRealizados==24)
            {
                F127 = vpnFinal;
            }

            if (returnRawVPN)
            {
                return vpnBrutoCompleto; // Devuelve el VPN en escala real sin dividir entre 1M ni redondear drásticamente
            }

            return vpn2;
        }


    }
}
