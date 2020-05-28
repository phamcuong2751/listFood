using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XlsIO;

namespace listFood
{
    class Food
    {
        public int ID { get; set; }
        public string nameOfFood { get; set; }
        public string howToFood { get; set; }
    }
    class ReadToFileExcel
    {
        OleDbConnection Conn;
        OleDbCommand Cmd;
        public ExcelDataService()
        {
            string ExcelFilePath = @"C:\\Users\\Quyet_Cute\\Desktop\\aaaa.xlsx";
            string excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelFilePath + ";Extended Properties=Excel 12.0;Persist Security Info=True";
            Conn = new OleDbConnection(excelConnectionString);
        }
    }
    public async Task<ObservableCollection<Student>> ReadRecordFromEXCELAsync()
    {
        ObservableCollection<Food> Foods = new ObservableCollection<Food>();
        await Conn.OpenAsync();
        Cmd = new OleDbCommand();
        Cmd.Connection = Conn;
        Cmd.CommandText = "Select * from [Sheet1$]";
        var Reader = await Cmd.ExecuteReaderAsync();
        while (Reader.Read())
        {
            Foods.Add(new Food()
            {
                ID = Convert.ToInt32(Reader["ID"]),
                nameOfFood = Reader["nameOfFood"].ToString(),
                howToFood = Reader["howToFood"].ToString()
            });
        }
        Reader.Close();
        Conn.Close();
        return Foods;
    }
    public async Task<bool> ManageExcelRecordsAsync(Food food)
    {
        bool IsSave = false;
        if (food.ID != 0)
        {
            await Conn.OpenAsync();
            Cmd = new OleDbCommand();
            Cmd.Connection = Conn;
            Cmd.Parameters.AddWithValue("@ID", food.ID);
            Cmd.Parameters.AddWithValue("@nameOfFood", food.nameOfFood);
            Cmd.Parameters.AddWithValue("@howToFood", food.howToFood);
            if (!IsStudentRecordExistAsync(food).Result)
            {
                Cmd.CommandText = "Insert into [Sheet1$] values (@ID,@nameOfFood,@howToFood)";
            }
            else
            {
                Cmd.CommandText = "Update [Sheet1$] set ID=@ID,Name=@nameOfFood,howToFood=@howToFood where ID=@ID";

            }
            int result = await Cmd.ExecuteNonQueryAsync();
            if (result > 0)
            {
                IsSave = true;
            }
            Conn.Close();
        }
        return IsSave;
    }
    private async Task<bool> IsStudentRecordExistAsync(Food food)
    {
        bool IsRecordExist = false;
        Cmd.CommandText = "Select * from [Sheet1$] where ID=@ID";
        var Reader = await Cmd.ExecuteReaderAsync();
        if (Reader.HasRows)
        {
            IsRecordExist = true;
        }

        Reader.Close();
        return IsRecordExist;
    }
    
}
