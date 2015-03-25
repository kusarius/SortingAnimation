using System;
using System.Threading;
using System.Windows.Forms;
using Vortex.Drawing;

namespace SortingAnimation {
    public partial class MainForm : Form {
        SingleContextDevice device;
        Canvas2D canvas;

        float[] array;
        int si1 = -1, si2 = -1;
        bool isDrawing = false;
        Random rnd = new Random();

        #region Sorting algoritms

        void QuickSort(float[] a, int start, int end) {
            int s = start, e = end;
            float v = a[start + (end - start) / 2];
            while (s <= e) {
                while (a[s] < v) s++;
                while (a[e] > v) e--;
                if (s <= e) {
                    Swap<float>(ref a[s], ref a[e]);
                    Thread.Sleep(animSpeedTrackBar.Value);
                    si1 = s; si2 = e;
                    UpdateScene();
                    s++;
                    e--;
                }
            }
            if (start < e) QuickSort(a, start, e);
            if (s < end) QuickSort(a, s, end);
        }

        void MergeSort(float[] a, int start, int end) {
            if (end - start < 2) return;
            if (end - start == 2) {
                if (a[start] > a[start + 1]) {
                    Swap<float>(ref a[start], ref a[start + 1]);
                    Thread.Sleep(animSpeedTrackBar.Value);
                    si1 = start; si2 = start + 1;
                    UpdateScene();
                }
                return;
            }

            int c = start + (end - start) / 2;
            MergeSort(a, start, c);
            MergeSort(a, c, end);

            float[] tmp = new float[end - start];
            int ap = 0, p1 = start, p2 = c;
            while (ap < end - start) {
                if (p2 >= end || (p1 < c && a[p1] < a[p2])) {
                    tmp[ap] = a[p1];
                    p1++;
                }
                else {
                    tmp[ap] = a[p2];
                    p2++;
                }

                ap++;
            }

            for (int i = start; i < end; i++) {
                a[i] = tmp[i - start];
                Thread.Sleep(animSpeedTrackBar.Value);
                si1 = i; si2 = -1;
                UpdateScene();
            }
        }

        #region Heap sort

        void Heapify(int count, int i, float[] a) {
            int right = 2 * i, left = 2 * i + 1;
            if (right >= count || left >= count) return;
            if (a[i] < a[left] || a[i] < a[right]) {
                int maxi = (a[left] > a[right]) ? left : right;
                Swap(ref a[i], ref a[maxi]);

                Thread.Sleep(animSpeedTrackBar.Value);
                si1 = i; si2 = maxi;
                UpdateScene();

                Heapify(count, maxi, a);
            }
        }

        void BuildHeap(float[] a) {
            for (int i = a.Length / 2 - 1; i >= 0; i--)
                Heapify(a.Length, i, a);
        }

        void HeapSort(float[] a) {
            BuildHeap(a);
            for (int i = a.Length - 1; i >= 0; i--) {
                Swap(ref a[i], ref a[0]);

                Thread.Sleep(animSpeedTrackBar.Value);
                si1 = i; si2 = 0;
                UpdateScene();

                Heapify(i, 0, a);
            }
        }

        #endregion

        #endregion

        #region Main program

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
                        canvas.DrawLine(i, canvasPanel.Height, i, canvasPanel.Height - array[i], 
                            (i == si1 || i == si2) ? ColorU.Red : ColorU.WhiteSmoke);
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

        private void startAlgoButton_Click(object sender, EventArgs e) {
            if (isDrawing) {
                clearCanvasButton.Enabled = genArrayButton.Enabled 
                    = startAlgoButton.Enabled = animSpeedTrackBar.Enabled = false;

                if (qsortRadioButton.Checked) QuickSort(array, 0, array.Length - 1);
                else if (mergesortRadioButton.Checked) MergeSort(array, 0, array.Length);
                else if (heapsortRadioButton.Checked) HeapSort(array);

                si1 = si2 = -1;
                UpdateScene();
                clearCanvasButton.Enabled = genArrayButton.Enabled 
                    = startAlgoButton.Enabled = animSpeedTrackBar.Enabled = true;
            }
        }

        #endregion
    }
}
