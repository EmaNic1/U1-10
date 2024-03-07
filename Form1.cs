using System;
using System.IO;
using System.Windows.Forms;
using static U1_10.Buses;

namespace U1_10
{
    public partial class Form1 : Form
    {
        //----------------------------------------
        //Constants
        const string PD1 = "Autobusai1.txt";
        const string PD2 = "Autobusai2.txt";
        const string RZ = "Rezultatai.txt";
        //----------------------------------------

        BusesK buses1 = new BusesK();
        string parkName1 = " ", streetName1 = " ";
        BusesK buses2 = new BusesK();
        string parkName2 = " ", streetName2 = " ";
        BusesK newList = new BusesK();

        public Form1()
        {
            InitializeComponent();
            enter.Enabled = true;
            print.Enabled = false;
            averageWork.Enabled = false;
            averageKM.Enabled = false;
            sortList.Enabled = false;
            find.Enabled = false;
            delete.Enabled = false;
            if(File.Exists(RZ))
                File.Delete(RZ);
        }

        /// <summary>
        /// Reads data from file
        /// </summary>
        /// <param name="fv">File name</param>
        /// <param name="parkName">Park name</param>
        /// <param name="streetName">Street name</param>
        /// <returns>Container with data</returns>
        static BusesK Read(string fv, out string parkName,
            out string streetName)
        {
            BusesK busesK = new BusesK();
            using (StreamReader reader = new StreamReader(fv))
            {
                string line;
                line = reader.ReadLine();
                string[] part = line.Split(';');
                parkName = part[0];
                streetName = part[1];
                while((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    string name = parts[0];
                    int experience = int.Parse(parts[1]);
                    BusType busType;
                    Enum.TryParse(parts[2], out busType);
                    int manufacture = int.Parse(parts[3]);
                    int space = int.Parse(parts[4]);
                    int driven = int.Parse(parts[5]);
                    Buses bus = new Buses(name, experience, busType, 
                        manufacture, space, driven);
                    busesK.AddMore(bus);
                }
            }
            return busesK;
        }

        /// <summary>
        /// Prints results from container to the results file
        /// </summary>
        /// <param name="fv">File name</param>
        /// <param name="busesK">Container name</param>
        /// <param name="heading">Table heading</param>
        /// <param name="parkName">Park name</param>
        /// <param name="streetName">Street name</param>
        static void Print(string fv, BusesK busesK, string heading,
            string parkName = "", string streetName= "")
        {
            const string top =
                "|----------------------------------------------------" +
                "-----------------------------------------------------" +
                "---------------------------------------|\r\n" +
                "| Nr.|        Vardas Pavarde        | Darbo stazas | " +
                "Autobusas/Mikroautobusas | Pagaminimo metai | Vietu skaicius" +
                " | Nuvaziuoti kilometrai(tukst.)|\r\n" +
                "|-----------------------------------------------------" +
                "------------------------------------------------------" +
                "-------------------------------------|";
            using (var fr = new StreamWriter(File.Open(fv, FileMode.Append)))
            {
                if (busesK.Take() != 0)
                {
                    fr.WriteLine("{0}", parkName);
                    fr.WriteLine("{0}", streetName);
                    fr.WriteLine(heading);
                    fr.WriteLine(top);
                    for (int i = 0; i < busesK.Take(); i++)
                        fr.WriteLine("|{0,3:d} {1}", i + 1, 
                            busesK.TakeBuses(i).ToString());
                    fr.WriteLine("|--------------------------------------------" +
                        "------------------------------------------------------" +
                        "----------------------------------------------|");
                    fr.WriteLine("");
                }
                else
                {
                    fr.WriteLine("Duomenu nera.");
                }
            }
        }

        /// <summary>
        /// Calculates average work experience
        /// </summary>
        /// <param name="busesK">Container name</param>
        /// <returns>Average</returns>
        static double AverageWorkExp(BusesK busesK)
        {
            double sum = 0;
            for(int i = 0; i < busesK.Take(); i++)
            {
                sum += busesK.TakeBuses(i).workExperience;
            }
            if(busesK.Take() != 0)
                return sum / busesK.Take();
            else
                return 0;
        }

        /// <summary>
        /// Calculates average driven km
        /// </summary>
        /// <param name="busesK">Container name</param>
        /// <returns>Average</returns>
        static double AverageKM(BusesK busesK)
        {
            double sum = 0;
            for (int i = 0; i < busesK.Take(); i++)
            {
                sum += busesK.TakeBuses(i).kmDriven;
            }
            if (busesK.Take() != 0)
                return sum / busesK.Take();
            else
                return 0;
        }

        /// <summary>
        /// Forms new list
        /// </summary>
        /// <param name="busesK">Conainer name</param>
        /// <param name="n">Age</param>
        /// <param name="newBusesK">New container name</param>
        static void NewList(BusesK busesK, int n, BusesK newBusesK)
        {
            for(int i = 0; i < busesK.Take(); i++)
            {
                if (n <= busesK.TakeBuses(i).manufacture)
                    newBusesK.AddMore(busesK.TakeBuses(i));
            }
        }

        /// <summary>
        /// Removes buses from the list
        /// </summary>
        /// <param name="busesK">Container name</param>
        /// <param name="x">Driven km</param>
        static void RemoveBuses(BusesK busesK, int x)
        {
            for(int i = 0; i < busesK.Take(); i++)
            {
                if(busesK.TakeBuses(i).kmDriven >= x)
                {
                    busesK.Remove(i);
                    i--;
                }
            }
        }

        //==================================================
        // GRAPHICAL INTERFACE
        //==================================================

        /// <summary>
        /// Enters data to the data window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enter_Click(object sender, EventArgs e)
        {
            string data1 = File.ReadAllText(PD1);
            string data2 = File.ReadAllText(PD2);
            data.Clear();
            data.Text = data1 + "\n\n" + data2 + "\n\n";
            buses1 = Read(PD1, out parkName1, out streetName1);
            buses2 = Read(PD2, out parkName2, out streetName2);
            enter.Enabled = false;
            print.Enabled = true;
        }

        /// <summary>
        /// Prints data in the data window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void print_Click(object sender, EventArgs e)
        {
            data.Clear();
            Print(RZ, buses1, "Autobusu/Mikroautobusu sarasas:", 
                parkName1, streetName1);
            Print(RZ, buses2, "Autobusu/Mikroautobusu sarasas:", 
                parkName2, streetName2);
            string rez = File.ReadAllText(RZ);
            data.Text += rez;
            print.Enabled = false;
            averageWork.Enabled = true;
        }


        /// <summary>
        /// Calculate average, and checks who has more expierence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void averageWork_Click(object sender, EventArgs e)
        {
            double average1 = AverageWorkExp(buses1);
            double average2 = AverageWorkExp(buses2);
            //Data is entered into a graphical interface
            if (average1 > 0 || average2 > 0)
            {
                if (average1 > average2)
                    aveWorkExpr.Text = parkName1 + ": " + average1 + " metai.";
                else if (average1 < average2)
                    aveWorkExpr.Text = parkName2 + ": " + average2 + " metai.";
                else
                    aveWorkExpr.Text = parkName1 + ": " + average1 + " metai."
                        + "\n" + parkName2 + ": " + average2 + " metai.";
            }
            else
                aveWorkExpr.Text = "Abieju parku patirtis = 0 metu.";
            //The data is entered into a results file
            using (var fr = new StreamWriter(File.Open(RZ, FileMode.Append)))
            {
                fr.WriteLine("Labiausiai patyrę vairuotojai:");
                if (average1 > 0 || average2 > 0)
                {
                    if (average1 > average2)
                        fr.WriteLine("{0}: {1,2:f2} metai.", parkName1, average1);
                    else if (average1 < average2)
                        fr.WriteLine("{0}: {1,2:f2} metai.", parkName2, average2);
                    else
                        fr.WriteLine("{0}: {1,2:f2} metai.\n" +
                            "{2}: {3,2:f2} metai.", parkName1, average1, 
                            parkName2, average2);
                }
                else
                    fr.WriteLine("Abieju parku patirtis = 0 metu.");
                fr.WriteLine("");
            }
            data.Text = File.ReadAllText(RZ);
            averageWork.Enabled = false;
            averageKM.Enabled = true;
        }

        /// <summary>
        /// Calculates average driven km and prints them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void averageKM_Click(object sender, EventArgs e)
        {
            double average1 = AverageKM(buses1);
            double average2 = AverageKM(buses2);
            //Data is entered into a graphical interface
            if (average1 > 0 || average2 > 0)
                aveKM.Text = parkName1 + ": " + average1 + " kilometrai.\n" +
                     parkName2 + ": " + average2 + " kilometrai/u.";
            else
                aveKM.Text = "Abieju parku autobusai/mikroautobusai\n" +
                    " nuvazevia 0 kilometru.";
            //The data is entered into a results file
            using (var fr = new StreamWriter(File.Open(RZ, FileMode.Append)))
            {
                fr.WriteLine("Nuvažiuotų kilometrų vidurkis(tūkst.):");
                if (average1 > 0 || average2 > 0)
                    fr.WriteLine("{0}: {1,2:f2} kilometrai/u.\n" +
                    "{2}: {3,2:f2} kilometrai/u.", parkName1, average1, 
                    parkName2, average2);
                else
                    fr.WriteLine("Abieju parku autobusai/mikroautobusai " +
                        "nuvazevia 0 kilometru.");
                fr.WriteLine(" ");
            }
            data.Text = File.ReadAllText(RZ);
            averageKM.Enabled = false;
            find.Enabled = true;
        }

        /// <summary>
        /// Prints new form list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void find_Click(object sender, EventArgs e)
        {
            int n = int.Parse(autoAge.Text);
            NewList(buses1, n, newList);
            NewList(buses2, n, newList);
            //The data is entered into a results file
            using (var fr = new StreamWriter(File.Open(RZ, FileMode.Append)))
            {
                fr.WriteLine("Ivesti autobusu/mikroautobusu pagaminimo metai:" +
                    " {0} metai.", n);
            }
            Print(RZ, newList, "Suformuotas sarasas:");
            data.Text = File.ReadAllText(RZ);
            find.Enabled = false;
            sortList.Enabled = true;
        }

        /// <summary>
        /// Sorts the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortList_Click(object sender, EventArgs e)
        {
            newList.Bubble();
            Print(RZ, newList, "Surikiuotas sarasas:");
            data.Text = File.ReadAllText(RZ);
            sortList.Enabled = false;
            delete.Enabled = true;
        }

        /// <summary>
        /// Deletes the buses 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Click(object sender, EventArgs e)
        {
            int x = int.Parse(autoKM.Text);
            RemoveBuses(newList, x);
            //The data is entered into a results file
            using (var fr = new StreamWriter(File.Open(RZ, FileMode.Append)))
            {
                fr.WriteLine("Ivesti autobusu/mikroautobusu nuvaziuoti kilometrai:" +
                    " {0} (tukst.).", x);
            }
            Print(RZ, newList, "Pasalinti autobusai/mokroautobusai:");
            data.Text = File.ReadAllText(RZ);
            delete.Enabled = false;
        }

        /// <summary>
        /// Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
