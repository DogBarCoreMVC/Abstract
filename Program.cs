using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s1 = new Shape();//error class shape ไม่สามารถนำไปสร้างเป็น object ได้

            Circle circle = new Circle();//create object circle
            double sumCircle = circle.GetArea();//เข้าไปทำงานใน method GetArea ทำเสร็จแล้วนำค่าที่ได้ออกมาไว้ใน variable sumCircle
            string showCircle = sumCircle.ToString("F2");//เอาค่าที่ได้มาตัดทศนิยมออกเหลือ 2 ตำแหน่ง ด้วย method ToString() F2 = ตำแหน่งทศนิยมที่ต้องการ
            Console.WriteLine("AreaCircle = " + showCircle);//แสดงผล

            circle.ShowArea();//แสดง method ที่สร้างไว้ใน abstract class

            AreaRectangle areaRectangle = new AreaRectangle();
            double showRectangle = areaRectangle.GetArea();
            Console.WriteLine("AreaRectangle = " + showRectangle);
        }
    }
}
