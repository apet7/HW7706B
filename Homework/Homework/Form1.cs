using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Event        
        private void LicenseTax_Load(object sender, EventArgs e)
        {
            this.Init();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void btnCalculate_MouseEnter(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.FromArgb(7, 111, 122);
            btnCalculate.ForeColor = Color.White;
        }

        private void btnCalculate_MouseLeave(object sender, EventArgs e)
        {
            btnCalculate.BackColor = Color.White;
            btnCalculate.ForeColor = Color.FromArgb(7, 111, 122);
        }
        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.FromArgb(7, 111, 122);
            btnReset.ForeColor = Color.White;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.BackColor = Color.White;
            btnReset.ForeColor = Color.FromArgb(7, 111, 122);
        }

        private void reYear_CheckedChanged(object sender, EventArgs e)
        {
            this.YearPick();
        }

        private void rbday_CheckedChanged(object sender, EventArgs e)
        {
            this.DayPick();
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選項
            if (this.cbxType.SelectedIndex == 0)
            {
                cbxTypeCC.Items.Add("150以下 / 12HP以下 (12.2PS以下)");
                cbxTypeCC.Items.Add("151-250 / 12.1-20HP (12.3-20.3PS)");
                cbxTypeCC.Items.Add("251 - 500 / 20.1hp以上 (20.4ps以上)");
                cbxTypeCC.Items.Add("501 - 600");
                cbxTypeCC.Items.Add("601 - 1200");
                cbxTypeCC.Items.Add("1201 - 1800");
                cbxTypeCC.Items.Add("1801或以上");
                cbxTypeCC.SelectedIndex = 0;
            }
            if (this.cbxType.SelectedIndex == 1)
            {
                cbxTypeCC.Items.Clear();
                cbxTypeCC.Items.Add("500以下");
                cbxTypeCC.Items.Add("501 - 600");
                cbxTypeCC.Items.Add("601 - 1200");
                cbxTypeCC.Items.Add("1201 - 1800");
                cbxTypeCC.Items.Add("1801 - 2400");
                cbxTypeCC.Items.Add("2401 - 3000 / 138HP以下 (140.1PS以下)");
                cbxTypeCC.Items.Add("3001 - 3600");
                cbxTypeCC.Items.Add("3601 - 4200 / 138.1-200HP (140.2-203.0PS)");
                cbxTypeCC.Items.Add("4201 - 4800");
                cbxTypeCC.Items.Add("4801 - 5400 / 200.1-247HP (203.1-250.7PS)");
                cbxTypeCC.Items.Add("5401 - 6000");
                cbxTypeCC.Items.Add("6001 - 6600 / 247.1-286HP (250.8-290.3PS)");
                cbxTypeCC.Items.Add("6601 - 7200");
                cbxTypeCC.Items.Add("7201 - 7800 / 286.1-336HP (290.4-341.0PS)");
                cbxTypeCC.Items.Add("7801 - 8400");
                cbxTypeCC.Items.Add("8401 - 9000 / 336.1-361HP (341.1-366.4PS)");
                cbxTypeCC.Items.Add("9001 - 9600");
                cbxTypeCC.Items.Add("9601 - 10200 / 361.1HP以上 (366.5PS以上)");
                cbxTypeCC.Items.Add("10201以上");
                cbxTypeCC.SelectedIndex = 0;
            }
            if (this.cbxType.SelectedIndex == 2)
            {
                cbxTypeCC.Items.Clear();
                cbxTypeCC.Items.Add("600以下");
                cbxTypeCC.Items.Add("601 - 1200");
                cbxTypeCC.Items.Add("1201 - 1800");
                cbxTypeCC.Items.Add("1801 - 2400");
                cbxTypeCC.Items.Add("2401 - 3000 / 138HP以下 (140.1PS以下)");
                cbxTypeCC.Items.Add("3001 - 3600");
                cbxTypeCC.Items.Add("3601 - 4200 / 138.1-200HP (140.2-203.0PS)");
                cbxTypeCC.Items.Add("4201 - 4800");
                cbxTypeCC.Items.Add("4801 - 5400 / 200.1-247HP (250.8-290.3PS)");
                cbxTypeCC.Items.Add("5401 - 6000");
                cbxTypeCC.Items.Add("6001 - 6600 / 247.1-286HP (250.8-290.3PS)");
                cbxTypeCC.Items.Add("6601 - 7200");
                cbxTypeCC.Items.Add("7201 - 7800 / 286.1-366HP (290.4-341.0PS)");
                cbxTypeCC.Items.Add("7801 - 8400");
                cbxTypeCC.Items.Add("8401 - 9000 / 336.1-361HP (341.1-366.4PS)");
                cbxTypeCC.Items.Add("9001 - 9600");
                cbxTypeCC.Items.Add("9601 - 10200 / 361.1HP以上 (366.5PS以上)");
                cbxTypeCC.Items.Add("10201以上");
                cbxTypeCC.SelectedIndex = 0;
            }
            if (this.cbxType.SelectedIndex == 3)
            {
                cbxTypeCC.Items.Clear();
                cbxTypeCC.Items.Add("500以下 / 38HP以下 (38.6PS以下)");
                cbxTypeCC.Items.Add("501 - 600 / 38.1-56HP (38.7-56.8PS)");
                cbxTypeCC.Items.Add("601 - 1200 / 56.1-83HP (56.9-84.2PS)");
                cbxTypeCC.Items.Add("1201 - 1800 / 83.1-182HP (84.3-184.7PS)");
                cbxTypeCC.Items.Add("1801 - 2400 / 182.1-262HP (184.8-265.9PS)");
                cbxTypeCC.Items.Add("2401 - 3000 / 262.1-322HP (266-326.8PS)");
                cbxTypeCC.Items.Add("3001 - 4200 / 322.1-414HP (326.9-420.2PS)");
                cbxTypeCC.Items.Add("4201 - 5400 / 414.1-469HP (420.3-476.0PS)");
                cbxTypeCC.Items.Add("5401 - 6600 / 469.1-509HP (476.1-516.6PS)");
                cbxTypeCC.Items.Add("6601 - 7800 / 509.1HP以上 (516.7PS以上)");
                cbxTypeCC.Items.Add("7801以上");
                cbxTypeCC.SelectedIndex = 0;
            }
            if (this.cbxType.SelectedIndex == 4)
            {
                cbxTypeCC.Items.Clear();
                cbxTypeCC.Items.Add("500以下 / 38HP以下 (38.6PS以下)");
                cbxTypeCC.Items.Add("501 - 600 / 38.1-56HP (38.7-56.8PS)");
                cbxTypeCC.Items.Add("601 - 1200 / 56.1-83HP (56.9-84.2PS)");
                cbxTypeCC.Items.Add("1201 - 1800 / 83.1-182HP (84.3-184.7PS)");
                cbxTypeCC.Items.Add("1801 - 2400 / 182.1-262HP (184.8-265.9PS)");
                cbxTypeCC.Items.Add("2401 - 3000 / 262.1-322HP (266-326.8PS)");
                cbxTypeCC.Items.Add("3001 - 4200 / 322.1-414HP (326.9-420.2PS)");
                cbxTypeCC.Items.Add("4201 - 5400 / 414.1-469HP (420.3-476.0PS)");
                cbxTypeCC.Items.Add("5401 - 6600 / 469.1-509HP (476.1-516.6PS)");
                cbxTypeCC.Items.Add("6601 - 7800 / 509.1HP以上 (516.7PS以上)");
                cbxTypeCC.Items.Add("7801以上");
                cbxTypeCC.SelectedIndex = 0;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 強制轉換成decimal
            decimal Price = (decimal)this.GetTaxPercentage();

            // 計算天數
            DateTime ds = dtpStart.Value;
            DateTime de = dtpEnd.Value;

            if (ds > de)
            {
                MessageBox.Show($"錯誤。\n" + "請重新輸入日期。");
                return;
            }

            TimeSpan Selectdays = de - ds;

            // 辨別閏年
            int yearSelect = dtpStart.Value.Year;
            int yearType;

            if (yearSelect % 4 == 0 && yearSelect % 100 != 0 || yearSelect % 400 == 0)
            {
                yearType = 366;
            }
            else
            {
                yearType = 365;
            }

            // 計算金額

            decimal result = Price * (Selectdays.Days + 1) / yearType;

            if (result < 1)
            {
                result = 0;
            }

            if (result > 1)
            {
                result = Math.Truncate(result); // 取得整數
            }

            // 全年度
            if (Selectdays.Days <= 366)
            {
                this.txtAns.Text = $"使用期間: {dtpStart.Value.ToString("yyyy/MM/dd")} ~ {dtpEnd.Value.ToString("yyyy/MM/dd")}\n"
                + $"計算天數: { Selectdays.Days + 1 }天\n"
                + $"汽缸CC數: {cbxTypeCC.SelectedItem.ToString()}\n"
                + $"用途: {cbxType.SelectedItem.ToString()}\n"
                + $"計算公式: {Price} * { Selectdays.Days + 1} / {yearType} = {result}元\n"
                + $"應納稅額: 共{result}元";

                DateTimePickerReset();
            }

            // 一年以上...寫不出來...
            //if (Selectdays.Days > 366)
            //{
            //    this.txtAns.Text = $"使用期間: {dtpStart.Value.ToString("yyyy/MM/dd")} ~ {dtpEnd.Value.ToString("yyyy/MM/dd")}\n"
            //    + $"計算天數: { Selectdays.Days + 1 }天\n"
            //    + $"汽缸CC數: {cbxTypeCC.SelectedItem.ToString()}\n"
            //    + $"用途: {cbxType.SelectedItem.ToString()}\n"
            //    + $"計算公式: {Price} * { Selectdays.Days + 1} / {yearType} = {result}元\n"
            //    + $"應納稅額: 共{result}元";
            //}
        }

        #endregion

        #region "Custom methods"
        /// <summary> 控制項初始化 </summary>
        private void Init()
        {
            this.reYear.Checked = true;
            this.rbday.Checked = false;
            this.cbxType.SelectedIndex = 0;
            this.cbxTypeCC.SelectedIndex = 0;
            this.txtAns.Text = "";
        }

        /// <summary>
        /// 日期選項
        /// </summary>
        private void YearPick()
        {
            this.dtpStart.Visible = false;
            this.dtpEnd.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
        }
        private void DayPick()
        {
            this.dtpStart.Visible = true;
            this.dtpEnd.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
        }

        private void DateTimePickerReset()
        {
            dtpStart.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpEnd.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }

        /// <summary>
        /// 價位
        /// </summary>
        /// <returns></returns>
        private int GetTaxPercentage()
        {
            if (this.cbxType.SelectedIndex == 0)
            {
                string taxType = this.cbxTypeCC.Text;

                switch (taxType)
                {
                    case "150以下 / 12HP以下 (12.2PS以下)":
                        return 0;
                    case "151-250 / 12.1-20HP (12.3-20.3PS)":
                        return 800;
                    case "251 - 500 / 20.1hp以上 (20.4ps以上)":
                        return 1620;
                    case "501 - 600":
                        return 2160;
                    case "601 - 1200":
                        return 4320;
                    case "1201 - 1800":
                        return 7120;
                    case "1801或以上":
                        return 11230;
                    default:
                        return 0;
                }
            }
            if (this.cbxType.SelectedIndex == 1)
            {
                string taxType = this.cbxTypeCC.Text;

                switch (taxType)
                {
                    case "500以下":
                        return 900;
                    case "501 - 600":
                        return 1080;
                    case "601 - 1200":
                        return 1800;
                    case "1201 - 1800":
                        return 2700;
                    case "1801 - 2400":
                        return 3600;
                    case "2401 - 3000 / 138HP以下 (140.1PS以下)":
                        return 4500;
                    case "3001 - 3600":
                        return 5400;
                    case "3601 - 4200 / 138.1-200HP (140.2-203.0PS)":
                        return 6300;
                    case "4201 - 4800":
                        return 7200;
                    case "4801 - 5400 / 200.1-247HP (203.1-250.7PS)":
                        return 8100;
                    case "5401 - 6000":
                        return 9000;
                    case "6001 - 6600 / 247.1-286HP (250.8-290.3PS)":
                        return 9900;
                    case "6601 - 7200":
                        return 10800;
                    case "7201 - 7800 / 286.1-336HP (290.4-341.0PS)":
                        return 11700;
                    case "7801 - 8400":
                        return 12600;
                    case "8401 - 9000 / 336.1-361HP (341.1-366.4PS)":
                        return 13500;
                    case "9001 - 9600":
                        return 14400;
                    case "9601 - 10200 / 361.1HP以上 (366.5PS以上)":
                        return 15300;
                    case "10201以上":
                        return 16200;
                    default:
                        return 0;
                }
            }
            if (this.cbxType.SelectedIndex == 2)
            {
                string taxType = this.cbxTypeCC.Text;

                switch (taxType)
                {
                    case "600以下":
                        return 1080;
                    case "601 - 1200":
                        return 1800;
                    case "1201 - 1800":
                        return 2700;
                    case "1801 - 2400":
                        return 3600;
                    case "2401 - 3000 / 138HP以下 (140.1PS以下)":
                        return 4500;
                    case "3001 - 3600":
                        return 5400;
                    case "3601 - 4200 / 138.1-200HP (140.2-203.0PS)":
                        return 6300;
                    case "4201 - 4800":
                        return 7200;
                    case "4801 - 5400 / 200.1-247HP (250.8-290.3PS)":
                        return 8100;
                    case "5401 - 6000":
                        return 9000;
                    case "6001 - 6600 / 247.1-286HP (250.8-290.3PS)":
                        return 9900;
                    case "6601 - 7200":
                        return 10800;
                    case "7201 - 7800 / 286.1-366HP (290.4-341.0PS)":
                        return 11700;
                    case "7801 - 8400":
                        return 12600;
                    case "8401 - 9000 / 336.1-361HP (341.1-366.4PS)":
                        return 13500;
                    case "9001 - 9600":
                        return 14400;
                    case "9601 - 10200 / 361.1HP以上 (366.5PS以上)":
                        return 15300;
                    case "10201以上":
                        return 16200;
                    default:
                        return 0;
                }
            }
            if (this.cbxType.SelectedIndex == 3)
            {
                string taxType = this.cbxTypeCC.Text;

                switch (taxType)
                {
                    case "500以下 / 38HP以下 (38.6PS以下)":
                        return 1620;
                    case "501 - 600 / 38.1-56HP (38.7-56.8PS)":
                        return 2160;
                    case "601 - 1200 / 56.1-83HP (56.9-84.2PS)":
                        return 4320;
                    case "1201 - 1800 / 83.1-182HP (84.3-184.7PS)":
                        return 7120;
                    case "1801 - 2400 / 182.1-262HP (184.8-265.9PS)":
                        return 11230;
                    case "2401 - 3000 / 262.1-322HP (266-326.8PS)":
                        return 15210;
                    case "3001 - 4200 / 322.1-414HP (326.9-420.2PS)":
                        return 28220;
                    case "4201 - 5400 / 414.1-469HP (420.3-476.0PS)":
                        return 46170;
                    case "5401 - 6600 / 469.1-509HP (476.1-516.6PS)":
                        return 69690;
                    case "6601 - 7800 / 509.1HP以上 (516.7PS以上)":
                        return 117000;
                    case "7801以上":
                        return 151200;
                    default:
                        return 0;
                }
            }
            if (this.cbxType.SelectedIndex == 4)
            {
                string taxType = this.cbxTypeCC.Text;

                switch (taxType)
                {
                    case "500以下 / 38HP以下 (38.6PS以下)":
                        return 900;
                    case "501 - 600 / 38.1-56HP (38.7-56.8PS)":
                        return 1260;
                    case "601 - 1200 / 56.1-83HP (56.9-84.2PS)":
                        return 2160;
                    case "1201 - 1800 / 83.1-182HP (84.3-184.7PS)":
                        return 3060;
                    case "1801 - 2400 / 182.1-262HP (184.8-265.9PS)":
                        return 6480;
                    case "2401 - 3000 / 262.1-322HP (266-326.8PS)":
                        return 9900;
                    case "3001 - 4200 / 322.1-414HP (326.9-420.2PS)":
                        return 16380;
                    case "4201 - 5400 / 414.1-469HP (420.3-476.0PS)":
                        return 24300;
                    case "5401 - 6600 / 469.1-509HP (476.1-516.6PS)":
                        return 33660;
                    case "6601 - 7800 / 509.1HP以上 (516.7PS以上)":
                        return 44460;
                    case "7801以上":
                        return 56700;
                    default:
                        return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        #endregion 
    }
}
