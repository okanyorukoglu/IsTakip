using System;
using System.Collections.Generic;
using System.Text;

namespace YSKProje.ToDo.DTO.DTOs.RaporDto
{
    public class RaporUpdateDto
    {
        public int GorevId { get; set; }
        
        public string Tanim { get; set; }
        
        public string Detay { get; set; }
        //public Gorev Gorev { get; set; }
    }
}
