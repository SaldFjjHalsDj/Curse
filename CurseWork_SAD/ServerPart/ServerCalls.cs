using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurseWork_SAD.ServerPart
{
    public class ServerCalls
    {

        private static string connectionString = @"Data Source=(local);Initial Catalog = CurseWork_SAD; Integrated Security = True";

        private static DB_Object dB = new DB_Object(connectionString);
        

        public static string newLawUser(string surname, string name, string lastname, string adress, long phone, long inn, string orgname, string password)
        {
            dB.sqlCommandString = "exec insert_new_LawUser " + "'" + surname + "'," + "'" + name + "'," + "'" + lastname + "'," + "'" + adress + "'," + phone + "," + inn + "," + "'" + orgname + "'," + "'" + password + "'";
            return "Совершено " + dB.DB_Changes() + " изменений";
        }

        public static string newPhysUser(string surname, string name, string lastname, string adress, long phone, long inn, string password)
        {
            dB.sqlCommandString = "exec insert_new_PhysUser " + "'" + surname + "'," + "'" + name + "'," + "'" + lastname + "'," + "'" + adress + "'," + phone + "," + inn + ","  + "'" + password + "'";
            return "Совершено " + dB.DB_Changes() + " изменений";
        }

        public static string findUser(long phone, string password)
        {
            dB.sqlCommandString = "exec Find_User_In_DB " + phone + ",'" + password + "'";
            return "Добро пожаловать пользователь " + phone;
        }

        public static SqlDataReader userOrders(long phone, string password)
        {
            dB.sqlCommandString = "exec User_Orders " + phone + ",'" + password + "'";
            return dB.readTable();
        }

        public static string createDelivery(int category, float weight, float volume, int amount, string desc, long phone, string date, string start, string finish, float dist)
        {
            dB.sqlCommandString = "exec Create_Delivery " + category + "," + weight + "," + volume + "," + amount + ",'" + desc + "'," + phone + ",'" + date + "'," + "'" + start + "'," + "'" + finish + "'," + dist;
            return "Совершено " + dB.DB_Changes() + " изменений";
        }

        public static SqlDataReader showDelivery(long phone)
        {
            dB.sqlCommandString = "exec Show_Nacladnay " + phone;
            return dB.readTable();
        }

        public static SqlDataReader showDeliveryNull(long phone)
        {
            dB.sqlCommandString = "exec Show_Nacladnay_Null " + phone;
            return dB.readTable();
        }

        public static SqlDataReader showAuto()
        {
            dB.sqlCommandString = "exec showAuto ";
            return dB.readTable();
        }

        public static SqlDataReader showDriver()
        {
            dB.sqlCommandString = "exec showDriver ";
            return dB.readTable();
        }

        public static SqlDataReader showShtat()
        {
            dB.sqlCommandString = "exec showShtat ";
            return dB.readTable();
        }

        public static string autoAdd(string mark, string model, string number, float weight, float volume, string date, string special)
        {
            dB.sqlCommandString = "exec AutoADD " + "'" + mark + "'," + "'" + model + "'," + "'" + number + "'," + weight + "," + volume + ",'" + date + "'," + "'" + special + "'";
            return "Совершено " + dB.DB_Changes() + " изменений";
        }

        public static string driverAdd(string surname, string name, string lastname, long phone, long prava, long strahovka, int staj)
        {
            dB.sqlCommandString = "exec DriverADD " + "'" + surname + "'," + "'" + name + "'," + "'" + lastname + "'," + phone + "," + prava + "," + strahovka + "," + "'" + staj + "'";
            return "Совершено " + dB.DB_Changes() + " изменений";
        }

        public static string shtatAdd(string pair, int driver, long number, long straj, int auto, string num, string status)
        {
            dB.sqlCommandString = "exec AutoADD " + "'" + pair + "',"  + driver + "," + number + "," + straj + "," + auto + ",'" + num + "'," + "'" + status + "'";
            return "Совершено " + dB.DB_Changes() + " изменений";
        }

        public static SqlDataReader countSum()
        {
            dB.sqlCommandString = "exec CountSum ";
            return dB.readTable();
        }

        public static SqlDataReader cargoDel()
        {
            dB.sqlCommandString = "exec Cargo_By_Class";
            return dB.readTable();
        }

    }

}
