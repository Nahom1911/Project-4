using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System.IO;

namespace Project_4
{
    class SQLiteDB1
    {
           //database path
            string dbPath = Path.Combine(
     System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
              "Departments.db3");

            public SQLiteDB1()
            {
            //Creating database, if it doesn't already exist 
            if (!File.Exists(dbPath))
            {
                var db = new SQLiteConnection(dbPath);
                    db.CreateTable<Departments>();
            }

            //if (db.Table<Departments>().Count() == 0)
        }

        public void Insert(string FullName,string Datetime, string Weight)
        {
            var db = new SQLiteConnection(dbPath);
            var newDepartments = new Departments();
            newDepartments.FullName = FullName;
            newDepartments.Weight = Weight;
            newDepartments.Datetime = Datetime;
            db.Insert(newDepartments);
        }

        
        public void Delete(int ID)
        {
            var db = new SQLiteConnection(dbPath);
            var newDepartments = new Departments();
            newDepartments.ID = ID;
            db.Delete(newDepartments);

        }

        public string select(string FullName)
            {
                string data = "";
                var db = new SQLiteConnection(dbPath);

                var DepartmentssStartingWithA = db.Query<Departments>("SELECT * FROM Departments WHERE FullName = ?", FullName);
                foreach (var s in DepartmentssStartingWithA)
                {
                data += s.ID + " " + s.FullName + " " + s.Datetime + " " + s.Weight + "\n";
            }
                return data;
            }

            public string SelectAll()
            {
                string data = "";
                var db = new SQLiteConnection(dbPath);
                Console.WriteLine("Reading data From Table");
                var table = db.Table<Departments>();
                foreach (var s in table)
                {
                data += s.ID + " " + s.FullName + " " + s.Datetime + " " + s.Weight + "\n";
            }
                return data;
            }

        [Table("Departments")]
        public class Departments
        {
            [PrimaryKey, AutoIncrement, Column("_ID")]
            public int ID { get; set; }
           
            [MaxLength(25)]
            public string FullName { get; set; }
            [Column("_Datetime")]
            [MaxLength(25)]
            public string Datetime { get; set; }
            [Column("_Weight")]
            [MaxLength(25)]
            public string Weight { get; set; }

        }

    }

    }