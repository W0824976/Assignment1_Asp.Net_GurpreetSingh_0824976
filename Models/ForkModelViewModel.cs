using Gurdeep_Fork_Assignment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Gurdeep_Fork_Assignment.Models
{
    public class ForkModelViewModel
    {
        public List<Fork> Forks { get; set; }
        public SelectList Models { get; set; }
        public string ForkModel { get; set; }
        public string SearchString { get; set; }
    }
}
