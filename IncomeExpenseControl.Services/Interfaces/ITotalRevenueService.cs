using IncomeExpenseControl.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Services.Interfaces
{
    public interface ITotalRevenueService
    {
        /// <summary>
        /// Parametre'de Gelen Type ve Gün'e Göre Tek Bir Kayıt'ı Getirmektedir.
        /// </summary>
        /// <param name="RevenueType"></param>
        /// <param name="RevenueDay"></param>
        /// <returns></returns>
        TotalRevenue GetSelectedTotalRevenueDay(RevenueType RevenueType, DateTime RevenueDay);

        /// <summary>
        /// Seçilmiş Ay ve Tipdeki Gelirleri Listeler
        /// </summary>
        /// <param name="RevenueType"></param>
        /// <param name="RevenueMonth"></param>
        /// <returns></returns>
        List<TotalRevenue> GetSelectedTotalRevenueMonth(RevenueType RevenueType, DateTime RevenueMonth);

        /// <summary>
        /// Seçilmiş Gün İçinde Bulunan Gelirleri Getirmektedir.
        /// </summary>
        /// <param name="RevenueType"></param>
        /// <param name="RevenueDay"></param>
        /// <returns></returns>
        List<TotalRevenue> GetTotalRevenueDay(DateTime RevenueDay);

        /// <summary>
        /// Seçilmiş Ay'daki Gelirleri Listeler
        /// </summary>
        /// <param name="RevenueType"></param>
        /// <param name="RevenueMonth"></param>
        /// <returns></returns>
        List<TotalRevenue> GetTotalRevenueMonth(DateTime RevenueMonth);







        /// <summary>
        /// Kayıt Oluşturur.
        /// </summary>
        /// <param name="totalRevenue"></param>
        /// <returns></returns>
        bool Insert(TotalRevenue totalRevenue);

        /// <summary>
        /// Var Olan Kaydı Günceller.
        /// </summary>
        /// <param name="totalRevenue"></param>
        /// <returns></returns>
        bool Update(TotalRevenue totalRevenue);
        
        /// <summary>
        /// Seçilmiş Günde Yapılan Toplam Ciro'yu Getirir.
        /// </summary>
        /// <param name="RevenueDay"></param>
        /// <returns></returns>
        decimal GetRevenueDayTotalPrice(DateTime RevenueDay);

        /// <summary>
        /// Seçilmiş Ay'daki Yapılan Toplam Ciro'yu Getirir.
        /// </summary>
        /// <param name="RevenueMonth"></param>
        /// <returns></returns>
        decimal GetRevenueeMonthTotalPrice(DateTime RevenueMonth);

      

       
    }
}
