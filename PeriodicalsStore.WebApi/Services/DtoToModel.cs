using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Entities;
using PeriodicalsStore.WebApi.Models;

namespace PeriodicalsStore.WebApi.Services
{
    public static class DtoToModel
    {
        public static Periodical ToModel(this PeriodicalDto periodicalDto)
        {
            return new Periodical()
            {
                Id = periodicalDto.Id,
                Name = periodicalDto.Name,
                Description = periodicalDto.Description,
                Themes = periodicalDto.Themes.Select(theme => theme.ToModel()).ToList()
            };
        }

        public static Theme ToModel(this ThemeDto themeDto)
        {
            return new Theme()
            {
                Id = themeDto.Id,
                Name = themeDto.Name
            };
        }

    }
}