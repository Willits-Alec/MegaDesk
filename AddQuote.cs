using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Willits
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        public class Desk
        {
            // Properties to store desk information
            public decimal Width { get; set; }
            public decimal Depth { get; set; }
            public int NumberOfDrawers { get; set; }
            public string WoodType { get; set; }
            public decimal CalculatedCost { get; private set; }
            public decimal RushOrderCost { get; set; }

            // Constructor to initialize the desk object with width, depth, drawers, and wood type
            public Desk(decimal width, decimal depth, int numberOfDrawers, string woodType)
            {
                Width = width;
                Depth = depth;
                NumberOfDrawers = numberOfDrawers;
                WoodType = woodType;

                // Calculate the cost upon object creation
                CalculateCost();
            }

            // Calculate the desk cost based on its attributes
            private void CalculateCost()
            {

                // Calculate surface area of the desktop
                decimal surfaceArea = Width * Depth;

                // Calculate the cost based on surface area
                decimal surfaceAreaCost = surfaceArea > 1000 ? surfaceArea * 1 : 0;

                // Add your calculation logic here based on Width, Depth, NumberOfDrawers, and WoodType
                // For example, a simple calculation could be:
                decimal baseCost = 200; // Base cost for the desk
                decimal drawerCost = NumberOfDrawers * 50; // $50 per drawer
                decimal woodTypeCost = GetWoodTypeCost(WoodType); // Get cost based on wood type
                decimal orderCost = GetOrderCost(RushOrderCost); // Get cost based on type of order


                CalculatedCost = baseCost + drawerCost + woodTypeCost + surfaceAreaCost;
            }

            private decimal GetOrderCost(decimal RushOrderCost)
            {
                
                return RushOrderCost;
            }

            // Get the cost based on the selected wood type
            private decimal GetWoodTypeCost(string woodType)
            {
                // Get the cost based on the selected wood type
                switch (woodType)
                {
                    case "Laminate":
                        return 100; // Cost for Laminate
                    case "Oak":
                        return 200; // Cost for Oak
                    case "Rosewood":
                        return 300; // Cost for Rosewood
                    case "Veneer":
                        return 125; // Cost for Veneer
                    case "Pine":
                        return 50; // Cost for Pine
                    default:
                        return 0;
                }
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenue = (MainMenu)Tag;
            viewMainMenue.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SurfaceMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWoodType = SurfaceMaterials.SelectedItem.ToString();

            // Handle the logic based on the selected wood type
            switch (selectedWoodType)
            {
                case "Laminate":
                    //MessageBox.Show("You selected Laminate wood.");
                    // Code for laminate wood type
                    break;
                case "Oak":
                    //MessageBox.Show("You selected Oak wood.");
                    // Code for oak wood type
                    break;
                case "Rosewood":
                   //MessageBox.Show("You selected Rosewood.");
                    // Code for rosewood wood type
                    break;
                case "Veneer":
                    //MessageBox.Show("You selected Veneer wood.");
                    // Code for veneer wood type
                    break;
                case "Pine":
                    //MessageBox.Show("You selected Pine wood.");
                    // Code for pine wood type
                    break;
                default:
                    MessageBox.Show("Unknown wood type selected.");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Get data from customer information textboxes
            string firstName = CustomerFirstName.Text;
            string lastName = CustomerLastName.Text;

            //Get selected wood type
            string selectedWoodType = SurfaceMaterials.SelectedItem.ToString();

            //Validate input
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(selectedWoodType))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any required field is empty
            }
            
        }

        private void CalculateCost_Click_1(object sender, EventArgs e)
        {
            // Parse input values from textboxes
            if (decimal.TryParse(width.Text, out decimal widthValue) && decimal.TryParse(depth.Text, out decimal depthValue) && int.TryParse(DrawerCount.Text, out int numberOfDrawers) && SurfaceMaterials.SelectedItem != null)
            {
                string selectedWoodType = SurfaceMaterials.SelectedItem.ToString();

                // Calculate surface area
                decimal surfaceArea = widthValue * depthValue;

                // Calculate surface area cost (if surface area > 1000, charge $1 per square inch)
                decimal surfaceAreaCost = surfaceArea > 1000 ? surfaceArea * 1 : 0;

                // Calculate drawer cost
                decimal drawerCost = numberOfDrawers * 50;

                // Calculate wood type cost based on the selected wood type
                decimal woodTypeCost = 0;
                switch (selectedWoodType)
                {
                    case "Oak":
                        woodTypeCost = 200;
                        break;
                    case "Laminate":
                        woodTypeCost = 100;
                        break;
                    case "Pine":
                        woodTypeCost = 50;
                        break;
                    case "Rosewood":
                        woodTypeCost = 300;
                        break;
                    case "Veneer":
                        woodTypeCost = 125;
                        break;
                }

                // Calculate total cost without rush order
                decimal totalCostWithoutRushOrder = 200 + drawerCost + woodTypeCost + surfaceAreaCost;




                // Determine rush order duration and cost based on selected radio button
                int rushOrderDays = 0;
                decimal rushOrderCost = 0;


                if (standard.Checked)
                {
                    // Standard delivery (no rush)
                    rushOrderDays = 14; // Standard delivery duration
                    rushOrderCost = 0;  // No rush order cost
                }
                else if (rushFast.Checked)
                {
                    // Rush Fast delivery (7 days)
                    rushOrderDays = 7;
                    rushOrderCost = 10;
                }
                else if (rushFaster.Checked)
                {
                    // Rush Faster delivery (5 days)
                    rushOrderDays = 5;
                    rushOrderCost = 20;
                }
                else if (rushFastest.Checked)
                {
                    // Rush Fastest delivery (3 days)
                    rushOrderDays = 3;
                    rushOrderCost = 30;
                }
                else
                {
                    MessageBox.Show("Please select a delivery option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                // calculate total cost
                decimal totalCost = totalCostWithoutRushOrder + rushOrderCost;

                if (totalCost < 1000)
                {
                    switch (rushOrderDays)
                    {
                        case 3:
                            rushOrderCost = 80;
                            break;
                        case 5:
                            rushOrderCost = 60;
                            break;
                        case 7:
                            rushOrderCost = 40;
                            break;

                    }
                    
                }
                else if (totalCost >= 1000 && totalCost <= 2000)
                {
                    switch (rushOrderDays)
                    {
                        case 3:
                            rushOrderCost = 90;
                            break;
                        case 5:
                            rushOrderCost = 70;
                            break;
                        case 7:
                            rushOrderCost = 50;
                            break;
                    }
                    
                }
                else if (totalCost > 2000)
                {
                    switch (rushOrderDays)
                    {
                        case 3:
                            rushOrderCost = 100;
                            break;
                        case 5:
                            rushOrderCost = 80;
                            break;
                        case 7:
                            rushOrderCost = 60;
                            break;
                    }
                    

                }



                // Get rush order cost (you need to provide the rush order cost logic)



                // Calculate total cost
                totalCost = 200 + drawerCost + woodTypeCost + surfaceAreaCost + rushOrderCost;

                // Display the calculated cost in the label
                calculatedCostLabel.Text = $"Total Cost: ${totalCost}";
            }
            else
            {
                MessageBox.Show("Please enter valid values for width, depth, drawers, and wood type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        


        private void width_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DrawerCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
