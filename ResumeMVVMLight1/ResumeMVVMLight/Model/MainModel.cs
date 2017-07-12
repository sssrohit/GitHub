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

    public class Resume
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String experience;
        public String Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        private String skills;
        public String Skills
        {
            get { return skills; }
            set { skills = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string summary;
        public string Summary
        {
            get { return summary; }
            set { summary = value; }
        }

        private string education;
        public string Education
        {
            get { return education; }
            set { education = value; }
        }

        private string interests;
        public string Interests
        {
            get { return interests; }
            set { interests = value; }
        }

        private string languages;
        public string Languages
        {
            get { return languages; }
            set { languages = value; }
        }
    }

}
