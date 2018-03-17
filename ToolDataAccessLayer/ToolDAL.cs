using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using TooLManagementEntities;


namespace ToolDataAccessLayer
{
    public class ToolDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Connection"].ToString());

        // AddItemBo Bo;
        #region Login
        public DataSet Login(string emaildid, string password, int userId)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmailID", emaildid);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserID", userId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }

        #endregion

        #region ItemInfo
        public DataSet ItemInfo(int userid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_AllItemInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region ItemInfo
        public DataSet ItemInfo(string itemCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ItemInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Itemcode", itemCode);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                throw ;
            }
        }

        #endregion
        //sudhakar
        #region ItemInfoBYIssueID
        public DataSet ItemInfobyIssueID(int userId, int isAdmin, string issueID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ItemisssuedDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@IsAdmin", isAdmin);
                cmd.Parameters.AddWithValue("@ItemCode", issueID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region Itemstatus
        public DataSet ItemStatus(int ItemId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ItemStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemId", ItemId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {

                throw;
            }
        }

        #endregion

        #region AllItemstatus
        public DataSet AllItemStatus(string itemcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_AllItemStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemId", itemcode);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {

                throw;
            }
        }

        #endregion

        #region AllReturnItems
        //public DataSet AllReturnItems(string itemcode, int IsAdmin, int UserId)
        //{
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("Sp_ReturnItemInfo", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@ItemCode", itemcode);
        //        cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
        //        cmd.Parameters.AddWithValue("@UserId", UserId);
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);
        //        return ds;
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        public DataSet AllReturnItems(string itemcode, int IsAdmin, int UserId, int pageIndex, int pageSize)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_ReturnItemInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", itemcode);
                cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region ItemDelete
        public int ItemDelete(int ItemId, int userid)
        {
            int Result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_DeleteItem", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemId", ItemId);
                cmd.Parameters.AddWithValue("@UserId", userid);
                con.Open();
                Result = cmd.ExecuteNonQuery();
                return Result;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region ItemRestore
        public int ItemRestore(int itemId, int userid)
        {
            int Result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_RestoreItem", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemId", itemId);
                cmd.Parameters.AddWithValue("@UserId", userid);
                con.Open();
                cmd.ExecuteNonQuery();

                return Result;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        #endregion

        #region ItemTypeInfo
        public DataTable ItemTypeInfo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select ItemTypeCode,ItemType from tblitemtype", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }

        #endregion

        #region BindItemType
        public DataTable BindItemType(int itemselectedgrooup)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_BindItemType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemgroupid", itemselectedgrooup);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
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
                SqlCommand cmd = new SqlCommand("Sp_BinditemGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@itemselectedCategory", itemselectedCategory);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region    BindCategory
        public DataTable BindCategory()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_BindCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region    BindJob
        public DataTable BindJob(int UserId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_BindJob", con);
                cmd.Parameters.AddWithValue("@userid", UserId);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region    BindSupplier
        public DataTable BindSupplier()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[Sp_BindSupplier]", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region    BindLocation
        public DataTable BindLocation(int DrawerID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Location", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DrawerId", DrawerID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region    BindDrawer
        public DataTable BindDrawer()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[Sp_Drawer]", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region InsertNewCategory

        public int InsertNewCategory(string ItemCategory, int UserId)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("[Sp_InsertItemCategory]", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@ItemCategory", ItemCategory);
                cmd.Parameters.AddWithValue("@Createduserid", UserId);
                //  SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return i;

        }

        #endregion

        #region InsertItemType
        public int InsertItemType(int itemGroupId, string itemtype, int UserId)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("Sp_InsertItemType", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemGroupId", itemGroupId);
                cmd.Parameters.AddWithValue("@ItemType", itemtype);
                cmd.Parameters.AddWithValue("@Createduserid", UserId);
                //  SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return i;
        }
        #endregion

        #region InsertGroup
        public int InsertGroup(int ItemCategoryId, string ItemNewGroup, int Userid)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertItemGroup", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemCategoryId", Convert.ToInt32(ItemCategoryId));
                cmd.Parameters.AddWithValue("@ItemNewGroup", ItemNewGroup);
                cmd.Parameters.AddWithValue("@Createduserid", Userid);
                //  SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
                // ex.Message("Error While Saving THe Data");
            }
            finally
            {
                con.Close();

            }
            return i;
        }
        #endregion

        #region InsertItemDetails
        public int InsertItemDetails(AddItemBo objbo, int UserId)
        {
            SqlCommand cmd = null;
            int i = 0;
            try
            {
                cmd = new SqlCommand("[Sp_InsertItemDetails]", con);

                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@CateGory", objbo.ItemCateGory);
                cmd.Parameters.AddWithValue("@ItemGroup", objbo.ItemGroup);
                if (!string.IsNullOrEmpty(objbo.ItemType))
                    cmd.Parameters.AddWithValue("@ItemType", objbo.ItemType);
                else
                    cmd.Parameters.AddWithValue("@ItemType", DBNull.Value);

                cmd.Parameters.AddWithValue("@ImagePath", objbo.ImagePath);
                cmd.Parameters.AddWithValue("@ItemCode", objbo.ItemCode);
                cmd.Parameters.AddWithValue("@ItemDesc", objbo.ItemDesc);
                cmd.Parameters.AddWithValue("@Location", objbo.Location);
                cmd.Parameters.AddWithValue("@Supplier", objbo.Supplier);
                cmd.Parameters.AddWithValue("@Quantity", objbo.Quantity);
                cmd.Parameters.AddWithValue("@MOQ", objbo.MOQ);
                cmd.Parameters.AddWithValue("@ProductCode", objbo.ProductCode);
                cmd.Parameters.AddWithValue("@AccessLevel", objbo.Accesslevel);
                //cmd.Parameters.AddWithValue("@BarCode", objbo.BarCode);
                // cmd.Parameters.AddWithValue("@SereialNo", objbo.SereialNo);
                // cmd.Parameters.AddWithValue("@SupplierPartNo", objbo.SupplierPartNo);                
                // cmd.Parameters.AddWithValue("@LastUnitCost", objbo.LastUnitCost);
                //  cmd.Parameters.AddWithValue("@LastReceiptDate", objbo.LastReceiptDate);

                // SqlDataAdapter da = new SqlDataAdapter(cmd);
                i = cmd.ExecuteNonQuery();

                return i;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }
        #endregion

        #region UpdateItemDetails
        public int UpdateItemDetails(AddItemBo objbo, int UserId, int ItemId)
        {
            SqlCommand cmd = null;
            int i = 0;
            try
            {
                cmd = new SqlCommand("Sp_UpdateItemDetails", con);

                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.Parameters.AddWithValue("@CateGory", objbo.ItemCateGory);
                cmd.Parameters.AddWithValue("@ItemGroup", objbo.ItemGroup);
                if (!string.IsNullOrEmpty(objbo.ItemType))
                    cmd.Parameters.AddWithValue("@ItemType", objbo.ItemType);
                else
                    cmd.Parameters.AddWithValue("@ItemType", DBNull.Value);

                cmd.Parameters.AddWithValue("@ImagePath", objbo.ImagePath);
                cmd.Parameters.AddWithValue("@ItemCode", objbo.ItemCode);
                cmd.Parameters.AddWithValue("@ItemDesc", objbo.ItemDesc);
                cmd.Parameters.AddWithValue("@Location", objbo.Location);
                cmd.Parameters.AddWithValue("@Supplier", objbo.Supplier);
                cmd.Parameters.AddWithValue("@Quantity", objbo.Quantity);
                cmd.Parameters.AddWithValue("@MOQ", objbo.MOQ);
                cmd.Parameters.AddWithValue("@ProductCode", objbo.ProductCode);
                cmd.Parameters.AddWithValue("@ItemId", ItemId);
                cmd.Parameters.AddWithValue("@AccessLevel", objbo.Accesslevel);
                //cmd.Parameters.AddWithValue("@BarCode", objbo.BarCode);
                // cmd.Parameters.AddWithValue("@SereialNo", objbo.SereialNo);
                // cmd.Parameters.AddWithValue("@SupplierPartNo", objbo.SupplierPartNo);                
                // cmd.Parameters.AddWithValue("@LastUnitCost", objbo.LastUnitCost);
                //  cmd.Parameters.AddWithValue("@LastReceiptDate", objbo.LastReceiptDate);
                // SqlDataAdapter da = new SqlDataAdapter(cmd);
                i = cmd.ExecuteNonQuery();

                return i;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                if (cmd!=null)
                {
                    cmd.Dispose();
                }
            }
        }
        #endregion

        #region ItemIssue
        public int ItemIssue(int itemissueqnt, int userid, int ItemId, int AvlQnt, int Jobid, int ReturnUsed, int Return)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("Sp_ItemIssue", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemissueQnty", itemissueqnt);
                cmd.Parameters.AddWithValue("@ItemId", ItemId);
                cmd.Parameters.AddWithValue("@UserId", userid);
                cmd.Parameters.AddWithValue("@AvlQnt", AvlQnt);
                cmd.Parameters.AddWithValue("@JobId", Jobid);
                cmd.Parameters.AddWithValue("@ReturnUsed", ReturnUsed);
                cmd.Parameters.AddWithValue("@Return", Return);
                //  SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return i;
        }

        #endregion

        #region ItemReturn
        public int ItemReturn(int itemissueqnt, int userid, int ItemId, string ItemType, int Jobid)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("Sp_ItemReturn", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ItemReturnQnty", itemissueqnt);
                cmd.Parameters.AddWithValue("@ItemId", ItemId);
                cmd.Parameters.AddWithValue("@UserId", userid);
                cmd.Parameters.AddWithValue("@ItemType", ItemType);
                cmd.Parameters.AddWithValue("@JobId", Jobid);
                //  SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return i;
        }

        #endregion

        #region InsertSupplier
        public int InsertSupplier(AddSupplierBo objbo, int UserId)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@SupplierName", objbo.Name);
                cmd.Parameters.AddWithValue("@Address", objbo.Address);
                cmd.Parameters.AddWithValue("@Phone", objbo.Phone);
                cmd.Parameters.AddWithValue("@UserName", objbo.Fax);
                cmd.Parameters.AddWithValue("@Contact", objbo.Contranct);
                cmd.Parameters.AddWithValue("@Note", objbo.Note);
                cmd.Parameters.AddWithValue("@UserId", UserId);

                //  SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
                // ex.Message("Error While Saving THe Data");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        #endregion

        #region TransactionInfo
        public DataSet TransactionInfo(int ItemId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_TransactionInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemId", ItemId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region IssuedDetails
        public DataSet IssuedDetails(int userId, int IsAdmin)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Sp_ItemisssuedDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                cmd.Parameters.AddWithValue("@ItemCode", "");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region ReturnItemDetails
        public DataSet ReturnItemDetails(int userId, int IsAdmin)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Sp_ReturnItemdDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion
        #region ReturnIteminfoDetails
        public DataSet ReturnIteminfoDetails(int userId, int IsAdmin,string Itemcode)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Sp_ReturnItemdInfoDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", Itemcode);
                //cmd.Parameters.AddWithValue("@UserId", userId);
                // cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region DletedDetails
        public DataSet DletedDetails(string ItemCode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_DeleteItemInfo", con);
                cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
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
                SqlCommand cmd = new SqlCommand("Sp_ItemInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Itemcode", itemId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }

        #endregion

        #region BindProcesslog
        public DataSet BindProcesslog(int logid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ProcesslogInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@logid", logid);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }

        #endregion

        #region systemusers
        public DataSet systemusersInfo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_SystemUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region UsersPrivilige
        public DataSet UsersPriviligeInfo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_UsersPrivilige", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion
        #region SuplierInfo
        public DataSet SuplierInfo()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Suplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region Createjob
        public int Createjob(string jobname, string jobDesc, int userid)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_CreateJob", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobName", jobname);
                cmd.Parameters.AddWithValue("@JobDescription", jobDesc);
                cmd.Parameters.AddWithValue("@Createduserid", userid);
                con.Open();
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region BindJobInfo
        public DataTable BindJobInfo(int Userid, int jobid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_JobInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Jobid", jobid);
                cmd.Parameters.AddWithValue("@Userid", Userid);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }

        #endregion

        public int InsertUserAccountDetails(UserAccountBo objUserAccount)
        {
            int i = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", objUserAccount.FirstName);
                cmd.Parameters.AddWithValue("@LastName", objUserAccount.LastName);
                cmd.Parameters.AddWithValue("@EmailID ", objUserAccount.Email);
                cmd.Parameters.AddWithValue("@Password", objUserAccount.Password);
                cmd.Parameters.AddWithValue("@Company ", objUserAccount.Company);
                cmd.Parameters.AddWithValue("@Phone", objUserAccount.Phone);
                cmd.Parameters.AddWithValue("@Mobile", objUserAccount.Mobile);
                cmd.Parameters.AddWithValue("@UserName", objUserAccount.UserName);
                cmd.Parameters.AddWithValue("@JobTittle", objUserAccount.JobTittle);
                cmd.Parameters.AddWithValue("@DepartMent", objUserAccount.DepartMent);
                cmd.Parameters.AddWithValue("@Address", objUserAccount.Address);
                cmd.Parameters.AddWithValue("@Town", objUserAccount.Town);
                cmd.Parameters.AddWithValue("@State", objUserAccount.State);
                cmd.Parameters.AddWithValue("@PostalCode ", objUserAccount.PostalCode);
                cmd.Parameters.AddWithValue("@Country ", objUserAccount.Country);
                cmd.Parameters.AddWithValue("@Notes ", objUserAccount.Notes);
                cmd.Parameters.AddWithValue("@IsAdmin ", objUserAccount.IsAdmin);
                cmd.Parameters.AddWithValue("@AccessLevel ", objUserAccount.AccessLevel);

                cmd.Parameters.AddWithValue("@AllowGeneral", objUserAccount.AllowGeneral);
                cmd.Parameters.AddWithValue("@AllowItemMnagement", objUserAccount.AllowItemMnagement);
                cmd.Parameters.AddWithValue("@AllowInventory", objUserAccount.AllowInventory);
                cmd.Parameters.AddWithValue("@AllowJobs", objUserAccount.AllowJobs);
                cmd.Parameters.AddWithValue("@AllowReports", objUserAccount.AllowReports);
                cmd.Parameters.AddWithValue("@AllowSupplier", objUserAccount.AllowSupplier);
                cmd.Parameters.AddWithValue("@AllowConfiguration", objUserAccount.AllowConfiguration);
               // cmd.Parameters["@ReturnUserId"].Direction = ParameterDirection.Output;

                con.Open();
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception )
            {
                throw;
                // ex.Message("Error While Saving THe Data");
            }
            finally
            {
                con.Close();
            }
        }
        public int UpdateUserAccountDetails(UserAccountBo objUserAccount,int UserID)
        {
            int i = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateUsers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", objUserAccount.FirstName);
                cmd.Parameters.AddWithValue("@LastName", objUserAccount.LastName);
                cmd.Parameters.AddWithValue("@EmailID ", objUserAccount.Email);
                cmd.Parameters.AddWithValue("@Password", objUserAccount.Password);
                cmd.Parameters.AddWithValue("@Company ", objUserAccount.Company);
                cmd.Parameters.AddWithValue("@Phone", objUserAccount.Phone);
                cmd.Parameters.AddWithValue("@Mobile", objUserAccount.Mobile);
                cmd.Parameters.AddWithValue("@UserName", objUserAccount.UserName);
                cmd.Parameters.AddWithValue("@JobTittle", objUserAccount.JobTittle);
                cmd.Parameters.AddWithValue("@DepartMent", objUserAccount.DepartMent);
                cmd.Parameters.AddWithValue("@Address", objUserAccount.Address);
                cmd.Parameters.AddWithValue("@Town", objUserAccount.Town);
                cmd.Parameters.AddWithValue("@State", objUserAccount.State);
                cmd.Parameters.AddWithValue("@PostalCode ", objUserAccount.PostalCode);
                cmd.Parameters.AddWithValue("@Country ", objUserAccount.Country);
                cmd.Parameters.AddWithValue("@Notes ", objUserAccount.Notes);
                cmd.Parameters.AddWithValue("@IsAdmin ", objUserAccount.IsAdmin);
                cmd.Parameters.AddWithValue("@AccessLevel ", objUserAccount.AccessLevel);
                cmd.Parameters.AddWithValue("@UserId ", UserID);

                cmd.Parameters.AddWithValue("@AllowGeneral", objUserAccount.AllowGeneral);
                cmd.Parameters.AddWithValue("@AllowItemMnagement", objUserAccount.AllowItemMnagement);
                cmd.Parameters.AddWithValue("@AllowInventory", objUserAccount.AllowInventory);
                cmd.Parameters.AddWithValue("@AllowJobs", objUserAccount.AllowJobs);
                cmd.Parameters.AddWithValue("@AllowReports", objUserAccount.AllowReports);
                cmd.Parameters.AddWithValue("@AllowSupplier", objUserAccount.AllowSupplier);
                cmd.Parameters.AddWithValue("@AllowConfiguration", objUserAccount.AllowConfiguration);
                con.Open();
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception )
            {
                throw;
                // ex.Message("Error While Saving THe Data");
            }
            finally
            {
                con.Close();
            }
        }

        public int AddSupplierDetails(SupplierDetails objSupplierDetails)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("sp_CreateSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SupplierName", objSupplierDetails.SupplierName);
               // cmd.Parameters.AddWithValue("@MiddleName", objSupplierDetails.MiddleName);
               // cmd.Parameters.AddWithValue("@LastName ", objSupplierDetails.LastName);
                cmd.Parameters.AddWithValue("@Company", objSupplierDetails.Company);
                cmd.Parameters.AddWithValue("@DisplayName ", objSupplierDetails.Displayname);
                cmd.Parameters.AddWithValue("@Mobile", objSupplierDetails.Mobile);
                cmd.Parameters.AddWithValue("@Email", objSupplierDetails.Email);
                cmd.Parameters.AddWithValue("@Address", objSupplierDetails.Address);
                cmd.Parameters.AddWithValue("@Phone", objSupplierDetails.Phone);
                cmd.Parameters.AddWithValue("@Fax", objSupplierDetails.Fax);
                cmd.Parameters.AddWithValue("@AccountNo", objSupplierDetails.AccountNo);
                cmd.Parameters.AddWithValue("@PanNumber", objSupplierDetails.PanNumber);
                cmd.Parameters.AddWithValue("@TaxRegistarNo", objSupplierDetails.TaxRegistrationNo);
                cmd.Parameters.AddWithValue("@SupplierCode", objSupplierDetails.SupplierCode);
                cmd.Parameters.AddWithValue("@City", objSupplierDetails.City);
                cmd.Parameters.AddWithValue("@State", objSupplierDetails.State);
                cmd.Parameters.AddWithValue("@Country", objSupplierDetails.Country);
                cmd.Parameters.AddWithValue("@PoastalCode", objSupplierDetails.PostalCode);
                cmd.Parameters.AddWithValue("@Notes", objSupplierDetails.Notes);
                cmd.Parameters.AddWithValue("@UserId", objSupplierDetails.UserId);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
                // ex.Message("Error While Saving THe Data");
            }
            finally
            {
                con.Close();
            }
            return i;
        }

        public DataTable SelectUsers(UserAccountBo objUserAccount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[Sp_SelectUsers]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IsAdmin", objUserAccount.IsAdmin);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
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
                SqlCommand cmd = new SqlCommand("[Sp_GetLocations]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }

        public int CheckRegisteredEmail(string email)
        {
            int i = 0;
            string query = string.Empty;
            try
            {
                con.Open();
                query = "SELECT count(UserName) as result FROM tblUsers Where  UserName='" + email + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int result = (int)cmd.ExecuteScalar();
                if (result == 0)
                {
                    i = 0;
                }
                else
                {
                    i = 1;
                }
                return i;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        #region BindUsers
        public DataSet BindUsers(int Uid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_SystemUsers", con);
                cmd.Parameters.AddWithValue("@uid", Uid);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region InsertOrUpdateItemFromExcel
        public int InsertOrUpdateItemFromExcel(AddItemBo objbo)
        {
            //  SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Connection"].ToString());
            SqlCommand cmd = null;
            try
            {

                cmd = new SqlCommand("sp_InsertOrUpdateItemFromExcel", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", objbo.TypeOfmethod);
                //   cmd.Parameters.AddWithValue("@Location", objbo.Location);
                cmd.Parameters.AddWithValue("@ItemCode", objbo.ItemCode);
                cmd.Parameters.AddWithValue("@ItemDesc", objbo.ItemDesc);
                cmd.Parameters.AddWithValue("@Barcode", objbo.BarCode);
                cmd.Parameters.AddWithValue("@Group", objbo.ItemGroup);
                cmd.Parameters.AddWithValue("@SubGroup", objbo.ItemCateGory);
                cmd.Parameters.AddWithValue("@Supplier", objbo.Supplier);
                cmd.Parameters.AddWithValue("@Quantity", objbo.Quantity);
                cmd.Parameters.AddWithValue("@Accesslevel", objbo.Accesslevel);
                cmd.Parameters.AddWithValue("@MOQ", objbo.MOQ);
                cmd.Parameters.AddWithValue("@UserId", objbo.UserId);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
        }
        //  public bool CheckDataHavingIntblItemInfoOrNot(string columnName, string value)
        #endregion


        public bool CheckDataHavingInDataTableOrNot(string columnName, string value)
        {
            //SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Connection"].ToString());
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("Sp_CheckDataHavingInDataTableOrNot", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ColumnName", columnName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bool checkresult = dt.AsEnumerable().Any(row1 => value.ToUpper() == row1.Field<String>(columnName).ToUpper());
                return checkresult;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public bool CheckItemSubGroup(string columnName, string checkItemcategory, string value)
        {
            // SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Connection"].ToString());
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand(" select itemgroup from tblItemGroup where ItemCategoryId in (select ItemCategoryId from tblItemCategory where ItemCategory='" + checkItemcategory + "' )", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@ColumnName", columnName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bool checkresult = dt.AsEnumerable().Any(row1 => value.ToUpper() == row1.Field<String>(columnName).ToUpper());
                return checkresult;
            }
            catch (Exception )
            {

                throw;
            }
            finally
            {
                cmd.Dispose();
            }
        }

        public bool ItemCodeContains(string columnName, string value)
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("Sp_ItemCodeContains", con);
                // cmd.CommandType = CommandType.StoredProcedure;               
                //cmd.Parameters.AddWithValue("@ColumnName", columnName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                bool checkresult = dt.AsEnumerable().Any(row1 => value.ToUpper() == row1.Field<String>(columnName).ToUpper());
                return checkresult;

            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                cmd.Dispose();

            }
        }

        int itemCategoryId = 0;
        public int GetCategoryId(string itemCategory)
        {
            SqlCommand cmd = null;
            try
            {
                cmd = new SqlCommand("Select ItemCategoryId,ItemCategory from tblItemCategory where ItemCategory ='" + itemCategory + "'", con);
                //cmd.CommandType = CommandType.StoredProcedure;               
                // cmd.Parameters.AddWithValue("@ItemCategory", ItemCategory);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                itemCategoryId = (Convert.ToInt32(dt.Rows[0]["ItemCategoryId"]));
            }
            catch (Exception )
            {
                throw;
            }
            return itemCategoryId;

        }


        #region AdvancedSearch
        public DataSet ItemInfo(ItemSearch objboItemSearch,int UserId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_AdvancedSearchItemInfo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Itemcode", objboItemSearch.ItemCode);
                cmd.Parameters.AddWithValue("@ItemGroup", objboItemSearch.ItemGroup);
                cmd.Parameters.AddWithValue("@ItemSubGroup", objboItemSearch.ItemSubGroup);
                cmd.Parameters.AddWithValue("@ItemSupplier", objboItemSearch.ItemSupplier);
                cmd.Parameters.AddWithValue("@QuantityType", objboItemSearch.QuantityType);
                cmd.Parameters.AddWithValue("@ItemQuanity", objboItemSearch.ItemQuanity);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                da.Fill(ds);
                return ds;
            }
            catch (Exception )
            {
                throw;
            }
        }

        public DataTable BindSubGroup()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select ItemCategoryId,ItemCategory from tblItemCategory", con);
                // cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion

        #region    BindAccessLevel
        public DataTable BindAccessLevel()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[Sp_BindAccessLevel]", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion
        #region    BindAccessLevel
        public int CheckItemCodeExit(string ItemCode)
        {
            int itemcodeCount = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_CheckItemCodeExit", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                con.Open();
                itemcodeCount = Convert.ToInt32(cmd.ExecuteScalar());
                return itemcodeCount;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region Delete Supplier
        public bool DeleteSupplier(int Supplierid,int Userid)
        {
            bool IsDelete = false;
            int del = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_DeleteSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SupplierId", Supplierid);
                cmd.Parameters.AddWithValue("@UserId", Userid);
                con.Open();
                del = cmd.ExecuteNonQuery();
                if (del > 0)
                {
                    IsDelete = true;
                }

                return IsDelete;
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
        #region UpdateSupplierDetails
         public int UpdateSupplierDetails(SupplierDetails objSupplierDetails)
        {
            int i = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateSupplier", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SupplierName", objSupplierDetails.SupplierName);
               // cmd.Parameters.AddWithValue("@MiddleName", objSupplierDetails.MiddleName);
               // cmd.Parameters.AddWithValue("@LastName ", objSupplierDetails.LastName);
                cmd.Parameters.AddWithValue("@Company", objSupplierDetails.Company);
                cmd.Parameters.AddWithValue("@DisplayName ", objSupplierDetails.Displayname);
                cmd.Parameters.AddWithValue("@Mobile", objSupplierDetails.Mobile);
                cmd.Parameters.AddWithValue("@Email", objSupplierDetails.Email);
                cmd.Parameters.AddWithValue("@Address", objSupplierDetails.Address);
                cmd.Parameters.AddWithValue("@Phone", objSupplierDetails.Phone);
                cmd.Parameters.AddWithValue("@Fax", objSupplierDetails.Fax);
                cmd.Parameters.AddWithValue("@AccountNo", objSupplierDetails.AccountNo);
                cmd.Parameters.AddWithValue("@PanNumber", objSupplierDetails.PanNumber);
                cmd.Parameters.AddWithValue("@TaxRegistarNo", objSupplierDetails.TaxRegistrationNo);
                cmd.Parameters.AddWithValue("@SupplierCode", objSupplierDetails.SupplierCode);
                cmd.Parameters.AddWithValue("@City", objSupplierDetails.City);
                cmd.Parameters.AddWithValue("@State", objSupplierDetails.State);
                cmd.Parameters.AddWithValue("@Country", objSupplierDetails.Country);
                cmd.Parameters.AddWithValue("@PostalCode", objSupplierDetails.PostalCode);
                cmd.Parameters.AddWithValue("@Notes", objSupplierDetails.Notes);
                cmd.Parameters.AddWithValue("@UserId", objSupplierDetails.UserId);
                cmd.Parameters.AddWithValue("@SupplierId", objSupplierDetails.SupplierID);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
                // ex.Message("Error While Saving THe Data");
            }
            finally
            {
                con.Close();
            }
            return i;
        }
        #endregion
        #region GetSupplierDetails
         public DataTable GetSupplierDetails(int SupplierId)
         {
             try
             {
                 DataTable dt = new DataTable();

                 SqlCommand cmd = new SqlCommand("Sp_GetSuplier", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@SupplierId", SupplierId);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 da.Fill(dt);
                 return dt;
             }
             catch (Exception )
             {
                 throw;
             }
         }

        #endregion
        #region Checking data
         public bool Checkingdata(string ItemName,string Value)
         {
             bool Isvalid = false;
             try
             {
                 int count = 0;
                 SqlCommand cmd = new SqlCommand("[Sp_CheckItem]", con);
                 cmd.Parameters.AddWithValue("@ItemName", ItemName);
                 cmd.Parameters.AddWithValue("@Value", Value);
                 cmd.CommandType = CommandType.StoredProcedure;
                 con.Open();
                 count = int.Parse(cmd.ExecuteScalar().ToString());
                 //SqlDataAdapter da = new SqlDataAdapter(cmd);
                 //DataTable dt = new DataTable();
                 //da.Fill(dt);
                 if (count > 0)
                 {

                     Isvalid = true;
                 }

                 return Isvalid;
             }
             catch (Exception)
             {

                 throw;
             }
             finally
             {
                 con.Close();
             }
         }
        #endregion
        #region    BindSupplierList
        public DataTable BindSupplierList(string Companycode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BindSupplierList", con);
                cmd.Parameters.AddWithValue("@Company", Companycode);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion
        #region    BindUserList
        public DataTable BindUserList(string UserName, string Search)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_UsersList", con);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Search", Search);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion
        #region InsertDepartment

        public int InsertDepartment(string deport)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("[Sp_InsertDepartment]", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Department", deport);
                con.Open();
                i = cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                throw;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
            return i;

        }

        #endregion
        #region BindDepartment
        public DataTable BindDepartment()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_BindDepartment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion
        #region Checkingdepartment
        public bool Checkingdepartment(string Department)
        {
            bool Isvalid = false;
            try
            {
                SqlCommand cmd = new SqlCommand("[Sp_CheckDepartment]", con);
                cmd.Parameters.AddWithValue("@Department", Department);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Isvalid = true;
                }

                return Isvalid;
            }
            catch (Exception )
            {

                throw;
            }
        }
        #endregion
        #region BindIssuedItemsReport
        public DataTable BindIssuedItemsReport(string FromDate,string Todate,int IsAdmin,int UserId)  
        {
            try
            {
                //DateTime dtFrom = Convert.ToDateTime(FromDate);
                //DateTime dtTo = Convert.ToDateTime(Todate);
                SqlCommand cmd = new SqlCommand("Sp_ItemisssuedDetailsReport", con);
                cmd.Parameters.AddWithValue("@FromDate", FromDate);
                cmd.Parameters.AddWithValue("@ToDate", Todate);
                cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                cmd.Parameters.AddWithValue("@UserId", UserId);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception )
            {
                throw;
            }
        }
        #endregion
        public DataTable MoQNotificationDetails()
         {
             try
             {
                 SqlCommand cmd = new SqlCommand("Select ItemCode,Quantity,MOQ from tblIteminfo where Quantity > MOQ", con);
                 // cmd.CommandType = CommandType.StoredProcedure;
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
             catch (Exception )
             {

                 throw;
             }

         }
        public DataTable BindIssueKit(StringBuilder sb)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand("sp_BindIssueKit", con);
                 cmd.Parameters.AddWithValue("@ItemIds", sb.ToString());
                 cmd.CommandType = CommandType.StoredProcedure;
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
             catch (Exception )
             {
                 throw;
             }
         }
        #region BindCurrentStock
         public DataSet BindCurrentStock(string itemCode) 
         {
             try
             {
                 SqlCommand cmd = new SqlCommand("Rpt_BindCurrentStock", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@ItemCode", itemCode);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataSet ds = new DataSet();
                 da.Fill(ds);
                 return ds;
             }
             catch (Exception )
             {
                 throw;
             }
         }
         #endregion
        #region BindShortageReport
         public DataTable BindShortageReport(string ItemCode) 
         {
             try
             {
                 SqlCommand cmd = new SqlCommand("Rpt_BindShortageReport", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
             catch (Exception )
             {
                 throw;
             }
         }
         #endregion
        #region BindSockReportbyBin
         public DataTable BindSockReportbyBin(string BinCode,int DrawerId)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand("Rpt_StockbyBin", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@BinCode", BinCode);
                 cmd.Parameters.AddWithValue("@DrawerId", DrawerId);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 DataTable dt = new DataTable();
                 da.Fill(dt);
                 return dt;
             }
             catch (Exception )
             {
                 throw;
             }
         }
         #endregion
        #region Create login history
         public int InsertLogid(int Userid,int LoginTypeId,string IPAddress)
         {
             try
             {
                 int LogId = 0;
                 SqlCommand cmd = new SqlCommand("Sp_InsertLogid", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@Userid", Userid);
                 cmd.Parameters.AddWithValue("@LoginTypeId", LoginTypeId);
                 cmd.Parameters.AddWithValue("@IPAddress", IPAddress);
                 cmd.Parameters.AddWithValue("@SpType", "insert");
                 cmd.Parameters.AddWithValue("@UpdateLogId", 0);
                 con.Open();
                 LogId = Convert.ToInt32(cmd.ExecuteScalar());
                 return LogId;
             }
             catch (Exception )
             {
                 throw;
             }
             finally
             {                
                 con.Close();
             }
         }
         #endregion
        #region Update login ID
         public void UpdateLogid(int LoginIg)
         {
             try
             {
                 int LogId = 0;
                 SqlCommand cmd = new SqlCommand("Sp_InsertLogid", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@Userid", 0);
                 cmd.Parameters.AddWithValue("@LoginTypeId", 0);
                 cmd.Parameters.AddWithValue("@IPAddress", "");
                 cmd.Parameters.AddWithValue("@SpType", "Update");
                 cmd.Parameters.AddWithValue("@UpdateLogId", LoginIg);
                 con.Open();
                 LogId = Convert.ToInt32(cmd.ExecuteScalar());
             }
             catch (Exception )
             {
                 throw;
             }
             finally
             {
                 con.Close();
             }
         }
         #endregion
         #region Bind login History
         public DataTable BindLoginHistory(string UserName)
         {
             try
             {
                 DataTable dt = new DataTable();
                 SqlCommand cmd = new SqlCommand("Sp_BindLoginHistory", con);
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.AddWithValue("@UserName", UserName);
                 SqlDataAdapter da = new SqlDataAdapter(cmd);
                 da.Fill(dt);       
               return dt;
             }
             catch (Exception )
             {
                 throw;
             }
             finally
             {
                 con.Close();
             }
         }
         #endregion
    }
}
