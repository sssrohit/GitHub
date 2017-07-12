using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeMVVMLight.Model
{
    class MainModel
    {
        public static List<Resume> GetAllResumes()
        {
            ResumeDataBaseContext dc = new ResumeDataBaseContext(Properties.Settings.Default.ResumeDBpath);
            List<Resume> resumes = new List<Resume>();
            foreach (var res in dc.ResumeTable)
            {
                Resume tRes = new Resume()
                {
                    Name = res.Name,
                    Skills = res.Skills,
                    Experience = res.Experience,
                    Email = res.Email,
                    Education = res.Education,
                    Interests = res.Interests,
                    Languages = res.Languages,
                    Phone = res.Phone,
                    Summary = res.Summary
                };
                resumes.Add(tRes);
            }
            return resumes;
        }
    }
}
