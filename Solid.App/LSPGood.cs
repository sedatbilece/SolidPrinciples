using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.App.LSPGood
{
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı.");
        }

        public abstract void TakePhoto(); 

    }


    public class Iphone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi.");
        }
    }
    // nokia foto çekmeyi desteklemiyor ise TakePhoto() adlı fonksiyona erişilememeli

    public class Nokia : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
