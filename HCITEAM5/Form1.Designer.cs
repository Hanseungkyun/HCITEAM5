
namespace HCITEAM5
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_weatherInformation = new System.Windows.Forms.TextBox();
            this.label_weatherInformation = new System.Windows.Forms.Label();
            this.label_currentLocation = new System.Windows.Forms.Label();
            this.textBox_currentLocation = new System.Windows.Forms.TextBox();
            this.label_restaurant = new System.Windows.Forms.Label();
            this.label_foodType = new System.Windows.Forms.Label();
            this.label_restaurantLocation = new System.Windows.Forms.Label();
            this.textBox_restaurantLocation = new System.Windows.Forms.TextBox();
            this.label_estimatedTime = new System.Windows.Forms.Label();
            this.textBox_estimatedTime = new System.Windows.Forms.TextBox();
            this.panel_Afterwards = new System.Windows.Forms.Panel();
            this.label_Afterwards = new System.Windows.Forms.Label();
            this.button_order = new System.Windows.Forms.Button();
            this.panel_currentFunction = new System.Windows.Forms.Panel();
            this.textBox_starfig = new System.Windows.Forms.TextBox();
            this.textBox_condfig = new System.Windows.Forms.TextBox();
            this.textBox_star = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_foodName = new System.Windows.Forms.ComboBox();
            this.comboBox_restaurnt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox_foodType = new System.Windows.Forms.ComboBox();
            this.textBox_foodCondition = new System.Windows.Forms.TextBox();
            this.label_foodCondition = new System.Windows.Forms.Label();
            this.panel_Afterwards.SuspendLayout();
            this.panel_currentFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_weatherInformation
            // 
            this.textBox_weatherInformation.Location = new System.Drawing.Point(23, 130);
            this.textBox_weatherInformation.Multiline = true;
            this.textBox_weatherInformation.Name = "textBox_weatherInformation";
            this.textBox_weatherInformation.Size = new System.Drawing.Size(1083, 787);
            this.textBox_weatherInformation.TabIndex = 0;
            this.textBox_weatherInformation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_weatherInformation
            // 
            this.label_weatherInformation.AutoSize = true;
            this.label_weatherInformation.Location = new System.Drawing.Point(20, 82);
            this.label_weatherInformation.Name = "label_weatherInformation";
            this.label_weatherInformation.Size = new System.Drawing.Size(86, 18);
            this.label_weatherInformation.TabIndex = 1;
            this.label_weatherInformation.Text = "날씨 정보";
            this.label_weatherInformation.Click += new System.EventHandler(this.label_weatherInformation_Click);
            // 
            // label_currentLocation
            // 
            this.label_currentLocation.AutoSize = true;
            this.label_currentLocation.Location = new System.Drawing.Point(413, 88);
            this.label_currentLocation.Name = "label_currentLocation";
            this.label_currentLocation.Size = new System.Drawing.Size(98, 18);
            this.label_currentLocation.TabIndex = 2;
            this.label_currentLocation.Text = "현재 위치 :";
            // 
            // textBox_currentLocation
            // 
            this.textBox_currentLocation.Location = new System.Drawing.Point(570, 82);
            this.textBox_currentLocation.Name = "textBox_currentLocation";
            this.textBox_currentLocation.Size = new System.Drawing.Size(200, 28);
            this.textBox_currentLocation.TabIndex = 3;
            this.textBox_currentLocation.Text = "궁동 414-14";
            this.textBox_currentLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_restaurant
            // 
            this.label_restaurant.AutoSize = true;
            this.label_restaurant.Location = new System.Drawing.Point(48, 88);
            this.label_restaurant.Name = "label_restaurant";
            this.label_restaurant.Size = new System.Drawing.Size(74, 18);
            this.label_restaurant.TabIndex = 4;
            this.label_restaurant.Text = "음식점 :";
            // 
            // label_foodType
            // 
            this.label_foodType.AutoSize = true;
            this.label_foodType.Location = new System.Drawing.Point(48, 45);
            this.label_foodType.Name = "label_foodType";
            this.label_foodType.Size = new System.Drawing.Size(98, 18);
            this.label_foodType.TabIndex = 5;
            this.label_foodType.Text = "음식 종류 :";
            // 
            // label_restaurantLocation
            // 
            this.label_restaurantLocation.AutoSize = true;
            this.label_restaurantLocation.Location = new System.Drawing.Point(413, 35);
            this.label_restaurantLocation.Name = "label_restaurantLocation";
            this.label_restaurantLocation.Size = new System.Drawing.Size(116, 18);
            this.label_restaurantLocation.TabIndex = 7;
            this.label_restaurantLocation.Text = "음식점 위치 :";
            // 
            // textBox_restaurantLocation
            // 
            this.textBox_restaurantLocation.Location = new System.Drawing.Point(570, 35);
            this.textBox_restaurantLocation.Multiline = true;
            this.textBox_restaurantLocation.Name = "textBox_restaurantLocation";
            this.textBox_restaurantLocation.Size = new System.Drawing.Size(200, 25);
            this.textBox_restaurantLocation.TabIndex = 9;
            this.textBox_restaurantLocation.Text = "유성구 장대동 362-7";
            this.textBox_restaurantLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_estimatedTime
            // 
            this.label_estimatedTime.AutoSize = true;
            this.label_estimatedTime.Location = new System.Drawing.Point(413, 133);
            this.label_estimatedTime.Name = "label_estimatedTime";
            this.label_estimatedTime.Size = new System.Drawing.Size(140, 18);
            this.label_estimatedTime.TabIndex = 10;
            this.label_estimatedTime.Text = "예상 소요 시간 :";
            // 
            // textBox_estimatedTime
            // 
            this.textBox_estimatedTime.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_estimatedTime.Location = new System.Drawing.Point(630, 130);
            this.textBox_estimatedTime.Name = "textBox_estimatedTime";
            this.textBox_estimatedTime.Size = new System.Drawing.Size(100, 28);
            this.textBox_estimatedTime.TabIndex = 26;
            this.textBox_estimatedTime.Text = "0분";
            this.textBox_estimatedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_estimatedTime.TextChanged += new System.EventHandler(this.textBox_estimatedTime_TextChanged);
            // 
            // panel_Afterwards
            // 
            this.panel_Afterwards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Afterwards.Controls.Add(this.label_weatherInformation);
            this.panel_Afterwards.Controls.Add(this.textBox_weatherInformation);
            this.panel_Afterwards.Location = new System.Drawing.Point(1009, 66);
            this.panel_Afterwards.Name = "panel_Afterwards";
            this.panel_Afterwards.Size = new System.Drawing.Size(1172, 944);
            this.panel_Afterwards.TabIndex = 12;
            // 
            // label_Afterwards
            // 
            this.label_Afterwards.AutoSize = true;
            this.label_Afterwards.Location = new System.Drawing.Point(1006, 30);
            this.label_Afterwards.Name = "label_Afterwards";
            this.label_Afterwards.Size = new System.Drawing.Size(164, 18);
            this.label_Afterwards.TabIndex = 13;
            this.label_Afterwards.Text = "나중에 구현할 기능";
            // 
            // button_order
            // 
            this.button_order.Font = new System.Drawing.Font("굴림", 15F);
            this.button_order.Location = new System.Drawing.Point(321, 302);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(152, 67);
            this.button_order.TabIndex = 14;
            this.button_order.Text = "주문하기";
            this.button_order.UseVisualStyleBackColor = true;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // panel_currentFunction
            // 
            this.panel_currentFunction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_currentFunction.Controls.Add(this.textBox_starfig);
            this.panel_currentFunction.Controls.Add(this.textBox_condfig);
            this.panel_currentFunction.Controls.Add(this.textBox_star);
            this.panel_currentFunction.Controls.Add(this.label4);
            this.panel_currentFunction.Controls.Add(this.textBox_price);
            this.panel_currentFunction.Controls.Add(this.label3);
            this.panel_currentFunction.Controls.Add(this.comboBox_foodName);
            this.panel_currentFunction.Controls.Add(this.comboBox_restaurnt);
            this.panel_currentFunction.Controls.Add(this.label2);
            this.panel_currentFunction.Controls.Add(this.label1);
            this.panel_currentFunction.Controls.Add(this.checkedListBox1);
            this.panel_currentFunction.Controls.Add(this.comboBox_foodType);
            this.panel_currentFunction.Controls.Add(this.textBox_foodCondition);
            this.panel_currentFunction.Controls.Add(this.label_foodCondition);
            this.panel_currentFunction.Controls.Add(this.button_order);
            this.panel_currentFunction.Controls.Add(this.textBox_estimatedTime);
            this.panel_currentFunction.Controls.Add(this.label_estimatedTime);
            this.panel_currentFunction.Controls.Add(this.textBox_restaurantLocation);
            this.panel_currentFunction.Controls.Add(this.label_restaurantLocation);
            this.panel_currentFunction.Controls.Add(this.label_foodType);
            this.panel_currentFunction.Controls.Add(this.label_restaurant);
            this.panel_currentFunction.Controls.Add(this.textBox_currentLocation);
            this.panel_currentFunction.Controls.Add(this.label_currentLocation);
            this.panel_currentFunction.Location = new System.Drawing.Point(51, 30);
            this.panel_currentFunction.Name = "panel_currentFunction";
            this.panel_currentFunction.Size = new System.Drawing.Size(816, 395);
            this.panel_currentFunction.TabIndex = 15;
            // 
            // textBox_starfig
            // 
            this.textBox_starfig.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_starfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_starfig.Location = new System.Drawing.Point(418, 225);
            this.textBox_starfig.Multiline = true;
            this.textBox_starfig.Name = "textBox_starfig";
            this.textBox_starfig.Size = new System.Drawing.Size(100, 28);
            this.textBox_starfig.TabIndex = 34;
            this.textBox_starfig.Text = "☆☆☆☆☆";
            this.textBox_starfig.TextChanged += new System.EventHandler(this.textBox_starfig_TextChanged);
            // 
            // textBox_condfig
            // 
            this.textBox_condfig.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_condfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_condfig.Location = new System.Drawing.Point(418, 259);
            this.textBox_condfig.Multiline = true;
            this.textBox_condfig.Name = "textBox_condfig";
            this.textBox_condfig.Size = new System.Drawing.Size(100, 28);
            this.textBox_condfig.TabIndex = 33;
            this.textBox_condfig.Text = "☆☆☆☆☆";
            this.textBox_condfig.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox_star
            // 
            this.textBox_star.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_star.Location = new System.Drawing.Point(312, 222);
            this.textBox_star.Name = "textBox_star";
            this.textBox_star.Size = new System.Drawing.Size(100, 28);
            this.textBox_star.TabIndex = 32;
            this.textBox_star.Text = "0점";
            this.textBox_star.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "별점 : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_price.Location = new System.Drawing.Point(312, 188);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 28);
            this.textBox_price.TabIndex = 30;
            this.textBox_price.Text = "0원";
            this.textBox_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "가격 : ";
            // 
            // comboBox_foodName
            // 
            this.comboBox_foodName.FormattingEnabled = true;
            this.comboBox_foodName.Location = new System.Drawing.Point(166, 130);
            this.comboBox_foodName.Name = "comboBox_foodName";
            this.comboBox_foodName.Size = new System.Drawing.Size(200, 26);
            this.comboBox_foodName.TabIndex = 25;
            this.comboBox_foodName.SelectedIndexChanged += new System.EventHandler(this.comboBox_foodName_SelectedIndexChanged);
            // 
            // comboBox_restaurnt
            // 
            this.comboBox_restaurnt.FormattingEnabled = true;
            this.comboBox_restaurnt.Location = new System.Drawing.Point(166, 88);
            this.comboBox_restaurnt.Name = "comboBox_restaurnt";
            this.comboBox_restaurnt.Size = new System.Drawing.Size(200, 26);
            this.comboBox_restaurnt.TabIndex = 24;
            this.comboBox_restaurnt.SelectedIndexChanged += new System.EventHandler(this.comboBox_restaurnt_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "음식 메뉴 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "음식 상태 필터링";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "음식 상태 최상만 보기",
            "음식 상태 상만 보기",
            "모든 음식 보기"});
            this.checkedListBox1.Location = new System.Drawing.Point(570, 290);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(226, 79);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // comboBox_foodType
            // 
            this.comboBox_foodType.FormattingEnabled = true;
            this.comboBox_foodType.Items.AddRange(new object[] {
            "한식",
            "분식",
            "카페.디저트",
            "돈까스.회.일식",
            "치킨",
            "피자",
            "아시안.양식",
            "중국집",
            "족발.보쌈",
            "야식",
            "찜.탕",
            "도시락",
            "패스트푸드"});
            this.comboBox_foodType.Location = new System.Drawing.Point(166, 39);
            this.comboBox_foodType.Name = "comboBox_foodType";
            this.comboBox_foodType.Size = new System.Drawing.Size(200, 26);
            this.comboBox_foodType.TabIndex = 16;
            this.comboBox_foodType.SelectedIndexChanged += new System.EventHandler(this.comboBox_foodType_SelectedIndexChanged);
            // 
            // textBox_foodCondition
            // 
            this.textBox_foodCondition.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_foodCondition.Location = new System.Drawing.Point(312, 256);
            this.textBox_foodCondition.Name = "textBox_foodCondition";
            this.textBox_foodCondition.ReadOnly = true;
            this.textBox_foodCondition.Size = new System.Drawing.Size(100, 28);
            this.textBox_foodCondition.TabIndex = 16;
            this.textBox_foodCondition.Text = "?";
            this.textBox_foodCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_foodCondition
            // 
            this.label_foodCondition.AutoSize = true;
            this.label_foodCondition.Location = new System.Drawing.Point(56, 259);
            this.label_foodCondition.Name = "label_foodCondition";
            this.label_foodCondition.Size = new System.Drawing.Size(250, 18);
            this.label_foodCondition.TabIndex = 15;
            this.label_foodCondition.Text = "예상 음식 상태 (최상~최하) : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2199, 1070);
            this.Controls.Add(this.panel_currentFunction);
            this.Controls.Add(this.label_Afterwards);
            this.Controls.Add(this.panel_Afterwards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Afterwards.ResumeLayout(false);
            this.panel_Afterwards.PerformLayout();
            this.panel_currentFunction.ResumeLayout(false);
            this.panel_currentFunction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_weatherInformation;
        private System.Windows.Forms.Label label_weatherInformation;
        private System.Windows.Forms.Label label_currentLocation;
        private System.Windows.Forms.TextBox textBox_currentLocation;
        private System.Windows.Forms.Label label_restaurant;
        private System.Windows.Forms.Label label_foodType;
        private System.Windows.Forms.Label label_restaurantLocation;
        private System.Windows.Forms.TextBox textBox_restaurantLocation;
        private System.Windows.Forms.Label label_estimatedTime;
        private System.Windows.Forms.TextBox textBox_estimatedTime;
        private System.Windows.Forms.Panel panel_Afterwards;
        private System.Windows.Forms.Label label_Afterwards;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Panel panel_currentFunction;
        private System.Windows.Forms.ComboBox comboBox_foodType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_foodName;
        private System.Windows.Forms.ComboBox comboBox_restaurnt;
        private System.Windows.Forms.TextBox textBox_star;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_starfig;
        private System.Windows.Forms.TextBox textBox_condfig;
        private System.Windows.Forms.TextBox textBox_foodCondition;
        private System.Windows.Forms.Label label_foodCondition;
    }
}

