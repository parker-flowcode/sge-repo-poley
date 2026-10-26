using System.Globalization;
using System.Runtime.InteropServices;

CultureInfo cultura = new("es-ES");
DateTime ahora = DateTime.Now;
DateTime haceTreintaDias = ahora.AddDays(-30);
DateTime dentroDeTreintaDias = ahora.AddDays(30);

string sistemaOperativo = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
    ? "Windows"
    : RuntimeInformation.OSDescription;

Console.WriteLine("==================================================");
Console.WriteLine("INFORME DEL SISTEMA");
Console.WriteLine("==================================================");
Console.WriteLine();

Console.WriteLine("FECHA Y HORA");
Console.WriteLine("------------");
Console.WriteLine($"Fecha: {ahora.ToString("dddd, d 'de' MMMM 'de' yyyy", cultura)}");
Console.WriteLine($"Hora: {ahora:HH:mm:ss}");
Console.WriteLine($"Día de la semana: {ahora.ToString("dddd", cultura)}");
Console.WriteLine($"Día del año: {ahora.DayOfYear}");
Console.WriteLine($"Semana del año: {ISOWeek.GetWeekOfYear(ahora)}");
Console.WriteLine();

Console.WriteLine("FECHA DE EJECUCIÓN");
Console.WriteLine("------------------");
Console.WriteLine($"Fecha actual: {ahora:dd/MM/yyyy}");
Console.WriteLine($"Hace 30 días era: {haceTreintaDias:dd/MM/yyyy}");
Console.WriteLine($"Dentro de 30 días será: {dentroDeTreintaDias:dd/MM/yyyy}");
Console.WriteLine();

Console.WriteLine("SISTEMA");
Console.WriteLine("-------");
Console.WriteLine($"Sistema operativo: {sistemaOperativo}");
Console.WriteLine($"Arquitectura: {RuntimeInformation.ProcessArchitecture}");
Console.WriteLine($"Nombre del equipo: {Environment.MachineName}");
Console.WriteLine($"Directorio actual: {Environment.CurrentDirectory}");
Console.WriteLine();
Console.WriteLine("==================================================");
