using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FelicaLib;
using System.Windows.Forms;

namespace getidm
{
    class GetIDm
    {
        string id;

        /*IDm取得メソッド*/
        public string getID()
        {
            try
            {
                using (Felica felica = new Felica())
                {
                    felica.Polling(0xFFFF);
                    byte[] data = felica.IDm();
                    id = "";
                    for (int i = 0; i < data.Length; i++)
                    {
                        id += data[i].ToString("X2");
                    }

                }
            }
            catch(Exception)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return id;
        }
    }
}
