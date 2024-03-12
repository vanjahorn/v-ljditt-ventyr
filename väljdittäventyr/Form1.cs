using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace väljdittäventyr
{
    public partial class Form1 : Form
    {
        string sceneA = "Du är ute och går i skogen, du kommer fram till en dörr som står mitt på en stig. Du funderar på om du ska kolla vad som finns bakom dörren eller om du bara ska gå vidare. Vill du gå in genom dörren?";
        string sceneB = "Du kliver in genom dörren och smyger försiktigt in, det är alldelles kolsvart och det är svårt att se vad som finns i rummet du befinner dig i. Ska du fortsätta in i det mörka rummet?";
        string sceneC = "Eftersom du valde att inte gå in genom dörren så fortsätter du din lugna promenad i skogen. Efter en stund så inser du att du inte vet hur länge du har gått och när du sedan vänder tillbaka så vandrar du runt i vad som känns som timmar utan att hitta tillbaka igen. När du fortsätter en bit till så har det börjat blivit mörkt ute...";
        public Form1()
       {
            InitializeComponent();
            textBox1.Text = sceneA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == sceneA)
            {
                textBox1.Text = sceneB;

            }
        }
    }

    }

