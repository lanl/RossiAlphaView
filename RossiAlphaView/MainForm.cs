//Copyright © 2019. Triad National Security, LLC.All rights reserved.
//
//This program was produced under U.S.Government contract 89233218CNA000001 for Los Alamos National Laboratory (LANL), which is operated by Triad National Security, LLC for the U.S.Department of Energy/National Nuclear Security Administration. All rights in the program are reserved by Triad National Security, LLC, and the U.S.Department of Energy/National Nuclear Security Administration. The Government is granted for itself and others acting on its behalf a nonexclusive, paid-up, irrevocable worldwide license in this material to reproduce, prepare derivative works, distribute copies to the public, perform publicly and display publicly, and to permit others to do so.
//
//This program is open source under the BSD-3 License.
//
//Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
//1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//2.Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
//3.Neither the name of the copyright holder nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
//
//THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using LiveCharts.Geared;
using LiveCharts.Defaults;

namespace RossiAlphaView
{
    public partial class MainForm : Form
    {
        string VERSION = "1.0.0";

        double screenCorrectionFactor = 1.0;

        int maxNumFissions = 0;

        int nBins = 100;
        int binWidth = 10;
        int maxVal = 50000;
        int diffPerFrame = 1;

        double baseProbability = 0.02;
        double correlatedP;

        double decayTime = 50.0;
        double multiplication = 2.5;
        double efficiency = 1.0;

        int gateWidth = 25;
        int longDelay = 50;
        int preDelay = 5;
        int RPlusA = 0;
        int A = 0;

        int alphaCount = 0;
        int fissionCount = 0;
        int alphaPulseCount = 0;
        int fissionPulseCount = 0;

        Random rand;

        Bitmap backBuffer;
        Graphics bufferGraphics;

        List<int> timeStamps;
        List<int> pulseOrigin;
        List<int> fissionTimes;
        List<int> fissionID;

        int[] histogram;
        int[] deltaHistogram;

        public MainForm()
        {
            InitializeComponent();

            this.Text = "Rossi Alpha View (Version " + VERSION + ")";

            rand = new Random();
            this.DoubleBuffered = true;
            histogram = new int[nBins];
            for (int i = 0; i < nBins; i++) histogram[i] = 0;
            deltaHistogram = new int[nBins];
            for (int i = 0; i < nBins; i++) deltaHistogram[i] = 0;
            InitializeChart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            screenCorrectionFactor = PulsePanel.Width / 1000.0;

            PulsePanel.Paint += new PaintEventHandler(PulsePanel_Paint);
            timeStamps = new List<int>();
            pulseOrigin = new List<int>();
            fissionTimes = new List<int>();
            fissionID = new List<int>();

            backBuffer = new Bitmap(PulsePanel.Width, PulsePanel.Height);
            bufferGraphics = Graphics.FromImage(backBuffer);

            HistChart.DisableAnimations = true;
            HistChart.Hoverable = false;
            HistChart.DataTooltip = null;

            HeartBeat.Start();
        }

        private void PulsePanel_Paint(object sender, PaintEventArgs e)
        {
            int maxDrawValue = nBins * binWidth;
            Pen alphaPen = new Pen(System.Drawing.Color.Red, 2);
            Pen fissionPen = new Pen(System.Drawing.Color.Green, 2);

            bufferGraphics.Clear(Color.White);

            for (int i = 0; i < timeStamps.Count; i++)
            {
                if (timeStamps[i] <= maxDrawValue)
                {
                    if (pulseOrigin[i] == 0)
                        bufferGraphics.DrawLine(alphaPen, (float)screenCorrectionFactor * timeStamps[i], 0, (float)screenCorrectionFactor * timeStamps[i], 50);
                    else
                    {
                        fissionPen.Color = Color.FromArgb((pulseOrigin[i] * 23) % 200, 255-((pulseOrigin[i] * 23) % 90), ((pulseOrigin[i] * 53) % 200));
                        bufferGraphics.DrawLine(fissionPen, (float)screenCorrectionFactor * timeStamps[i], 0, (float)screenCorrectionFactor * timeStamps[i], 50);
                    }
                }
            }

            e.Graphics.DrawImage(backBuffer, 0, 0);
        }

        private void AddToHistogram(int t)
        {
            int index;
            for (int i = 0; i < nBins; i++)
            {
                histogram[i] += deltaHistogram[i];
                deltaHistogram[i] = 0;
            }
            for (int i = 0; i < timeStamps.Count; i++)
            {
                index = (int)Math.Floor((double)(timeStamps[i] - t) / ((double)binWidth));
                if (index < (nBins-1))
                    deltaHistogram[index] += 1;
            }
        }

        private void UpdateCounterLabels()
        {
            FissionCountLabel.Text = "Fission Count: " + fissionCount.ToString();
            FissionPulsesLabel.Text = "Fission Pulses: " + fissionPulseCount.ToString();
            AlphaCountLabel.Text = "Alpha Count: " + alphaCount.ToString();
            AlphaPulsesLabel.Text = "Alpha Pulses: " + alphaPulseCount.ToString();
        }

        private void GeneratePulse()
        {
            for (int i = diffPerFrame - 1; i >= 0; i--)
            {
                if (rand.NextDouble() < (1 - correlatedP))
                {
                    if (rand.NextDouble() < baseProbability)
                    {
                        alphaCount++;
                        if (rand.NextDouble() < efficiency)
                        {
                            AddToHistogram(i);
                            timeStamps.Insert(0, i);
                            pulseOrigin.Insert(0, 0);
                            alphaPulseCount++;
                        }
                    }
                    UpdateCounterLabels();
                }
                else
                {
                    if (rand.NextDouble() < baseProbability/ multiplication)
                    {
                        fissionTimes.Insert(0, i);
                        fissionCount++;
                        fissionID.Insert(0, fissionCount);
                        UpdateCounterLabels();
                        if (maxNumFissions > 0 && fissionCount == maxNumFissions)
                        {
                            Pause();
                            return;
                        }
                    }
                }
                for (int ft=0; ft < fissionTimes.Count(); ft++)
                {
                    if (rand.NextDouble() < efficiency * multiplication * Math.Exp(-(fissionTimes[ft] - i) / decayTime) / decayTime)
                    {
                        AddToHistogram(i);
                        timeStamps.Insert(0, i);
                        pulseOrigin.Insert(0, fissionID[ft]);
                        fissionPulseCount++;
                        UpdateCounterLabels();
                    }
                }
            }
        }

        private void InitializeChart()
        {
            HistChart.Series.Clear();
            HistChart.AxisY.Add(new Axis
            {
                MinValue = 0,
                LabelFormatter = val => val.ToString("0.0 E0"),
                Sections = new SectionsCollection
                {
                    new AxisSection
                    {
                        Value = 0,
                        Stroke = System.Windows.Media.Brushes.Transparent,
                        StrokeThickness = 2,
                        StrokeDashArray = new System.Windows.Media.DoubleCollection(new [] {10d}),
                    }
                }
            });
            HistChart.AxisX.Add(new Axis
            {
                MinValue = 0,
                Sections = new SectionsCollection
                {
                    new AxisSection
                    {
                        Value = preDelay,
                        SectionWidth = gateWidth,
                        Fill = new System.Windows.Media.SolidColorBrush
                        {
                            Color = System.Windows.Media.Colors.Green,
                            Opacity = 0.0
                        }
                    },
                    new AxisSection
                    {
                        Value = preDelay + longDelay,
                        SectionWidth = gateWidth,
                        Fill = new System.Windows.Media.SolidColorBrush
                        {
                            Color = System.Windows.Media.Colors.Red,
                            Opacity = 0.0
                        }
                    }
                }
            });

            // Gate Labels
            HistChart.VisualElements.Add(new VisualElement
            {
                X = preDelay+(gateWidth/2),
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Top,
                UIElement = new System.Windows.Controls.TextBlock //notice this property must be a wpf control
                {
                    Text = "R+A\n0",
                    TextAlignment = System.Windows.TextAlignment.Center,
                    FontSize = 18,
                    Opacity = 0
                }
            });
            HistChart.VisualElements.Add(new VisualElement
            {
                X = preDelay + longDelay + (gateWidth / 2),
                HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                VerticalAlignment = System.Windows.VerticalAlignment.Top,
                UIElement = new System.Windows.Controls.TextBlock //notice this property must be a wpf control
                {
                    Text = "A\n0",
                    TextAlignment = System.Windows.TextAlignment.Center,
                    FontSize = 18,
                    Opacity = 0
                }
            });

            //Topper
            HistChart.Series.Add(new GStepLineSeries
            {
                Values = new ChartValues<ObservablePoint> { },
                Stroke = System.Windows.Media.Brushes.Black,
                Fill = new System.Windows.Media.SolidColorBrush
                {
                    Color = System.Windows.Media.Colors.LightBlue,
                    Opacity = 0.25
                },
                //System.Windows.Media.Brushes.Red,
                PointGeometry = null
            });
            HistChart.Series[0].Values.Add(new ObservablePoint(-1, 0));
            for (int i = 0; i < nBins; i++)
                HistChart.Series[0].Values.Add(new ObservablePoint(i, histogram[i]));
            // Main histogram
            HistChart.Series.Add(new GStepLineSeries
            {
                Values = new ChartValues<ObservablePoint> { },
                Stroke = System.Windows.Media.Brushes.Black,
                Fill = new System.Windows.Media.SolidColorBrush
                {
                    Color = System.Windows.Media.Colors.DarkBlue,
                    Opacity = 0.5
                }, // System.Windows.SystemColors.ControlBrush,
                PointGeometry = null
            });
            HistChart.Series[1].Values.Add(new ObservablePoint(-1, 0));
            for (int i = 0; i < nBins; i++)
                HistChart.Series[1].Values.Add(new ObservablePoint(i, histogram[i]));
        }

        private void DrawChart()
        {
            for (int i = 0; i < nBins; i++)
                ((ObservablePoint)(HistChart.Series[0].Values[i+1])).Y = histogram[i] + deltaHistogram[i];
            for (int i = 0; i < nBins; i++)
                ((ObservablePoint)(HistChart.Series[1].Values[i+1])).Y = histogram[i];
            CalculateGates();
        }

        private void CalculateGates()
        {
            RPlusA = 0;
            for (int i = preDelay; i < preDelay + gateWidth; i++)
                if (i < nBins)
                    RPlusA += histogram[i] + deltaHistogram[i];
            ((System.Windows.Controls.TextBlock)((VisualElement)HistChart.VisualElements[0]).UIElement).Text = "R+A\n" + RPlusA.ToString();

            A = 0;
            for (int i = preDelay + longDelay; i < longDelay + preDelay + gateWidth; i++)
                if (i < nBins)
                    A += histogram[i] + deltaHistogram[i];
            ((System.Windows.Controls.TextBlock)((VisualElement)HistChart.VisualElements[1]).UIElement).Text = "A\n" + A.ToString();

            // A level
            HistChart.AxisY[0].Sections[0].Value = ((double)A) / ((double)gateWidth);

            // R+A - A Label
            int RPlusAMinusA = RPlusA - A;
            double absUncertainty = Math.Sqrt(RPlusA + A);
            RPlusAMinusALabel.Text = "R+A - A = " + RPlusAMinusA.ToString() + " (\u00B1" + absUncertainty.ToString("N1") + ")";
            UncertaintyLabel.Text = "Uncertainty = " + (100 * absUncertainty / RPlusAMinusA).ToString("N1") + "%";
        }

        private void DrawGates()
        {

        }

        private void HeartBeat_Tick(object sender, EventArgs e)
        {
            for (int i =0; i<timeStamps.Count; i++)
            {
                timeStamps[i] += diffPerFrame;
            }
            for (int i = 0; i < fissionTimes.Count; i++)
                fissionTimes[i] += diffPerFrame;
            while (true)
            {
                if (timeStamps.Count == 0) break;

                if (timeStamps.Last() >= maxVal)
                {
                    pulseOrigin.RemoveAt(timeStamps.Count - 1);
                    timeStamps.RemoveAt(timeStamps.Count - 1);
                }
                else
                    break;
            }
            while (true)
            {
                if (fissionTimes.Count == 0) break;

                if (fissionTimes.Last() >= maxVal)
                {
                    fissionID.RemoveAt(fissionTimes.Count - 1);
                    fissionTimes.RemoveAt(fissionTimes.Count - 1);                    
                }
                else
                    break;
            }
            GeneratePulse();
            PulsePanel.Refresh();
            DrawChart();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeartBeat.Stop();
            timeStamps.Clear();
            pulseOrigin.Clear();
            fissionTimes.Clear();
            fissionID.Clear();
            for (int i = 0; i < histogram.Length; i++)
            {
                histogram[i] = 0;
                deltaHistogram[i] = 0;
            }
            PulsePanel.Refresh();
            DrawChart();
            fissionCount = 0;
            fissionPulseCount = 0;
            alphaCount = 0;
            alphaPulseCount = 0;
            if (!paused)
                HeartBeat.Start();
        }

        private void CorrelatedTrackBar_Scroll(object sender, EventArgs e)
        {
            correlatedP = ((double)CorrelatedTrackBar.Value)/CorrelatedTrackBar.Maximum;
            DragToolTip.SetToolTip(CorrelatedTrackBar, correlatedP.ToString());
        }

        private void SpeedTrackBar_Scroll(object sender, EventArgs e)
        {
            diffPerFrame = (int) (  Math.Pow((Math.Exp(((double)SpeedTrackBar.Value) / ((double)SpeedTrackBar.Maximum))-1.0) / 2.718, 3) * 25000 );
            DragToolTip.SetToolTip(SpeedTrackBar, diffPerFrame.ToString());
        }

        private void DieAwayTrackBar_Scroll(object sender, EventArgs e)
        {
            decayTime = (double)DieAwayTrackBar.Value * 200.0 / (double)DieAwayTrackBar.Maximum;
            DragToolTip.SetToolTip(DieAwayTrackBar, decayTime.ToString());
        }

        private void StrengthTrackBar_Scroll(object sender, EventArgs e)
        {
            baseProbability = ((double)StrengthTrackBar.Value) / ((double)StrengthTrackBar.Maximum) * 0.25;
            DragToolTip.SetToolTip(StrengthTrackBar, baseProbability.ToString());
        }

        bool paused = false;

        private void Pause()
        {
            HeartBeat.Stop();
            paused = true;
            PauseButton.Text = "Resume";
        }

        private void Resume()
        {
            HeartBeat.Start();
            paused = false;
            PauseButton.Text = "Pause";
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (paused)
                Resume();
            else
                Pause();
        }

        private void GateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (GateCheckBox.Checked)
            {
                PreDelayLabel.Visible = true;
                PreDelayTrackBar.Visible = true;
                GateWidthLabel.Visible = true;
                GateWidthTrackBar.Visible = true;
                LongDelayLabel.Visible = true;
                LongDelayTrackBar.Visible = true;
                RPlusAMinusALabel.Visible = true;
                UncertaintyLabel.Visible = true;

                HistChart.AxisX[0].Sections[0].Fill.Opacity = 0.25;
                HistChart.AxisX[0].Sections[1].Fill.Opacity = 0.25;
                HistChart.AxisY[0].Sections[0].Stroke = System.Windows.Media.Brushes.Red;
                ((VisualElement)HistChart.VisualElements[0]).UIElement.Opacity = 1;
                ((VisualElement)HistChart.VisualElements[1]).UIElement.Opacity = 1;
            }
            else
            {
                PreDelayLabel.Visible = false;
                PreDelayTrackBar.Visible = false;
                GateWidthLabel.Visible = false;
                GateWidthTrackBar.Visible = false;
                LongDelayLabel.Visible = false;
                LongDelayTrackBar.Visible = false;
                RPlusAMinusALabel.Visible = false;
                UncertaintyLabel.Visible = false;

                HistChart.AxisX[0].Sections[0].Fill.Opacity = 0;
                HistChart.AxisX[0].Sections[1].Fill.Opacity = 0;
                HistChart.AxisY[0].Sections[0].Stroke = System.Windows.Media.Brushes.Transparent;
                ((VisualElement)HistChart.VisualElements[0]).UIElement.Opacity = 0;
                ((VisualElement)HistChart.VisualElements[1]).UIElement.Opacity = 0;
            }
        }

        private void UpdateGates()
        {
            AxisSection RASection = HistChart.AxisX[0].Sections[0];
            AxisSection ASection = HistChart.AxisX[0].Sections[1];

            RASection.Value = preDelay;
            RASection.SectionWidth = gateWidth;
            ((VisualElement)HistChart.VisualElements[0]).X = preDelay + (gateWidth / 2);

            ASection.Value = preDelay + longDelay;
            ASection.SectionWidth = gateWidth;
            ((VisualElement)HistChart.VisualElements[1]).X = preDelay + longDelay + (gateWidth / 2);

            CalculateGates();
        }

        private void AdjustMaximumLongDelay()
        {
            int newMax = 100 - preDelay - gateWidth;
            LongDelayTrackBar.Maximum = newMax;
            if (longDelay > newMax)
            {
                LongDelayTrackBar.Value = newMax;
                longDelay = newMax;
            }
        }

        private void PreDelayTrackBar_Scroll(object sender, EventArgs e)
        {
            preDelay = PreDelayTrackBar.Value;
            DragToolTip.SetToolTip(PreDelayTrackBar, preDelay.ToString());
            AdjustMaximumLongDelay();
            UpdateGates();
        }

        private void GateWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            gateWidth = GateWidthTrackBar.Value;
            DragToolTip.SetToolTip(GateWidthTrackBar, gateWidth.ToString());
            AdjustMaximumLongDelay();
            UpdateGates();
        }

        private void LongDelayTrackBar_Scroll(object sender, EventArgs e)
        {
            longDelay = LongDelayTrackBar.Value;
            DragToolTip.SetToolTip(LongDelayTrackBar, longDelay.ToString());
            UpdateGates();
        }

        private void EfficiencyTrackBar_Scroll(object sender, EventArgs e)
        {
            efficiency = (double)EfficiencyTrackBar.Value / (double)EfficiencyTrackBar.Maximum;
            DragToolTip.SetToolTip(EfficiencyTrackBar, efficiency.ToString());
        }

        private void SystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SystemCheckBox.Checked)
            {
                DieAwayLabel.Visible = true;
                DieAwayTrackBar.Visible = true;
                EfficiencyLabel.Visible = true;
                EfficiencyTrackBar.Visible = true;
            }
            else
            {
                DieAwayLabel.Visible = false;
                DieAwayTrackBar.Visible = false;
                EfficiencyLabel.Visible = false;
                EfficiencyTrackBar.Visible = false;
            }
        }

        private void MaxFissionsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                maxNumFissions = int.Parse(MaxFissionsTextBox.Text);
                if (maxNumFissions > 0)
                    MaxFissionsTextBox.ForeColor = Color.Black;
                else
                    MaxFissionsTextBox.ForeColor = Color.Red;
            }
            catch
            {
                maxNumFissions = 0;
                MaxFissionsTextBox.ForeColor = Color.Red;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox(VERSION);
            aboutBox.ShowDialog();
        }
    }
}
