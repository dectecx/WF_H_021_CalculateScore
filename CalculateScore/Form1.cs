using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 第一題
        /// <summary>
        /// 學號
        /// </summary>
        string[] Nos = new string[0];

        /// <summary>
        /// 國文成績
        /// </summary>
        int[] ChScores = new int[0];

        /// <summary>
        /// 英文成績
        /// </summary>
        int[] EnScores = new int[0];

        /// <summary>
        /// 數學成績
        /// </summary>
        int[] MaScores = new int[0];

        /// <summary>
        /// 三科總成績
        /// </summary>
        int[] TotalScores = new int[0];

        /// <summary>
        /// 輸入成績
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (Nos.Length >= 5)
            {
                MessageBox.Show("最多輸入5名資料");
                return;
            }
            // 資料轉換
            int chScore = 0;
            int enScore = 0;
            int maScore = 0;
            int totalScore = 0;
            try
            {
                chScore = Convert.ToInt32(tb_Ch1.Text);
                enScore = Convert.ToInt32(tb_En1.Text);
                maScore = Convert.ToInt32(tb_Ma1.Text);
                totalScore = chScore + enScore + maScore;
            }
            catch
            {
                MessageBox.Show("請輸入成績(限數字)");
                return;
            }
            // 更新陣列
            string[] tempNo = Nos;
            int[] tempCh = ChScores;
            int[] tempEn = EnScores;
            int[] tempMa = MaScores;
            int[] tempTotal = TotalScores;
            Nos = new string[Nos.Length + 1];
            ChScores = new int[ChScores.Length + 1];
            EnScores = new int[EnScores.Length + 1];
            MaScores = new int[MaScores.Length + 1];
            TotalScores = new int[TotalScores.Length + 1];
            tempNo.CopyTo(Nos, 0);
            tempCh.CopyTo(ChScores, 0);
            tempEn.CopyTo(EnScores, 0);
            tempMa.CopyTo(MaScores, 0);
            tempMa.CopyTo(TotalScores, 0);
            Nos[Nos.Length - 1] = tb_No1.Text;
            ChScores[ChScores.Length - 1] = chScore;
            EnScores[EnScores.Length - 1] = enScore;
            MaScores[MaScores.Length - 1] = maScore;
            TotalScores[TotalScores.Length - 1] = totalScore;

            RenderTable("");
        }

        /// <summary>
        /// 依學號查詢成績
        /// </summary>
        private void btn_SearchNo_Click(object sender, EventArgs e)
        {
            // 查詢學號
            string searchNo = tb_SearchNo.Text;
            RenderTable(searchNo);
        }

        /// <summary>
        /// 取得成績排名名次
        /// </summary>
        /// <param name="totalScore"></param>
        private int GetRank(int totalScore)
        {
            int rank = 1;
            for(int i = 0; i < TotalScores.Length; i++)
            {
                if (TotalScores[i] > totalScore)
                {
                    rank++;
                }
            }
            return rank;
        }

        /// <summary>
        /// 顯示成績(不及格以紅色顯示)、計算總平均
        /// </summary>
        /// <param name="searchNo"></param>
        private void RenderTable(string searchNo)
        {
            // 渲染表格
            DataTable table = new DataTable();
            table.Columns.Add("學號");
            table.Columns.Add("國文");
            table.Columns.Add("英文");
            table.Columns.Add("數學");
            table.Columns.Add("平均");
            table.Columns.Add("排名");
            for (int i = 0; i < Nos.Length; i++)
            {
                // 如果沒傳入查詢學號 或 與查詢學號相同才加入表格中
                if (searchNo == "" || searchNo == Nos[i])
                {
                    DataRow dr = table.NewRow();
                    dr["學號"] = Nos[i];
                    dr["國文"] = ChScores[i];
                    dr["英文"] = EnScores[i];
                    dr["數學"] = MaScores[i];
                    dr["平均"] = Math.Round(TotalScores[i] / 3.0, 2); // 四捨五入取小數第二位
                    dr["排名"] = GetRank(TotalScores[i]);
                    table.Rows.Add(dr);
                }
            }
            // 若至少有一筆,則各科計算平均
            if (table.Rows.Count > 0)
            {
                int totalCount = Nos.Length;
                int chTotalScore = 0;
                int enTotalScore = 0;
                int maTotalScore = 0;
                int totalScore = 0;
                for (int i = 0; i < totalCount; i++)
                {
                    chTotalScore += ChScores[i];
                    enTotalScore += EnScores[i];
                    maTotalScore += MaScores[i];
                    totalScore += TotalScores[i];
                }

                DataRow dr = table.NewRow();
                dr["學號"] = "平均";
                dr["國文"] = chTotalScore / totalCount;
                dr["英文"] = enTotalScore / totalCount;
                dr["數學"] = maTotalScore / totalCount;
                dr["平均"] = Math.Round(totalScore / 3.0, 2); // 四捨五入取小數第二位
                dr["排名"] = "";
                table.Rows.Add(dr);
            }
            gv_Table.DataSource = table;

            // 跑所有欄位看是否有不及格,有就改成紅色
            foreach (DataGridViewRow row in gv_Table.Rows)
            {
                // 只計算中間的國(1)+英(2)+數(3)+平均(4)
                for (int i = 1; i < 4; i++)
                {
                    if (Convert.ToInt32(row.Cells[i].Value) < 60)
                    {
                        row.Cells[i].Style.BackColor = Color.Red;
                    }
                }
            }
        }
        #endregion

        #region 第二題
        /// <summary>
        /// 目前正在輸入第n位成績
        /// </summary>
        int currentIndex = 0;
        int[] chScores2 = new int[3];
        int[] enScores2 = new int[3];
        int[] maScores2 = new int[3];

        /// <summary>
        /// 自訂函式 - 輸入成績
        /// </summary>
        /// <param name="scores"></param>
        /// <returns></returns>
        private double EnterScore(int chScore, int enScore, int maScore)
        {
            chScores2[currentIndex] = chScore;
            enScores2[currentIndex] = enScore;
            maScores2[currentIndex] = maScore;
            return Avg(new int[] { chScore, enScore, maScore });
        }

        /// <summary>
        /// 自訂函式 - 計算平均
        /// </summary>
        /// <param name="scores"></param>
        /// <returns></returns>
        private double Avg(int[] scores)
        {
            double total = 0;
            int count = scores.Length;
            for (int i = 0; i < count; i++)
            {
                total += scores[i];
            }
            return total / count;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 3)
            {
                MessageBox.Show("已輸入三位成績,如要重新輸入請點擊清除");
                return;
            }

            // 資料轉換
            int chScore = 0;
            int enScore = 0;
            int maScore = 0;
            try
            {
                chScore = Convert.ToInt32(tb_Ch2.Text);
                enScore = Convert.ToInt32(tb_En2.Text);
                maScore = Convert.ToInt32(tb_Ma2.Text);
                tb_Ch2.Text = "";
                tb_En2.Text = "";
                tb_Ma2.Text = "";
            }
            catch
            {
                MessageBox.Show("請輸入成績(限數字)");
                return;
            }
            EnterScore(chScore, enScore, maScore);

            lb_EnterResult.Text =
                "同學1: " + "國文: " + chScores2[0] + " 英文: " +  enScores2[0] + " 數學: " + maScores2[0] + "\n" +
                "同學2: " + "國文: " + chScores2[1] + " 英文: " +  enScores2[1] + " 數學: " + maScores2[1] + "\n" +
                "同學3: " + "國文: " + chScores2[2] + " 英文: " +  enScores2[2] + " 數學: " + maScores2[2];
            currentIndex++;
        }

        private void btn_Avg_Click(object sender, EventArgs e)
        {
            if (currentIndex < 3)
            {
                MessageBox.Show("請先輸入完畢三位同學成績");
                return;
            }
            lb_AvgResult.Text = "" +
                "國文平均: " + Avg(new int[] { chScores2[0], chScores2[1], chScores2[2] }) + "\n" +
                "英文平均: " + Avg(new int[] { enScores2[0], enScores2[1], enScores2[2] }) + "\n" +
                "數學平均: " + Avg(new int[] { maScores2[0], maScores2[1], maScores2[2] }) + "\n" +
                "同學1 3科平均: " + Avg(new int[] { chScores2[0], enScores2[0], maScores2[0] }) + "\n" +
                "同學2 3科平均: " + Avg(new int[] { chScores2[1], enScores2[1], maScores2[1] }) + "\n" +
                "同學3 3科平均: " + Avg(new int[] { chScores2[2], enScores2[2], maScores2[2] }) + "\n";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            chScores2 = new int[3];
            enScores2 = new int[3];
            maScores2 = new int[3];
            tb_Ch2.Text = "";
            tb_En2.Text = "";
            tb_Ma2.Text = "";
            lb_EnterResult.Text = "";
            lb_AvgResult.Text = "";
        }
        #endregion
    }
}
