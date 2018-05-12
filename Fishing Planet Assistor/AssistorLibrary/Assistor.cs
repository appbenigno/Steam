using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assistor
{
    public class Assistant
    {
        /// <summary>
        /// Add Settings
        /// </summary>
        /// <param name="targetListView"></param>
        /// <param name="reelInterval"></param>
        /// <param name="jerkInterval"></param>
        /// <param name="speed"></param>
        /// <param name="reelPulse"></param>
        /// <param name="jerkPulse"></param>
        /// <param name="description"></param>
        public static void addSettings(ListView targetListView, NumericUpDown reelInterval, NumericUpDown jerkInterval, NumericUpDown speed, NumericUpDown reelPulse, NumericUpDown jerkPulse, string description)
        {
            ListViewItem lvi = new ListViewItem(reelInterval.Value.ToString());
            lvi.SubItems.Add(jerkInterval.Value.ToString());
            lvi.SubItems.Add(speed.Value.ToString());
            lvi.SubItems.Add(reelPulse.Value.ToString());
            lvi.SubItems.Add(jerkPulse.Value.ToString());
            lvi.SubItems.Add(description);
            targetListView.Items.Add(lvi);
        }

        /// <summary>
        /// Remove Settings
        /// </summary>
        /// <param name="targetListView"></param>
        public static void removeSettings(ListView targetListView)
        {
            targetListView.SelectedItems[0].Remove();
        }

        /// <summary>
        /// Edit Settings
        /// </summary>
        /// <param name="targetListView"></param>
        /// <param name="reelInterval"></param>
        /// <param name="jerkInterval"></param>
        /// <param name="speed"></param>
        /// <param name="reelPulse"></param>
        /// <param name="jerkPulse"></param>
        /// <param name="description"></param>
        public static void editSettings(ListView targetListView, NumericUpDown reelInterval, NumericUpDown jerkInterval, NumericUpDown speed, NumericUpDown reelPulse, NumericUpDown jerkPulse, string description)
        {
            targetListView.SelectedItems[0].SubItems[0].Text = reelInterval.Value.ToString();
            targetListView.SelectedItems[0].SubItems[1].Text = jerkInterval.Value.ToString();
            targetListView.SelectedItems[0].SubItems[2].Text = speed.Value.ToString();
            targetListView.SelectedItems[0].SubItems[3].Text = reelPulse.Value.ToString();
            targetListView.SelectedItems[0].SubItems[4].Text = jerkPulse.Value.ToString();
            targetListView.SelectedItems[0].SubItems[5].Text = description;
        }

        public static void getSettings(ListView targetListView, NumericUpDown reelInterval, NumericUpDown jerkInterval, NumericUpDown speed, NumericUpDown reelPulse, NumericUpDown jerkPulse, TextBox description)
        {
            reelInterval.Value = Convert.ToInt32(targetListView.SelectedItems[0].SubItems[0].Text);
            jerkInterval.Value = Convert.ToInt32(targetListView.SelectedItems[0].SubItems[1].Text);
            speed.Value = Convert.ToInt32(targetListView.SelectedItems[0].SubItems[2].Text);
            reelPulse.Value = Convert.ToInt32(targetListView.SelectedItems[0].SubItems[3].Text);
            jerkPulse.Value = Convert.ToInt32(targetListView.SelectedItems[0].SubItems[4].Text);
            description.Text = targetListView.SelectedItems[0].SubItems[5].Text;
        }
    }
}
