using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Common.Entities;

namespace PeriodicalsStore.WebApi.Models
{
    public class ThemeDto
    {
        public ThemeDto() { }

        public ThemeDto(Theme theme)
        {
            Id = theme.Id;
            Name = theme.Name;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}