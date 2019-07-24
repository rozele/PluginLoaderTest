using System;
using System.Composition.Hosting;
using System.IO;
using McMaster.NETCore.Plugins;
using Models;

namespace PluginLoaderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblyFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins", "TestPlugin", "TestPlugin.dll");
            var assembly = PluginLoader.CreateFromAssemblyFile(assemblyFile, PluginLoaderOptions.PreferSharedTypes)
                .LoadDefaultAssembly();
            var test = new ContainerConfiguration()
                .WithAssembly(assembly)
                .CreateContainer()
                .GetExport<ITest>();
            test.Test();
        }
    }
}
