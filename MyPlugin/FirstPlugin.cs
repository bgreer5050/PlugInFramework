using PluginContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlugin
{
    public class FirstPlugin :IPlugin
    {
        public string Name
        {
            get {
                return "From Bills Plugin";
            }
        }

        public void Do()
        {
            Console.WriteLine(this.Name);
        }
    }
}
