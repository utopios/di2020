using System;
using System.Collections.Generic;
using coursWeb.Models;

namespace coursWeb.ViewModels
{
    public class HomeViewModel
    {
        public Person Person { get; set; }
        public List<string> ListeStrings { get; set; }
        public HomeViewModel()
        {
        }
    }
}
