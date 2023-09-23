using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder.Models
{
    public class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Country { get; set; }
        public string Details { get; set; }

        public BannedGame()
        {
            Title = string.Empty;
            Series = string.Empty;
            Country = string.Empty;
            Details = string.Empty;
        }
        public BannedGame(string title, string series, string country, string details)
        {
            Title=title;
            Series=series;
            Country=country;
            Details=details;
        }
        public BannedGame(BannedGame banGa)
        {
            Title = banGa.Title;
            Series = banGa.Series;
            Country = banGa.Country;
            Details = banGa.Details;
        }
    }
}
