using Microsoft.Win32;
using System;
using System.Management;
using System.Text;

namespace AutoFy
{
    static class Config
    {
        private static ManagementObjectSearcher osSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
        private static ManagementObjectSearcher videoCardSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
        private static ManagementObjectSearcher processorSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
        private static ManagementObjectSearcher memorySearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
        private static StringBuilder sb = new StringBuilder();
        public static void ConfigPc()
        {
            string netFrameworkVersion = GetDotNetFrameworkVersion();
            sb.AppendLine(".NET Framework версия: " + netFrameworkVersion + "\n");
            string netCoreVersion = GetDotNetCoreVersion();
            sb.AppendLine(".NET Core версия: " + netCoreVersion + "\n");

            // Получаем информацию о версии Windows
            foreach (var os in osSearcher.Get())
            {
                var osCaption = (string)os["Caption"];
                var osBuildNumber = (string)os["BuildNumber"];

                sb.AppendLine($"ОС: {osCaption}");
                sb.AppendLine($"Номер сборки: {osBuildNumber}\n");
            }

            // Обрабатываем информацию о видеокарте
            foreach (var videoCard in videoCardSearcher.Get())
            {
                var videoCardName = (string)videoCard["Name"];
                var videoCardAdapterRAM = videoCard["AdapterRAM"]; // Объем памяти видеокарты в байтах

                // Преобразуем объем памяти видеокарты в гигабайты
                var videoCardMemoryInMB = Convert.ToInt64(videoCardAdapterRAM) / (1024 * 1024 * 1024);

                sb.AppendLine($"Видеокарта: {videoCardName}");
                sb.AppendLine($"Память видеокарты: {videoCardMemoryInMB} ГБ\n");
            }

            // Обрабатываем информацию о процессоре
            foreach (var processor in processorSearcher.Get())
            {
                var processorName = (string)processor["Name"];
                var processorSpeedMHz = processor["MaxClockSpeed"].ToString();
                var processorSpeedGHz = Convert.ToInt64(processorSpeedMHz) / 1000.0;
                sb.AppendLine($"Процессор: {processorName}");
                sb.AppendLine($"Частота процессора: {processorSpeedGHz} Ггц\n");
            }

            // Обрабатываем информацию об оперативной памяти
            foreach (var memory in memorySearcher.Get())
            {
                var memoryCapacity = Convert.ToUInt64(memory["Capacity"]);
                var memorySize = memoryCapacity / (1024 * 1024 * 1024); // Преобразуем к гигабайтам
                sb.AppendLine($"Оперативная память: {memorySize} ГБ");
            }
        }
        public static string GetConfigInfo()
        {
            return sb.ToString();
        }
        public static string GetDotNetFrameworkVersion()
        {
            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full"))
            {
                if (regKey != null && regKey.GetValue("Version") != null)
                {
                    return regKey.GetValue("Version").ToString();
                }
            }
            return "Никакой версии .NET Framework не найдено!";
        }
       public static string GetDotNetCoreVersion()
       {
            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\dotnet\Setup\InstalledVersions\x64\Desktop"))
            {
                if (regKey != null && regKey.GetValue("Version") != null)
                {
                    return regKey.GetValue("Version").ToString();
                }
            }
            return "Никакой версии .NET Сore не найдено!";
       }
    }
}
