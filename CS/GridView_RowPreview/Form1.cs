// Developer Express Code Central Example:
// How to create a GridView descendant, which will allow using a specific repository item for displaying and editing data in a row preview section
// 
// This example shows how to create a GridView
// (ms-help://MS.VSCC.v90/MS.VSIPCC.v90/DevExpress.NETv9.2/DevExpress.XtraGrid/clsDevExpressXtraGridViewsGridGridViewtopic.htm)
// descendant, which will allow using a specific repository item for displaying and
// editing data in a row preview section.
// 
// 
// See Also:
// <kblink id = "K18341"/>
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2002

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GridView_RowPreview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Users myUsers = new Users();
        private void Form1_Load(object sender, EventArgs e)
        {
            myUsers.Add(new User("Antuan", "Acapulco", 23));
            myUsers[0].About = "Acapulco (Officially known as Acapulco de Juárez) is a city, and major sea port in the state of Guerrero on the Pacific coast of Mexico, 300 kilometres (190 mi) southwest from Mexico City";
            myUsers.Add(new User("Bill", "Brussels", 17));
            myUsers[1].About = "Brussels is the de facto capital city of the European Union (EU) and the largest urban area in Belgium.[6][7] It comprises 19 municipalities, including the City of Brussels proper, which is the capital of Belgium, Flanders and the French Community of Belgium.";
            myUsers.Add(new User("Charli", "Chicago", 45));
            myUsers[2].About = "Chicago is the largest city in the U.S. state of Illinois, and with more than 2.8 million people, the 3rd largest city in the United States";
            myUsers.Add(new User("Denn", "Denver", 20));
            myUsers[3].About = "Denver";
            myUsers.Add(new User("Eva", "Ernakulam", 23));
            myUsers[4].About = "The name 'Ernakulam' is derived from the name of a very famous temple of Lord Shiva called the Ernakulathappan Temple";
            customGridControl1.DataSource = myUsers;
            gridColumn1.FieldName = "Name";
            gridColumn1.Caption = "Name";
            gridColumn2.FieldName = "City";
            gridColumn2.Caption = "City";
            gridColumn3.FieldName = "Age";
            gridColumn3.Caption = "Age";
            customGridView1.OptionsView.ShowPreview = true;
        }
    }
    public class User
    {
        string name, city, about;
        int age;
        public User(string name, string city, int age)
        {
            this.name = name;
            this.city = city;
            this.age = age;
            this.about = String.Empty;
        }
        public int Age { set { age = value; } get { return age; } }
        public string Name { set { name = value; } get { return name; } }
        public string City { set { city = value; } get { return city; } }
        public string About { get { return about; } set { if (About != value) about = value; } }
    }
    public class Users : ArrayList
    {
        public new virtual User this[int index] { get { return (User)base[index]; } set { base[index] = value; } }
    }
}