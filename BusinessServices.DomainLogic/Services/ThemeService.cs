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
    public class ThemeService : IThemeService
    {
        private readonly UnitOfWork _unitOfWork;

        public ThemeService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Theme> GetAll()
        {
            return _unitOfWork.ThemeRepository.GetAll();
        }

        public Theme GetById(int id)
        {
            var theme = _unitOfWork.ThemeRepository.GetById(id);
            
            return _unitOfWork.ThemeRepository.GetById(id);
        }

        public int Create(Theme theme)
        {
            if (theme != null && _unitOfWork.ThemeRepository.GetById(theme.Id) == null)
            {
                _unitOfWork.ThemeRepository.Add(theme);
                _unitOfWork.Save();
            }
            return theme.Id;
        }

        public bool Edit(Theme editedTheme)
        {
            if (editedTheme != null && _unitOfWork.ThemeRepository.GetById(editedTheme.Id) == null)
            {
                _unitOfWork.ThemeRepository.Update(editedTheme);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }

        public bool Delete(Theme deletedTheme)
        {
            if (deletedTheme != null && _unitOfWork.ThemeRepository.GetById(deletedTheme.Id) == null)
            {
                _unitOfWork.ThemeRepository.Delete(deletedTheme);
                _unitOfWork.Save();
                return true;
            }
            return false;
        }
    }
}
