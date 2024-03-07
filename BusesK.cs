using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace U1_10
{
    class BusesK
    {
        int cn = 2;
        private Buses[] buses;
        public int count { get; set; }

        public BusesK()
        {
            count = 0;
            buses = new Buses[cn];
        }

        /// <summary>
        /// Increases the capacity of the array if necessary
        /// </summary>
        /// <param name="secondCount">New count</param>
        public void IncreaseSize(int secondCount)
        {
            if(secondCount > cn)
            {
                Buses[] temporary = new Buses[secondCount];
                for(int i = 0; i < count; i++)
                {
                    temporary[i] = buses[i]; 
                }
                buses = temporary;
                cn = secondCount;
            }
        }

        /// <summary>
        /// Adds a new bus to the array of objects
        /// </summary>
        /// <param name="b">Bus</param>
        public void AddMore(Buses b)
        {
            if(cn == count)
            {
                IncreaseSize(cn * 2);
            }
            buses[count++] = b;
        }
        
        /// <summary>
        /// Returns a bus object at the specified index
        /// </summary>
        /// <param name="i">Index</param>
        /// <returns> returns a bus object </returns>
        public Buses TakeBuses(int i) { return buses[i]; }

        /// <summary>
        /// Takes count of the data
        /// </summary>
        /// <returns>Count</returns>
        public int Take() { return count; }

        /// <summary>
        /// Sorting the list with the Comparison operator >
        /// </summary>
        public void Bubble()
        {
            int i = 0;
            bool bk = true;
            while (bk)
            {
                bk = false;
                for(int j = count - 1; j > i; j--)
                {
                    if(buses[j] > buses[j - 1])
                    {
                        bk = true;
                        Buses bs = buses[j];
                        buses[j] = buses[j - 1];
                        buses[j - 1] = bs;
                    }
                }
                i++;
            }
        }

        /// <summary>
        /// Removing the data with index
        /// </summary>
        /// <param name="index">Index</param>
        public void Remove(int index)
        {
            if(-1 < index && index < count)
            {
                for(int i = index; i < count - 1; i++)
                {
                    buses[i] = buses[i + 1];
                }
                count--;
            }
        }
    }
}
