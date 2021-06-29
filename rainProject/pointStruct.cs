using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rainControlDevelop
{
    /// <summary>
    /// 定义点类型的类，画点时使用
    /// </summary>
    class pointStruct
    {
        private double x;
        private double y;
        private double z;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
    }
}
