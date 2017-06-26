using sqlCandidate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace sqlCandidate
{
    class Accessor
    {
        public static System.Data.Linq.Table<CandidateTable> GetEmployeeTable()
        {
            CandidateDbaseContext dc = new CandidateDbaseContext(Properties.Settings.Default.DatabasePath);
            return dc.GetTable<CandidateTable>();
        }

        public static void InsertOrUpdateEmp(string date, string Name, string position, string worklocation, string currentlocation, string contactno, string emailid, string qualification, string topexp,
            string relevantexp, string currentcompany, string currentctc, string expectedctc, string noticeperiod)
        {

            CandidateDbaseContext dc = new CandidateDbaseContext(Properties.Settings.Default.DatabasePath);


            try
            {

                Table<CandidateTable> employee = Accessor.GetEmployeeTable();
                
                CandidateTable emp = new CandidateTable();

                emp.Date_Candidate = date;
                emp.Name_Candidate = Name;
                emp.Position_Candidate = position;
                emp.WorkLocation_Candidate = worklocation;
                emp.CurrentLocation_Candidate = currentlocation;
                emp.ContactNo_Candidate = contactno;
                emp.EmailId_Candidate = emailid;
                emp.Qualification_Candidate = qualification;
                emp.TopExp_Candidate = topexp;
                emp.RelevantExp_Candidate = relevantexp;
                emp.CurrentCompany_Candidate = currentcompany;
                emp.CurrentCTC_Candidate = currentctc;
                emp.ExpectedCTC_Candidate = expectedctc;
                emp.NoticePeriod_Candidate = noticeperiod;

                employee.InsertOnSubmit(emp);
                
                employee.Context.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteEmp(string EmpName)
        {
            CandidateDbaseContext dc = new CandidateDbaseContext(Properties.Settings.Default.DatabasePath);

            var matchedEmp = (from c in dc.GetTable<CandidateTable>()
                              where c.Name_Candidate == EmpName
                              select c).FirstOrDefault();

            try
            {
                dc.CandidateTable.DeleteOnSubmit(matchedEmp);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public static void UpdateEmp(string date, string Name, string position, string worklocation, string currentlocation, string contactno, string emailid, string qualification, string topexp,
            string relevantexp, string currentcompany, string currentctc, string expectedctc, string noticeperiod)
        {
            CandidateDbaseContext dc = new CandidateDbaseContext(Properties.Settings.Default.DatabasePath);

            var matchedEmp = (from c in dc.GetTable<CandidateTable>()
                              where c.Name_Candidate == Name
                              select c).FirstOrDefault();

            try
            {
                Table<CandidateTable> employee = Accessor.GetEmployeeTable();
                //CandidateTable emp = new CandidateTable();

                matchedEmp.Date_Candidate = date;
                matchedEmp.Name_Candidate = Name;
                matchedEmp.Position_Candidate = position;
                matchedEmp.WorkLocation_Candidate = worklocation;
                matchedEmp.CurrentLocation_Candidate = currentlocation;
                matchedEmp.ContactNo_Candidate = contactno;
                matchedEmp.EmailId_Candidate = emailid;
                matchedEmp.Qualification_Candidate = qualification;
                matchedEmp.TopExp_Candidate = topexp;
                matchedEmp.RelevantExp_Candidate = relevantexp;
                matchedEmp.CurrentCompany_Candidate = currentcompany;
                matchedEmp.CurrentCTC_Candidate = currentctc;
                matchedEmp.ExpectedCTC_Candidate = expectedctc;
                matchedEmp.NoticePeriod_Candidate = noticeperiod;
                
                //employee.InsertOnSubmit(emp);
                dc.SubmitChanges();
                employee.Context.SubmitChanges();
                //dc.CandidateTable.InsertOnSubmit (matchedEmp);
                //dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
