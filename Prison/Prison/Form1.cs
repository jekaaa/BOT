using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prison
{
    public partial class Form1 : Form
    {
        Authentification auth;
        GameMethods game;

        public Form1()
        {
            InitializeComponent();
        }

        static private List<Boss> Bosses()
        {
            List<Boss> list = new List<Boss>();
            list.Add(new Boss("Кирпич", 1000, 1));
            list.Add(new Boss("Сизый", 10000, 2));
            list.Add(new Boss("Махно", 50000, 3));
            list.Add(new Boss("Лютый", 100000, 4));
            list.Add(new Boss("Шайба", 500000, 5));
            list.Add(new Boss("Палыч", 100000, 6));
            list.Add(new Boss("Бурят", 2000000, 14));
            list.Add(new Boss("Дядя Миша", 3000000, 16));
            list.Add(new Boss("Бандяк", 5000000, 27));
            list.Add(new Boss("Гризли", 10000000, 34));
            list.Add(new Boss("Воркута", 10000000, 30));
            list.Add(new Boss("Феня", 15000000, 37));
            list.Add(new Boss("Север", 20000000, 32));
            list.Add(new Boss("Мазай", 25000000, 40));
            list.Add(new Boss("Хирург", 30000000, 11));
            list.Add(new Boss("Немой", 100000000, 48));
            list.Add(new Boss("Бидон", 300000000, 53));
            list.Add(new Boss("Старшой", 400000000, 52));
            return list;
        }

        List<Boss> listBosses = Bosses();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            auth = new Authentification("68c6a31b752a5d36189561856c4ed4c3", "121905459");
            game = new GameMethods(auth);
           
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            var bricks = listBosses.Where(x => x.id == "1");
            foreach (Boss brick in bricks)
            {
                listBox1.Items.Add(brick.name + ": " + game.startBattle(brick.id, "0", "simple", "0", "0"));

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var bluishs = listBosses.Where(x => x.id == "2");
            foreach (Boss bluish in bluishs)
            {
                listBox1.Items.Add(bluish.name + ": " + game.startBattle(bluish.id, "4", "simple", "0", "0"));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var machnos = listBosses.Where(x => x.id == "3");
            foreach (Boss machno in machnos)
            {
                listBox1.Items.Add(machno.name + ": " + game.startBattle(machno.id, "7", "simple", "0", "0"));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pals = listBosses.Where(x => x.id == "6");
            foreach (Boss pal in pals)
            {
                listBox1.Items.Add(pal.name + ": " + game.startBattle(pal.id, "22", "simple", "0", "0"));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var vorkuts = listBosses.Where(x => x.id == "30");
            foreach (Boss vorkuta in vorkuts)
            {
                listBox1.Items.Add(vorkuta.name + ": " + game.startBattle(vorkuta.id, "0", "simple", "0", "0"));
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(game.getBoss());
        }
    }
}
