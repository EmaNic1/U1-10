using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U1_10
{
    class Buses
    {
        /// <summary>
        /// Enumerator: Autobusas, Mikroautobusas
        /// </summary>
        public enum BusType
        {
            Autobusas = 1,
            Mikroautobusas = 2
        }

        public string nameSurname { get; set; } // Driver's name and surname
        public int workExperience { get; set; } // Driver's work experience
        public BusType auto { get; set; } //Bus type
        public int manufacture { get; set; } //Bus year of manufacture
        public int spaceNumber { get; set; } //Bus space number
        public int kmDriven { get; set; } //Kilometres driven by the bus

        public Buses()
        {
            nameSurname = "";
            workExperience = 0;
            auto = BusType.Autobusas;
            manufacture = 0;
            spaceNumber = 0;
            kmDriven = 0;
        }

        public Buses(string nameSurname, int workExperience, BusType auto, 
            int manufacture, int spaceNumber, int kmDriven)
        {
            this.nameSurname = nameSurname;
            this.workExperience = workExperience;
            this.auto = auto;
            this.manufacture = manufacture;
            this.spaceNumber = spaceNumber;
            this.kmDriven = kmDriven;
        }

        /// <summary>
        /// Data line
        /// </summary>
        /// <returns>Data line</returns>
        public override string ToString()
        {
            string line;
            line = string.Format("|{0,-30}|{1,14:d}|{2,-26}|{3,18:d}|{4,16:d}|{5,30:d}|", 
                nameSurname, workExperience, auto, manufacture,spaceNumber, kmDriven);
            return line;
        }

        /// <summary>
        /// Comparison operator >
        /// </summary>
        /// <param name="b1">Class</param>
        /// <param name="b2">Class</param>
        /// <returns>True, or False</returns>
        public static bool operator >(Buses b1, Buses b2)
        {
           if(b1.workExperience > b2.workExperience)
                return true;
           return false;
        }

        /// <summary>
        /// Comparison operator <
        /// </summary>
        /// <param name="b1">Class</param>
        /// <param name="b2">Class</param>
        /// <returns>True, or False</returns>
        public static bool operator <(Buses b1, Buses b2)
        {
            if (b1.workExperience < b2.workExperience)
                return true;
            return false;
        }
    }
}
