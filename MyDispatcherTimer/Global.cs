using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDispatcherTimer
{
    public static class Global
    {
        public static int ID { get; set; }
        public static int Name { get; set; }
        public static List<ActInfo> ActInfos { get; set; }
    }


    public class ActInfo
    {
        public int Id { get; set; }
        public DateTime LoginTime { get; set; }
        public string NameAction { get; set; }

    }
}
