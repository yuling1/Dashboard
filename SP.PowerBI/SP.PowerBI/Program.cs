using SP.PowerBI.DB.DBContext;
using SP.PowerBI.DB.Model;
using SP.PowerBI.DBService;
using SP.PowerBI.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.PowerBI
{
    class Program
    {   
        static void Main(string[] args)
        {
            Basic_DbContext context = new Basic_DbContext();
            ManageService manageService = new ManageService(context);
            ExcelHelper helper = null;
            if (args.Length == 0)
            {
                Console.WriteLine("Please specifiy excel file path!");
            }

            string testPath = args[0];
            try
            {
                helper = new ExcelHelper(testPath);
                DataTable dt = helper.ExcelToDataTable();
                if (dt != null)
                {
                    //var allBllings = helper.TableToEntity(dt, typeof(Handoff));
                    //var allBllings = helper.TableToEntity(dt, typeof(NewFeature));
                    var allBllings = helper.TableToEntity(dt, typeof(Bug));
                    //var allBllings = helper.TableToEntity(dt, typeof(Communication));
                    //var allBllings = helper.TableToEntity(dt, typeof(Resource));
                    //var allBllings = helper.TableToEntity(dt, typeof(ResourceAllocation));
                    //var allBllings = helper.TableToEntity(dt, typeof(Efficency_Improvement));

                    if (manageService.ConvertModel2Context(allBllings))
                    {
                        Console.WriteLine("Success!");
                    }
                    else
                    {
                        Console.WriteLine("Failed!");
                    }
                }
                else
                {
                    Console.WriteLine("Table doesn't exsit！");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                helper.Dispose();
            }
            Console.ReadKey();
        }
    }
}


