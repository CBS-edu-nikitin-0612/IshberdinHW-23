using System;
using System.Windows;

namespace Task4
{
    internal class Presenter
    {
        private readonly Model model;
        private readonly MainWindow viewe;
        public event EventHandler Result = null;
        enum Operand
        {
            sum ,
            sub ,
            mul ,
            div
        };
        Operand operand;


        public void Sum(object sender, RoutedEventArgs e)
        {
            model.Value1 = Convert.ToDouble(viewe.TextBox.Text);
            viewe.TextBox.Text = "";
            operand = Operand.sum;
        }

        public void Sub(object sender, RoutedEventArgs e)
        {
            model.Value1 = Convert.ToDouble(viewe.TextBox.Text);
            viewe.TextBox.Text = "";
            operand = Operand.sub;
        }

        public void Mul(object sender, RoutedEventArgs e)
        {
            model.Value1 = Convert.ToDouble(viewe.TextBox.Text);
            viewe.TextBox.Text = "";
            operand = Operand.mul;
        }

        public void Div(object sender, EventArgs e)
        {
            model.Value1 = Convert.ToDouble(viewe.TextBox.Text);
            viewe.TextBox.Text = "";
            operand = Operand.div;
        }
        public void Res(object sender, EventArgs e)
        {
            model.Value2 = Convert.ToDouble(viewe.TextBox.Text);

            switch (operand)
            {
                case Operand.sum:
                    viewe.TextBox.Text = (model.Value1 + model.Value2).ToString();
                    break;
                case Operand.sub:
                    viewe.TextBox.Text = (model.Value1 - model.Value2).ToString();
                    break;
                case Operand.mul:
                    viewe.TextBox.Text = (model.Value1 * model.Value2).ToString();
                    break;
                case Operand.div:
                    viewe.TextBox.Text = (model.Value1 / model.Value2).ToString();
                    break;
                default:
                    break;
            }
        }

        public Presenter(MainWindow viewe)
        {
            this.viewe = viewe;
            this.model = new Model();
        }
    }
}
