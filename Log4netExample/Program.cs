using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.IO;

namespace Log4netExample
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
            Console.WriteLine("Press Any Key...");
            Console.ReadKey();
        }
        public Program()
        {
            // xml이 있는 패스 경로
            String logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log4Net.xml");
            // Fileinfo로 변환하고
            FileInfo file = new FileInfo(logPath);
            // LogManager에 주입한다.
            XmlConfigurator.Configure(file);

            ILog logger = LogManager.GetLogger(this.GetType());

            // 로그 레벨 순위 입니다.
            logger.Fatal("fatal log");
            logger.Error("error log");
            logger.Warn("warn log");
            logger.Info("info log");
            logger.Debug("debug log");

            // 위에서 Info로 설정하게 되면 Fatal, Error, Warn, Info만 표시되고 Debug는 표시 되지 않습니다.
        }
    }
}