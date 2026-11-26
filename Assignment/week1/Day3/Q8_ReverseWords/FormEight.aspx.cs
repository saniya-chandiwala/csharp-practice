using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FormEight : System.Web.UI.Page
{
    string sentence;
    string[] words;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnReverse_Click(object sender, EventArgs e)
    {
        sentence = txtSentence.Text;

        if (string.IsNullOrEmpty(sentence)) {
            lbReverse.Text = "Enter a Valid Sentence";
        }
        else {
            string[] words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--) {

                lbReverse.Text += words[i] + " ";

            }
        }

    }
}