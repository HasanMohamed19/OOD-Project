using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    // this class to be used to store data about current logged in user (other option is to store them application settings)
    public static class Global
    {
        public static int user_id {  get; set; }
    }
}
