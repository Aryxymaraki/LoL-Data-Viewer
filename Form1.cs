using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace LoL_Data_Viewer
{
    public partial class Form1 : Form
    {
        System.IO.StreamReader reader;
        string[] headers;
        string line;
        int filterBoxes;
        string[] filterTypes;
        string[] filterValues;

        public Form1()
        {
            InitializeComponent();
            reader = new System.IO.StreamReader(Application.StartupPath + "/Data/Data.csv");
            line = "";
            line = reader.ReadLine();
            //First thing that needs to be done: Identify the column headers.
            //The first line in the file is the column headers.
            //I currently have the first line read into line.  So all I need to do now is split it by commas and add it to headers.
            headers = line.Split(',');
            filterBox1.Items.AddRange(headers);
            filterBox1.Items.Add("");
            filterBoxes = 1;
            filterTypes = new string[] { "=", ">", "<", ">=", "<=" };

            filterBox1Filter.Items.AddRange(filterTypes);

            filterValues = new string[] { "True", "False" };
            filterBox1FilterValue.Items.AddRange(filterValues);

            for (int i = 0; i < headers.Count(); i++)
            {
                championOutputView.Columns.Add("Column", headers[i]);
            }

            reader.Close();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            //When the Go button is hit, check all filters.  Is there a way to use reflection to figure out how many filter boxes are
            //around or in use?
            //Mow through the file adding each champion's name to an arraylist when they hit the filter.
            //For now, only supports one filter, let's do it this way.
            List <string> champions = new List<string>();
            List<List<string>> finalReturn = new List<List<string>>();

            //Clear the data view so I'm not viewing all previous usages added together
            championOutputView.Rows.Clear();

            //Now I need to repeat that for each filter which is active.
            //Champions can become an arraylist of arraylists.
            //This strikes me as the kind of thing that should really be a function.

            //I hate this.  There has to be a better way.
            if (filterBox1.SelectedIndex >= 0 && filterBox1.Text != "")
                finalReturn.Add(getChampions(filterBox1, filterBox1Filter.Text, filterBox1FilterValue.Text));
            if (filterBox2.SelectedIndex >= 0 && filterBox2.Text != "")
                finalReturn.Add(getChampions(filterBox2, filterBox2Filter.Text, filterBox2FilterValue.Text));
            if (filterBox3.SelectedIndex >= 0 && filterBox3.Text != "")
                finalReturn.Add(getChampions(filterBox3, filterBox3Filter.Text, filterBox3FilterValue.Text));
            if (filterBox4.SelectedIndex >= 0 && filterBox4.Text != "")
                finalReturn.Add(getChampions(filterBox4, filterBox4Filter.Text, filterBox4FilterValue.Text));
            if (filterBox5.SelectedIndex >= 0 && filterBox5.Text != "")
                finalReturn.Add(getChampions(filterBox5, filterBox5Filter.Text, filterBox5FilterValue.Text));
            if (filterBox6.SelectedIndex >= 0 && filterBox6.Text != "")
                finalReturn.Add(getChampions(filterBox6, filterBox6Filter.Text, filterBox6FilterValue.Text));

            //Now I need to and the lists together.
            //Begin with the very first list
            //Error handling in case the list doesn't actually exist
            if (finalReturn.Count > 0)
            {
                HashSet<string> hashSet = new HashSet<string>(finalReturn[0]);
                for (int i = 1; i < finalReturn.Count; i++)
                {
                    hashSet.IntersectWith(finalReturn[i]);
                }
                champions = hashSet.ToList();
            }

            //Need to now fill up the championsOutputView with the champion list.
            string[] temp;
            for (int i = 0; i < champions.Count; i++)
            {
                temp = champions[i].Split(',');
                championOutputView.Rows.Add(temp);
            }

            tabControl1.SelectTab(1);
        }

        private List<string> getChampions(ComboBox filter, string filterType, string filterValue)
        {
            //Needs to be passed the combobox set of filter, filter type, and filter value.
            List<string> returner = new List<string>();
            //First thing: I need to make sure I'm starting from the top of the file regardless of where I was in the program.
            reader = new System.IO.StreamReader(Application.StartupPath + "/Data/Data.csv");
            //Then I need to throw away the first line.
            reader.ReadLine();

            //Now I'm into the actual data.
            //Currently:  Only checks for boolean values. 
            //TODO: Add options for not, add options for greater than/less than
            //I now have boxes that tell me what the user wants.  Let's start with making true/false work.
            //Probably need a new function for this.  What we want to do is determine whether or not we should be adding the current champion to the list.
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                //Determine truthhood!
                try
                {
                    if (filterType == "=")
                    {
                        if (filterValue == "True")
                        {
                            if (System.Convert.ToInt32(line.Split(',')[filter.SelectedIndex]) == 1)
                            {
                                returner.Add(line);
                            }
                        }
                        else if (filterValue == "False")
                        {
                            if (System.Convert.ToInt32(line.Split(',')[filter.SelectedIndex]) == 0)
                            {
                                returner.Add(line);
                            }
                        }
                        else
                        {
                            if (line.Split(',')[filter.SelectedIndex] == filterValue)
                            {
                                returner.Add(line);
                            }
                        }
                    }
                    else if (filterType == ">")
                    {
                        if (System.Convert.ToDouble(line.Split(',')[filter.SelectedIndex]) > System.Convert.ToDouble(filterValue))
                        {
                            returner.Add(line);
                        }
                    }
                    else if (filterType == "<")
                    {
                        if (System.Convert.ToDouble(line.Split(',')[filter.SelectedIndex]) < System.Convert.ToDouble(filterValue))
                        {
                            returner.Add(line);
                        }
                    }
                    else if (filterType == ">=")
                    {
                        if (System.Convert.ToDouble(line.Split(',')[filter.SelectedIndex]) >= System.Convert.ToDouble(filterValue))
                        {
                            returner.Add(line);
                        }
                    }
                    else if (filterType == "<=")
                    {
                        if (System.Convert.ToDouble(line.Split(',')[filter.SelectedIndex]) <= System.Convert.ToDouble(filterValue))
                        {
                            returner.Add(line);
                        }
                    }
                }
                catch
                {
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(",*");
                    if (regex.IsMatch(line))
                    {
                        //Do nothing in this case; we found a line that has nothing but commas, it was blank in excel.
                    }
                    else 
                    returner.Add("Error: Failed to convert item.  Check that you entered the right kind of value!");
                }
            }
            return returner;
        }

        private void addFilterButton_Click(object sender, EventArgs e)
        {
            filterBoxes++;
            switch (filterBoxes)
            {
                case 0: break;
                case 1: break;
                case 2:
                    filterBox2.Enabled = true;
                    filterBox2.Visible = true;
                    filterBox2.Items.AddRange(headers);
                    filterBox2.Items.Add("");

                    filterBox2Filter.Enabled = true;
                    filterBox2Filter.Visible = true;
                    filterBox2Filter.Items.AddRange(filterTypes);

                    filterBox2FilterValue.Enabled = true;
                    filterBox2FilterValue.Visible = true;
                    filterBox2FilterValue.Items.AddRange(filterValues);
                    break;
                case 3:
                    filterBox3.Enabled = true;
                    filterBox3.Visible = true;
                    filterBox3.Items.AddRange(headers);
                    filterBox3.Items.Add("");

                    filterBox3Filter.Enabled = true;
                    filterBox3Filter.Visible = true;
                    filterBox3Filter.Items.AddRange(filterTypes);

                    filterBox3FilterValue.Enabled = true;
                    filterBox3FilterValue.Visible = true;
                    filterBox3FilterValue.Items.AddRange(filterValues);
                    break;
                case 4:
                    filterBox4.Enabled = true;
                    filterBox4.Visible = true;
                    filterBox4.Items.AddRange(headers);
                    filterBox4.Items.Add("");

                    filterBox4Filter.Enabled = true;
                    filterBox4Filter.Visible = true;
                    filterBox4Filter.Items.AddRange(filterTypes);

                    filterBox4FilterValue.Enabled = true;
                    filterBox4FilterValue.Visible = true;
                    filterBox4FilterValue.Items.AddRange(filterValues);
                    break;
                case 5:
                    filterBox5.Enabled = true;
                    filterBox5.Visible = true;
                    filterBox5.Items.AddRange(headers);
                    filterBox5.Items.Add("");

                    filterBox5Filter.Enabled = true;
                    filterBox5Filter.Visible = true;
                    filterBox5Filter.Items.AddRange(filterTypes);

                    filterBox5FilterValue.Enabled = true;
                    filterBox5FilterValue.Visible = true;
                    filterBox5FilterValue.Items.AddRange(filterValues);
                    break;
                case 6:
                    filterBox6.Enabled = true;
                    filterBox6.Visible = true;
                    filterBox6.Items.AddRange(headers);
                    filterBox6.Items.Add("");

                    filterBox6Filter.Enabled = true;
                    filterBox6Filter.Visible = true;
                    filterBox6Filter.Items.AddRange(filterTypes);

                    filterBox6FilterValue.Enabled = true;
                    filterBox6FilterValue.Visible = true;
                    filterBox6FilterValue.Items.AddRange(filterValues);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void filterBoxSelectedIndexChangedGeneric(ComboBox filterBox, ComboBox filterBoxFilter, ComboBox filterBoxFilterValue)
        {
            //if (filterBox.Text == "Range")
            //{
            //    filterBoxFilterValue.Items.Clear();
             //   filterBoxFilterValue.Items.AddRange(new string[] { "Ranged", "Melee" });
           // }
            if (filterBox.Text == "")
            {
                filterBoxFilter.SelectedIndex = -1;
                filterBoxFilterValue.SelectedIndex = -1;
                filterBoxFilterValue.Text = "";
            }
            /*else
            {
                filterBoxFilterValue.Items.Clear();
                filterBoxFilterValue.Items.AddRange(filterValues);
            }*/
        }

        private void filterBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterBoxSelectedIndexChangedGeneric(filterBox1, filterBox1Filter, filterBox1FilterValue);
        }

        private void filterBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterBoxSelectedIndexChangedGeneric(filterBox2, filterBox2Filter, filterBox2FilterValue);
        }

        private void filterBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterBoxSelectedIndexChangedGeneric(filterBox3, filterBox3Filter, filterBox3FilterValue);
        }

        private void filterBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterBoxSelectedIndexChangedGeneric(filterBox4, filterBox4Filter, filterBox4FilterValue);
        }

        private void filterBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterBoxSelectedIndexChangedGeneric(filterBox5, filterBox5Filter, filterBox5FilterValue);
        }

        private void filterBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterBoxSelectedIndexChangedGeneric(filterBox6, filterBox6Filter, filterBox6FilterValue);
        }


    }
}
