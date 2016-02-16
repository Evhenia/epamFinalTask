using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Entities;
using PeriodicalsStore.WebApi.Models;

namespace PeriodicalsStore.WebApi.Services
{
    public static class ModelToDto
    {
        public static IEnumerable<ThemeDto> ToDto(this IEnumerable<Theme> themes)
        {
            return themes.Select(theme => new ThemeDto(theme));
        }

        public static IEnumerable<PeriodicalDto> ToDto(this IEnumerable<Periodical> periodicals)
        {
            return periodicals.Select(periodical => new PeriodicalDto(periodical));
        }
    }
}