using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    //abstract class จะเป็น SuperClass เท่านั้น คือให้ supClass ไปทำงานเขียนต่อ
    public abstract class Shape//class Shape จะไม่สามารถนำไปสร้างเป็น object ได้
    {
        public abstract double GetArea();//method GetArea คือ method ที่ยังทำงานไม่เสร็จ

        public void ShowArea()//ภายใน abstract class สามารถมี method ที่สมบูรณ์ได้
        {
            Console.WriteLine("ShowArea in abstract class" + "\n");
        }
    }
}
