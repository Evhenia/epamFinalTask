using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Entities;

namespace DataAccess.SqlServer.Core
{
    public class PeriodicalsDBInitializer : CreateDatabaseIfNotExists<PeriodicalsDBContext>
    {
        protected override void Seed(PeriodicalsDBContext context)
        {
            Theme theme1 = new Theme() { Name = "Бизнесс" };
            Theme theme2 = new Theme() { Name = "Дом" };
            Theme theme3 = new Theme() { Name = "Наука" };
            Theme theme4 = new Theme() { Name = "Политика" };
            Theme theme5 = new Theme() { Name = "Рукоделие" };

            context.Themes.Add(theme1);
            context.Themes.Add(theme2);
            context.Themes.Add(theme3);
            context.Themes.Add(theme4);
            context.Themes.Add(theme5);

            context.SaveChanges();

            Periodical periodical1 = new Periodical() { Name = "Forbes", Price = 65, Description = "Журнал для успешних людей.", CountOfPage = 60, TimesAPeriod = 1, Themes = new List<Theme>() { theme1, theme4 } };
            Periodical periodical2 = new Periodical() { Name = "Burda", Price = 30, Description = "Журнал, помогающий шить.", CountOfPage = 45, TimesAPeriod = 1, Themes = new List<Theme>() { theme5, theme2 } };
            Periodical periodical3 = new Periodical() { Name = "Журнал3", Price = 23, Description = "Описание 3", CountOfPage =35, TimesAPeriod = 2, Themes = new List<Theme>() { theme1, theme3 } };
            Periodical periodical4 = new Periodical() { Name = "Журнал4", Price = 45, Description = "Описание 4", CountOfPage =36, TimesAPeriod = 1, Themes = new List<Theme>() { theme2, theme5 } };
            Periodical periodical5 = new Periodical() { Name = "Журнал5", Price = 66, Description = "Описание 5", CountOfPage =75, TimesAPeriod = 2, Themes = new List<Theme>() { theme4, theme5 } };
            Periodical periodical6 = new Periodical() { Name = "Журнал6", Price = 12, Description = "Описание 6", CountOfPage =20, TimesAPeriod = 1, Themes = new List<Theme>() { theme1, theme3, theme5} };
            Periodical periodical7 = new Periodical() { Name = "Журнал7", Price = 44, Description = "Описание 7", CountOfPage =15, TimesAPeriod = 4, Themes = new List<Theme>() { theme1, theme2, theme3 } };
            Periodical periodical8 = new Periodical() { Name = "Журнал8", Price = 32, Description = "Описание 8", CountOfPage =50, TimesAPeriod = 1, Themes = new List<Theme>() { theme2, theme3 } };

            context.Periodicals.Add(periodical1);
            context.Periodicals.Add(periodical2);
            context.Periodicals.Add(periodical3);
            context.Periodicals.Add(periodical4);
            context.Periodicals.Add(periodical5);
            context.Periodicals.Add(periodical6);
            context.Periodicals.Add(periodical7);
            context.Periodicals.Add(periodical8);

            context.SaveChanges();

            //base.Seed(context);
        }
    }
}
