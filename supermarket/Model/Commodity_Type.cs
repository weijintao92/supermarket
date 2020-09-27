using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermarket.Model
{
    public class Commodity_Type
    {
        public string Id { set; get; }
        public string Type { set; get; }

        private string state;
        public string State
        {

            get { return state; }

            set

            {

                state = String.IsNullOrEmpty(value) ? "启用" : value;

            }

        }
    }
}
