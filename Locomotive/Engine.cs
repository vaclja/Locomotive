using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    internal class Engine
    {
		private string engineName;

		public string EngineName
		{
			get { return engineName; }
			set { engineName = value;
                if (!value.Equals("diesel") && !value.Equals("parní") && !value.Equals("elektrická"))
                {
                    throw new ArgumentException("Neplatný typ motoru. Platné hodnoty jsou: diesel, parní, elektrický.");
                }
            }
		}


		public Engine(string engineName)
        {
            this.engineName = engineName;
        }

        public override string ToString()
        {
            return $"Typ motoru: {engineName}";
        }
    }
}
