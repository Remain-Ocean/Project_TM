using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_WPF
{
    internal class Toilet
    {
        public string Floor {  get; set; }
        public string Gender { get; set; }
        public string LocationDetail {  get; set; }
        public string CardName => $"{Floor.Substring(0,1)}F_{Gender.Substring(1)}_T_1";
        public string Status { get; set; }
    }
}
