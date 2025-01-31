using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Z2
{
    public partial class MainForm : Form
    {
        private readonly List<GraphicObject> _graphicObjects = new List<GraphicObject>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddCircleButton_Click_1(object sender, EventArgs e)
        {
            var circle = new Circle { Color = "Red" };
            _graphicObjects.Add(circle);
            RefreshDrawing();
        }

        private void AddSquareButton_Click_1(object sender, EventArgs e)
        {
            var square = new Square { Color = "Blue" };
            _graphicObjects.Add(square);
            RefreshDrawing();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            _graphicObjects.Clear();
            RefreshDrawing();
        }
        private void RefreshDrawing()
        {
            using (var graphics = DrawingPanel.CreateGraphics())
            {
                graphics.Clear(Color.White);

                foreach (var graphicObject in _graphicObjects)
                {
                    if (graphicObject is Circle)
                    {
                        graphics.FillEllipse(Brushes.Red, 50, 50, 100, 100);
                    }
                    else if (graphicObject is Square)
                    {
                        graphics.FillRectangle(Brushes.Blue, 200, 50, 100, 100);
                    }
                }
            }
        }

    }
}