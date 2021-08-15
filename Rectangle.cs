using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Rectangle : Shape//สร้าง abstract class Rectangle และทืบทอดมาจาก class Shape
    {
        //Property width and langth
        public double Width { get; private set; }
        public double Length { get; private set; }

        public Rectangle(double width, double length)//สร้าง constructor Rectangle รับค่าเข้า panameter 2 ค่า
        {
            Width = width;//ส่งค่าไป Width
            Length = length;
        }
    }

    public class AreaRectangle : Rectangle//สร้าง abstract class AreaRectangle และทืบทอดมาจาก class Rectangle
    {
        public AreaRectangle() : base(width:2.5,length:2.5) { }//สร้าง constructor AreaRectangle ส่งค่าเข้า panameter 2 ค่า แล้วให้กลับไปทำงานที่ constructor Rectangle โดยเอาค่าที่ได้ไปใส่ใน Property width and length

        public override double GetArea()//เขียนทับ method เดิม GetArea (เขียนวิธีการทำงาน)
        {
            return Width * Length;//ส่งค่าคืนกลับไป
        }
    }
}
