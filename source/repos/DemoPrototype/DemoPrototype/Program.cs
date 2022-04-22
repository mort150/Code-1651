using System;

namespace DemoPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            MissingForm template = new MissingForm();
            template.Content = "Toi muon tim nguoi than :D";
            template.Footer = "Ha Noi, ngay 15 thang 6 nam 2021 \nNguoi viet don";
            template.Who = "Nguoi than";
            template.print();

            // a trinh bao mat tich

            MissingForm newForm = (MissingForm)template.CreateTemplate();
            newForm.Footer += "\nNguyen Van A";
            newForm.To += "Cong An ND";
            newForm.From += "Nguyen Van A";
            newForm.Content = "Con gai bi bat coc sang nay";
            newForm.print();

            // b trinh bao bo di lac
            newForm = (MissingForm)template.CreateTemplate();
            newForm.Footer += "\nNguyen Van B";
            newForm.From += "Nguyen Van B";
            newForm.Content = "Bo cao tuoi di lac tu hom qua";
            newForm.print();
        }
    }
}
