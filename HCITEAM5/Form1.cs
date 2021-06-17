using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HCITEAM5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Get weather information from open API and add it to the text box.
            String myhome = "http://apis.data.go.kr/1360000/VilageFcstInfoService/getVilageFcst?serviceKey=yWxHNPitgzSyxzfc5xe8dgnB7ZmqWNzv18X5NWtzqIpkUBzpFUJ68dTgDQgtWgSLx6B7jdj8c4BzhWwDQm9FKQ%3D%3D&pageNo=1&numOfRows=14&dataType=XML&base_date=20210427&base_time=1700&nx=66&ny=101";
            string responseText = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(myhome);
            request.Method = "GET";
            request.Timeout = 30 * 1000;
            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            Stream respStream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(respStream);
            this.textBox_weatherInformation.Text = sr.ReadToEnd();

            // initialize comboBox index
            this.comboBox_foodType.SelectedIndex = 0;
            this.comboBox_restaurnt.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_weatherInformation_Click(object sender, EventArgs e)
        {

        }

        private void button_order_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (checkedListBox1.SelectedIndex != -1)
            {
                string str = checkedListBox1.SelectedItem.
                foreach(int i in checkedListBox1.Items)
                {
                    if(checkedListBox1.SelectedValue == 1)
                    {

                    }
                }
            }
            */
        }

        private void comboBox_foodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFoodtype = (string)comboBox_foodType.SelectedItem;
            int resultIndex = -1;
            ComboBox comboBox = (ComboBox)sender;
            resultIndex = comboBox_foodType.FindStringExact(selectedFoodtype);
            rest_addIndex(resultIndex);
        }
        private void comboBox_restaurnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_foodName.SelectedItem = null;
            string selectedrestaurnt = (string)comboBox_restaurnt.SelectedItem;
            int resultIndex = -1;
            ComboBox comboBox = (ComboBox)sender;
            resultIndex = comboBox_restaurnt.FindStringExact(selectedrestaurnt);
            foodName_addIndex(resultIndex);
        }

        /*
        // ** TEST1, CASE1 **
        private void comboBox_foodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_restaurnt.SelectedIndex == 0 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "6,000원";
                textBox_star.Text = "4.0점";
                textBox_starfig.Text = "★★★★☆";
                textBox_foodCondition.Text = "";
                textBox_condfig.Text = "";
                textBox_estimatedTime.Text = "";
                label_foodCondition.Text = "";
                textBox_foodCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (comboBox_restaurnt.SelectedIndex == 1 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "10,000원";
                textBox_star.Text = "4.0점";
                textBox_starfig.Text = "★★★★☆";
                textBox_foodCondition.Text = "";
                textBox_condfig.Text = "";
                textBox_estimatedTime.Text = "";
                label_foodCondition.Text = "";
                textBox_foodCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (comboBox_restaurnt.SelectedIndex == 2 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "10,000원";
                textBox_star.Text = "4.8점";
                textBox_starfig.Text = "★★★★★";
                textBox_foodCondition.Text = "";
                textBox_condfig.Text = "";
                textBox_estimatedTime.Text = "";
                label_foodCondition.Text = "";
                textBox_foodCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        
        // ** TEST1, CASE2 **
        private void comboBox_foodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_restaurnt.SelectedIndex == 0 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "6,000원";
                textBox_star.Text = "4.0점";
                textBox_starfig.Text = "★★★★☆";
                textBox_estimatedTime.Text = "10분";
            }
            else if (comboBox_restaurnt.SelectedIndex == 1 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "10,000원";
                textBox_star.Text = "4.0점";
                textBox_starfig.Text = "★★★★☆";
                textBox_estimatedTime.Text = "5분";
            }
            else if (comboBox_restaurnt.SelectedIndex == 2 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "10,000원";
                textBox_star.Text = "4.8점";
                textBox_starfig.Text = "★★★★★";
                textBox_estimatedTime.Text = "10분";
            }
            set_cond_time(textBox_estimatedTime.Text);
        }
        */

        // ** TEST1, CASE3 **
        private void comboBox_foodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_restaurnt.SelectedIndex == 0 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "6,000원";
                textBox_star.Text = "4.0점";
                textBox_starfig.Text = "★★★★☆";
                textBox_estimatedTime.Text = "15분";
            }
            else if (comboBox_restaurnt.SelectedIndex == 1 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "10,000원";
                textBox_star.Text = "4.0점";
                textBox_starfig.Text = "★★★★☆";
                textBox_estimatedTime.Text = "5분";
            }
            else if (comboBox_restaurnt.SelectedIndex == 2 && comboBox_foodName.SelectedIndex == 0)
            {
                textBox_price.Text = "10,000원";
                textBox_star.Text = "4.8점";
                textBox_starfig.Text = "★★★★★";
                textBox_estimatedTime.Text = "15분";
            }
            set_cond_time(textBox_estimatedTime.Text);
        }

        private void rest_addIndex(int resultIndex)
        {
            comboBox_restaurnt.Items.Clear();
            switch (resultIndex)
            {
                case 0:     // 한식
                    comboBox_restaurnt.Items.AddRange(new object[] {
                        "아지트-밥의도리",
                        "분유성집 동태찌게 전문점",
                        "통불오돌뼈 유성점",
                        "국밥일번지 유성점"});
                    comboBox_restaurnt.SelectedItem = 0;
                    break;
                case 7: // 중식
                    comboBox_restaurnt.Items.AddRange(new object[] {
                        "음식점A",
                        "음식점B",
                        "음식점C" });
                    comboBox_restaurnt.SelectedIndex = 0;
                    break;

            }
        }
        private void foodName_addIndex(int resultIndex)
        {
            comboBox_foodName.Items.Clear();

            switch (resultIndex)
            {
                case 0:     // 음식점A   = 거리 5분
                    comboBox_foodName.Items.AddRange(new object[] {
                        "짜장면",
                        "짬뽕",
                        "탕수육"});
                    break;
                case 1:     // 음식점B   = 거리 10분
                    comboBox_foodName.Items.AddRange(new object[] {
                        "짜장면",
                        "짬뽕",
                        "탕수육"});
                    break;
                case 2:     // 음식점C   = 거리 15분
                    comboBox_foodName.Items.AddRange(new object[] {
                        "짜장면",
                        "짬뽕",
                        "탕수육"});
                    break;
            }
        }
        void set_cond_time(string estimatedTime)
        {
            int time = extract_number(estimatedTime);
            checkfood_and_setCond(time);
        }
        void checkfood_and_setCond(int time)
        {
            if (comboBox_foodName.Text == "짜장면")
            {
                if (time <= 5)
                {
                    textBox_foodCondition.Text = "최상";
                    textBox_condfig.Text = "★★★★★";
                }
                else if (5 < time && time <= 10)
                {
                    textBox_foodCondition.Text = "상";
                    textBox_condfig.Text = "★★★★☆";
                }
                else if (10 < time && time <= 15)
                {
                    textBox_foodCondition.Text = "중";
                    textBox_condfig.Text = "★★★☆☆";
                }
                else if (15 < time && time <= 20)
                {
                    textBox_foodCondition.Text = "하";
                    textBox_condfig.Text = "★★☆☆☆";
                }
                else
                {
                    textBox_foodCondition.Text = "최하";
                    textBox_condfig.Text = "★☆☆☆☆";
                }
            }
        }
        int extract_number(string estimatedTime)
        {
            int time = 0;
            for (int i = 0; i < estimatedTime.Length; i++)
            {
                if (estimatedTime[i] > 47 && estimatedTime[i] < 58)
                    if (estimatedTime[i] > 47 && estimatedTime[i] < 58) time = time * 10 + estimatedTime[i] - 48;
            }
            return time;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox_starfig_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_estimatedTime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
