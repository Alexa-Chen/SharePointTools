using System.Collections.Generic;

namespace SharePointTools.Tools
{
    public class DicOfName
    {
        private static Dictionary<string, string> dictionarys = new Dictionary<string, string>();
        public static Dictionary<string, string> GetDictionarys()
        {
            if (dictionarys.Count > 0) return dictionarys;
            if (dictionarys != null)
            {
                dictionarys.Add(Constant.NO, "Title");
                dictionarys.Add(Constant.ID, "_x5458__x5de5_ID");
                dictionarys.Add(Constant.Name, "_x59d3__x540d_");
                dictionarys.Add(Constant.Sex, "_x6027__x522b_");
                dictionarys.Add(Constant.EnglishName, "_x82f1__x6587__x540d_");
                dictionarys.Add(Constant.LoginDomainName, "_x767b__x9646__x57df__x540d_");
                dictionarys.Add(Constant.SkypeID, "Skype_x0020_ID");
                dictionarys.Add(Constant.LyncID, "Lync_x0020_ID");
                dictionarys.Add(Constant.Office, "Office");
                dictionarys.Add(Constant.Department, "_x90e8__x95e8_");
                dictionarys.Add(Constant.Band, "Band");
                dictionarys.Add(Constant.Province, "_x7701_");
                dictionarys.Add(Constant.PostCode, "_x90ae__x7f16_");
                dictionarys.Add(Constant.EducationBackgroud, "_x5b66__x5386_");
                dictionarys.Add(Constant.Position, "_x804c__x4f4d_");
                dictionarys.Add(Constant.DirectLeader, "_x76f4__x5c5e__x9886__x5bfc_");
                dictionarys.Add(Constant.ArrivalDate, "_x5230__x5c97__x65e5__x671f_");
                dictionarys.Add(Constant.LaborContractStartDate, "_x52b3__x52a8__x5408__x540c__x8d");
                dictionarys.Add(Constant.ConversionDate, "_x8f6c__x6b63__x65e5__x671f_");
                dictionarys.Add(Constant.LaborContractEndDate, "_x52b3__x52a8__x5408__x540c__x7e");
                dictionarys.Add(Constant.LaborContractUtilDate, "_x52b3__x52a8__x5408__x7eed__x7b");
                dictionarys.Add(Constant.Birthday, "_x751f__x65e5_");
                dictionarys.Add(Constant.IsIntern, "_x662f__x5426__x4e3a__x5b9e__x4e");
                dictionarys.Add(Constant.GraduateSchool, "_x6bd5__x4e1a__x5b66__x6821_");
                dictionarys.Add(Constant.GraduateTime, "_x6bd5__x4e1a__x65f6__x95f4_");
                dictionarys.Add(Constant.HouseAddress, "_x5bb6__x5ead__x5730__x5740_");
                dictionarys.Add(Constant.Mobile, "_x79fb__x52a8__x7535__x8bdd_");
                dictionarys.Add(Constant.IsLeave, "_x662f__x5426__x79bb__x804c_");
                dictionarys.Add(Constant.LeaveDate, "_x79bb__x804c__x65e5__x671f_");
                dictionarys.Add(Constant.EditInHRIS, "Edit_x0020_In_x0020_HRIS");
                dictionarys.Add(Constant.IDNumber, "ID_x0020_Number");              
            }
            return dictionarys;
        }
    }
}
