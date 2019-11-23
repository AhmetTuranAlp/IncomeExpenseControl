using IncomeExpenseControl.Data.Entity;
using IncomeExpenseControl.DataAccess.Abstract.Repositories;
using IncomeExpenseControl.DataAccess.Abstract.UnitofWork;
using IncomeExpenseControl.DataAccess.Base.UnitofWork;
using IncomeExpenseControl.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncomeExpenseControl.Data.Entity.ModelEnums;

namespace IncomeExpenseControl.Services.Services
{
    public class Staff_Service : IStaff_Service
    {
        private readonly IRepository<Staff> _staffRepo;
        private readonly IUnitofWork _uow;
        public Staff_Service(UnitofWork uow)
        {
            _uow = uow;
            _staffRepo = _uow.GetRepository<Staff>();
        }

        public List<Staff> GetAllStaffs()
        {
            try
            {
                return _staffRepo.GetAll().Where(x => x.Status == Status.Active).OrderBy(x => x.UploadDate).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Staff GetStaff(string FullName)
        {
            try
            {
                return _staffRepo.GetAll().FirstOrDefault(x => x.Status == Status.Active && x.FullName == FullName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Insert(Staff staff)
        {
            try
            {
                var newEntity = AutoMapper.Mapper.DynamicMap<Staff>(staff);
                newEntity.Status = Status.Active;
                _staffRepo.Insert(newEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Staff staff)
        {
            try
            {
                var updateEntity = _staffRepo.Find(staff.Id);
                AutoMapper.Mapper.DynamicMap(staff, updateEntity);
                _staffRepo.Update(updateEntity);
                _uow.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
