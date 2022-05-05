using System;
using System.Collections.Generic;
using System.Text;

namespace Tinh_ke_thua
{
    class animal // lớp cha 
    {
        protected double Weight;
        protected double Height;
        protected static int legs;

        public void Info()
        {
            Console.WriteLine("weight: " + Weight + "\tHeight: " + Height + "\tLegs: " + legs);
        }

        public animal()
        {

        }
        public animal(Double w, Double h , int l)
        {
            Weight = w;
            Height = h;
            legs = l;
        }
    }
    class Cat : animal //lớp con kế thừa từ thằng cha 
    {
        public Cat()
        {
            Weight = 500;
            Height = 20;
            legs = 2;
        }
        /*Nếu như lớp cha có phương thức khởi tạo có tham số đòi hỏi lớp con phải có phương thức khởi tạo tương ứng và thực hiện gọi phương thức
         khởi tạo của lớp cha thông qua từ khóa BASE
        *Cách gọi contrustor của lớp 
         */
        public Cat(Double w, Double h, int l): base(w, h, l)
        {

        }
        public new void Info()
        {
            Console.WriteLine("Info of Cat : ");
            base.Info(); // gọi đến hàm Info() của lớp cha
        }
    }
}
