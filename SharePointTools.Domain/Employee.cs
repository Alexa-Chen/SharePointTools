using System.Text;
using SharePointTools.Utility;

namespace SharePointTools.Domain
{
    public class Employee
    {
        public string NO { get; set; }
        public string MinPicture { get; set; }//图片流文件
        public string MediumPicture { get; set; }
        public string MaxPicture { get; set; }
        public string MinPicturePath { get; set; }//图片路径
        public string MediumPicturePath { get; set; }
        public string MaxPicturePath { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string EnglishName { get; set; }
        public string LoginDomainName { get; set; }
        public string SkypeId { get; set; }
        public string LyncId { get; set; }
        public string Office { get; set; }
        public string Department { get; set; }
        public string Band { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public string EducationBackgroud { get; set; }//学历
        public string Position { get; set; }
        public string DirectLeader { get; set; }
        public string ArrivalDate { get; set; }//到岗日期
        public string LaborContractStartDate { get; set; }//劳动合同起始日
        public string ConversionDate { get; set; }//转正日期
        public string LaborContractEndDate { get; set; } //劳动合同终止日
        public string LaborContractUtilDate { get; set; }//劳动合续签至
        public string Birthday { get; set; }
        public string IsIntern { get; set; }
        public string GraduateSchool { get; set; }
        public string GraduateTime { get; set; }
        public string HouseAddress { get; set; }
        public string Mobile { get; set; }
        public string IsLeave { get; set; }
        public string LeaveDate { get; set; }
        public string EditInHRIS { get; set; }
        public string IDNumber { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(Constant.NO + ":" + this.NO + "\n");
            stringBuilder.Append(Constant.Picture + ":" + this.MediumPicture + "\n");
            stringBuilder.Append(Constant.ID + ":" + this.ID + "\n");
            stringBuilder.Append(Constant.Name + ":" + this.Name + "\n");
            stringBuilder.Append(Constant.Sex + ":" + this.Sex + "\n");
            stringBuilder.Append(Constant.EnglishName + ":" + this.EnglishName + "\n");
            stringBuilder.Append(Constant.LoginDomainName + ":" + this.LoginDomainName + "\n");
            stringBuilder.Append(Constant.SkypeID + ":" + this.SkypeId + "\n");
            stringBuilder.Append(Constant.LyncID + ":" + this.LyncId + "\n");
            stringBuilder.Append(Constant.Office + ":" + this.Office + "\n");
            stringBuilder.Append(Constant.Department + ":" + this.Department + "\n");
            stringBuilder.Append(Constant.Province + ":" + this.Province + "\n");
            stringBuilder.Append(Constant.PostCode + ":" + this.PostCode + "\n");
            stringBuilder.Append(Constant.EducationBackgroud + ":" + this.EducationBackgroud + "\n");
            stringBuilder.Append(Constant.Position + ":" + this.Position + "\n");
            stringBuilder.Append(Constant.DirectLeader + ":" + this.DirectLeader + "\n");
            stringBuilder.Append(Constant.ArrivalDate + ":" + this.ArrivalDate+ "\n");
            stringBuilder.Append(Constant.LaborContractStartDate + ":" + this.LaborContractStartDate + "\n");
            stringBuilder.Append(Constant.ConversionDate + ":" + this.ConversionDate + "\n");
            stringBuilder.Append(Constant.LaborContractEndDate + ":" + this.LaborContractEndDate + "\n");
            stringBuilder.Append(Constant.LaborContractUtilDate + ":" + this.LaborContractUtilDate + "\n");
            stringBuilder.Append(Constant.Birthday + ":" + this.Birthday + "\n");
            stringBuilder.Append(Constant.IsIntern + ":" + this.IsIntern + "\n");
            stringBuilder.Append(Constant.GraduateSchool + ":" + this.GraduateSchool + "\n");
            stringBuilder.Append(Constant.GraduateTime + ":" + this.GraduateTime + "\n");
            stringBuilder.Append(Constant.HouseAddress + ":" + this.HouseAddress + "\n");
            stringBuilder.Append(Constant.Mobile + ":" + this.Mobile + "\n");
            stringBuilder.Append(Constant.IsLeave + ":" + this.IsLeave + "\n");
            stringBuilder.Append(Constant.LeaveDate + ":" + this.LeaveDate + "\n");
            stringBuilder.Append(Constant.EditInHRIS + ":" + this.EditInHRIS + "\n");
            stringBuilder.Append(Constant.IDNumber + ":" + this.IDNumber + "\n");
            return stringBuilder.ToString();
        }
    }
}
