using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public static class CommonFunctions
    {
        public static string GetProjectPath()
        {
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string projectPath = Path.GetDirectoryName(assemblyLocation);
            projectPath = "D:\\Source\\BMS\\Icons\\fingerprint gif.gif";
            return projectPath;
        }
    }

    public class Student
    {
        public int Id { get; set; }

        public int StdUId { get; set; }

        public byte[] Stamp { get; set; }

        public DateTime? StampTime { get; set; }

        public string StampString { get; set; }

        public bool? IsActive { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }


        public string StdPersonalNo { get; set; }

        public string StdFirstName { get; set; }

        public string StdEmail { get; set; }

        public string StdLastName { get; set; }

        public string StdPhoneNo { get; set; }

    }
}
