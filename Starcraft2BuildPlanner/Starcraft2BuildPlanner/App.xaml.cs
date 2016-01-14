using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Starcraft2BuildPlanner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public uint CurrentTimeInTicks { get; set; } = 40; // Ticks are 0.5 seconds for now
    }
}
