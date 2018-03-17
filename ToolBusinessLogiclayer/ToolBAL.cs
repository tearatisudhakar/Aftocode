using System;
using System.Linq;
using System.Data;
using ToolDataAccessLayer;
using TooLManagementEntities;

namespace ToolBusinessLogiclayer
{
    public class ToolBAL
    {

        ToolDAL objDAL = new ToolDAL();


        #region CheckUser
        public DataSet CheckUser(string emailid, string password, int userid)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = objDAL.Login(emailid, password, userid);
            }
            catch (Exception )
            {
                throw;
            }
            return ds;
        }

        #endregion

        #region BindItemType
        public DataTable BindItemType(int itemselectedgrooup)
        {
            try
            {
                return objDAL.BindItemType(itemselectedgrooup);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region BindItemGroup
        public DataTable BindItemGroup(int itemselectedCategory)
        {
            try
            {
                return objDAL.BindItemGroup(itemselectedCategory);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region BindCategory
        public DataTable BindCategory()
        {
            try
            {
                return objDAL.BindCategory();
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region BindCategory
        public DataTable BindJob(int userid)
        {
            try
            {
                return objDAL.BindJob(userid);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region BindSupplier
        public DataTable BindSupplier()
        {
            try
            {
                return objDAL.BindSupplier();
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region BindLocation
        public DataTable BindLocation(int DrawerId)
        {
            try
            {
                return objDAL.BindLocation(DrawerId);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region BindDrawer
        public DataTable BindDrawer()
        {
            try
            {
                return objDAL.BindDrawer();
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region InsertItemType
        public int InsertItemType(int itemGroupId, string itemtype, int UserId)
        {
            try
            {
                int i = objDAL.InsertItemType(itemGroupId, itemtype, UserId);
                return i;
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region InsertGroup
        public int InsertGroup(int ItemCategoryId, string ItemNewGroup, int UserId)
        {
            try
            {
                int i = objDAL.InsertGroup(ItemCategoryId, ItemNewGroup, UserId);
                return i;
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region InsertCategory
        public int InsertCategory(string ItemCategory, int userid)
        {
            try
            {
                int i = objDAL.InsertNewCategory(ItemCategory, userid);
                return i;
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region InsertItemDetails
        public int InsertItemDetails(AddItemBo objbo, int UserId)
        {
            try
            {
                return objDAL.InsertItemDetails(objbo, UserId);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion
        #region UpdateitemDetails
        public int UpdateItemDetails(AddItemBo objbo, int UserId, int ItemCode)
        {
            try
            {
                return objDAL.UpdateItemDetails(objbo, UserId, ItemCode);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region InsertSupplier
        public int InsertSupplier(AddSupplierBo objbo, int UserId)
        {
            try
            {
                int i = objDAL.InsertSupplier(objbo, UserId);
                return i;
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        #region TransactionInfo
        public DataSet TransactionInfo(int ItemId)
        {
            try
            {
                return objDAL.TransactionInfo(ItemId);
            }
            catch (Exception )
            {

                throw;
            }
        }

        #endregion

        #region ReturnItemInfo
        public DataSet ReturnItemInfo(int UserID, int IsAdmin)
        {
            try
            {
                return objDAL.ReturnItemDetails(UserID, IsAdmin);
            }
            catch (Exception )
            {

                throw;
            }
        }

        #endregion

        //#region ItemInfobyIssueID
        //public DataSet ItemInfobyIssueID(string IssueID)
        //{
        //    try
        //    {
        //        return objDAL.ItemInfobyIssueID(IssueID);
        //    }
        //    catch (Exception )
        //    {

        //        throw;
        //    }
        //}

        //#endregion

        #region ItemInfo
        public DataSet ItemInfo(string itemcode)
        {
            try
            {
                return objDAL.ItemInfo(itemcode);
            }
            catch (Exception )
            {

                throw;
            }
        }

        #endregion

        #region BindTransactionInfo
        public DataSet BindTransactionInfo(int itemId)
        {
            try
            {
                return objDAL.BindTransactionInfo(itemId);
            }
            catch (Exception )
            {
                throw;
            }
        }

        #endregion

        #region CreateJob
        public int CreateJob(string jobname, string jobDesc, int userid)
        {
            try
            {
                int i = objDAL.Createjob(jobname, jobDesc, userid);
                return i;
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion

        public int InsertUserAccountDetails(UserAccountBo objUserAccount)
        {
            try
            {
                return objDAL.InsertUserAccountDetails(objUserAccount);
            }
            catch (Exception )
            {

                throw;
            }

        }

        #region UpdateUser 
        public int UpdateUserAccountDetails(UserAccountBo objUserAccount,int UserId)
        {
            try
            {
                return objDAL.UpdateUserAccountDetails(objUserAccount,UserId);
            }
            catch (Exception )
            {

                throw;
            }

        }
        #endregion

        public int AddSupplierDetails(SupplierDetails objSupplierDetails)
        {
            try
            {
                return objDAL.AddSupplierDetails(objSupplierDetails);
            }
            catch (Exception )
            {

                throw;
            }
        }

        public DataTable SelectUsers(UserAccountBo objUserAccount)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = objDAL.SelectUsers(objUserAccount);
                return dt;

            }
            catch (Exception )
            {

                throw;
            }
        }

        public DataTable GetLocations()
        {
            try
            {
                DataTable dt = new DataTable();
                return dt = objDAL.GetLocations();
            }
            catch (Exception )
            {

                throw;
            }
        }

        public int CheckRegisteredEmail(string email)
        {
            try
            {
                return objDAL.CheckRegisteredEmail(email);
            }
            catch (Exception )
            {
                
                throw;
            }
            

        }


        #region InsertOrUpdateItemFromExcel
        public int InsertOrUpdateItemFromExcel(AddItemBo objbo)
        {
            try
            {
                int i = objDAL.InsertOrUpdateItemFromExcel(objbo);
                //   TooLManagementEntities objEntites = new TooLManagementEntities();

                return i;
            }
            catch (Exception )
            {                
                throw;
            }
            
        }
        // public bool CheckDataHavingIntblItemInfoOrNot(string columnName, string value)
        string coluMnName = string.Empty;
        string value = string.Empty;
        public bool CheckDataHavingInDataTableOrNot(AddItemBo objboAdditem, int UserId)
        {

            bool checkresult = false;
            try
            {
                if (objboAdditem.ItemCateGory != null)
                {
                    coluMnName = "ItemCategory";
                    string value = objboAdditem.ItemCateGory;
                    checkresult = objDAL.CheckDataHavingInDataTableOrNot(coluMnName, value);
                    if (!checkresult)
                    {
                        objDAL.InsertNewCategory(value, UserId);
                    }
                }
                if (objboAdditem.ItemGroup != null)
                {
                    coluMnName = "ItemGroup";
                    string checkItemcategory = objboAdditem.ItemCateGory;
                    string checkvalue = objboAdditem.ItemGroup;
                    checkresult = objDAL.CheckItemSubGroup(coluMnName, checkItemcategory, checkvalue);
                    if (!checkresult)
                    {
                        int itemCateGoryId = objDAL.GetCategoryId(objboAdditem.ItemCateGory);
                        InsertGroup(itemCateGoryId, checkvalue, UserId);
                    }
                }

                if (objboAdditem.Supplier != null)
                {
                    coluMnName = "Company";
                    value = objboAdditem.Supplier;
                    checkresult = objDAL.CheckDataHavingInDataTableOrNot(coluMnName, value);
                    if (!checkresult)
                    {
                        SupplierDetails objbo = new SupplierDetails();
                        string supplierName = string.Empty;
                        supplierName = objboAdditem.Supplier;
                        SupplierDetails objSupplierDetails = new SupplierDetails();
                        objSupplierDetails.SupplierName =
                       objSupplierDetails.MiddleName = "";
                        objSupplierDetails.LastName = "";
                        objSupplierDetails.Company = supplierName;
                        objSupplierDetails.Displayname = "";
                        objSupplierDetails.Mobile = "";
                        objSupplierDetails.Email = "";
                        objSupplierDetails.Address = "";
                        objSupplierDetails.Phone = "";
                        objSupplierDetails.Fax = "";
                        objSupplierDetails.AccountNo = "";
                        objSupplierDetails.PanNumber = "";
                        objSupplierDetails.TaxRegistrationNo = "";
                        objSupplierDetails.SupplierCode = "";
                        objSupplierDetails.City = "";
                        objSupplierDetails.State = "";
                        objSupplierDetails.Country = "";
                        objSupplierDetails.PostalCode = "";
                        objSupplierDetails.Notes = "";
                        objSupplierDetails.UserId = 0;
                        int i = AddSupplierDetails(objSupplierDetails);

                        if (i != 0)
                        {
                            checkresult = true;
                        }
                    }
                }

                return checkresult;

                // return dt;
            }
            catch (Exception )
            {

                throw;
            }
        }


        private bool CheckDataHavingInDataTableOrNot(DataTable datatable, string columnName, string value)
        {
            try
            {
                bool checkresult = datatable.AsEnumerable().Any(row1 => value == row1.Field<String>(columnName));
                return checkresult;
            }
            catch (Exception )
            {
                throw;
            }

        }

        #endregion

        public bool ItemCodeContains(string columnName, string value)
        {
            bool checkresult = false;
            return checkresult = objDAL.ItemCodeContains(columnName, value);

        }

        public DataTable BindSubGroup()
        {
            return objDAL.BindSubGroup();
        }

        #region BindAccessLevel
        public DataTable BindAccessLevel()
        {
            try
            {
                return objDAL.BindAccessLevel();
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion
        #region CheckItemCodeExit
        public int CheckItemCodeExit(string ItemCode)
        {
            try
            {
                return objDAL.CheckItemCodeExit(ItemCode);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion
        #region BindUsers
        public DataSet BindUsers(int UID)
        {
            try
            {
                return objDAL.BindUsers(UID);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion
        #region Delete Supplier
        //public bool DeleteSupplier(int Supplierid,int Userid)
        //{
        //    bool IsDelete = false;
        //    try
        //    {
        //        IsDelete = objDAL.DeleteSupplier(Supplierid, Userid);
        //        return IsDelete;
        //    }
        //    catch (Exception )
        //    {
        //        throw;
        //    }
        //}
        #endregion
        #region UpdateSupplierDetails
         public int UpdateSupplierDetails(SupplierDetails objSupplierDetails)
        {
            try
            {
                return objDAL.UpdateSupplierDetails(objSupplierDetails);
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion
        #region Checking
         public bool CheckDataHavingOrNot(string ItemName, string Value)
         {
             try
             {
                 bool Result = false;
                 Result = objDAL.Checkingdata(ItemName, Value);
                 return Result;
             }
             catch (Exception )
             {                 
                 throw;
             }
         }
        #endregion
         #region InsertDepartment
         public int InsertDepartment(string Department)
         {
             try
             {
                 int i = objDAL.InsertDepartment(Department);
                 return i;
             }
             catch (Exception )
             {

                 throw;
             }
         }
         #endregion
         #region CheckDepartment
         public bool CheckDepartment(string DepartmentName)
         {
             try
             {
                 bool Result = false;
                 Result = objDAL.Checkingdepartment(DepartmentName);
                 return Result;
             }
             catch (Exception )
             {
                 throw;
             }
         }
         #endregion
         public DataTable GetMoQNotificationDetails()
         {
             try
             {
                 return objDAL.MoQNotificationDetails();
             }
             catch (Exception )
             {

                 throw;
             }
         }
    }
}
