using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessServices.DomainLogic.Interfaces.Services;
using Common.Entities;
using DataAccess.SqlServer.Core;

namespace BusinessServices.DomainLogic.Services
{
    public class PeriodicalService : IPeriodicalService
    {
        private readonly UnitOfWork _unitOfWork;

        public PeriodicalService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Periodical> GetAll()
        {
            return _unitOfWork.PeriodicalRepository.GetAll();
        }

        public Periodical GetById(int id)
        {
            var Periodical = _unitOfWork.PeriodicalRepository.GetById(id);

            return _unitOfWork.PeriodicalRepository.GetById(id);
        }

        public int Create(Periodical periodical)
        {
            if (periodical != null && _unitOfWork.PeriodicalRepository.GetById(periodical.Id) == null)
            {
                _unitOfWork.PeriodicalRepository.Add(periodical);
                _unitOfWork.Save();
            }
            return periodical.Id;
        }

        public bool Edit(Periodical editedPeriodical)
        {
            if (editedPeriodical != null && _unitOfWork.PeriodicalRepository.GetById(editedPeriodical.Id) == null)
            {
                _unitOfWork.PeriodicalRepository.Update(editedPeriodical);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }

        public bool Delete(Periodical deletedPeriodical)
        {
            if (deletedPeriodical != null && _unitOfWork.PeriodicalRepository.GetById(deletedPeriodical.Id) == null)
            {
                _unitOfWork.PeriodicalRepository.Delete(deletedPeriodical);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
    }
}
