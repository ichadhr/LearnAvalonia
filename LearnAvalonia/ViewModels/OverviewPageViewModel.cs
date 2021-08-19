using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using Avalonia.Input;
using HardwareInformation;

namespace LearnAvalonia.ViewModels
{
    public class OverviewViewModel
    {
        public OverviewViewModel(string osName, string name, string arc, string cpuPhysicalCore, string cpuLogicalCore)
        {
            OsName = osName;
            Name = name;
            Arc = arc;
            CpuPhysicalCore = cpuPhysicalCore;
            CpuLogicalCore = cpuLogicalCore;
        }
        
        public string OsName { get; set; }
        public string Name { get; set; }
        public string Arc{get; set;}
        public string CpuPhysicalCore{get; set;}
        
        public string CpuLogicalCore{get; set;}
    }



    public class OverviewPageViewModel : ViewModelBase
    {
        private readonly MachineInformation _info = MachineInformationGatherer.GatherInformation(skipClockspeedTest: true);
        // private readonly osNameAndVersion = RuntimeInformation.OSDescription;
        public OverviewPageViewModel()
        {
            HardwareInfo = new ObservableCollection<OverviewViewModel>();
            
            var item = new OverviewViewModel(
                Environment.OSVersion.ToString(),
                _info.Cpu.Name, 
                _info.Cpu.Architecture,
                _info.Cpu.PhysicalCores.ToString(),
                _info.Cpu.LogicalCores.ToString()
                );
            
            HardwareInfo.Add(item);
        }

        public ObservableCollection<OverviewViewModel> HardwareInfo { get; }
    }
}