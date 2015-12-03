using System;
using SharePointTools.Services;
using SharePointTools.Tools;
using Utility = SharePointTools.Tools.Utility;

namespace SharePointTools
{
    public class Program
    {
        private static SharePointOperaion operaion = new SharePointOperaion();
        public static void Main()
        {
            //var infos = new SharePointInfo();
            //var context = infos.MyContext;
            //var web = infos.GetWeb2();
            //var list = web.Lists.GetByTitle("User Photos");
            //var query = new CamlQuery();
            //context.Load(list);
            //context.ExecuteQuery();
            //var items = list.GetItems(query);
            //context.Load(items);
            //context.ExecuteQuery();
            //var folderPath = items[0]["FileRef"].ToString();

            //query.FolderServerRelativeUrl = folderPath;
            //var fitems = list.GetItems(query);
            //context.Load(fitems);
            //context.ExecuteQuery();
            //foreach (var fitem in fitems)
            //{
            //    var fileName = fitem["FileLeafRef"].ToString();
            //    var path = Constant.RootSite + fitem["FileRef"];
            //    WebDownload.Saveimage(path,"D:/photos/"+fileName);
            //}
            Utility.Menu();
            while (true)
            {
                Console.WriteLine("输入选项:");
                var optionContent = Console.ReadLine();
                if (!Utility.IsNumber(optionContent))
                {
                    Console.WriteLine("选项错误，请重新输入.");
                    continue;
                }
                var option = Convert.ToInt32(optionContent);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("输入你要查询的员工的名字和英文名:(O 名字 或 o 名字)，名字可以为姓名和英文名");
                        var condition = Console.ReadLine();
                        while (condition != null && (!condition.Contains("O ") && !condition.Contains("o ")))
                        {
                            Console.WriteLine("输入命令的格式不对,重新输入:");
                            condition = Console.ReadLine();
                        }
                        var employees = operaion.GetIsLeaveEmployees(condition, Dimission.NotLeave);

                        Console.WriteLine(employees.Count == 0 ? "没有找到相关员工:" : "查找员工信息如下:");
                        if (employees.Count != 0)
                        {
                            foreach (var employee in employees)
                            {
                                Console.WriteLine(employee == null ? "" : employee.ToString());
                            }
                        }

                        break;
                    case 2: System.Environment.Exit(0); break;
                }


            }

            //var list = web.Lists.GetByTitle("China Employees List");
            //context.Load(list);
            //context.ExecuteQuery();
            //var items = list.GetItems(new CamlQuery());
            //context.Load(items);
            //context.ExecuteQuery();
            //for (var i = 0; i < 20; i++)
            //{

            //Console.WriteLine("姓名:" + items.ElementAt(i).FieldValues["_x59d3__x540d_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["Office"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x6027__x522b_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x767b__x9646__x57df__x540d_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["Skype_x0020_ID"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x90e8__x95e8_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x7701_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x90ae__x7f16_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x5b66__x5386_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x804c__x4f4d_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x76f4__x5c5e__x9886__x5bfc_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x5230__x5c97__x65e5__x671f_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x6bd5__x4e1a__x5b66__x6821_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x6bd5__x4e1a__x65f6__x95f4_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_x5bb6__x5ead__x5730__x5740_"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["_ModerationComments"]);
            //Console.WriteLine(items.ElementAt(i).FieldValues["File_x0020_Type"]);
            //    Console.WriteLine(items.ElementAt(i).FieldValues["_x5934__x50cf_"]);
            //    Console.WriteLine("\n");
            //}
            Console.ReadKey();
        }
    }
}
