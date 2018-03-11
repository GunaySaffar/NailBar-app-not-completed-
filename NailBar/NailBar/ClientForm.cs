using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NailBar
{
    public partial class client_form : Form
    {
        public client_form()
        {
            InitializeComponent();
        }

        private void choose_confirm_Load(object sender, EventArgs e)
        {
            choose_mast.Items.Clear();
           

           
            foreach (var item in Master.master_list)
            {
                choose_mast.Items.Add(item.Name);
            }
        }

        private void choose_confirm_Click(object sender, EventArgs e)
        {
            var sel_mast = choose_mast.SelectedItem;
            var sel_day = choose_day.SelectedItem;
            var sel_month = choose_month.SelectedItem;
            var sel_hour = choose_hour.SelectedItem;
            MessageBox.Show("We will wait you  "+sel_day+sel_month+" on : "+sel_hour);
        }
        public int sel_mast_item;
        private void choose_mast_SelectedIndexChanged(object sender, EventArgs e)
        {
            //choose_month.Items.Clear();
            sel_mast_item = Convert.ToInt32(choose_mast.SelectedIndex);
            sel_mast_item++;
            foreach (var item in Master.master_list)
            {
                if (item.Id == sel_mast_item)
                {
                    foreach (var months in item.master_month.Distinct())
                    {
                        choose_month.Items.Add(months);
                    }
                }
            }
            
        }

        private void choose_month_SelectedIndexChanged(object sender, EventArgs e)
        {

            //choose_day.Items.Clear();
            foreach (var item in Master.master_list)
            {
                if (item.Id == sel_mast_item)
                {
                    foreach (var months in item.master_month)
                    {
                        if (months == choose_month.Text)
                        {
                            foreach (var days in item.master_day)
                            {
                                choose_day.Items.Add(days);
                            }
                        }
                    }
                }
            }
        }

        private void choose_day_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           // choose_hour.Items.Clear();
            foreach (var item in Master.master_list)
            {
                if (item.Id == sel_mast_item)
                {
                    foreach (var months in item.master_month)
                    {
                        if (months == choose_month.Text)
                        {
                            foreach (var days in item.master_day)
                            {
                                if (days==Convert.ToInt32(choose_day.Text))
                                {
                                    foreach (var hours in item.master_hour)
                                    {
                                        choose_hour.Items.Add(hours);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
