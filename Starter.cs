using System;
using System.Text;

namespace Module2HM6
{
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();

            for (int i = 0; i < 100; i++)
            {
                int number = new Random().Next(1, 4);
                Result result = null;

                switch (number)
                {
                    case 1:
                        result = actions.Method1();
                        break;
                    case 2:
                        result = actions.Method2();
                        try
                        {
                            Run();
                        }
                        catch (BusinessException exception)
                        {
                            var item = new LogItem(DateTime.Now, "Action got this custom Exception: exception", LogType.Warning);
                            FileService.GetInstance().File(item);
                        }
                        finally
                        {
                            Console.WriteLine("finally");
                        }
                        break;
                    case 3:
                        result = actions.Method3();
                        try
                        {
                            Run();
                        }
                        catch (Exception ex)
                        {
                            var item = new LogItem(DateTime.Now, "Action failed by reason: ex", LogType.Error);
                            FileService.GetInstance().File(item);
                        }
                        finally
                        {
                            Console.WriteLine("finally");
                        }
                        break;
                }
                if (result != null && !result.Status)
                {
                    var item = new LogItem(DateTime.Now, "Action failed by a reason: status = false", LogType.Error);
                    FileService.GetInstance().File(item);
                }
            }
            
            var text = new StringBuilder();
            var current = FileService.GetInstance().Storage;
            while (current != null)
            {
                text.AppendLine(current.time.ToShortTimeString+ " Type:" + current.Type + " Message" + current.Message);

                current = current.Next;
            }

            File.WriteAllText("log.txt", text.ToString());
        }
    }
}

