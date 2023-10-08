using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPBad
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public  class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı.");
        }

    }

    public class Iphone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("foto çekildi");
        }
    }

    public class Nokia : BasePhone
    {

    }
}
