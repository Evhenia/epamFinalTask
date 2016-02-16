using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Entities;
using PeriodicalsStore.WebApi.Services;

namespace PeriodicalsStore.WebApi.Models
{
    public class PeriodicalDto
    {
        public PeriodicalDto() { }

        public PeriodicalDto(Periodical periodical)
        {
            Id = periodical.Id;
            Name = periodical.Name;
            Description = periodical.Description;
            Themes = periodical.Themes.ToDto().ToList();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<ThemeDto> Themes { get; set; }

    }
}