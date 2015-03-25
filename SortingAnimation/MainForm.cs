using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Vortex;
using Vortex.Drawing;

namespace SortingAnimation {
    public partial class MainForm : Form {
        SingleContextDevice device;
        Canvas2D canvas;

        float[] array;
        bool isDrawing = false;
        Random rnd = new Random();

        public MainForm() {
            InitializeComponent();

            // Array initialization
            array = new float[canvasPanel.Width];

            device = new SingleContextDevice(canvasPanel.Handle);
            canvas = device.Context.Canvas;
        }

        private void CreateArray() {
            for (int i = 0; i < array.Length; i++)
                array[i] = (float)i * ((float)canvasPanel.Height / (float)canvasPanel.Width);
        }

        static void Swap<T>(ref T lhs, ref T rhs) {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        private void Shuffle() {
            for (int i = 0; i < array.Length; i++)
                Swap<float>(ref array[i], ref array[rnd.Next(i, array.Length)]);
        }

        private void UpdateScene() {
            if (device.BeginScene()) {
                canvas.Clear(ColorU.Black);

                if (isDrawing) {
                    for (int i = 0; i < array.Length; i++)
                        canvas.DrawLine(i, canvasPanel.Height, i, canvasPanel.Height - array[i], ColorU.WhiteSmoke);
                }

                device.EndScene();
                device.Context.Present();
            }
            else device.TryReset();
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e) {
            UpdateScene();
        }

        private void clearCanvasButton_Click(object sender, EventArgs e) {
            isDrawing = false;
            UpdateScene();
        }

        private void genArrayButton_Click(object sender, EventArgs e) {
            CreateArray();

            // Array generation
            if (randomRadioButton.Checked) Shuffle();
            else if (nsortedRadioButton.Checked) {
                int iterations = rnd.Next(10, array.Length / 3);
                for (int i = 0; i < iterations; i++) {
                    int swapIndex = rnd.Next(0, array.Length);
                    try { Swap(ref array[swapIndex], ref array[swapIndex + rnd.Next(-7, 8)]); }
                    catch { /* Index out of range... */ }
                }
            }
            else if (reversedRadioButton.Checked) Array.Reverse(array);
            else if (funiqueRadioButton.Checked) {
                int heightsCount = rnd.Next(4, 11);
                float partHeight = (float)canvasPanel.Height / (float)heightsCount;
                float partWidth = (float)canvasPanel.Width / (float)heightsCount;

                for (int i = 0, h = 1, w = 1; i < array.Length; i++) {
                    if (i <= h * partWidth) array[i] = h * partHeight;
                    else { h++; w++; }
                }

                Shuffle();
            }

            isDrawing = true;
            UpdateScene();
        }
    }
}
