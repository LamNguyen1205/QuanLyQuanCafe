using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInforDAO
    {
        private static BillInforDAO instance;

        public static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO(); return BillInforDAO.instance;  }
            private set { BillInforDAO.instance = value; }
        }
        private BillInforDAO() { }

        public List<BillInfor> GetListBillInfo(int id)
        {
            List<BillInfor> listBillInfo = new List<BillInfor>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfor info = new BillInfor(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
        
    }
}
