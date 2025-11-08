using iTextSharp.text;
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
        IEnumerable<VentaReporteModel> GetVentasPorVendedor(int idVendedor, DateTime fechaInicio, DateTime fechaFin);
        IEnumerable<VentaReporteModel> GetVentasPorCliente(int idCliente, DateTime fechaInicio, DateTime fechaFin);
        
        UsuarioModel GetVendedorPorId(int idVendedor);
        IEnumerable<UsuarioModel> GetVendedoresActivos();
        IEnumerable<ClienteModel> GetClientesActivos();
        decimal GetTotalVentasPeriodo(DateTime fechaInicio, DateTime fechaFin);
        int GetCantidadVentasPeriodo(DateTime fechaInicio, DateTime fechaFin);
        decimal GetTotalVentasPorVendedor(int idVendedor, DateTime fechaInicio, DateTime fechaFin);
        int GetCantidadVentasPorVendedor(int idVendedor, DateTime fechaInicio, DateTime fechaFin);
        decimal GetTotalVentasPorCliente(int value, DateTime fechaInicio, DateTime fechaFin);
        int GetCantidadVentasPorCliente(int value, DateTime fechaInicio, DateTime fechaFin);
    }
}
