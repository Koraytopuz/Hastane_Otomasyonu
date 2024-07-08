using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan =new SqlConnection("Data Source=KRYTOPUZ\\SQL1;Initial Catalog=Proje_Hastane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
