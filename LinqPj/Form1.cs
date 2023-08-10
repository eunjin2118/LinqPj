using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqPj
{
    public partial class Form1 : Form
    {
        static private List<Music> musics = new List<Music>()
        {
            new Music() { Title = "다시 걸을 때", Artist = "TOIL", Date = "0130", Type = "Feat"},
            new Music() { Title = "정이라고 하자", Artist = "BIG Naughty", Date = "0420", Type = "Single"},
            new Music() { Title = "Level", Artist = "J Word", Date = "0304", Type = "Feat"},
            new Music() { Title = "Lovey Dovey", Artist = "BIG Naughty", Date = "0609", Type = "EP"},
            new Music() { Title = "이건내가처음쓰는사랑노래", Artist = "키조", Date = "0705", Type = "Feat"},
            new Music() { Title = "길", Artist = "기리보이", Date = "0225", Type = "Feat"},
            new Music() { Title = "이브닝", Artist = "유주", Date = "0728", Type = "Feat"},
            new Music() { Title = "낭만교향곡", Artist = "BIG Naughty", Date = "0609", Type = "EP"},
            new Music() { Title = "Vancouver", Artist = "BIG Naughty", Date = "0609", Type = "EP"},
            new Music() { Title = "Actor", Artist = "TOIL", Date = "0130", Type = "Feat"},
            new Music() { Title = "단거", Artist = "고막소년단", Date = "1122", Type = "Pj"},
            new Music() { Title = "연애의 발명", Artist = "BIG Naughty", Date = "0819", Type = "OST"},
            new Music() { Title = "Drivin'", Artist = "김승민", Date = "0730", Type = "Feat"},
            new Music() { Title = "Night Dancer", Artist = "imase", Date = "0515", Type = "Remix"},
            new Music() { Title = "뻔한 발라드", Artist = "BIG Naughty", Date = "0228", Type = "EP"},
            new Music() { Title = "친구로 지내다 보면", Artist = "BIG Naughty", Date = "0129", Type = "Single"},
            new Music() { Title = "딱 10cm만", Artist = "BIG Naughty x 10cm", Date = "0925", Type = "Single"},
            new Music() { Title = "여름 밤에 쓴 노래", Artist = "릴러말즈", Date = "0831", Type = "Prod"},
            new Music() { Title = "부라보", Artist = "BIG Naughty", Date = "0225", Type = "EP"},
            new Music() { Title = "Peace Out(MEGA MIX)", Artist = "블라세", Date = "0120", Type = "Feat"},

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = musics;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
