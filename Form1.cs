using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaberSongSpeed {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            mapTextBox.MaxLength = int.MaxValue;
        }

        private void convertButton_Click(object sender, EventArgs e) {

            string[] multiplierLines = multiplierInput.Lines;

            float multiplier;
            try {
                if (multiplierLines.Length > 0) {
                    if (!float.TryParse(multiplierLines[0], out multiplier)) {
                        infoLabel.Text = "Your multiplier value is invalid!  You must use a valid decimal number (above zero).";
                        return;
                    }
                } else {
                    infoLabel.Text = "Your multiplier value is invalid!  You must use a valid decimal number (above zero).";
                    return;
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
                infoLabel.Text = "Your multiplier value is invalid!  You must use a valid decimal number (above zero).";
                return;
            }

            string[] maps = mapTextBox.Lines;

            if (maps.Length < 1) {
                infoLabel.Text = "You must include the map data you wish to convert!";
                return;
            }

            try {

                string[] newMaps = new string[maps.Length];
                for (int i = 0; i < maps.Length; i++) {
                    string[] subMap = maps[i].Split('{');
                    for (int j = 0; j < subMap.Length; j++) {
                        string s = subMap[j];
                        if (s.StartsWith("\"_time\":")) {
                            s = s.Split(',')[0].Split(':')[1];
                            float t = float.Parse(s);
                            subMap[j] = subMap[j].Replace("time\":" + t, "time\":" + (t / multiplier));

                            if (subMap[j].Contains("_duration")) {
                                s = subMap[j].Split(':')[4].Split(',')[0];
                                t = float.Parse(s);
                                subMap[j] = subMap[j].Replace("duration\":" + t, "duration\":" + (t / multiplier));
                            }
                            //Console.WriteLine(s);
                        }
                    }
                    newMaps[i] = string.Join("{", subMap);
                }

                mapTextBox.Lines = newMaps;

                infoLabel.Text = "Done!";

            } catch (Exception ex) {
                infoLabel.Text = "There was an error during conversion!";
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
