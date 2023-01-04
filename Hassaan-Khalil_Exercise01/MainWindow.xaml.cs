using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hassaan_Khalil_Exercise01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int diameter = (int)Sizes.MEDIUM; // diameter of circle
        private Brush brushColor = Brushes.Red; // drawing color
        private bool shouldErase = false; // specify whether to erase
        private bool shouldPaint = false; // specify whether to paint

        private enum Sizes //size constants for diameter of the circle
        {
            SMALL = 4,
            MEDIUM = 8,
            LARGE = 16,
        } // end enum sizes

        public MainWindow()
        {
            InitializeComponent();
        } //emd coonstructor

        private void PaintCircle(Brush circleColor, Point position)
        {
            Ellipse newEllipse = new Ellipse(); // create an Ellipse   

            newEllipse.Fill = circleColor; // set Ellipse's color      
            newEllipse.Width = diameter; // set its horizontal diameter
            newEllipse.Height = diameter; // set its vertical diameter 

            // set the Ellipse's position            
            Canvas.SetTop(newEllipse, position.Y);
            Canvas.SetLeft(newEllipse, position.X);

            paintCanvas.Children.Add(newEllipse);
        } // end method PaintCircle

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            paintCanvas.Children.Clear(); // clear the canvas
        } // end method clear_Click

        private void redRadio_Checked(object sender, RoutedEventArgs e)
        {
            brushColor = Brushes.Red;
        } // end method redRadio_Checked

        // handles Blue RadioButton's Checked event
        private void blueRadio_Checked(object sender, RoutedEventArgs e)
        {
            brushColor = Brushes.Blue;
        }// end method blueRadio_Checked

        // handles Green RadioButton's Checked event
        private void greenRadio_Checked(object sender, RoutedEventArgs e)
        {
            brushColor = Brushes.Green;
        } // end method greenRadio_Checked

        // handles Black RadioButton's Checked event
        private void blackRadio_Checked(object sender, RoutedEventArgs e)
        {
            brushColor= Brushes.Black;
        } // end method blackRadio_Checked

        // handles Small RadioButton's Checked event
        private void smallRadio_Checked(object sender, RoutedEventArgs e)
        {
            diameter = (int) Sizes.SMALL;
        } // end method smallRadio_Checked

        // handles Medium RadioButton's Checked event
        private void mediumRadio_Checked(object sender, RoutedEventArgs e)
        {
            diameter = (int) Sizes.MEDIUM;
        } // end method mediumRadio_Checked

        // handles Large RadioButton's Checked event
        private void largeRadio_Checked(object sender, RoutedEventArgs e)
        {
            diameter = (int) Sizes.LARGE;
        } // end method largeRadio_Checked

        // handles Undo Button's Checked event
        private void undo_Click(object sender, RoutedEventArgs e)
        {
            int count = paintCanvas.Children.Count;

            //if there are any shapes on Canvas remoce the last on added
            if (count > 0)
                paintCanvas.Children.RemoveAt(count - 1);
        }//end method undo_Click

        // handles paintCanvas's MouseMove event
        private void paintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(shouldPaint)
            {
                // draw a circle of selected color at current mouse position
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(brushColor, mousePosition);
            } // end if
            else if(shouldErase)
            {
                // erase by drawing circles of the Canvas's background color
                Point mousePosition = e.GetPosition(paintCanvas);
                PaintCircle(paintCanvas.Background, mousePosition);
            } // end else if
        } // end method paintCanvas_MouseMove

        // handles paintCanvas's MouseLeftButtonDown event
        private void paintCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            shouldPaint = true; // OK to draw on the Canvas
        } // end method paintCanvas_MouseLeftButtonDown

        // handles paintCanvas's MouseLeftButtonUp event
        private void paintCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            shouldPaint = false; // do not draw on the Canvas
        } // end method paintCanvas_MouseLeftButtonUp

        // handles paintCanvas's MouseRightButtonDown event
        private void paintCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            shouldErase = true; // OK to erase the Canvas
        } // end method paintCanvas_MouseRightButtonDown

        // handles paintCanvas's MouseRightButtonUp event
        private void paintCanvas_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            shouldErase = false; // do not erase the Canvas
        } // end method paintCanvas_MouseRightButtonUp
    }
}
