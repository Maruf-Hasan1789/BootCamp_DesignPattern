namespace BlogProject.Logger;

//LogWriter is implemented in singleton design pattern
//so that only one log file is created
public class LogWriter
{
    private string m_exePath = string.Empty;
    private static readonly object _lock = new(); 
    public static LogWriter Logger;

    public static LogWriter GetInstance()
    {
        lock(_lock)
        {
            if(Logger == null)
            {
                Logger = new();
            }
            return Logger;
        }
    }

    private LogWriter()
    {

    }

    public void LogWrite(string logMessage)
    {
        var m_exePath = Directory.GetCurrentDirectory();
        Console.WriteLine(m_exePath);
        try
        {
            var logDirectory = m_exePath+ "/logs";
            if(!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }
            using (StreamWriter w = File.AppendText(logDirectory+"/" + "custom.log"))
            {
                Log(logMessage, w);
            }
        }
        catch (Exception ex)
        {
        }
    }

    private void Log(string logMessage, TextWriter txtWriter)
    {
        try
        {
            txtWriter.Write("\r\nLog Entry : ");
            txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
            DateTime.Now.ToLongDateString());
            txtWriter.WriteLine("  :");
            txtWriter.WriteLine("  :{0}", logMessage);
            txtWriter.WriteLine("-------------------------------");
        }
        catch (Exception ex)
        {
            
        }
    }
}
