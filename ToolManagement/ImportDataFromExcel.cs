using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolBusinessLogiclayer;
using TooLManagementEntities;
using System.Data.OleDb;
using System.IO;
using System.Collections;
using System.Reflection;
namespace ToolManagement
{
    public partial class ImportDataFromExcel : Form
    {
        public ImportDataFromExcel()
        {
            InitializeComponent();
            gvUpdateExceltem.Visible = true;
            btnUpdateExcelitems.Visible = true;
            btnCancelUpdate.Visible = true;
           // from Shashi
            if (Login.IsAdmin)
            {
                //btnInsertItemFromExcel.Visible = true;
                //btnUpdateExcelitems.Visible = true;
                //btnUplloadExcelFile.Visible = true;

                btnInsertItemFromExcel.Enabled = true;
                btnUpdateExcelitems.Enabled = true;
                btnUplloadExcelFile.Enabled = true;
            }
            else
            {
                //btnInsertItemFromExcel.Visible = false;
                //btnUpdateExcelitems.Visible = false;
                //btnUplloadExcelFile.Visible = false;


                btnInsertItemFromExcel.Enabled = false;
                btnUpdateExcelitems.Enabled = false;
                btnUplloadExcelFile.Enabled = false;
            }

        }
        ToolBAL objcontroler = new ToolBAL();
        AddItemBo objbo = new AddItemBo();
        DataTable dtExcelItemInfo = null;
        DataTable dtExcelItemsForInsert = null;
        DataTable dtExcelItemsToUpdate = null;
        DataTable dtexcel = null;
        string columnName = string.Empty;
        string value = string.Empty;
        string typeOfMethod = string.Empty;
        int checkMatchingColumnsCount = 0;
        bool checkMatchingColumns = false;
        StringBuilder sb = null;
        #region BrowseExcelFile
        private void btnUplloadExcelFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = string.Empty;
                string fileExt = string.Empty;
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Excel Files|*.xlsx;";
                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    checkMatchingColumnsCount = 0;
                    filePath = file.FileName;
                    fileExt = Path.GetExtension(filePath);
                    //if(fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                    if (fileExt.CompareTo(".xlsx") == 0)
                    {
                        try
                        {
                            dtExcelItemInfo = new DataTable();
                            dtExcelItemInfo = ReadExcel(filePath, fileExt); //read excel file


                            UpdateExcelFileToGrids(dtExcelItemInfo);
                        }
                        catch (OleDbException ex)
                        {
                            MessageBox.Show("Please Select Deafult Downloaded  File.");
                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            return;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose Default DownLoaded Template  file only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        public DataTable ReadExcel(string fileName, string fileExt)
        {


            string conn = string.Empty;
            dtexcel = new DataTable();
            //if (fileExt.CompareTo(".xls") == 0)
            //{
            //    conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + fileName + "';Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';";
            //}
            if (fileExt.CompareTo(".xlsx") == 0)
            {
                conn = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}; Extended Properties=Excel 8.0", fileName);
                //    conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fileName + "';Extended Properties='Excel 12.0;HDR=NO';";
            }
            using (OleDbConnection constr = new OleDbConnection(conn))
            {
                try
                {
                    OleDbCommand comm = new OleDbCommand();
                    //string shtName = sw.Worksheets(1).Name; 

                    comm.CommandText = "Select * from [ExcelitemDetails$]";
                    comm.Connection = constr;
                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        da.SelectCommand = comm;
                        da.Fill(dtexcel);
                    }
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;

                }

            }
            return dtexcel;
        }

        public string[] GetExcelSheetName(DataTable dt)
        {
            String[] excelSheets = new String[dt.Rows.Count];
            try
            {
                int i = 0;

                // Add the sheet name to the string array.
                foreach (DataRow row in dt.Rows)
                {
                    excelSheets[i] = row[""].ToString();
                    i++;
                }

                // Loop through all of the sheets if you want too...
                for (int j = 0; j < excelSheets.Length; j++)
                {
                    // Query each excel sheet.
                }
                return excelSheets;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateExcelFileToGrids(DataTable dtExcelItemInfo)
        {
            try
            {
                int Qnt = 0;
                int rowCount = 0;
                int Accesslevel = 0;
                int Moq1 = 0;
                gvUpdateExceltem.DataSource = null;
                gvInsertExcelINewtems.DataSource = null;
                AddItemBo objbo = new AddItemBo();
                //Columns For InsertExcelIems
                CreateExcelGridColumns();
                checkMatchingColumnsCount = CompareSelectedExcelColumnsMatchng(dtExcelItemInfo);
                if (checkMatchingColumnsCount == 0)
                {
                    if (dtExcelItemInfo != null && dtExcelItemInfo.Rows.Count > 0)
                    {
                        foreach (DataRow item in dtExcelItemInfo.Rows)
                        {
                            rowCount = rowCount + 1;
                            Validations(item);
                            // objbo.Location = item["Location"].ToString();
                            if (sb != null && sb.ToString() != string.Empty)
                            {
                                sb.Append(" In Excel File at Row No  " + rowCount);
                                MessageBox.Show(sb.ToString());
                            }
                            else
                            {
                                objbo.ItemCode = item["Item code"].ToString();
                                objbo.ItemDesc = item["Item description"].ToString();
                                objbo.BarCode = item["Bar code"].ToString();
                                objbo.ItemCateGory = item["Category"].ToString();
                                objbo.ItemGroup = item["Group"].ToString();
                                objbo.ItemType = item["Item type"].ToString();
                                objbo.Supplier = item["Supplier"].ToString();
                                if (int.TryParse(item["Quantity"].ToString(), out Qnt))
                                {
                                    objbo.Quantity = Qnt;
                                }
                                if (int.TryParse(item["Access Level"].ToString(), out Accesslevel))
                                {
                                    objbo.Accesslevel = Accesslevel;
                                }
                                if (int.TryParse(item["MOQ"].ToString(), out Moq1))
                                {
                                    objbo.MOQ = Moq1;
                                }
                                objbo.UserId = Login.UserId;
                                objbo.IsAdmin = Login.IsAdmin;
                                columnName = "ItemCode";
                                value = objbo.ItemCode;
                                bool checkItemCode = objcontroler.ItemCodeContains(columnName, value);
                                if (checkItemCode == true)
                                {
                                    DataRow drExcelItemsToUpdate = dtExcelItemsToUpdate.NewRow();
                                    // drExcelItemsToUpdate["Location"] = objbo.Location;
                                    drExcelItemsToUpdate["Item code"] = objbo.ItemCode;
                                    drExcelItemsToUpdate["Item description"] = objbo.ItemDesc;
                                    drExcelItemsToUpdate["Bar code"] = objbo.BarCode;
                                    drExcelItemsToUpdate["Category"] = objbo.ItemCateGory;
                                    drExcelItemsToUpdate["Group"] = objbo.ItemGroup;
                                    drExcelItemsToUpdate["Item type"] = objbo.ItemType;
                                    drExcelItemsToUpdate["Supplier"] = objbo.Supplier;
                                    drExcelItemsToUpdate["Quantity"] = objbo.Quantity;
                                    drExcelItemsToUpdate["Access Level"] = objbo.Accesslevel;
                                    drExcelItemsToUpdate["MOQ"] = objbo.MOQ;
                                    dtExcelItemsToUpdate.Rows.Add(drExcelItemsToUpdate);
                                    sb = null;
                                }
                                else
                                {
                                    DataRow drExcelItemsForInsert = dtExcelItemsForInsert.NewRow();
                                    //drExcelItemsForInsert["Location"] = objbo.Location;
                                    drExcelItemsForInsert["Item code"] = objbo.ItemCode;
                                    drExcelItemsForInsert["Item description"] = objbo.ItemDesc;
                                    drExcelItemsForInsert["Bar code"] = objbo.BarCode;
                                    drExcelItemsForInsert["Category"] = objbo.ItemCateGory;
                                    drExcelItemsForInsert["Group"] = objbo.ItemGroup;
                                    drExcelItemsForInsert["Item type"] = objbo.ItemType;
                                    drExcelItemsForInsert["Supplier"] = objbo.Supplier;
                                    drExcelItemsForInsert["Quantity"] = objbo.Quantity;
                                    drExcelItemsForInsert["Access Level"] = objbo.Accesslevel;
                                    drExcelItemsForInsert["MOQ"] = objbo.MOQ;
                                    dtExcelItemsForInsert.Rows.Add(drExcelItemsForInsert);
                                    sb = null;

                                }
                            }
                        }
                        if (sb == null)
                        {
                            gvUpdateExceltem.DataSource = dtExcelItemsToUpdate;
                            gvInsertExcelINewtems.DataSource = dtExcelItemsForInsert;
                        }
                    }
                    else
                    {
                        MessageBox.Show("There Is No Data In Excel Please Insert Data", this.Text);

                    }
                }
                else
                {
                    if (checkMatchingColumnsCount == 1)
                    {
                        MessageBox.Show("There is " + checkMatchingColumnsCount + " Miss matched Columns  please Download Defualt Templeate again !", this.Text);
                    }
                    else
                    {
                        MessageBox.Show("There are " + checkMatchingColumnsCount + " Miss matched Columns  please Download Defualt Templeate again !", this.Text);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private int CompareSelectedExcelColumnsMatchng(DataTable dtExcelItemInfo)
        {

            try
            {
                if (dtExcelItemInfo.Rows.Count > 0)
                {
                    for (int j = 0; j < dtExcelItemsForInsert.Columns.Count; j++)
                    {
                        if (!dtExcelItemsForInsert.Columns.Contains(dtExcelItemInfo.Columns[j].ColumnName))
                        {
                            checkMatchingColumnsCount = checkMatchingColumnsCount + 1;
                        }
                        else
                        {
                            checkMatchingColumns = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return checkMatchingColumnsCount;
        }
        public void CreateExcelGridColumns()
        {
            try
            {
                dtExcelItemsForInsert = new DataTable();
                dtExcelItemsForInsert.Columns.Add("Item code");
                //dtExcelItemsForInsert.Columns.Add("Location"); Commented  by Ajay regards validating Location issue
                dtExcelItemsForInsert.Columns.Add("Item description");
                dtExcelItemsForInsert.Columns.Add("Bar code");
                dtExcelItemsForInsert.Columns.Add("Category");
                dtExcelItemsForInsert.Columns.Add("Group");
                dtExcelItemsForInsert.Columns.Add("Item type");
                dtExcelItemsForInsert.Columns.Add("Supplier");
                dtExcelItemsForInsert.Columns.Add("Quantity");
                dtExcelItemsForInsert.Columns.Add("Access Level");
                dtExcelItemsForInsert.Columns.Add("MOQ");
                //Columns For UpdateExcelItems
                dtExcelItemsToUpdate = new DataTable();
                dtExcelItemsToUpdate.Columns.Add("Item code");
                // dtExcelItemsToUpdate.Columns.Add("Location");
                dtExcelItemsToUpdate.Columns.Add("Item description");
                dtExcelItemsToUpdate.Columns.Add("Bar code");
                dtExcelItemsToUpdate.Columns.Add("Category");
                dtExcelItemsToUpdate.Columns.Add("Group");
                dtExcelItemsToUpdate.Columns.Add("Item type");
                dtExcelItemsToUpdate.Columns.Add("Supplier");
                dtExcelItemsToUpdate.Columns.Add("Quantity");
                dtExcelItemsToUpdate.Columns.Add("Access Level");
                dtExcelItemsToUpdate.Columns.Add("MOQ");


            }
            catch (Exception ex)
            {
                throw ex;


            }
        }
        #endregion  BrowseExcelFile

        #region InsertExcelItems
        private void btnInsertItemFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                typeOfMethod = "InsertItemFromExcel";
                InsertOrUpdateExcelItem(typeOfMethod, dtExcelItemsForInsert);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
        }
        private void gvInsertExcelINewtems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AddItemBo objboAdditem = new AddItemBo();
                DataGridViewRow row = this.gvInsertExcelINewtems.SelectedRows[0];
                // objboAdditem.Location = (string)row.Cells["Location"].Value;
                objboAdditem.ItemCode = (string)row.Cells["ItemCode"].Value;
                objboAdditem.ItemDesc = (string)row.Cells["ItemDescription"].Value;
                objboAdditem.BarCode = (string)row.Cells["BarCode"].Value;
                objboAdditem.ItemGroup = (string)row.Cells["SubGroup"].Value;
                objboAdditem.ItemCateGory = (string)row.Cells["Group"].Value;
                objboAdditem.Supplier = (string)row.Cells["Supplier"].Value;
                objboAdditem.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                AddaNewItem obj = new AddaNewItem(objboAdditem);
                obj.ShowDialog();


                string itemcode = (string)row.Cells["ItemCode"].Value;
                DeleteAddedItem(itemcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void DeleteAddedItem(string itemcode)
        {
            try
            {
                DataTable dtExcelItemsForAfterRowInsert = dtExcelItemsForInsert;
                DataRow[] result = dtExcelItemsForAfterRowInsert.Select("itemcode='" + itemcode + "'");
                foreach (DataRow row in result)
                {
                    // dtItemcode = objcontroler.ItemCodeContains(DataTable dt,string columnName);
                    // dtItemcode = objcontroler.ItemCodeContains(DataTable dt,string columnName);
                    //bool checkItemCode = dtItemcode.AsEnumerable().Any(row1 => itemcode == row1.Field<String>("ItemCode"));
                    columnName = "ItemCode";
                    value = itemcode;
                    bool checkItemCode = objcontroler.ItemCodeContains(columnName, value);
                    if (checkItemCode == true)
                    {
                        dtExcelItemsForAfterRowInsert.Rows.Remove(row);
                    }
                }
                gvInsertExcelINewtems.DataSource = dtExcelItemsForAfterRowInsert;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
        private void btnCancelInsert_Click(object sender, EventArgs e)
        {
            try
            {
                gvInsertExcelINewtems.DataSource = null;
                dtExcelItemsForInsert = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        #endregion  InsertExcelItems

        #region UpdateExcelItems

        private void btnUpdateExcelitems_Click(object sender, EventArgs e)
        {
            try
            {
                typeOfMethod = "UpdateItemFromExcel";
                InsertOrUpdateExcelItem(typeOfMethod, dtExcelItemsToUpdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dtExcelItemsToUpdate = null;
                gvUpdateExceltem.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion UpdateExcelItems

        #region InsertOrUpdateExcelItem

        public int InsertOrUpdateExcelItem(string typeOfMethod, DataTable dtExcelItemsForInsertOrUpdate)
        {
            try
            {
                int count = 0;
                int i = 0;
                AddItemBo objbo = new AddItemBo();
                if (dtExcelItemsForInsertOrUpdate != null && dtExcelItemsForInsertOrUpdate.Rows.Count > 0)
                {
                    bool result = false;
                    foreach (DataRow item in dtExcelItemsForInsertOrUpdate.Rows)
                    {
                        objbo.TypeOfmethod = typeOfMethod;
                        //  objbo.Location = item["Location"].ToString();
                        objbo.ItemCode = item["Item code"].ToString();
                        objbo.ItemDesc = item["Item description"].ToString();
                        objbo.BarCode = item["Bar code"].ToString();
                        objbo.ItemCateGory = item["Category"].ToString();
                        objbo.ItemGroup = item["Group"].ToString();
                        objbo.ItemType = item["Item type"].ToString();
                        objbo.Supplier = item["Supplier"].ToString();
                        objbo.Quantity = Convert.ToInt32(item["Quantity"]);
                        objbo.Accesslevel = Convert.ToInt32(item["Access level"]);
                        objbo.MOQ = Convert.ToInt32(item["MOQ"].ToString());
                        objbo.UserId = Login.UserId;
                        objbo.IsAdmin = Login.IsAdmin;
                        if (objbo.TypeOfmethod == "InsertItemFromExcel")
                        {
                            result = objcontroler.CheckDataHavingInDataTableOrNot(objbo, Login.UserId);
                            if (result == true)
                            {
                                i = objcontroler.InsertOrUpdateItemFromExcel(objbo);
                            }
                        }
                        else
                        {
                            i = objcontroler.InsertOrUpdateItemFromExcel(objbo);
                        }


                        if (i != 0)
                        {
                            count = count + 1;
                        }
                        else
                        {
                            MessageBox.Show(" Items  are not Inserted From excel please try again");

                        }
                    }
                    if (objbo.TypeOfmethod == "InsertItemFromExcel")
                    {
                        if (count == 1)
                        {
                            MessageBox.Show(count + " Item  has  Inserted From excel");

                        }
                        else
                        {
                            MessageBox.Show(count + " Items  are Inserted From excel");

                        }
                        gvInsertExcelINewtems.DataSource = null;
                        dtExcelItemsForInsert = null;

                    }
                    if (objbo.TypeOfmethod == "UpdateItemFromExcel")
                    {
                        if (count == 1)
                        {
                            MessageBox.Show(count + " Item  has Updated From excel");
                        }
                        else
                        {
                            MessageBox.Show(count + " Items  are Updated From excel");
                        }
                        dtExcelItemsToUpdate = null;
                        gvUpdateExceltem.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("There is no Data To  Insert/UpDatae ! Please Browse  File Data");

                }
                return i;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        #endregion InsertOrUpdateExcelItem

        private void lnklblDownloadExcelDefaultTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                CreateDefaultExcel obj = new CreateDefaultExcel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Validations(DataRow item)
        {
            //int Qnt = 0;
            try
            {
                sb = new StringBuilder();
                if (item["Item code"].ToString() == "")
                {
                    sb.Append("Please Add ItemCode Group");
                }
                //Commented by Rajkumar 
                //if (item["ItemDescription"].ToString() == "")
                //{
                //    if (sb != null)
                //    {
                //        sb.Append(",\n Please Add ItemDescription.");
                //    }
                //    else
                //    {
                //        sb.Append("Please Add ItemDescription");
                //    }
                //}
                //if (item["Barcode"].ToString() == "")
                //{
                //    if (sb != null)
                //    {
                //        sb.Append(",\n Please Add Barcode");
                //    }
                //    else
                //    {
                //        sb.Append("Please Add Barcode");
                //    }
                //}
                if (item["Category"].ToString() == "")
                {
                    if (sb != null)
                    {
                        sb.Append(",\n Please Add Caegory.");
                    }
                    else
                    {
                        sb.Append("Please Add Category");
                    }
                }
                if (item["Group"].ToString() == "")
                {
                    if (sb != null)
                    {
                        sb.Append(",\n Please Add Group.");
                    }
                    else
                    {
                        sb.Append("Please Add Group");
                    }
                }
                if (item["Item type"].ToString() == "")
                {
                    if (sb != null)
                    {
                        sb.Append(",\n Please Add Item Type.");
                    }
                    else
                    {
                        sb.Append("Please Add Item Type");
                    }
                }

                if (item["Supplier"].ToString() == "")
                {
                    if (sb != null)
                    {
                        sb.Append(",\n Please Add Supplier.");
                    }
                    else
                    {
                        sb.Append("Please Add Supplier");
                    }
                }
                if (item["Quantity"].ToString() == "")
                {
                    if (sb != null)
                    {
                        sb.Append(",\n Please Add Quantity.");
                    }
                    else
                    {
                        sb.Append("Please Add Quantity");

                    }
                }
                if (item["Access level"].ToString() == "")
                {
                    if (sb != null)
                    {
                        sb.Append(",\n Please Add Access level.");
                    }
                    else
                    {
                        sb.Append("Please Add Access level");

                    }
                }
                if (item["MOQ"].ToString() == "")
                {
                    if (sb != null)
                    {
                        sb.Append(",\n Please Add MOQ.");
                    }
                    else
                    {
                        sb.Append("Please Add MOQ");

                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class CreateDefaultExcel
    {
        ToolBAL objBal = new ToolBAL();
        int columnIndex = 0;
        object missing = Type.Missing;
        public CreateDefaultExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook oWB = oXL.Workbooks.Add(missing);
                Microsoft.Office.Interop.Excel.Worksheet oSheet = oWB.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;
                oSheet.Cells[1, 1] = "Item code";
                oSheet.Cells[1, 2] = "Item description";
                oSheet.Cells[1, 3] = "Bar code";
                oSheet.Cells[1, 4] = "Category";
                oSheet.Cells[1, 5] = "Group";
                oSheet.Cells[1, 6] = "Item type";
                oSheet.Cells[1, 7] = "Supplier";
                //oSheet.Cells[1, 9] = "Supplier code";
                oSheet.Cells[1, 08] = "Quantity";
                oSheet.Cells[1, 09] = "Access level";
                oSheet.Cells[1, 10] = "MOQ";
                oSheet.Name = "ExcelItemDetails";
                //if we want to add For Application Root directry we can add 
                //Microsoft.Office.Interop.Excel.Worksheet oSheet2 = oWB.Sheets.Add(missing, missing, 1, missing)
                //                as Microsoft.Office.Interop.Excel.Worksheet;
                //oSheet2.Name = "Sheet2";
                //oSheet2.Cells[1, 1] = "Something completely different";
                //string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                //                        + "\\Sample.xlsx";
                string fileName = null;
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Default.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    // Bind Access Level
                    var accesLevelList = new System.Collections.Generic.List<string>();
                    accesLevelList.Add("1");
                    accesLevelList.Add("2");
                    accesLevelList.Add("3");
                    var flatAccesLevelList = string.Join(",", accesLevelList.ToArray());
                    var oMissing = Type.Missing;
                    columnIndex = 09;
                    oXL.Visible = false;
                    BindExcelDropDowns(oXL, oSheet, columnIndex, flatAccesLevelList);
                    // Bind Supplier
                    DataTable dtSupplier = objBal.BindSupplier();
                    var supplierlList = new System.Collections.Generic.List<string>();
                    if (dtSupplier.Rows.Count > 0)
                    {
                        for (int i = 0; i < dtSupplier.Rows.Count; i++)
                        {
                            supplierlList.Add(dtSupplier.Rows[i]["Company"].ToString());
                        }
                    }
                    var flaSupplierlList = string.Join(",", supplierlList.ToArray());
                    var oMissingsupplierlList = Type.Missing;
                    columnIndex = 07;
                    oXL.Visible = false;
                    BindExcelDropDowns(oXL, oSheet, columnIndex, flaSupplierlList);

                    fileName = savefile.FileName;
                    oWB.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook,
                   missing, missing, missing, missing,
                   Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                   missing, missing, missing, missing, missing);
                    MessageBox.Show("Data saved in Excel format at location " + fileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    oWB.Close(missing, missing, missing);
                    oXL.UserControl = true;
                    oXL.Quit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindExcelDropDowns(Microsoft.Office.Interop.Excel.Application oXL, Microsoft.Office.Interop.Excel.Worksheet oSheet, int columnIndex, string flatList)
        {
            //Bind AccesLevel
            try
            {
                for (int i = 1; i < 100; i++)
                {

                    var cell = oSheet.Cells[i, columnIndex];
                    cell.Validation.Delete();
                    cell.Validation.Add(
                       Microsoft.Office.Interop.Excel.XlDVType.xlValidateList,
                       Microsoft.Office.Interop.Excel.XlDVAlertStyle.xlValidAlertInformation,
                       Microsoft.Office.Interop.Excel.XlFormatConditionOperator.xlBetween,
                       flatList,
                       Type.Missing);
                    cell.Validation.IgnoreBlank = true;
                    cell.Validation.InCellDropdown = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

            //Bind Supplier

        }
    }
}
