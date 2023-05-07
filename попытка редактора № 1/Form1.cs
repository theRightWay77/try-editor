using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace попытка_редактора___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearInput();
        }

        private void ClearInput()
        {
            TheWord.Text = string.Empty;
            Translation.Text = string.Empty;
            Example.Text = string.Empty;
            
        }

        private void SerializeXML(Words words)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Words));

            using (FileStream fs = new FileStream("Words.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, words);
            }
        }


        private Words DeserializeXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(Words));

            using (FileStream fs = new FileStream("Words.xml", FileMode.OpenOrCreate))
            {
                return (Words)xml.Deserialize(fs);
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            ClearInput();

            Words words = DeserializeXML();

            foreach (Word word in words.WordsList)
            {
                Addd(word); 
            }
        }

        private void Addd(Word word)
        {
            ListViewItem listWords = new ListViewItem(word.TheWord);
            listWords.Tag = word;

            listViewWords.Items.Add(listWords);
        }
        private void Serialize_Click(object sender, EventArgs e)
        {                  
                Words words = new Words();

                foreach (ListViewItem item in listViewWords.Items)
                {
                    if (item.Tag != null)
                    {
                        words.WordsList.Add((Word)item.Tag);
                    }
                }
                SerializeXML(words);          
        }



        private void Add_Click(object sender, EventArgs e)
        {
            Word word = new Word(TheWord.Text, Translation.Text, Example.Text);

            Addd(word);

            ClearInput();
        }

       

        private void listViewWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewWords.SelectedItems.Count == 1)
            {
                Word word = (Word)listViewWords.SelectedItems[0].Tag;

                if (TheWord != null)
                {
                    TheWord.Text = word.TheWord;
                    // TheWord.Text = "hello";
                    Translation.Text = word.Translation;
                    Example.Text = word.Example;
                }
            }
            else if (listViewWords.SelectedItems.Count == 0)
            {
                ClearInput();
            }
        }
    }
}
