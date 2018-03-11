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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        public int selected_day;
        public string selected_month;
        public string selected_hours;
        public int selected_master;
        public int idCount =0;
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                day_box.Items.Add(i);
            }
            string[] month_arr = new string []{ "January","February","March","April","May","June","July","August","September","October","November","December" };
            foreach (var item in month_arr)
            {
                month_box.Items.Add(item);
            }
            string[] hours_arr = new string[] { "10:00", "12:00", "14:00", "16:00", "18:00"};
            foreach (var item in hours_arr)
            {
                hours_box.Items.Add(item);
            }
            

        }

        private void add_master_btn_Click(object sender, EventArgs e)
        {
            mast_id_box.Items.Clear();
            master_name_box.Items.Clear();
            idCount++;
            var mast_box=master_add_box.Text;
            Master masters = new Master(idCount, mast_box);
            master_name_box.Text = "";
            mast_id_box.Text = "";
            foreach (var item in Master.master_list)
            {
                
                master_name_box.Items.Add(item.Id+" "+item.Name);
                mast_id_box.Items.Add(item.Id);
            }
            
        }
        public int selected_mast;
        private void delete_master_btn_Click(object sender, EventArgs e)
        {
            selected_mast = Convert.ToInt32(mast_id_box.SelectedItem);
            foreach (var item in Master.master_list)
            {
                if ( item.Id==selected_mast)
                {
                   Master.master_list.Remove(item);
                    break;
                }
            }
            mast_id_box.Text = " ";
            master_name_box.Items.Clear();
            mast_id_box.Items.Clear();
            master_name_box.Text = " ";
            foreach (var item in Master.master_list)
            {
                master_name_box.Items.Add(item.Id + "-" + item.Name);
                mast_id_box.Items.Add(item.Id);
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            selected_master = Convert.ToInt32(master_name_box.SelectedIndex);
            selected_master++;
            selected_day = Convert.ToInt32(day_box.SelectedItem);
            selected_month = Convert.ToString(month_box.SelectedItem);
            selected_hours = Convert.ToString(hours_box.SelectedItem);

            foreach (var item in Master.master_list)
            {
                if (item.Id == selected_master)
                {
                    item.AddDay(selected_day);
                    item.AddMonth(selected_month);
                    item.AddHour(selected_hours);
                }
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            var my_form = new Login();
            my_form.Show();
            this.Hide();
        }

        private void master_name_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
    class Master
    {
        public static List<Master> master_list = new List<Master>();
        public int Id;
        public string Name;
        public List<int> master_day = new List<int>();
        public List<string> master_month = new List<string>();
        public List<string> master_hour = new List<string>();
        public Master(int _id,string _name)
        {
            Id = _id;
            Name = _name;
            master_list.Add(this);
        }
        public void AddDay(int _day)
        {
            master_day.Add(_day);
        }
        public void AddMonth(string _month)
        {
            master_month.Add(_month);
        }
        public void AddHour(string _hour)
        {
            master_hour.Add(_hour);
        }

    }
}
