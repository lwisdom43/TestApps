using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace TestSerializingObjectIntoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Defaults();
        }

        private void Defaults()
        {
            txtName.Text = "Lee Wisdom";
            txtAddr1.Text = "1505 Beech St";
            txtAddr2.Text = "";
            txtCity.Text = "Valparaiso";
            txtState.Text = "IN";
            txtZip.Text = "46383";
            txtPhone.Text = "2195085208";
            txtEmail.Text = "lwisdom43@gmail.com";
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            AddressEntry ae = new AddressEntry();

            ae.Name = txtName.Text;
            ae.Address1 = txtAddr1.Text;
            ae.Address2 = txtAddr2.Text;
            ae.City = txtCity.Text;
            ae.State = txtState.Text;
            ae.Zip = txtZip.Text;
            ae.Phone = txtPhone.Text;
            ae.Email = txtEmail.Text;

            SerializeXMLObject(ae);
        }

        private void SerializeXMLObject(AddressEntry ae)
        {
            XmlSerializer x = new XmlSerializer(ae.GetType());

            using (StringWriter strw = new StringWriter())
            {
                x.Serialize(strw, ae);
                txtXML.Text = strw.ToString();
            }            
        }
    }
}
