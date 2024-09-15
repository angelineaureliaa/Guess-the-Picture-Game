using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_tebak_kata_Aurel_Cennia
{
    public partial class FormPlay : Form
    {
        // array pertanyaan, huruf depan, huruf belakang, hint, jawaban 
         string[] question_easy = { "Jauh di mata, tapi dekat di hati, apakah itu?", "Gajah naik motor kelihatan apanya?", "Kita tidak bisa menelepon, kalau handphone-nya nggak ada?", "Salah apa yang tidak bisa dipidanakan", "Lemari apa yang bisa dimasukkan kantong?" };
         string[] question_med = { "Kalo haus minum?", "Seorang barber mencukur rambut pelanggan dengan?", "Matahari tenggelam di sebelah", "Burung adalah hewan yang bisa?", "Binatang hinggap di makanan" };
         string[] question_hard = { "Jeruk, alpukat, dan apel disebut", "Ikan bernapas di air dengan", "Senikmat-nikmatnya makan di luar lebih nikmat makan di?", "Semut kecil, kalo gajah?", "Motor yang selalu salah" };

         string[] depan_easy = { "U", "B", "A", "S", "L" };
         string[] depan_med = { "A", "G", "G", "T", "L" };
         string[] depan_hard = { "", "", "", "", "" };

         string[] belakang_easy = { "S", "A", "A", "T", "N" };
         string[] belakang_med = { "", "", "", "", "", "" };
         string[] belakang_hard = { "", "", "", "", "" };

         string[] hint_easy = { "Jawaban terdiri atas 4 huruf", "Jawaban terdiri atas 8 huruf", "Jawaban terdiri atas 5 huruf", "Jawaban terdiri atas 9 huruf", "Jawaban terdiri atas 10 huruf" };
         string[] hint_med = { "Jawaban terdiri atas 3 huruf", "Jawaban terdiri atas 7 huruf", "Jawaban terdiri atas 5 huruf", "Jawaban terdiri atas 7 huruf", "Jawaban terdiri atas 5 huruf" };
         string[] hint_hard = { "Jawaban terdiri atas 4 huruf", "Jawaban terdiri atas 6 huruf", "Jawaban terdiri atas 5 huruf", "Jawaban terdiri atas 5 huruf", "Jawaban terdiri atas 6 huruf" };

         string[] jawaban_easy = { "SU", "OHONGNY", "NGK", "ALAH URA", "EMARIBUA" };
         string[] jawaban_med = { "JA", "ANTIAN", "AWAT", "EMENAN", "APAR" };
         string[] jawaban_hard = { "BISA", "TENANG", "TELAN", "HEWAN", "YAMAAP" };

        public string mode = ""; // menentukan mode / level game

        bool[] status = new bool[100]; // agar tidak double soal yang keluar, statusnya true/false, 100 tergantung banyak soal (maksimal kemungkinan)
        int questionCount = 0; // jumlah pertanyaan dalam array tiap mode
        int questionShowNumber = 0; // index / nomor soal yang keluar sekarang
        int totalShow = 0; // jumlah soal yang keluar per mode saat di run
        int nextCount = 0; // next berapa kali
        int coin = 100; // coin pertama kali main

        Random rnd = new Random();
        public FormPlay()
        {
            InitializeComponent();
        }

        private void generate_question_status()
        {
            if (mode == "easy")
            {
                questionCount = question_easy.Length;
                totalShow = 3;
            }
            else if (mode == "medium")
            {
                questionCount = question_med.Length;
                totalShow = 3;
            }
            else
            {
                questionCount = question_hard.Length;
                totalShow = 3;
            }
            for (int i = 0; i < questionCount; i++)
            {
                status[i] = false; // semua soal status awalnya false = belum pernah keluar
            }
            
        }
        private void generate_next_question()
        {
            bool found = false;
            while (found == false) 
            {
                questionShowNumber = rnd.Next(questionCount);
                if (status[questionShowNumber] == false)
                {
                    found = true;
                    status[questionShowNumber] = true; // soal yang sekarang keluar, dari yang awalnya false akan berubah jadi true (sudah keluar) jadi tidak akan keluar lagi
                }
            }

            if (mode == "easy") 
            {
                lblQuestion.Text = question_easy[questionShowNumber];
                lblDepan.Text = depan_easy[questionShowNumber];
                lblBelakang.Text = belakang_easy[questionShowNumber];
            }
            else if (mode == "medium")
            {
                lblQuestion.Text = question_med[questionShowNumber];
                lblDepan.Text = depan_med[questionShowNumber];
                lblBelakang.Text = belakang_med[questionShowNumber];
            }
            else
            {
                lblQuestion.Text = question_hard[questionShowNumber];
                lblDepan.Text = depan_hard[questionShowNumber];
                lblBelakang.Text = belakang_hard[questionShowNumber];
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            string playerAnswer = txtAnswerr.Text.ToUpper();
            string keyAnswer = "";
            if (mode == "easy")
            {
                keyAnswer = jawaban_easy[questionShowNumber].ToUpper();
            }
            else if (mode == "medium")
            {
                keyAnswer = jawaban_med[questionShowNumber].ToUpper();
            }
            else
            {
                keyAnswer = jawaban_hard[questionShowNumber].ToUpper();
            }
             
            if (playerAnswer == keyAnswer)
            {
                lblCheckAnswer.Text = "Jawaban Anda BENAR!";
                coin += 20;
                lblCoin.Text = coin.ToString();
                btnHint.Visible = false;
            }
            else if (playerAnswer.Length == keyAnswer.Length)
            {
                for (int i = 0; i < playerAnswer.Length; i++)
                {
                    char a = playerAnswer[i];
                    char b = keyAnswer[i];
                    if (a != b)
                    {
                        lblCheckAnswer.Text = a.ToString(); // nampung huruf yang beda
                    }
                }
                int difference = lblCheckAnswer.Text.Length; // banyak huruf yang beda
                if (difference <= 2)
                {
                    lblCheckAnswer.Text = "Jawaban Anda HAMPIR BENAR!";
                }
                else
                {
                    lblCheckAnswer.Text = "Jawaban Anda SALAH!";
                }
            }
            else
            {
                lblCheckAnswer.Text = "Jawaban Anda SALAH!";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            generate_next_question();
            nextCount++;
            btnHint.Visible = true;
            lblHint.Text = "";
            lblCheckAnswer.Text = "";
            txtAnswerr.Text = "";
            if (nextCount == totalShow) // arti: jumlah soal yang diinginkan untuk keluar sudah terpenuhi
            {
                MessageBox.Show("Your Coin is " + coin);
                Close();
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            btnHint.Visible = false;
            if (mode=="easy")
            {
                lblHint.Text = hint_easy[questionShowNumber];
            }
            else if (mode=="medium")
            {
                lblHint.Text = hint_med[questionShowNumber];
            }
            else if (mode=="hard")
            {
                lblHint.Text = hint_hard[questionShowNumber];
            }
            
            coin -= 50;
            lblCoin.Text = coin.ToString();
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            generate_question_status();
            generate_next_question();
        }
    }
}
