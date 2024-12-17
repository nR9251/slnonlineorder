using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using prjonlineorder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjonlineorder.Controllers
{
    public class StoreController : Controller
    {
        dbORD2Context db = new dbORD2Context();
        public IActionResult Backstage()
        {
            //連接資料庫
            SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            sqlConn.Open();
            for (int i = 1; i <= 3; i++)
            {
                String strSQL = "UPDATE TableB" + i + " SET tPrice=TableC.tPrice*TableB" + i + ".tNum FROM TableC WHERE TableC.tMeal=TableB" + i + ".tMeal";
                SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
                sqlcommand.ExecuteNonQuery();
                db.SaveChanges();
            }
            sqlConn.Close();
            return View();
        }

        
        public IActionResult Accounting()
        {
            //列出明細
            var accounting = db.TableA.ToList();
            return View(accounting);
        }

        public IActionResult DetailsA()
        {
            //列出TableB1中數量>0的項目
            var desk = db.TableB1.Where(n => n.TNum > 0).ToList();
            return View(desk);
        }
        public IActionResult DetailsB()
        {
            //列出TableB2中數量>0的項目
            var desk = db.TableB2.Where(n => n.TNum > 0).ToList();
            return View(desk);
        }
        public IActionResult DetailsC()
        {
            //列出TableB3中數量>0的項目
            var desk = db.TableB3.Where(n => n.TNum > 0).ToList();
            return View(desk);
        }

        public IActionResult DeleteA()
        {
            //將結帳時間、桌號、總金額在TableA中生成
            SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            sqlConn.Open();
            String strSQL = "INSERT INTO TableA (tId,tDesk,tTotal)(SELECT convert(nvarchar(50),GetDate(), 108),1, SUM(tPrice) FROM TableB1) ";
            SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
            sqlcommand.ExecuteNonQuery();
            db.SaveChanges();
            sqlConn.Close();
            //清空TableB1的項目，因為菜單有20道菜，所以從1到20全部清空一次
            for (int t = 1; t <= 20; t++)
            {
                var Z = db.TableB1.Where(n => n.TNumber == t).FirstOrDefault();
                Z.TNum = 0;
                Z.TPrice = 0;
                db.SaveChanges();
            }
            return RedirectToAction("Accounting");
        }
        public IActionResult DeleteB()
        {
            //將結帳時間、桌號、總金額在TableA中生成
            SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            sqlConn.Open();
            String strSQL = "INSERT INTO TableA (tId,tDesk,tTotal)(SELECT convert(nvarchar(50),GetDate(), 108),2, SUM(tPrice) FROM TableB2) ";
            SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
            sqlcommand.ExecuteNonQuery();
            db.SaveChanges();
            sqlConn.Close();
            //清空TableB2的項目，因為菜單有20道菜，所以從1到20全部清空一次
            for (int t = 1; t <= 20; t++)
            {
                var Z = db.TableB2.Where(n => n.TNumber == t).FirstOrDefault();
                Z.TNum = 0;
                Z.TPrice = 0;
                db.SaveChanges();
            }
            return RedirectToAction("Accounting");
        }
        public IActionResult DeleteC()
        {
            //將結帳時間、桌號、總金額在TableA中生成
            SqlConnection sqlConn = new SqlConnection("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            sqlConn.Open();
            String strSQL = "INSERT INTO TableA (tId,tDesk,tTotal)(SELECT convert(nvarchar(50),GetDate(), 108),3, SUM(tPrice) FROM TableB3) ";
            SqlCommand sqlcommand = new SqlCommand(strSQL, sqlConn);
            sqlcommand.ExecuteNonQuery();
            db.SaveChanges();
            sqlConn.Close();
            //清空TableB3的項目，因為菜單有20道菜，所以從1到20全部清空一次
            for (int t = 1; t <= 20; t++)
            {
                var Z = db.TableB3.Where(n => n.TNumber == t).FirstOrDefault();
                Z.TNum = 0;
                Z.TPrice = 0;
                db.SaveChanges();
            }
            return RedirectToAction("Accounting");
        }
    }
}
