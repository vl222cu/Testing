using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SendButton_Click(object sender, EventArgs e)
        {
            var birthdate = DateTime.Parse(Birthdate.Text);
            var nextBirthday = new DateTime(DateTime.Today.Year, birthdate.Month, birthdate.Day);
            if (nextBirthday < DateTime.Today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            DayOfWeekLabel.Text = nextBirthday.ToString("dddd");
            DaysUntilBirthdayLabel.Text = (nextBirthday - DateTime.Today).Days.ToString();
            AgeOnLabel.Text = (nextBirthday.Year - birthdate.Year).ToString();
            OutputPlaceHolder.Visible = true;
        }
    }
}