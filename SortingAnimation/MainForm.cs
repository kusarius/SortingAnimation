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

        static int stickWidth = 1;
        static int stickXOffset = (stickWidth == 1) ? 0 : 1;

        Thread sortWork;

        #region Sorting algoritms

        void VisualizeArray(int _si1, int _si2) {
            Thread.Sleep(animSpeedTrackBar.Value);
            si1 = _si1; si2 = _si2;
            UpdateScene();
        }

        void QuickSort(float[] a, int start, int end) {
            int s = start, e = end;
            float v = a[start + (end - start) / 2];
            while (s <= e) {
                while (a[s] < v) s++;
                while (a[e] > v) e--;
                if (s <= e) {
                    Swap<float>(ref a[s], ref a[e]);
                    VisualizeArray(s, e);
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
                    VisualizeArray(start, start + 1);
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
                VisualizeArray(i, -1);
            }
        }

        void SelectionSort(float[] a) {
            for (int i = 0; i < a.Length - 1; i++) {
                int min = i;
                for (int j = i + 1; j < a.Length; j++) {
                    if (a[j] < a[min]) {
                        min = j;
                    }
                }
                float dummy = a[i];
                a[i] = a[min];
                a[min] = dummy;
                VisualizeArray(i, min);
            }
        }

        void InsertionSort(float[] a) {
            float curr;
            int prevIndex;
            for (int i = 1; i < a.Length; i++) {
                curr = a[i];
                prevIndex = i - 1;
                while (prevIndex >= 0 && a[prevIndex] > curr) {
                    a[prevIndex + 1] = a[prevIndex];
                    a[prevIndex] = curr;
                    VisualizeArray(prevIndex, prevIndex + 1);
                    prevIndex--;
                }
            }
        }

        void BubbleSort(float[] a) {
            for (int i = 0; i < a.Length; i++) {
                int F = 0;
                for (int c = 0; c < a.Length - i - 1; c++)
                    if (a[c] > a[c + 1]) {
                        Swap<float>(ref a[c], ref a[c + 1]);
                        VisualizeArray(c, c + 1);
                        F = 1;
                    }
                if (F == 0) break;
            }
        }

        void ShakerSort(float[] a) {
            int left = 0;
            int right = a.Length - 1;

            while (left <= right) {
                for (int i = left; i < right; i++) {
                    if (a[i] > a[i + 1]) {
                        Swap<float>(ref a[i], ref a[i + 1]);
                        VisualizeArray(i, i + 1);
                    }
                }
                right--;

                for (int i = right; i > left; i--) {
                    if (a[i] < a[i - 1]) {
                        Swap<float>(ref a[i], ref a[i - 1]);
                        VisualizeArray(i, i - 1);
                    }
                }
                left++;
            }
        }

        #region Heap sort

        void Heapify(int count, int i, float[] a) {
            int right = 2 * i, left = 2 * i + 1;
            if (right >= count || left >= count) return;
            if (a[i] < a[left] || a[i] < a[right]) {
                int maxi = (a[left] > a[right]) ? left : right;
                Swap(ref a[i], ref a[maxi]);
                VisualizeArray(i, maxi);
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
                VisualizeArray(i, 0);
                Heapify(i, 0, a);
            }
        }

        #endregion

        #endregion

        #region Main program

        public MainForm() {
            InitializeComponent();

            // Array initialization
            array = new float[canvasPanel.Width / stickWidth];

            device = new SingleContextDevice(canvasPanel.Handle);
            canvas = device.Context.Canvas;
        }

        private void CreateArray() {
            stickWidth = (int)stickWidthNumericUpDown.Value;
            stickXOffset = (stickWidth == 1) ? 0 : 1;
            array = new float[canvasPanel.Width / stickWidth];

            for (int i = 1; i <= array.Length; i++)
                array[i - 1] = (float)i * ((float)canvasPanel.Height / (float)array.Length);
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
                        canvas.DrawFilledRect(i * stickWidth + stickXOffset, canvasPanel.Height - array[i], 
                            stickWidth - stickXOffset, array[i], 
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
                float partWidth = (float)array.Length / (float)heightsCount;

                array[0] = partHeight;

                for (int i = 1, ch = 1; i < array.Length; i++)
                    if (i <= ch * partWidth) array[i] = array[i - 1];
                    else { ch++; array[i] = ch * partHeight; }

                Shuffle();
            }

            isDrawing = true;
            UpdateScene();
        }

        void EnableControls(bool enable) {
            clearCanvasButton.Enabled = genArrayButton.Enabled
                = startAlgoButton.Enabled = groupBox1.Enabled = groupBox2.Enabled = enable;
        }

        private void startAlgoButton_Click(object sender, EventArgs e) {
            sortWork = new Thread(() => {
                if (isDrawing) {
                    EnableControls(false);

                    if (qsortRadioButton.Checked) QuickSort(array, 0, array.Length - 1);
                    else if (mergesortRadioButton.Checked) MergeSort(array, 0, array.Length);
                    else if (heapsortRadioButton.Checked) HeapSort(array);
                    else if (insertionSortRadioButton.Checked) InsertionSort(array);
                    else if (bubbleSortRadioButton.Checked) BubbleSort(array);
                    else if (shakerSortRadioButton.Checked) ShakerSort(array);
                    else if (selectionSortRadioButton.Checked) SelectionSort(array);

                    si1 = si2 = -1;
                    UpdateScene();
                    EnableControls(true);
                }
            });
            
            sortWork.Start();
        }

        private void stopAlgoButton_Click(object sender, EventArgs e) {
            if (sortWork != null && sortWork.IsAlive) {
                sortWork.Abort();
                EnableControls(true);
                si1 = si2 = -1;
                UpdateScene();
            }
        }

        #endregion
    }
}
