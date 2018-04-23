using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAPT
{

    enum browserType
    {
        Chorme,
        }
    [TestFixture]

   public class Hooks : Base1
    {

      
       public Hooks()
       {

           Driver = new ChromeDriver(); 
       }

        }

    }

