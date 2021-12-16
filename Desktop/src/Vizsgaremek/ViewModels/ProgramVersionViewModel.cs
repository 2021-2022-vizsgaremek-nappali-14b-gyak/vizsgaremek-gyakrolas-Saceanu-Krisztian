using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vizsgaremek.Models;

namespace Vizsgaremek.ViewModels
{
    class ProgramVersionViewModel
    {

        private ProgramInfo programinfo;
        public string Version 
        {
            get
            {
                return programinfo.Version;
            }

            set
            {
                Version = value;
            }

        }


        public ProgramVersionViewModel()
        {
            ProgramInfo programinfo = new ProgramInfo();
        }
    }
}
