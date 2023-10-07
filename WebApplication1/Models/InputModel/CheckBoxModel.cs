using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.InputModel
{
    public class CheckBoxModel
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public bool Selected { get; set; }
    }
}