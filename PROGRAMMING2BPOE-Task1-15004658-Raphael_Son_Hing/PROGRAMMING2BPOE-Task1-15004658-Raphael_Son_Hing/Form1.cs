using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMMING2BPOE_Task1_15004658_Raphael_Son_Hing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intWeeksLeft;

        String strCodeM1, strNameM1;
        String strCodeM2, strNameM2;
        String strCodeM3, strNameM3;
        String strCodeM4, strNameM4;
        String strCodeM5, strNameM5;

        int intCreditsM1, intHoursM1, intSumM1;
        int intCreditsM2, intHoursM2, intSumM2;
        int intCreditsM3, intHoursM3, intSumM3;
        int intCreditsM4, intHoursM4, intSumM4;
        int intCreditsM5, intHoursM5, intSumM5;

        String ActivateT1 = "N";
        String ActivateT2 = "N";
        String ActivateT3 = "N";
        String ActivateT4 = "N";
        String ActivateT5 = "N";

        private void btnReset_Click(object sender, EventArgs e)
        {
            ActivateT1 = "N";
            ActivateT2 = "N";
            ActivateT3 = "N";
            ActivateT4 = "N";
            ActivateT5 = "N";
            this.lblDisplay.Text = "";
            this.txtCodeM1.Text = "";
            this.txtNameM1.Text = "";
            this.numCreditsM1.Value = 0;
            this.numHoursM1.Value = 0;
            this.numHoursDoneM1H1.Value = 0;
            this.numHoursDoneM1H2.Value = 0;
            this.numHoursDoneM1H3.Value = 0;
            this.numHoursDoneM1H4.Value = 0;
            this.txtCodeM2.Text = "";
            this.txtNameM2.Text = "";
            this.numCreditsM2.Value = 0;
            this.numHoursM2.Value = 0;
            this.numHoursDoneM2H1.Value = 0;
            this.numHoursDoneM2H2.Value = 0;
            this.numHoursDoneM2H3.Value = 0;
            this.numHoursDoneM2H4.Value = 0;
            this.txtCodeM3.Text = "";
            this.txtNameM3.Text = "";
            this.numCreditsM3.Value = 0;
            this.numHoursM3.Value = 0;
            this.numHoursDoneM3H1.Value = 0;
            this.numHoursDoneM3H2.Value = 0;
            this.numHoursDoneM3H3.Value = 0;
            this.numHoursDoneM3H4.Value = 0;
            this.txtCodeM4.Text = "";
            this.txtNameM4.Text = "";
            this.numCreditsM4.Value = 0;
            this.numHoursM4.Value = 0;
            this.numHoursDoneM4H1.Value = 0;
            this.numHoursDoneM4H2.Value = 0;
            this.numHoursDoneM4H3.Value = 0;
            this.numHoursDoneM4H4.Value = 0;
            this.txtCodeM5.Text = "";
            this.txtNameM5.Text = "";
            this.numCreditsM5.Value = 0;
            this.numHoursM5.Value = 0;
            this.numHoursDoneM5H1.Value = 0;
            this.numHoursDoneM5H2.Value = 0;
            this.numHoursDoneM5H3.Value = 0;
            this.numHoursDoneM5H4.Value = 0;
            this.tabPage1.Text = "Module 1";
            this.tabPage2.Text = "Module 2";
            this.tabPage3.Text = "Module 3";
            this.tabPage4.Text = "Module 4";
            this.tabPage5.Text = "Module 5";
            intSumM1 = 0;
            intSumM2 = 0;
            intSumM3 = 0;
            intSumM4 = 0;
            intSumM5 = 0;

            MessageBox.Show("Reset Complete");
        }

        


        String strDisplay;

        private void btnSetM1_Click(object sender, EventArgs e)
        {
            
            if (this.txtCodeM1.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM1.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else 
            {
                strCodeM1 = this.txtCodeM1.Text;
                strNameM1 = this.txtNameM1.Text;
                intCreditsM1 = Convert.ToInt32(this.numCreditsM1.Value);
                intHoursM1 = Convert.ToInt32(this.numHoursM1.Value); ;
                MessageBox.Show("Module set successfully");
                intSumM1 = Convert.ToInt32(this.numHoursDoneM1H1.Value) + Convert.ToInt32(this.numHoursDoneM1H2.Value) + Convert.ToInt32(this.numHoursDoneM1H3.Value) + Convert.ToInt32(this.numHoursDoneM1H4.Value);
                this.tabPage1.Text = strCodeM1;
                ActivateT1 = "Y";
            }
        }

        private void btnSetM2_Click(object sender, EventArgs e)
        {
            if (this.txtCodeM2.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM2.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                strCodeM2 = this.txtCodeM2.Text;
                strNameM2 = this.txtNameM2.Text;
                intCreditsM2 = Convert.ToInt32(this.numCreditsM2.Value);
                intHoursM2 = Convert.ToInt32(this.numHoursM2.Value); ;
                MessageBox.Show("Module set successfully");
                intSumM2 = Convert.ToInt32(this.numHoursDoneM2H1.Value) + Convert.ToInt32(this.numHoursDoneM2H2.Value) + Convert.ToInt32(this.numHoursDoneM2H3.Value) + Convert.ToInt32(this.numHoursDoneM2H4.Value);
                this.tabPage2.Text = strCodeM2;
                ActivateT2 = "Y";
            }
        }

        private void btnSetM3_Click(object sender, EventArgs e)
        {
            if (this.txtCodeM3.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM3.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                strCodeM3 = this.txtCodeM3.Text;
                strNameM3 = this.txtNameM3.Text;
                intCreditsM3 = Convert.ToInt32(this.numCreditsM3.Value);
                intHoursM3 = Convert.ToInt32(this.numHoursM3.Value); ;
                MessageBox.Show("Module set successfully");
                intSumM3 = Convert.ToInt32(this.numHoursDoneM3H1.Value) + Convert.ToInt32(this.numHoursDoneM3H2.Value) + Convert.ToInt32(this.numHoursDoneM3H3.Value) + Convert.ToInt32(this.numHoursDoneM3H4.Value);
                this.tabPage3.Text = strCodeM3;
                ActivateT3 = "Y";
            }
        }

        private void btnSetM4_Click(object sender, EventArgs e)
        {
            if (this.txtCodeM4.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM4.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                strCodeM4 = this.txtCodeM4.Text;
                strNameM4 = this.txtNameM4.Text;
                intCreditsM4 = Convert.ToInt32(this.numCreditsM4.Value);
                intHoursM4 = Convert.ToInt32(this.numHoursM4.Value); ;
                MessageBox.Show("Module set successfully");
                intSumM4 = Convert.ToInt32(this.numHoursDoneM4H1.Value) + Convert.ToInt32(this.numHoursDoneM4H2.Value) + Convert.ToInt32(this.numHoursDoneM4H3.Value) + Convert.ToInt32(this.numHoursDoneM4H4.Value);
                this.tabPage4.Text = strCodeM4;
                ActivateT4 = "Y";
            }
        }

        private void btnSetM_Click(object sender, EventArgs e)
        {
            if (this.txtCodeM5.Text.Equals("")) //Prevents blank data entries
            {
                MessageBox.Show("Enter Code, for example, PROG6212");
            }
            else if (this.txtNameM5.Text.Equals(""))
            {
                MessageBox.Show("Enter Name, for example, Programming 2B");
            }
            else
            {
                strCodeM5 = this.txtCodeM5.Text;
                strNameM5 = this.txtNameM5.Text;
                intCreditsM5 = Convert.ToInt32(this.numCreditsM5.Value);
                intHoursM5 = Convert.ToInt32(this.numHoursM5.Value); ;
                MessageBox.Show("Module set successfully");
                intSumM5 = Convert.ToInt32(this.numHoursDoneM5H1.Value) + Convert.ToInt32(this.numHoursDoneM5H2.Value) + Convert.ToInt32(this.numHoursDoneM5H3.Value) + Convert.ToInt32(this.numHoursDoneM5H4.Value);
                this.tabPage5.Text = strCodeM5;
                ActivateT5 = "Y";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strDisplay = "Thank you for using this app " + this.txtName.Text + ".\nYour resullts are as follows:";
            intWeeksLeft = Convert.ToInt32(this.numWeeksLeft.Value);
            if (intWeeksLeft.Equals(0))
            {
                MessageBox.Show("If there are no weeks left you are out of time");
            }
            else
            {
                if (ActivateT1.Equals("Y"))
                {
                    double dblTotalM1 = ((intCreditsM1 * 10) / intWeeksLeft) - intHoursM1;
                    strDisplay += "\n\n" + strCodeM1 + " or " + strNameM1 + " has " + dblTotalM1 + " hours left.\nHours recorded: " + intSumM1;
                }
                if (ActivateT2.Equals("Y"))
                {
                    double dblTotalM2 = ((intCreditsM2 * 10) / intWeeksLeft) - intHoursM2;
                    strDisplay += "\n\n" + strCodeM2 + " or " + strNameM2 + " has " + dblTotalM2 + " hours left.\nHours recorded: " + intSumM2;
                }
                if (ActivateT3.Equals("Y"))
                {
                    double dblTotalM3 = ((intCreditsM3 * 10) / intWeeksLeft) - intHoursM3;
                    strDisplay += "\n\n" + strCodeM3 + " or " + strNameM3 + " has " + dblTotalM3 + " hours left.\nHours recorded: " + intSumM3;
                }
                if (ActivateT4.Equals("Y"))
                {
                    double dblTotalM4 = ((intCreditsM4 * 10) / intWeeksLeft) - intHoursM4;
                    strDisplay += "\n\n" + strCodeM4 + " or " + strNameM4 + " has " + dblTotalM4 + " hours left.\nHours recorded: " + intSumM4;
                }
                if (ActivateT5.Equals("Y"))
                {
                    double dblTotalM5 = ((intCreditsM5 * 10) / intWeeksLeft) - intHoursM5;
                    strDisplay += "\n\n" + strCodeM5 + " or " + strNameM5 + " has " + dblTotalM5 + " hours left.\nHours recorded: " + intSumM5;
                }
                this.lblDisplay.Text = strDisplay;
            }
            
        }
    }
}
