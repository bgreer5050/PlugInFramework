using PluginContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadPlugins();
            System.Console.ReadLine();
        }

        private static void LoadPlugins()
        {
            if (!Directory.Exists("PluginDirectory"))
            {
                Directory.CreateDirectory("PluginDirectory");
                System.Console.WriteLine("Plugin Directory Created");
            }
            else
            {
                System.Console.WriteLine("Plugin Directory Exists");

            }

            //Get dlls from plugin directory
            string[] dllFileNames = null;
            dllFileNames = Directory.GetFiles("PluginDirectory");

            //load the assemblies
            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);

            System.Console.WriteLine("Loading {0} Assemblies.", dllFileNames.Length.ToString());

            foreach(string dllFile in dllFileNames)
            {
                AssemblyName an = System.Reflection.AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }

            System.Console.WriteLine("Search For Assemblies That Match Our Interface");

            Type pluginType = typeof(IPlugin);
            ICollection<Type> pluginTypes = new List<Type>();
            foreach(Assembly assembly in assemblies)
            {
                if(assembly != null)
                {
                    Type[] types = assembly.GetTypes();
                    throw new NotImplementedException();
                }
            }




            


        }
    }
}
