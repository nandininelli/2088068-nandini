using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace DoctorsManagement.Models


{
    public class DoctorsInfo
    {

        public int Id { get; set; }

        [Required ,StringLength(30)]
        public string Name { get; set; }

        public   string Specialization { get; set; }

        public string  HospitalName { get; set; }


    }
}
