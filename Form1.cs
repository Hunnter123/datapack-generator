using System;
using System.IO;
using System.Windows.Forms;

namespace datapack_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                string dir = folder.SelectedPath;
                string name = textBox1.Text;

                string tickContent = textBox2.Text;
                string loadContent = textBox3.Text;
                
                GeneratePack(dir, name, tickContent, loadContent);

                MessageBox.Show("Datapack generated");
                this.Close();
            }
        }

        private void GeneratePack(string dir, string name, string tickContent, string loadContent)
        {
            Directory.CreateDirectory($"{dir}/{name}");

            using (StreamWriter meta = new StreamWriter($"{dir}/{name}/pack.mcmeta"))
            {
                meta.Write(@"{
    ""pack"": {
        ""pack_format"": 57,
        ""description"": ""description""
    }
}");
            }

            Directory.CreateDirectory($"{dir}/{name}/data");
            Directory.CreateDirectory($"{dir}/{name}/data/pack");
            Directory.CreateDirectory($"{dir}/{name}/data/pack/function");
            Directory.CreateDirectory($"{dir}/{name}/data/minecraft");
            Directory.CreateDirectory($"{dir}/{name}/data/minecraft/tags");
            Directory.CreateDirectory($"{dir}/{name}/data/minecraft/tags/function");

            if (enchantments.Checked)
            {
                Directory.CreateDirectory($"{dir}/{name}/data/pack/enchantment");
            }

            if (dementions.Checked)
            {
                Directory.CreateDirectory($"{dir}/{name}/data/pack/dimension");
            }

            if (recipes.Checked)
            {
                Directory.CreateDirectory($"{dir}/{name}/data/pack/recipe");
            }

            using (StreamWriter tickFunc = new StreamWriter($"{dir}/{name}/data/pack/function/tick.mcfunction"))
            {
                tickFunc.Write(tickContent);
            }

            using (StreamWriter loadFunc = new StreamWriter($"{dir}/{name}/data/pack/function/load.mcfunction"))
            {
                loadFunc.Write(loadContent);
            }

            using (StreamWriter tickJson = new StreamWriter($"{dir}/{name}/data/minecraft/tags/function/tick.json"))
            {
                tickJson.Write(@"{
    ""values"": [
        ""pack:tick""
    ]
}");
            }

            using (StreamWriter loadJson = new StreamWriter($"{dir}/{name}/data/minecraft/tags/function/load.json"))
            {
                loadJson.Write(@"{
    ""values"": [
        ""pack:load""
    ]
}");
            }
        }
    }
}