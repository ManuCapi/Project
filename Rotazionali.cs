using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Project
{
    public partial class Form1 : Form
    {
        NumberFormatInfo nfi = NumberFormatInfo.InvariantInfo;
        double Val710, D710, Val500, D500, Val425, D425, Val300, D300, Val212, D212, Val150, D150, Val0, D0;
        double somma, sommatemp;
        double Fin0, Fin150, Fin212, Fin300, Fin425, Fin500, Fin710;

        private void Set425_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? Set425.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Set300_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? Set300.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Set212_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? Set212.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Set150_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? Set150.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Set0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? Set0.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Set500_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? Set500.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void Set710_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? Set710.Text.Contains('.') == true : true))
                e.Handled = true;

        }

        double Col710, Col500, Col425, Col300, Col212, Col150, Col0;

        private void Set0_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set0.Text) == false)
            {
                Col0 = Convert.ToDouble(Set0.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                if (Col0 < 411.36)
                    Set0.BackColor = Color.Red;
                else
                    Set0.BackColor = Color.White;
            }
            else
                Set0.BackColor = Color.White;
        }

        private void Set150_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set150.Text) == false)
            {
                Col150 = Convert.ToDouble(Set150.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                if (Col150 < 387.27)
                    Set150.BackColor = Color.Red;
                else
                    Set150.BackColor = Color.White;
            }
            else
                Set150.BackColor = Color.White;
        }

        private void Set212_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set212.Text) == false)
            {
                Col212 = Convert.ToDouble(Set212.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                if (Col212 < 392.64)
                    Set212.BackColor = Color.Red;
                else
                    Set212.BackColor = Color.White;
            }
            else
                Set212.BackColor = Color.White;

        }

        private void Set300_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set300.Text) == false)
            {
                Col300 = Convert.ToDouble(Set300.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                if (Col300 < 398.38)
                    Set300.BackColor = Color.Red;
                else
                    Set300.BackColor = Color.White;
            }
            else
                Set300.BackColor = Color.White;
        }

        private void Set425_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set425.Text) == false)
            {
                Col425 = Convert.ToDouble(Set425.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                if (Col425 < 416.87)
                    Set425.BackColor = Color.Red;
                else
                    Set425.BackColor = Color.White;
            }
            else
                Set425.BackColor = Color.White;

        }

        private void Set500_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set500.Text) == false)
            {
                Col500 = Convert.ToDouble(Set500.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                if (Col500 < 422.31)
                    Set500.BackColor = Color.Red;
                else
                    Set500.BackColor = Color.White;
            }
            else
                Set500.BackColor = Color.White;
        }

        private void Set710_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set710.Text) == false)
            {
                Col710 = Convert.ToDouble(Set710.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                if (Col710 < 452.61)
                    Set710.BackColor = Color.Red;
                else
                    Set710.BackColor = Color.White;
            }
            else
                Set710.BackColor = Color.White;
        }

        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcolo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Set0.Text) == true || String.IsNullOrEmpty(Set150.Text) == true || String.IsNullOrEmpty(Set212.Text) == true || String.IsNullOrEmpty(Set300.Text) == true || String.IsNullOrEmpty(Set425.Text) == true || String.IsNullOrEmpty(Set500.Text) == true || String.IsNullOrEmpty(Set710.Text) == true)
                MessageBox.Show("Non hai inserito ancora tutti i numeri !", "Errore");
            else
            {
                Val710 = Convert.ToDouble(Set710.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                D710 = Val710 - 452.61d;
                
                Val500 = Convert.ToDouble(Set500.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                D500 = Val500 - 422.31d;
                
                Val425 = Convert.ToDouble(Set425.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                D425 = Val425 - 416.87d;

                Val300 = Convert.ToDouble(Set300.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                D300 = Val300 - 398.38d;
                
                Val212 = Convert.ToDouble(Set212.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                D212 = Val212 - 392.64d;
                
                Val150 = Convert.ToDouble(Set150.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                D150 = Val150 - 387.27d;
                
                Val0 = Convert.ToDouble(Set0.Text.Replace(",", nfi.NumberDecimalSeparator), nfi);
                D0 = Val0 - 411.36d;

                if (D710 < 0.00 || D710 < 0.00 || D500 < 0.00 || D425 < 0.00 || D300 < 0.00 || D212 < 0.00 || D150 < 0.00 || D0 < 0.00)
                {
                    MessageBox.Show("Attenzione, peso minore rispetto a quello originale", "Errore");
                }
                else
                {
                    if (D710 > 100 || D710 > 100 || D500 > 100 || D425 > 100 || D300 > 100 || D212 > 100 || D150 > 100 || D0 > 100)
                        MessageBox.Show("Sicuro di avere inserito i valori giusti ? Uno dei setacci ha un valore troppo alto di peso lordo", "Errore");
                    else
                    {
                        Dif710.Text = D710.ToString("#0.00");
                        Dif500.Text = D500.ToString("#0.00");
                        Dif425.Text = D425.ToString("#0.00");
                        Dif300.Text = D300.ToString("#0.00");
                        Dif212.Text = D212.ToString("#0.00");
                        Dif150.Text = D150.ToString("#0.00");
                        Dif0.Text = D0.ToString("#0.00");
                        somma = D0 + D150 + D212 + D300 + D425 + D500 + D710;
                        Tot.Text = somma.ToString("#0.00");                   
                    }                    
                }
            }
        }

        private void Algoritmo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Dif0.Text) == true)
                MessageBox.Show("Non hai ancora calcolato la differenza !", "Errore");
            else
            {
                Fin0 = D0;
                Fin150 = D150;
                Fin212 = D212;
                Fin300 = D300;
                Fin425 = D425;
                Fin500 = D500;
                Fin710 = D710;
                sommatemp = somma;

                if (sommatemp>100)                
                    while (sommatemp > 100.00) //Algoritmo, se somma è maggiore di 100.00
                    {
                        if (Fin300 > 0.00d)
                        {
                            sommatemp -= Fin300;
                            Fin300 -= 0.001d;
                            sommatemp += Fin300;

                            if (sommatemp <= 100)
                                break;
                        }

                        if (Fin212 > 0.00d)
                        {
                            sommatemp -= Fin212;
                            Fin212 -= 0.001d;
                            sommatemp += Fin212;

                            if (sommatemp <= 100)
                                break;
                        }

                        if (Fin425 > 0.00d)
                        {
                            sommatemp -= Fin425;
                            Fin425 -= 0.001d;
                            sommatemp += Fin425;

                            if (sommatemp <= 100)
                                break;
                        }

                        if (Fin150 > 0.00d)
                        {
                            sommatemp -= Fin150;
                            Fin150 -= 0.001d;
                            sommatemp += Fin150;

                            if (sommatemp <= 100)
                                break;
                        }

                        if (Fin500 > 0.00d)
                        {
                            sommatemp -= D500;
                            Fin500 -= 0.001d;
                            sommatemp += Fin500;

                            if (sommatemp <= 100)
                                break;
                        }

                        if (Fin0 > 0.00d)
                        {
                            sommatemp -= Fin0;
                            Fin0 -= 0.001d;
                            sommatemp += Fin0;

                            if (sommatemp <= 100)
                                break;
                        }

                        if (Fin710 > 0.00d)
                        {
                            sommatemp -= Fin710;
                            Fin710 -= 0.001d;
                            sommatemp += Fin710;

                            if (sommatemp <= 100)
                                break;
                        }
                    }
                else
                    while (sommatemp < 100.00) //Algoritmo, se somma è minore di 100.00
                {
                        if (Fin300 > 0.00d)
                        {
                            sommatemp -= Fin300;
                            Fin300 += 0.001d;
                            sommatemp += Fin300;

                            if (sommatemp >= 100)
                                break;
                        }

                        if (Fin212 > 0.00d)
                        {
                            sommatemp -= Fin212;
                            Fin212 += 0.001d;
                            sommatemp += Fin212;

                            if (sommatemp >= 100)
                                break;
                        }

                        if (Fin425 > 0.00d)
                        {
                            sommatemp -= Fin425;
                            Fin425 += 0.001d;
                            sommatemp += Fin425;

                            if (sommatemp >= 100)
                                break;
                        }

                        if (Fin150 > 0.00d)
                        {
                            sommatemp -= Fin150;
                            Fin150 += 0.001d;
                            sommatemp += Fin150;

                            if (sommatemp >= 100)
                                break;
                        }

                        if (Fin500 > 0.00d)
                        {
                            sommatemp -= Fin500;
                            Fin500 += 0.001d;
                            sommatemp += Fin500;

                            if (sommatemp >= 100)
                                break;
                        }

                        if (Fin0 > 0.00d)
                        {
                            sommatemp -= Fin0;
                            Fin0 += 0.001d;
                            sommatemp += Fin0;

                            if (sommatemp >= 100)
                                break;
                        }

                        if (Fin710 > 0.00d)
                        {
                            sommatemp -= Fin710;
                            Fin710 += 0.001d;
                            sommatemp += Fin710;

                            if (sommatemp >= 100)
                                break;
                        }

                    }

                SomTemp.Text = sommatemp.ToString("#0.00");
                F0.Text = Fin0.ToString("#0.00");
                F150.Text = Fin150.ToString("#0.00");
                F212.Text = Fin212.ToString("#0.00");
                F300.Text = Fin300.ToString("#0.00");
                F425.Text = Fin425.ToString("#0.00");
                F500.Text = Fin500.ToString("#0.00");
                F710.Text = Fin710.ToString("#0.00");
            }
        }
    }
}
