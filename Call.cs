using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_8
{
    class Call
    {
        private string outgoing_abonent;

        public string Outgoing_abonent
        {
            get
            {
                return outgoing_abonent;
            }

            set
            {
                outgoing_abonent = value; 
            }
        }

        private string incoming_abonent;

        public string Incoming_abonent
        {
            get
            {
                return incoming_abonent;
            }

            set
            {
                incoming_abonent = value;
            }
        }

        private int duration_min;

        public int Duration_min
        {
            get
            {
                return duration_min;
            }

            set
            {
                duration_min = value;
            }
        }

        private int duration_sek;

        public int Duration_sek
        {
            get
            {
                return duration_sek;
            }

            set
            {
                duration_sek = value;
            }
        }
        public Call(string outgoing_abonent, string incoming_abonent, int duration_min, int duration_sek)
        {
            this.outgoing_abonent = outgoing_abonent;
            this.incoming_abonent = incoming_abonent;
            this.duration_min = duration_min;
            this.duration_sek = duration_sek;
        }
        public int cost(int price)
        {
            Duration_min = Duration_min * 60;
            Duration_sek = Duration_sek + Duration_min;
            return Duration_sek / 12 * price;
        }
    }
}
