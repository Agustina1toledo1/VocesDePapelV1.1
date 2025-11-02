using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocesDePapelV1._1.Models;

namespace VocesDePapelV1._1.Repositories
{
    public interface IVentaReporteRepository
    {
        IEnumerable<VentaReporteModel> GetVentasPorFecha(DateTime fechaInicio, DateTime fechaFin);
        IEnumerable<VentaReporteModel> GetVentasPorVendedor(int idVendedor);
        IEnumerable<VentaReporteModel> GetVentasPorCliente(string criterioCliente);
        IEnumerable<VentaReporteModel> GetTop10Ventas();
        decimal GetTotalVentasPeriodo(DateTime fechaInicio, DateTime fechaFin);
        int GetCantidadVentasPeriodo(DateTime fechaInicio, DateTime fechaFin);
    }
}
