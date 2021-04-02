using System;
using System.Linq;
using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment10.Components
{
    public class TeamFilterViewComponent: ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamFilterViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
