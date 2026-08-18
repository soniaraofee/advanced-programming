using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverters
{
    public partial class UnitConverters : Form
    {
        private bool isUpdating = false;
        private string[] allUnitsFrom = new string[] { };
        private string[] allUnitsTo = new string[] { };
        private List<string> currentToItemsFull = new List<string>();
        // Initialize the application with the default category and UI theme.
        public UnitConverters()
        {
            InitializeComponent();



            tabControl1_SelectedIndexChanged(null, null);

            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.FlatAppearance.BorderSize = 0;

            ApplyTheme();

        }

        // Render tab headers manually to support a custom appearance in both themes.
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color activeBg, inactiveBg, activeText, inactiveText;

            if (isDarkMode)
            {
                activeBg = ColorTranslator.FromHtml("#334155");
                inactiveBg = ColorTranslator.FromHtml("#1E293B");
                activeText = ColorTranslator.FromHtml("#F1F5F9");
                inactiveText = ColorTranslator.FromHtml("#94A3B8");
            }
            else
            {
                activeBg = ColorTranslator.FromHtml("#F1F5F9");
                inactiveBg = ColorTranslator.FromHtml("#334155");
                activeText = ColorTranslator.FromHtml("#1E293B");
                inactiveText = Color.White;
            }

            Graphics g = e.Graphics;
            Rectangle tabRect = tabControl1.GetTabRect(e.Index);

            Color backgroundColor;
            Color textColor;

            if (e.State == DrawItemState.Selected)
            {
                backgroundColor = activeBg;
                textColor = activeText;
            }
            else
            {
                backgroundColor = inactiveBg;
                textColor = inactiveText;
            }

            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                g.FillRectangle(brush, tabRect);
            }

            Font tabFont = new Font(tabControl1.Font, FontStyle.Bold);
            TextRenderer.DrawText(g, tabControl1.TabPages[e.Index].Text, tabFont, tabRect, textColor,
                                  TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            using (Pen pen = new Pen(isDarkMode ? ColorTranslator.FromHtml("#475569") : Color.Gray))
            {
                g.DrawRectangle(pen, tabRect);
            }
        }
        // Reload the available units whenever the selected measurement category changes.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchFrom.Text = "";
            txtSearchTo.Text = "";

            isUpdating = true;

            lstFrom.Items.Clear();
            lstTo.Items.Clear();

            string[] units;

            // Each category defines its own set of supported units.
            switch (tabControl1.SelectedTab.Text)
            {
                case "Length":
                    units = new string[] { "Meter", "Kilometer", "Centimeter", "Millimeter", "Micrometer", "Nanometer", "Mile", "Yard", "Foot", "Inch", "Light Year" };
                    break;
                case "Temperature":
                    units = new string[] { "Celsius", "Kelvin", "Fahrenheit" };
                    break;
                case "Area":
                    units = new string[] { "Square Meter", "Square Kilometer", "Square Centimeter", "Square Milimeter", "Square Micrometer", "Hectare", "Square Mile", "Square Yard", "Square Foot", "Square Inch", "Acre" };
                    break;
                case "Volume":
                    units = new string[] { "Cubic Meter", "Cubic Kilometer", "Cubic Centimeter", "Cubic Milimeter", "Liter", "Mililiter", "US Gallon", "US Quart", "US Pint", "US Cup", "US Fluid Ounce", "US Table Spoon", "US Tea Spoon", "Imerial Gallon", "Imerial Quart", "Imerial Pint", "Imerial Fluid Ounce", "Imerial Table Spoon", "Imerial Tea Spoon", "Cubic Mile", "Cubic Yard", "Cubic Foot", "Cubic Inch" };
                    break;
                case "Weight":
                    units = new string[] { "Kilogram", "Gram", "Milligram", "Metric Ton", "Long Ton", "Short Ton", "Pound", "Ounce", "Carrat", "Atomic Mass Unit" };
                    break;
                case "Time":
                    units = new string[] { "Second", "Milisecond", "Microsecond", "Nanosecond", "Picosecond", "Minute", "Hour", "Day", "Week", "Month", "Year" };
                    break;
                default:
                    units = new string[] { };
                    break;
            }

            lstFrom.Items.AddRange(units);
            lstTo.Items.AddRange(units);
            allUnitsFrom = units;
            allUnitsTo = units;
            // Select default units to provide an immediate conversion when the category loads.
            if (lstFrom.Items.Count > 0)
                lstFrom.SelectedIndex = 0;

            if (lstTo.Items.Count > 1)
                lstTo.SelectedIndex = 1;
            else if (lstTo.Items.Count > 0)
                lstTo.SelectedIndex = 0;

            isUpdating = false;

            PerformConversion();
        }
        // Perform the initial conversion after updating the available units.
        // Recalculate all conversion results whenever the input or selected unit changes.
        private void PerformConversion()
        {
            // Prevent recursive updates while controls are being refreshed.
            if (isUpdating) return;

            double val;
            // Invalid numeric input is treated as zero to keep the interface responsive.
            double.TryParse(txtFrom.Text, out val);

            if (lstFrom.SelectedItem == null)
            {
                isUpdating = true;
                lstTo.Items.Clear();
                isUpdating = false;

                txtTo.Text = "";
                lblResult.Text = "";
                return;
            }

            string category = tabControl1.SelectedTab.Text;
            string fromUnit = lstFrom.SelectedItem.ToString();

            string[] units = new string[] { };
            double[] factors = new double[] { };

            // Conversion factors are stored relative to a single base unit for each category.
            switch (category)
            {
                case "Length":
                    units = new string[] { "Meter", "Kilometer", "Centimeter", "Millimeter", "Micrometer", "Nanometer", "Mile", "Yard", "Foot", "Inch", "Light Year" };
                    factors = new double[] { 1, 1000, 0.01, 0.001, 1e-6, 1e-9, 1609.34, 0.9144, 0.3048, 0.0254, 9.46073e15 };
                    break;

                case "Area":
                    units = new string[] { "Square Meter", "Square Kilometer", "Square Centimeter", "Square Milimeter", "Square Micrometer", "Hectare", "Square Mile", "Square Yard", "Square Foot", "Square Inch", "Acre" };
                    factors = new double[] { 1, 1e6, 0.0001, 1e-6, 1e-12, 10000, 2589988.11, 0.836127, 0.092903, 0.00064516, 4046.86 };
                    break;

                case "Volume":
                    units = new string[] { "Cubic Meter", "Cubic Kilometer", "Cubic Centimeter", "Cubic Milimeter", "Liter", "Mililiter", "US Gallon", "US Quart", "US Pint", "US Cup", "US Fluid Ounce", "US Table Spoon", "US Tea Spoon", "Imerial Gallon", "Imerial Quart", "Imerial Pint", "Imerial Fluid Ounce", "Imerial Table Spoon", "Imerial Tea Spoon", "Cubic Mile", "Cubic Yard", "Cubic Foot", "Cubic Inch" };
                    factors = new double[] { 1000, 1e12, 0.001, 1e-6, 1, 0.001, 3.78541, 0.946353, 0.473176, 0.236588, 0.0295735, 0.0147868, 0.00492892, 4.54609, 1.13652, 0.568261, 0.0284131, 0.0177582, 0.00591939, 4.168e12, 764.555, 28.3168, 0.0163871 };
                    break;

                case "Weight":
                    units = new string[] { "Kilogram", "Gram", "Milligram", "Metric Ton", "Long Ton", "Short Ton", "Pound", "Ounce", "Carrat", "Atomic Mass Unit" };
                    factors = new double[] { 1, 0.001, 1e-6, 1000, 1016.05, 907.185, 0.453592, 0.0283495, 0.0002, 1.660539e-27 };
                    break;

                case "Time":
                    units = new string[] { "Second", "Milisecond", "Microsecond", "Nanosecond", "Picosecond", "Minute", "Hour", "Day", "Week", "Month", "Year" };
                    factors = new double[] { 1, 0.001, 1e-6, 1e-9, 1e-12, 60, 3600, 86400, 604800, 2628000, 31536000 };
                    break;

                case "Temperature":
                    units = new string[] { "Celsius", "Kelvin", "Fahrenheit" };
                    break;
            }

            int fromIdx = Array.IndexOf(units, fromUnit);
            if (fromIdx == -1) return;

            // Keep the previously selected unit.
            string selectedTargetUnit = "";
            if (lstTo.SelectedItem != null)
            {
                string oldItem = lstTo.SelectedItem.ToString();
                int p = oldItem.IndexOf('(');
                if (p > 0)
                    selectedTargetUnit = oldItem.Substring(0, p).Trim();
            }

            isUpdating = true;

            lstTo.Items.Clear();

            foreach (string targetUnit in units)
            {
                double convertedVal = 0;
                // Temperature conversions require dedicated formulas because they are not based on fixed ratios.
                if (category == "Temperature")
                {
                    double c = 0;

                    if (fromUnit == "Celsius")
                        c = val;
                    else if (fromUnit == "Kelvin")
                        c = val - 273.15;
                    else if (fromUnit == "Fahrenheit")
                        c = (val - 32) * 5 / 9;

                    if (targetUnit == "Celsius")
                        convertedVal = c;
                    else if (targetUnit == "Kelvin")
                        convertedVal = c + 273.15;
                    else if (targetUnit == "Fahrenheit")
                        convertedVal = (c * 9 / 5) + 32;
                }
                else
                {
                    int toIdx = Array.IndexOf(units, targetUnit);
                    // Convert the input value to the base unit before converting it to the target unit.
                    double baseValue = val * factors[fromIdx];
                    convertedVal = baseValue / factors[toIdx];
                }

                lstTo.Items.Add(string.Format("{0} ({1})", targetUnit, convertedVal.ToString("G10")));
               
            }
            // Store every calculated result so the destination list can be filtered without recalculation.
            currentToItemsFull.Clear();

            foreach (string item in lstTo.Items)
            {
                currentToItemsFull.Add(item);
            }

            if (lstTo.Items.Count > 0)
            {
                int indexToSelect = 0;

                if (selectedTargetUnit != "")
                {
                    for (int i = 0; i < lstTo.Items.Count; i++)
                    {
                        string item = lstTo.Items[i].ToString();
                        int p = item.IndexOf('(');
                        string unitName;

                        if (p > 0)
                        {
                            unitName = item.Substring(0, p).Trim();
                        }
                        else
                        {
                            unitName = item;
                        }

                        if (unitName == selectedTargetUnit)
                        {
                            indexToSelect = i;
                            break;
                        }
                    }
                }
                else
                {
                    if (lstTo.Items.Count > 1)
                        indexToSelect = 1;
                }

                lstTo.SelectedIndex = indexToSelect;
            }

            isUpdating = false;

            UpdateResultDisplay();
        }
        // Update the displayed output after all calculations have been completed.
        // Display only the conversion selected by the user.
        private void UpdateResultDisplay()
        {
            double val;
            if (!double.TryParse(txtFrom.Text, out val))
            {
                txtTo.Text = "";
                lblResult.Text = "";
                return;
            }
            // Ignore incomplete selections until both units are available.
            if (lstFrom.SelectedItem == null || lstTo.SelectedItem == null)
            {
                txtTo.Text = "";
                lblResult.Text = "";
                return;
            }

            string fromUnit = lstFrom.SelectedItem.ToString();
            string selectedItem = lstTo.SelectedItem.ToString();
            // Extract the converted value from the formatted list item.
            int start = selectedItem.IndexOf('(');
            int end = selectedItem.LastIndexOf(')');
            if (start == -1 || end == -1 || end <= start)
            {
                txtTo.Text = "";
                lblResult.Text = "";
                return;
            }

            string resultUnit = selectedItem.Substring(0, start).Trim();
            string resultValue = selectedItem.Substring(start + 1, end - start - 1).Trim();

            txtTo.Text = resultValue;
            lblResult.Text = string.Format("Result: {0} {1} = {2} {3}",
                                          val.ToString("G10"), fromUnit, resultValue, resultUnit);
        }
        // Provide instant feedback by updating the conversion as the user types.
        private void txtFrom_TextChanged(object sender, EventArgs e)
        {
            PerformConversion();

        }
        // Refresh the conversion after selecting a different source unit.
        private void lstFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformConversion();

        }
        // Update only the displayed result without recalculating all conversions.
        private void lstTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;
            UpdateResultDisplay();
        }

        private void lblTo_Click(object sender, EventArgs e)
        {

        }
        // Copy the converted value to the clipboard and briefly notify the user.
        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTo.Text))
                return;

            Clipboard.SetText(txtTo.Text);
            // Preserve the original button appearance before showing temporary feedback.
            string originalText = btnCopy.Text;
            var originalColor = btnCopy.BackColor;

            if (isDarkMode)
            {
                btnCopy.BackColor = ColorTranslator.FromHtml("#334155");
            }
            else
            {
                btnCopy.BackColor = ColorTranslator.FromHtml("#94A3B8");
            }

            btnCopy.Text = "Copied!";
            // Restore the button state after a short delay.
            await Task.Delay(1000);

            btnCopy.BackColor = originalColor;
            btnCopy.Text = originalText;
        }


        // Filter the available units while preserving the original data.
        private void FilterList(ListBox listBox, string[] sourceUnits, string searchText)
        {
            isUpdating = true;

            listBox.Items.Clear();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                foreach (string item in sourceUnits)
                {
                    listBox.Items.Add(item);
                }
            }
            else
            {
                List<string> filtered = new List<string>();

                foreach (string item in sourceUnits)
                {
                    if (item.ToLower().Contains(searchText.ToLower()))
                    {
                        filtered.Add(item);
                    }
                }

                foreach (string item in filtered)
                {
                    listBox.Items.Add(item);
                }
            }

            if (listBox.Items.Count > 0)
                listBox.SelectedIndex = 0;

            isUpdating = false;
        }

        private void txtSearchFrom_TextChanged(object sender, EventArgs e)
        {
            FilterList(lstFrom, allUnitsFrom, txtSearchFrom.Text);
            // Refresh the results after filtering the source unit list.
            PerformConversion();
        }
        // Filter only the displayed results without affecting the calculated values.
        private void txtSearchTo_TextChanged(object sender, EventArgs e)
        {
           FilterList(lstTo, currentToItemsFull.ToArray(), txtSearchTo.Text);
           UpdateResultDisplay();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {

        }
        // Locate a target unit by its name after rebuilding the destination list.
        private void SetToSelection(string unitName)
        {
            for (int i = 0; i < lstTo.Items.Count; i++)
            {
                string item = lstTo.Items[i].ToString();
                int p = item.IndexOf('(');
                string name;

                if (p > 0)
                {
                    name = item.Substring(0, p).Trim();
                }
                else
                {
                    name = item;
                }

                if (name == unitName)
                {
                    lstTo.SelectedIndex = i;
                    break;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Reverse the conversion direction while preserving the converted value.
        private void btnSwap_Click_1(object sender, EventArgs e)
        {
            if (lstFrom.SelectedItem == null || lstTo.SelectedItem == null)
                return;


            string fromUnit = lstFrom.SelectedItem.ToString();


            string toItemFull = lstTo.SelectedItem.ToString();
            string toUnit = toItemFull;

            int p = toItemFull.IndexOf('(');
            if (p > 0)
                toUnit = toItemFull.Substring(0, p).Trim();


            string newFromValue = txtTo.Text;

            isUpdating = true;

            txtSearchFrom.Text = "";
            txtSearchTo.Text = "";

            isUpdating = false;


            int newFromIndex = lstFrom.Items.IndexOf(toUnit);
            lstFrom.SelectedIndex = newFromIndex;


            txtFrom.Text = newFromValue;

            SetToSelection(fromUnit);
        }
        // Switch between light and dark themes.
        private void btnTheme_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;
            ApplyTheme();
        }
        private bool isDarkMode = false;
        // Apply a consistent color scheme to every control in the interface.
        private void ApplyTheme()
        {
            // Configure colors and styles for the dark theme.
            if (isDarkMode)
            {
                Color bgMain = ColorTranslator.FromHtml("#0F172A");
                Color bgControl = ColorTranslator.FromHtml("#1E293B");
                Color borderColor = ColorTranslator.FromHtml("#334155");
                Color textColor = ColorTranslator.FromHtml("#CBD5E1");

                this.BackColor = bgMain;
                panel1.BackColor = bgMain;

                lblFrom.ForeColor = textColor;
                lblFrom.BackColor = bgMain;

                lblTo.ForeColor = textColor;
                lblTo.BackColor = bgMain;

                lblSearchFrom.ForeColor = textColor;
                lblSearchFrom.BackColor = bgMain;

                lblSearchTo.ForeColor = textColor;
                lblSearchTo.BackColor = bgMain;

                txtFrom.BackColor = bgControl;
                txtFrom.ForeColor = textColor;

                txtTo.BackColor = bgControl;
                txtTo.ForeColor = textColor;

                txtSearchFrom.BackColor = bgControl;
                txtSearchFrom.ForeColor = textColor;

                txtSearchTo.BackColor = bgControl;
                txtSearchTo.ForeColor = textColor;

                lstFrom.BackColor = bgControl;
                lstFrom.ForeColor = textColor;

                lstTo.BackColor = bgControl;
                lstTo.ForeColor = textColor;

                lblResult.BackColor = bgMain;
                lblResult.ForeColor = textColor;

                btnTheme.Text = "☀️";
                btnTheme.BackColor = bgControl;
                btnTheme.ForeColor = textColor;
                btnTheme.FlatStyle = FlatStyle.Flat;
                btnTheme.FlatAppearance.BorderColor = borderColor;


                btnSwap.BackColor = ColorTranslator.FromHtml("#334155");
                btnSwap.ForeColor = ColorTranslator.FromHtml("#F1F5F9");
                btnSwap.FlatStyle = FlatStyle.Flat;
                btnSwap.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#475569");


                btnCopy.BackColor = ColorTranslator.FromHtml("#334155");
                btnCopy.ForeColor = Color.White;
            }
            // Restore the default appearance for the light theme.
            else
            {
                Color bgMain = ColorTranslator.FromHtml("#F8FAFC");
                Color bgControl = Color.White;
                Color borderColor = ColorTranslator.FromHtml("#E2E8F0");
                Color textColor = ColorTranslator.FromHtml("#334155");

                this.BackColor = bgMain;
                panel1.BackColor = bgMain;

                lblFrom.ForeColor = textColor;
                lblFrom.BackColor = bgMain;

                lblTo.ForeColor = textColor;
                lblTo.BackColor = bgMain;

                lblSearchFrom.ForeColor = textColor;
                lblSearchFrom.BackColor = bgMain;

                lblSearchTo.ForeColor = textColor;
                lblSearchTo.BackColor = bgMain;

                txtFrom.BackColor = bgControl;
                txtFrom.ForeColor = textColor;

                txtTo.BackColor = ColorTranslator.FromHtml("#F1F5F9");
                txtTo.ForeColor = textColor;

                txtSearchFrom.BackColor = bgControl;
                txtSearchFrom.ForeColor = textColor;

                txtSearchTo.BackColor = bgControl;
                txtSearchTo.ForeColor = textColor;

                lstFrom.BackColor = bgControl;
                lstFrom.ForeColor = textColor;

                lstTo.BackColor = bgControl;
                lstTo.ForeColor = textColor;

                lblResult.BackColor = bgMain;
                lblResult.ForeColor = textColor;


                btnTheme.Text = "🌙";
                btnTheme.BackColor = bgControl;
                btnTheme.ForeColor = textColor;
                btnTheme.FlatStyle = FlatStyle.Flat;
                btnTheme.FlatAppearance.BorderColor = borderColor;



                btnSwap.BackColor = ColorTranslator.FromHtml("#E2E8F0");
                btnSwap.ForeColor = ColorTranslator.FromHtml("#334155");
                btnSwap.FlatStyle = FlatStyle.Flat;
                btnSwap.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#CBD5E1");

                btnCopy.BackColor = ColorTranslator.FromHtml("#E2E8F0");
                btnCopy.ForeColor = ColorTranslator.FromHtml("#334155");
            }

            tabControl1.Invalidate();
        }


    }
}
