//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session5MVCmultitable.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee_project
    {
        public int emp_id { get; set; }
        [System.ComponentModel.DataAnnotations. StringLength(50)]
        public string emp_name { get; set; }
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string emp_project { get; set; }
    }
}
