using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Spire.Xls;

namespace Utility
{
    public static class PasswordVerifier
    {

        public static bool verifyPassword(string password)
        {
            string temp;
            return verifyPassword(password, out temp);

        }
        public static bool verifyPassword(string password, out string error)
        {
            /*
             paroli unda iyos aseTi:
                                    a-z, A-Z, 0-9, !, ?, *, (no spaces),

                                    savaldebulo : min 1 spec symbol,
                                                  min 4 latin symbol,
                                                  min 3 nums,
                                                  fixed 8 characters
        */
            #region sub methods
            bool isNum(char c)
            {
                return c >= (int)'0' && c <= (int)'9';
            }
            bool isSpec(char c)
            {
                return c == '!' || c == '?' || c == '*';
            }
            bool isLatin(char c)
            {
                return (c >= (int)'a' && c <= (int)'z') || (c >= (int)'A' && c <= (int)'Z');
            }
            bool isForeign(char c)
            {
                return !isLatin(c) && !isNum(c) && !isSpec(c);
            }
            #endregion

            error = string.Empty;

            if (password.Length == 8)
            {

                int numCounter = 0;
                int latinCounter = 0;
                int specCounter = 0;


                for (int i = 0; i < password.Length; i++)
                {
                    if (isForeign(password[i]))
                    {
                        error = "Input contains wrong symbols, allowed symbols: latin characters, numbers, and ?, !, or *";
                        return false;
                    }
                    if (isLatin(password[i])) latinCounter++;
                    if (isNum(password[i])) numCounter++;
                    if (isSpec(password[i])) specCounter++;
                }
                if (numCounter == 3 && latinCounter == 4 && specCounter == 1)
                {
                    return true;
                }
                else
                {
                    error = "Password should contain 4 latin symbols, 3 numbers, and any of !, ? or * once";
                    return false;
                }
                //validacia tu gahyva useri parolis sherchevis wesebs 
            }
            else
            {
                error = "Input is not 8 symbols";
                return false;
                //roca 8 ze naklebi an meti iqneba parolebi magis case 
            }

            /*
             1. ორივე ტოლია
             2. 8 სიმბოლოა
             3. 
             */
        }
    }

    public static class InputFieldVerifier
    {
        // username can only contain letters (Georgian/English)
        public static bool verify_username(string input, string regex_pattern = @"^[A-Za-z\u10A0-\u10FF]+$") => Regex.IsMatch(input, regex_pattern);

        // cuurently only works for georgian phone numbers
        public static bool verify_phone(string input, string regex_pattern = @"^\d{10}$") => Regex.IsMatch(input, regex_pattern);

        // remove all white space
        public static string normalize_phone(string input) => input.Replace(" ", "");


        // cuurently only works for georgian IDs
        public static bool verify_id(string input, string regex_pattern = @"^\d{11}$") => Regex.IsMatch(input, regex_pattern);

        // email must match username@domain.extension format
        public static bool verify_email(string input, string regex_pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$") => Regex.IsMatch(input, regex_pattern);

        // old password verifier. TODO: confirm this is what we want
        public static bool VerifyPassword(string password, out string error)
        {
            // Regular expression to match the password requirements
            string pattern = @"^(?=(?:.*[A-Za-z]){4})(?=(?:.*\d){3})(?=(?:.*[!?*]){1})[A-Za-z\d!?*]{8}$";

            if (Regex.IsMatch(password, pattern))
            {
                error = string.Empty;
                return true;
            }
            else
            {
                error = "Password must be exactly 8 characters, with 4 Latin letters, 3 digits, and 1 special character (!, ?, *).";
                return false;
            }
        }
    }


    public static class DataIO
    {
        public static DataTable[] read_tables_from_excel(string excel_path)
        {
            if (!File.Exists(excel_path))
            {
                MessageBox.Show($"File: {{{excel_path}}} doesn't exist");
                return null;
            }

            List<DataTable> tables = new List<DataTable>();
            try
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(excel_path);

                foreach (Worksheet sheet in workbook.Worksheets)
                {
                    tables.Add(sheet.ExportDataTable());
                }

                return tables.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return null;
            }
        }


        // takes in path to the file and data tables, then writes these data tables as sheets in an excel file
        public static void write_to_excel(string excel_path, params DataTable[] tables)
        {
            try
            {
                Workbook workbook = new Workbook();

                if (tables == null || tables.Length == 0)
                {
                    MessageBox.Show("No tables provided to write.");
                    return;
                }

                // Use the default sheet for the first DataTable
                Worksheet defaultSheet = workbook.Worksheets[0];
                defaultSheet.Name = "Sheet1";
                defaultSheet.InsertDataTable(tables[0], true, 1, 1);

                // Add additional sheets for remaining DataTables
                for (int i = 1; i < tables.Length; i++)
                {
                    Worksheet sheet = workbook.Worksheets.Add($"Sheet{i + 1}");
                    sheet.InsertDataTable(tables[i], true, 1, 1);
                }

                // Save the workbook to the specified path
                workbook.SaveToFile(excel_path, ExcelVersion.Version2013);

                MessageBox.Show("Excel file created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while writing to Excel: {ex.Message}");
            }
        }
    }

}
